import { useEffect, useState } from "react";
import {  Button, Container, Table } from "react-bootstrap";
import Service from "../../services/SmjerService";
import { NumericFormat } from "react-number-format";
import { GrValidate } from "react-icons/gr";
import { IoIosAdd } from "react-icons/io";
import { FaEdit, FaTrash } from "react-icons/fa";
import { Link, useNavigate } from "react-router-dom";
import { RoutesNames } from "../../constants";


export default function Smjerovi(){
    const [smjerovi,setSmjerovi] = useState();
    const navigate = useNavigate();

    async function dohvatiSmjerove(){
        const odgovor = await Service.get('Smjer');
        if(!odgovor.ok){
            alert(Service.dohvatiPorukeAlert(odgovor.podaci));
            return;
        }
        setSmjerovi(odgovor.podaci);
    }

    async function obrisiSmjer(sifra){
        const odgovor = await Service.obrisi('Smjer',sifra);
        alert(Service.dohvatiPorukeAlert(odgovor.podaci));
        if (odgovor.ok){
            dohvatiSmjerove();
        }
    }
     // Ovo se poziva dvaput u dev ali jednom u produkciji
    // https://stackoverflow.com/questions/60618844/react-hooks-useeffect-is-called-twice-even-if-an-empty-array-is-used-as-an-ar
    useEffect(()=>{
        dohvatiSmjerove();
        // eslint-disable-next-line react-hooks/exhaustive-deps
    },[]);
    
    function verificiran(smjer){
        if (smjer.verificiran==null) return 'gray';
        if(smjer.verificiran) return 'green';
        return 'red';
    }

    function verificiranTitle(smjer){
        if (smjer.verificiran==null) return 'Nije definirano';
        if(smjer.verificiran) return 'Verificiran';
        return 'NIJE verificiran';
    }

    return (

        <Container>
            <Link to={RoutesNames.SMJER_NOVI} className="btn btn-success siroko">
                <IoIosAdd
                size={25}
                /> Dodaj
            </Link>
            <Table striped bordered hover responsive>
                <thead>
                    <tr>
                        <th>Naziv</th>
                        <th>Trajanje</th>
                        <th>Cijena</th>
                        <th>Verificiran</th>
                        <th>Akcija</th>
                    </tr>
                </thead>
                <tbody>
                    {smjerovi && smjerovi.map((smjer,index)=>(
                        <tr key={index}>
                            <td>{smjer.naziv}</td>
                            <td className="desno">{smjer.trajanje}</td>
                            <td className={smjer.cijena==null ? 'sredina' : 'desno'}>
                                {smjer.cijena==null 
                                ? 'Nije definirano'
                                :
                                    <NumericFormat 
                                    value={smjer.cijena}
                                    displayType={'text'}
                                    thousandSeparator='.'
                                    decimalSeparator=','
                                    prefix={'€'}
                                    decimalScale={2}
                                    fixedDecimalScale
                                    />
                                }
                            </td>
                            <td className="sredina">
                            <GrValidate 
                            size={30} 
                            color={verificiran(smjer)}
                            title={verificiranTitle(smjer)}
                            />
                            </td>
                            <td className="sredina">
                                <Button 
                                variant="primary"
                                onClick={()=>{navigate(`/smjerovi/${smjer.sifra}`)}}>
                                    <FaEdit 
                                    size={25}
                                    />
                                </Button>
                                
                                    &nbsp;&nbsp;&nbsp;
                                <Button
                                    variant="danger"
                                    onClick={()=>obrisiSmjer(smjer.sifra)}
                                >
                                    <FaTrash  
                                    size={25}
                                    />
                                </Button>

                            </td>
                        </tr>
                    ))}
                </tbody>
            </Table>
        </Container>

    );

}