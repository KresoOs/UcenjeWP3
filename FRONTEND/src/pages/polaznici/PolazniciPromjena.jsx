import { useEffect, useState } from 'react';
import { Container, Form } from 'react-bootstrap';
import { useNavigate, useParams } from 'react-router-dom';
import Service from '../../services/PolaznikService';
import { RoutesNames } from '../../constants';
import InputText from '../../components/InputText';
import Akcije from '../../components/Akcije';

export default function PolazniciPromjeni() {
  const [polaznik, setPolaznik] = useState({});

  const routeParams = useParams();
  const navigate = useNavigate();


  async function dohvatiPolaznik() {
    const odgovor = await Service.getBySifra('Polaznik',routeParams.sifra);
    if(!odgovor.ok){
      alert(Service.dohvatiPorukeAlert(odgovor.podaci));
      return;
    }
    setPolaznik(odgovor.podaci);
  }

  useEffect(() => {
    dohvatiPolaznik();
  // eslint-disable-next-line react-hooks/exhaustive-deps
  }, []);

  async function promjeniPolaznik(polaznik) {
    const odgovor = await Service.promjeni('Polaznik',routeParams.sifra, polaznik);
    if(odgovor.ok){
      navigate(RoutesNames.POLAZNIK_PREGLED);
      return;
    }
    alert(dohvatiPorukeAlert(odgovor.podaci));
  }

  function handleSubmit(e) {
    e.preventDefault();

    const podaci = new FormData(e.target);
    promjeniPolaznik({
      ime: podaci.get('ime'),
      prezime: podaci.get('prezime'),
      oib: podaci.get('oib'),
      email: podaci.get('email'),
      brojugovora: podaci.get('brojugovora')
    });
  }


  return (
    <Container className='mt-4'>
          <Form onSubmit={handleSubmit}>
            <InputText atribut='ime' vrijednost={polaznik.ime} />
            <InputText atribut='prezime' vrijednost={polaznik.prezime} />
            <InputText atribut='oib' vrijednost={polaznik.oib} />
            <InputText atribut='email' vrijednost={polaznik.email} />
            <InputText atribut='brojugovora' vrijednost={polaznik.brojugovora} />
            <Akcije odustani={RoutesNames.POLAZNIK_PREGLED} akcija='Promjeni polaznika' /> 
          </Form>
    </Container>
  );
}
