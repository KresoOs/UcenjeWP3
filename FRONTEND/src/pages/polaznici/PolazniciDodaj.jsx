import { Container, Form } from 'react-bootstrap';
import { useNavigate } from 'react-router-dom';
import Service from '../../services/PolaznikService';
import { RoutesNames } from '../../constants';
import InputText from '../../components/InputText';
import Akcije from '../../components/Akcije';


export default function PolazniciDodaj() {
  const navigate = useNavigate();


  async function dodajPolaznik(Polaznik) {
    const odgovor = await Service.dodaj('Polaznik',Polaznik);
    if(odgovor.ok){
      navigate(RoutesNames.POLAZNIK_PREGLED);
      return
    }
    alert(Service.dohvatiPorukeAlert(odgovor.podaci));
  }

  function handleSubmit(e) {
    e.preventDefault();
    const podaci = new FormData(e.target);
    dodajPolaznik({
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
        <InputText atribut='ime' vrijednost='' />
        <InputText atribut='prezime' vrijednost='' />
        <InputText atribut='oib' vrijednost='' />
        <InputText atribut='email' vrijednost='' />
        <InputText atribut='brojugovora' vrijednost='' />
        <Akcije odustani={RoutesNames.POLAZNIK_PREGLED} akcija='Dodaj polaznika' />  
      </Form>
    </Container>
  );
}
