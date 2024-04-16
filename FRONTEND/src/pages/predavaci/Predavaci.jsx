import { useEffect, useState } from "react";
import { Button, Container, Table } from "react-bootstrap";
import Service from "../../services/PredavacService";
import { IoIosAdd } from "react-icons/io";
import {  FaEdit, FaTrash} from "react-icons/fa";
import { Link } from "react-router-dom";
import {  RoutesNames } from "../../constants";
import { useNavigate } from "react-router-dom";

export default function Predavaci(){
    const [predavaci,setPredavaci] = useState();
    let navigate = useNavigate(); 

    async function dohvatiPredavace(){
        const odgovor = await Service.get('Predavac');
        if(!odgovor.ok){
            alert(Service.dohvatiPorukeAlert(odgovor.podaci));
            return;
        }
        setPredavaci(odgovor.podaci);
    }

    async function obrisiPredavac(sifra) {
        const odgovor = await Service.obrisi('Predavac',sifra);
        alert(Service.dohvatiPorukeAlert(odgovor.podaci));
        if (odgovor.ok){
            dohvatiPredavace();
        }
    }

    useEffect(()=>{
        dohvatiPredavace();
        // eslint-disable-next-line react-hooks/exhaustive-deps
    },[]);


    return (
        <Container>
            <Link to={RoutesNames.PREDAVAC_NOVI} className="btn btn-success siroko">
                <IoIosAdd
                size={25}
                /> Dodaj
            </Link>
            <Table striped bordered hover responsive>
                <thead>
                    <tr>
                        <th>Ime</th>
                        <th>Prezime</th>
                        <th>OIB</th>
                        <th>Email</th>
                        <th>IBAN</th>
                        <th>Akcija</th>
                    </tr>
                </thead>
                <tbody>
                    {predavaci && predavaci.map((predavac,index)=>(
                        <tr key={index}>
                            <td>{predavac.ime}</td>
                            <td>{predavac.prezime}</td>
                            <td>{predavac.oib}</td>
                            <td>{predavac.email}</td>
                            <td>{predavac.iban}</td>
                            <td className="sredina">
                                    <Button
                                        variant='primary'
                                        onClick={()=>{navigate(`/predavaci/${predavac.sifra}`)}}
                                    >
                                        <FaEdit 
                                    size={25}
                                    />
                                    </Button>
                               
                                
                                    &nbsp;&nbsp;&nbsp;
                                    <Button
                                        variant='danger'
                                        onClick={() => obrisiPredavac(predavac.sifra)}
                                    >
                                        <FaTrash
                                        size={25}/>
                                    </Button>

                                   
                            </td>
                        </tr>
                    ))}
                </tbody>
            </Table>
        </Container>
    );

}