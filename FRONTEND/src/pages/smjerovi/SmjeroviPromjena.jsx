import { useEffect, useState } from "react";
import {  Container, Form } from "react-bootstrap";
import { useNavigate, useParams } from "react-router-dom";
import Service from "../../services/SmjerService";
import { RoutesNames } from "../../constants";
import InputText from "../../components/InputText";
import InputCheckbox from "../../components/InputCheckbox";
import Akcije from "../../components/Akcije";

export default function SmjeroviPromjeni(){

    const navigate = useNavigate();
    const routeParams = useParams();
    const [smjer,setSmjer] = useState({});

    async function dohvatiSmjer(){
        const odgovor = await Service.getBySifra('Smjer',routeParams.sifra)
        if(!odgovor.ok){
            alert(Service.dohvatiPorukeAlert(odgovor.podaci));
            navigate(RoutesNames.SMJER_PREGLED);
            return;
        }
        setSmjer(odgovor.podaci);
    }

    useEffect(()=>{
        dohvatiSmjer();
        // eslint-disable-next-line react-hooks/exhaustive-deps
    },[]);

    async function promjeniSmjer(smjer){
        const odgovor = await Service.promjeni('Smjer',routeParams.sifra,smjer);
        if(odgovor.ok){
          navigate(RoutesNames.SMJER_PREGLED);
          return;
        }
        alert(Service.dohvatiPorukeAlert(odgovor.podaci));
    }

    
    function handleSubmit(e){
        e.preventDefault();
        const podaci = new FormData(e.target);
        promjeniSmjer({
            naziv: podaci.get('naziv'),
            trajanje: parseInt(podaci.get('trajanje')),
            cijena: parseFloat(podaci.get('cijena')),
            verificiran: podaci.get('verificiran')=='on' ? true: false
        });
    }



    return (
        <Container>
           <Form onSubmit={handleSubmit}>
                    <InputText atribut='naziv' vrijednost={smjer.naziv} />
                    <InputText atribut='trajanje' vrijednost={smjer.trajanje} />
                    <InputText atribut='cijena' vrijednost={smjer.cijena} />
                    <InputCheckbox atribut='verificiran' vrijednost={smjer.verificiran} />
                    <Akcije odustani={RoutesNames.SMJER_PREGLED} akcija='Promjeni smjer' />
             </Form>
             </Container>
    );

}