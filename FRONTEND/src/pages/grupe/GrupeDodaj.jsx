import { Container, Form} from 'react-bootstrap';
import { useNavigate } from 'react-router-dom';
import { useEffect, useState } from 'react';
import Service from '../../services/GrupaService';
import { RoutesNames } from '../../constants';
import InputText from '../../components/InputText';
import Akcije from '../../components/Akcije';
import moment from 'moment';



export default function GrupeDodaj() {
  const navigate = useNavigate();

  const [smjerovi, setSmjerovi] = useState([]);
  const [smjerSifra, setSmjerSifra] = useState(0);

  const [predavaci, setPredavaci] = useState([]);
  const [predavacSifra, setPredavacSifra] = useState(0);

  async function dohvatiSmjerove(){
    
    const odgovor = await Service.get('Smjer');
    if(!odgovor.ok){
      alert(Service.dohvatiPorukeAlert(odgovor.podaci));
      return;
    }
    setSmjerovi(odgovor.podaci);
    setSmjerSifra(odgovor.podaci[0].sifra);
  }

  async function dohvatiPredavaci(){
    const odgovor = await Service.get('Predavac');
    if(!odgovor.ok){
      alert(Service.dohvatiPorukeAlert(odgovor.podaci));
        return;
    }
    setPredavaci(odgovor.podaci);
    setPredavacSifra(odgovor.podaci[0].sifra);
  }

  async function ucitaj(){
    await dohvatiSmjerove();
    await dohvatiPredavaci();
  }

  useEffect(()=>{
    ucitaj();
    // eslint-disable-next-line react-hooks/exhaustive-deps
  },[]);

  async function dodaj(e) {
    const odgovor = await Service.dodaj('Grupa',e);
    if(odgovor.ok){
      navigate(RoutesNames.GRUPA_PREGLED);
      return
    }
    alert(Service.dohvatiPorukeAlert(odgovor.podaci));
  }

  function handleSubmit(e) {
    e.preventDefault();

    const podaci = new FormData(e.target);

    if(podaci.get('datum')=='' && podaci.get('vrijeme')!=''){
      alert('Ako postavljate vrijeme morate i datum');
      return;
    }
    let datumpocetka=null;
    if(podaci.get('datum')!=''){
      if (podaci.get('vrijeme')!=''){
        datumpocetka = moment.utc(podaci.get('datum') + ' ' + podaci.get('vrijeme'));
      }else{
        datumpocetka = moment.utc(podaci.get('datum'));
      }
      
    }

    dodaj({
      naziv: podaci.get('naziv'),
      datumpocetka: datumpocetka,
      smjerSifra: parseInt(smjerSifra),
      predavacSifra: parseInt(predavacSifra),
      maksimalnopolaznika: parseInt(podaci.get('maksimalnopolaznika'))
    });
  }

  return (
    <Container className='mt-4'>
      <Form onSubmit={handleSubmit}>

        <InputText atribut='naziv' vrijednost='' />

        <Form.Group className='mb-3' controlId='datum'>
          <Form.Label>Datum</Form.Label>
          <Form.Control
            type='date'
            name='datum'
          />
        </Form.Group>

        <Form.Group className='mb-3' controlId='vrijeme'>
          <Form.Label>Vrijeme</Form.Label>
          <Form.Control
            type='time'
            name='vrijeme'
          />
        </Form.Group>

        <Form.Group className='mb-3' controlId='smjer'>
          <Form.Label>Smjer</Form.Label>
          <Form.Select multiple={true}
          onChange={(e)=>{setSmjerSifra(e.target.value)}}
          >
          {smjerovi && smjerovi.map((s,index)=>(
            <option key={index} value={s.sifra}>
              {s.naziv}
            </option>
          ))}
          </Form.Select>
        </Form.Group>

        <Form.Group className='mb-3' controlId='predavac'>
          <Form.Label>Predavač</Form.Label>
          <Form.Select
          onChange={(e)=>{setPredavacSifra(e.target.value)}}
          >
          {predavaci && predavaci.map((e,index)=>(
            <option key={index} value={e.sifra}>
              {e.ime} {e.prezime}
            </option>
          ))}
          </Form.Select>
        </Form.Group>

        <InputText atribut='maksimalnopolaznika' vrijednost='' />
        <Akcije odustani={RoutesNames.GRUPA_PREGLED} akcija='Dodaj grupu' /> 
      </Form>
    </Container>
  );
}
