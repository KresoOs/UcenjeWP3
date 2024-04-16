import { Container, Form } from "react-bootstrap";
import { useNavigate } from "react-router-dom";
import { RoutesNames } from "../../constants";
import Service from "../../services/SmjerService";
import InputText from "../../components/InputText";
import InputCheckbox from "../../components/InputCheckbox";
import Akcije from "../../components/Akcije";

export default function SmjeroviDodaj(){
    const navigate = useNavigate();

    async function dodajSmjer(smjer){
        const odgovor = await Service.dodaj('Smjer',smjer);
        if(odgovor.ok){
          navigate(RoutesNames.SMJER_PREGLED);
          return
        }
        alert(Service.dohvatiPorukeAlert(odgovor.podaci));
    }

    function handleSubmit(e){
        e.preventDefault();
        const podaci = new FormData(e.target);
        dodajSmjer({
            naziv: podaci.get('naziv'),
            trajanje: parseInt(podaci.get('trajanje')),
            cijena: parseFloat(podaci.get('cijena')),
            verificiran: podaci.get('verificiran')=='on' ? true: false
        });
    }

    return (

        <Container>
           <Form onSubmit={handleSubmit}>
                <InputText atribut='naziv' vrijednost='' />
                <InputText atribut='trajanje' vrijednost='' />
                <InputText atribut='cijena' vrijednost='' />
                <InputCheckbox atribut='verificiran' vrijednost={false} />
                <Akcije odustani={RoutesNames.SMJER_PREGLED} akcija='Dodaj smjer' />
           </Form>
        </Container>

    );

}