import React, { useEffect, useState } from 'react';
import { useParams } from "react-router-dom";
import Card from 'react-bootstrap/Card';

const About = () => {

  const params = useParams(); 
  const id = params.id;
  const apiKey = 'live_YofICKhS5rzVW9ntbmlFH90L7hHJr6uYB8QG3jUKinPyZoGquMS9LsBPbM2QKoKM';

  const [breed, setBreed] = useState([]);
  const [data, setData] = useState([]);

  useEffect (() => {
    const requestOptions = {
        method : "GET",
        headers : { "Content-Type" : 'application/json',
          'x-api-key' : apiKey
        },
    };

    fetch ("https://api.thedogapi.com/v1/breeds/"+id, requestOptions)
     .then(response => response.json())
     .then(breed=>setBreed(breed));
  }, []);

  console.log(breed)

  useEffect (() => {
    const requestOptions = {
        method : "GET",
        headers : { "Content-Type" : 'application/json',
          'x-api-key' : apiKey
        },
    };
  
    fetch ("https://api.thedogapi.com/v1/images/search?format=json&breed_id="+id, requestOptions)
     .then(response => response.json())
     .then(data=>setData(data));
  }, []);

  const image = data[0]?.url
  const imageWidth = 300 * data[0]?.width / data[0]?.height
  
  return(
    <Card>
          <Card.Body style={{textAlign: 'center'}}>
              <Card.Title style={{height: 50, fontWeight: 'bold', fontSize: 30}}>{breed.name}</Card.Title>
              <Card.Img style={{height: 300, width: imageWidth, marginBottom: 20}} src={image} />
              <Card.Title style={{height: 50}}>Average life span: {breed.life_span}</Card.Title>
              <Card.Title style={{height: 50}}>Temperament: {breed.temperament}</Card.Title>
              <Card.Title style={{height: 50}}>Weight: {breed.weight?.metric}</Card.Title>
              <Card.Title style={{height: 50}}>Height: {breed.height?.metric}</Card.Title>
          </Card.Body>       
    </Card>
  )
}

export default About;