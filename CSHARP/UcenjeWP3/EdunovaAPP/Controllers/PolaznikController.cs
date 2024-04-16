using EdunovaAPP.Data;
using EdunovaAPP.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Text;

namespace EdunovaAPP.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class PolaznikController : EdunovaController<Polaznik, PolaznikDTORead, PolaznikDTOInsertUpdate>
    {
        public PolaznikController(EdunovaContext context) : base(context)
        {
            DbSet = _context.Polaznici;
        }

        [HttpGet]
        [Route("trazi/{uvjet}")]
        public IActionResult TraziPolaznik(string uvjet)
        {
            if (uvjet == null || uvjet.Length < 3)
            {
                return BadRequest(ModelState);
            }
            uvjet = uvjet.ToLower();
            try
            {
                IEnumerable<Polaznik> query = _context.Polaznici;
                var niz = uvjet.Split(" ");
                foreach (var s in uvjet.Split(" "))
                {
                    query = query.Where(p => p.Ime.ToLower().Contains(s) || p.Prezime.ToLower().Contains(s));
                }
                var polaznici = query.ToList();
                return new JsonResult(_mapper.MapReadList(polaznici));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        protected override void KontrolaBrisanje(Polaznik entitet)
        {
            var entitetIzbaze = _context.Polaznici
                .Include(x => x.Grupe)
                .FirstOrDefault(x => x.Sifra == entitet.Sifra);

            if (entitetIzbaze == null)
            {
                throw new Exception("Ne postoji polaznik s šifrom " + entitet.Sifra + " u bazi");
            }
            if (entitetIzbaze.Grupe != null && entitetIzbaze.Grupe.Count > 0)
            {
                StringBuilder sb = new();
                sb.Append("Polaznik se ne može obrisati jer je postavljen na grupama: ");
                foreach (var e in entitetIzbaze.Grupe)
                {
                    sb.Append(e.Naziv).Append(", ");
                }

                throw new Exception(sb.ToString()[..^2]);
            }
        }

    }
}
