import { Button, Col, Container, Form, Row } from "react-bootstrap";
import { Link, useNavigate, useParams } from "react-router-dom";
import { RoutesNames } from "../../constants";
import SmjerService from "../../services/SmjerService";
import { useEffect, useState } from "react";


export default function SmjeroviPromjena(){
    const navigate = useNavigate();
    const routeParams = useParams();
    const [smjer, setSmjer] = useState({});

   async function dohvatiSmjer(){
        const o = await SmjerService.getBySifra(routeParams.sifra);
        if(o.greska){
            console.log(o.poruka);
            alert('pogledaj konzolu');
            return;
        }
        setSmjer(o.poruka);
   }

   async function promjeni(smjer){
    const odgovor = await SmjerService.put(routeParams.sifra,smjer);
    if (odgovor.greska){
        console.log(odgovor.poruka);
        alert('Pogledaj konzolu');
        return;
    }
    navigate(RoutesNames.SMJER_PREGLED);
}

   useEffect(()=>{
    dohvatiSmjer();
   },[]);

    function obradiSubmit(e){ // e predstavlja event
        e.preventDefault();
        //alert('Dodajem smjer');

        const podaci = new FormData(e.target);

        const smjer = {
            naziv: podaci.get('naziv'),  // 'naziv' je name atribut u Form.Control
            trajanje: parseInt(podaci.get('trajanje')), //na backend je int
            cijena: parseFloat(podaci.get('cijena')),
            verificiran: podaci.get('verificiran')=='on' ? true : false            
        };
        //console.log(routeParams.sifra);
        //console.log(smjer);
        promjeni(smjer);

    }

    return (

        <Container>
            <Form onSubmit={obradiSubmit}>

                <Form.Group controlId="naziv">
                    <Form.Label>Naziv</Form.Label>
                    <Form.Control 
                    type="text" 
                    name="naziv" 
                    defaultValue={smjer.naziv}
                    required />
                </Form.Group>

                <Form.Group controlId="trajanje">
                    <Form.Label>Trajanje</Form.Label>
                    <Form.Control 
                    type="number" 
                    name="trajanje"
                    defaultValue={smjer.trajanje}
                     />
                </Form.Group>

                <Form.Group controlId="cijena">
                    <Form.Label>Cijena</Form.Label>
                    <Form.Control type="text" name="cijena" defaultValue={smjer.cijena} />
                </Form.Group>

                <Form.Group controlId="verificiran">
                    <Form.Check label="Verificiran" name="verificiran" defaultChecked={smjer.verificiran   } />
                </Form.Group>

                <hr />
                <Row>
                    <Col>
                        <Link className="btn btn-danger siroko" to={RoutesNames.SMJER_PREGLED}>
                            Odustani
                        </Link>
                    </Col>
                    <Col>
                        <Button className="siroko" variant="primary" type="submit">
                            Promjeni
                        </Button>
                    </Col>
                </Row>

            </Form>
        </Container>

    );
}