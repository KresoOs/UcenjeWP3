import  {get,obrisi,dodaj,getBySifra,promjeni,dohvatiPorukeAlert, httpService, obradiUspjeh, obradiGresku } from "./HttpService";

async function traziPolaznik(naziv,uvjet) {
    return await httpService.get('/' + naziv +'/trazi/' + uvjet).then((res)=>{return obradiUspjeh(res);}).catch((e)=>{ return obradiGresku(e);});
  }

export default{
    get,
    obrisi,
    dodaj,
    promjeni,
    getBySifra,
    dohvatiPorukeAlert,

    traziPolaznik
};