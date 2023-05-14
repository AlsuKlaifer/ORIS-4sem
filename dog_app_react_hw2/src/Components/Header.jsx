import Container from 'react-bootstrap/Container';
import Nav from 'react-bootstrap/Nav';
import Navbar from 'react-bootstrap/Navbar';

const TopMenu = () => {
  return (
    <>
      <Navbar bg="dark" variant="dark">
        <Container>
          <Navbar.Brand href="/">Dogs</Navbar.Brand>
          <Nav className="me-auto">
            <Nav.Link href="/">Home</Nav.Link>
            <Nav.Link href="/">Contacts</Nav.Link>
            <Nav.Link href="/">About</Nav.Link>
          </Nav>
        </Container>
      </Navbar>
      <div className='m-4'>
        <h2 className="text-center"> </h2>
      </div>
    </>
  );
}

export default TopMenu;