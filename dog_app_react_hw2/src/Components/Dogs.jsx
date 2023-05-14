import { useEffect, useState } from "react";
import {Card, Col, Row, Container, Button} from 'react-bootstrap';
import { Link } from "react-router-dom";


const Dogs = () => {
    const maxDogsPerPage = 172;
    //const apiUrl = `https://api.thedogapi.com/v1/breeds?limit=${maxDogsPerPage}&page=0`;
    const apiUrl = "http://localhost:7251/api/Dog"
    const apiKey = 'live_YofICKhS5rzVW9ntbmlFH90L7hHJr6uYB8QG3jUKinPyZoGquMS9LsBPbM2QKoKM';

    const [data, setData] = useState({});

    const requestDogs = async () => {
        const requestOptions = {
            method: "GET",
            headers: {
              "Content-Type": "application/json",
            //   "x-api-key": apiKey,
            }
        }
        
        const apiResponse = await fetch(apiUrl, {requestOptions});
        const jsonResult = await apiResponse.json();
        console.log("dogs result", jsonResult);
        setData(jsonResult);
    }

    console.log(data);
    useEffect(() => {
        requestDogs();
      }, []);

    return (
        <Container style={{marginTop: 50}}>
            <Row className="justify-content-center" >
                {Object.values(data).map(dog => (
                    <Col style={{height: 350}} key={dog.id}>
                        <Card style={{width: 160, height: 270}}>
                            <Card.Body>
                                <Card.Title style={{height: 50}}>{dog.family}</Card.Title>
                                <Card.Img style={{height: 100}} src={dog.imgUrl} />
                                <Link to={'/' + (dog.id)} key={dog.id}>
                                    <Button key={dog.id} style={{marginTop: 20}} variant="primary">Read more</Button>
                                </Link>
                            </Card.Body> 
                        </Card>
                    </Col>
                ))}
            </ Row>
        </Container>      
    )
};

export default Dogs;