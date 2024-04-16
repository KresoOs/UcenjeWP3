import { useEffect, useState } from "react";
import { Button, Card, Col, Container,Row } from "react-bootstrap";
import Service from "../../services/PolaznikService";
import { FaEdit, FaTrash } from "react-icons/fa";
import { RoutesNames } from "../../constants";
import { Link } from "react-router-dom";
import nepoznato from '../../assets/nepoznato.png'; 
import { IoIosAdd } from "react-icons/io";

export default function Polaznici(){
    const [polaznici,setPolaznici] = useState([]);

    async function dohvatiPolaznike(){
        const odgovor = await Service.get('Polaznik');
        if(!odgovor.ok){
            alert(Service.dohvatiPorukeAlert(odgovor.podaci));
            return;
        }
        setPolaznici(odgovor.podaci);
    }

    async function obrisiPolaznik(sifra) {
        const odgovor = await Service.obrisi('Polaznik',sifra);
        alert(Service.dohvatiPorukeAlert(odgovor.podaci));
        if (odgovor.ok){
            dohvatiPolaznike();
        }
    }

    useEffect(()=>{
            dohvatiPolaznike(); 
    // eslint-disable-next-line react-hooks/exhaustive-deps
    },[]);





    return (

        <Container>
             <Link to={RoutesNames.POLAZNIK_NOVI} className="btn btn-success siroko">
                <IoIosAdd
                size={25}
                /> Dodaj
            </Link>
            <Row>
            { polaznici && polaznici.map((p) => (
           
           <Col key={p.sifra} sm={12} lg={3} md={3}>
              <Card style={{ marginTop: '1rem' }}>
              <Card.Img variant="top" src={nepoznato} className="slika"/>
                <Card.Body>
                  <Card.Title>{p.ime} {p.prezime}</Card.Title>
                  <Card.Text>
                    {p.email}
                  </Card.Text>
                  <Row>
                      <Col>
                      <Link className="btn btn-primary gumb" to={`/polaznici/${p.sifra}`}><FaEdit /></Link>
                      </Col>
                      <Col>
                      <Button variant="danger" className="gumb"  onClick={() => obrisiPolaznik(p.sifra)}><FaTrash /></Button>
                      </Col>
                    </Row>
                </Card.Body>
              </Card>
            </Col>
          ))
      }
      </Row>
        </Container>


    );

}