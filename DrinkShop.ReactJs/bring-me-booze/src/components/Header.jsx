import {Container, Nav, Navbar} from "react-bootstrap";

const Header = () => {
    return (
        <Navbar collapseOnSelect expand="lg" bg="dark" variant="dark">
            <Container>
                <Navbar.Brand href="/">BringMeBooze</Navbar.Brand>
                <Navbar.Toggle aria-controls="responsive-navbar-nav" />
                <Navbar.Collapse id="responsive-navbar-nav">
                    <Nav className="me-auto">
                        <Nav.Link href="/">Home</Nav.Link>
                        <Nav.Link href="/products">Products</Nav.Link>
                    </Nav>
                    <Nav>
                        <Nav.Link href="/register">Register</Nav.Link>
                        <Nav.Link href="/login">Login</Nav.Link>
                    </Nav>
                </Navbar.Collapse>
            </Container>
        </Navbar>
    )
};

export default Header;
