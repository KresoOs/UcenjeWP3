using System.Text;

namespace UcenjeCS.E14VjezbanjeRadaSObjektima
{
    internal class Osoba
    {

        public string? Ime { get; set; }
        public string? Prezime { get; set; }
        public int Dob { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new();
            sb.Append(Ime);
            sb.Append(' ');
            sb.Append(Prezime);
            sb.Append(" (");
            sb.Append(Dob);
            return sb.Append(')').ToString();
        }
    }
}
