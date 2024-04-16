import { useEffect, useState } from "react";
import { Button, Container, Table } from "react-bootstrap";
import { IoIosAdd } from "react-icons/io";
import { FaEdit, FaTrash } from "react-icons/fa";
import { Link } from "react-router-dom";
import { useNavigate } from "react-router-dom";
import ProgressBar from 'react-bootstrap/ProgressBar';
import moment from "moment";

import Service from "../../services/GrupaService";
import { RoutesNames } from "../../constants";

export default function Grupe(){
    const [grupe,setGrupe] = useState();
    let navigate = useNavigate(); 

    async function dohvatiGrupe(){
        const odgovor = await Service.get('Grupa');
        if(!odgovor.ok){
            alert(Service.dohvatiPorukeAlert(odgovor.podaci));
            return;
        }
        setGrupe(odgovor.podaci);
    }

    async function obrisiGrupu(sifra) {
        const odgovor = await Service.obrisi('Grupa',sifra);
        alert(Service.dohvatiPorukeAlert(odgovor.podaci));
        if (odgovor.ok){
            dohvatiGrupe();
        }
    }

    useEffect(()=>{
        dohvatiGrupe();
        // eslint-disable-next-line react-hooks/exhaustive-deps
    },[]);


    function progressStatus(entitet){
    return entitet.brojpolaznika + " polaznika od ukupno " +
    entitet.maksimalnopolaznika + " polaznika na grupi.";
    }

    function progressLabel(entitet){
    return entitet.brojpolaznika + "/" +
    entitet.maksimalnopolaznika;
    }

    function progressPostotak(entitet){
    if (entitet.maksimalnopolaznika==0 || entitet.brojpolaznika==0){
        return 0;
    }

    return (entitet.brojpolaznika / entitet.maksimalnopolaznika) * 100;
    }

    function formatirajDatum(datumpocetka){
    let mdp = moment.utc(datumpocetka);
    if(mdp.hour()==0 && mdp.minutes()==0){
        return mdp.format('DD. MM. YYYY.');
    }
    return mdp.format('DD. MM. YYYY. HH:mm');
    
    }

    return (

        <Container>
            <Link to={RoutesNames.GRUPA_NOVI} className="btn btn-success siroko">
                <IoIosAdd
                size={25}
                /> Dodaj
            </Link>
            <Table striped bordered hover responsive>
                <thead>
                    <tr>
                        <th>Naziv</th>
                        <th>Smjer</th>
                        <th>Predavač</th>
                        <th>Datum početka</th>
                        <th>Akcija</th>
                    </tr>
                </thead>
                <tbody>
                    {grupe && grupe.map((entitet,index)=>(
                        <tr key={index}>
                            <td>{entitet.naziv}</td>
                            <td>{entitet.smjerNaziv}</td>
                            <td>{entitet.predavacImePrezime}</td>
                            <td>
                                <p>
                                {entitet.datumpocetka==null 
                                ? 'Nije definirano'
                                :   
                                formatirajDatum(entitet.datumpocetka)
                                }
                                </p>
                                <ProgressBar 
                                label={progressLabel(entitet)}
                                variant="success"
                                title={progressStatus(entitet)} now={progressPostotak(entitet)} />
                               
                                {/* 
                                <span title="Broj upisanih polaznika">{entitet.brojpolaznika}</span>/ 
                                <span title="Maksimalno polaznika u grupi">
                                {entitet.maksimalnopolaznika==null ? '0' : 
                                entitet.maksimalnopolaznika
                                }
                                </span> 
                                */}
                            </td>
                            <td className="sredina">
                                    <Button
                                        variant='primary'
                                        onClick={()=>{navigate(`/grupe/${entitet.sifra}`)}}
                                    >
                                        <FaEdit 
                                    size={25}
                                    />
                                    </Button>
                               
                                
                                    &nbsp;&nbsp;&nbsp;
                                    <Button
                                        variant='danger'
                                        onClick={() => obrisiGrupu(entitet.sifra)}
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