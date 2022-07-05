import {Col, Row, Card, Button, Modal} from "react-bootstrap";
import WineImage from '../images/download.png';
import {useState} from "react";
import {InputNumber} from "primereact/inputnumber";

const Products = () => {

    const [show, setShow] = useState(false);
    const [value, setValue] = useState(1324);

    const handleClose = () => setShow(false);
    const handleShow = () => setShow(true);


    return (
        <>
            <Button variant="primary" onClick={handleShow}>
                Add a product
            </Button>
            <Row xs={4} className="g-4">
                {Array.from({length: 6}).map((_, idx) => (
                    <Col>
                        <Card>
                            <img src={WineImage} alt="Wine"/>
                            <Card.Body>
                                <Card.Title>Tikvesh 0.75L</Card.Title>
                                <Card.Text>
                                    High quality Macedonian wine
                                </Card.Text>
                                <Card.Text>
                                    300 MKD
                                </Card.Text>
                            </Card.Body>
                        </Card>
                    </Col>
                ))}
            </Row>

            <Modal show={show} onHide={handleClose}>
                <Modal.Header closeButton>
                    <Modal.Title>Modal heading</Modal.Title>
                </Modal.Header>
                <Modal.Body>
                    <form className="px-4 py-3">
                        Tikvesh 0.75L
                        <br/>
                        <div className="grid p-fluid">
                            <div className="field col-12 md:col-3">
                                <InputNumber inputId="horizontal" value={value} onValueChange={(e) => setValue(e.value)}
                                             showButtons buttonLayout="horizontal" step={1}
                                             decrementButtonClassName="p-button-danger"
                                             incrementButtonClassName="p-button-success"
                                             incrementButtonIcon="pi pi-plus" decrementButtonIcon="pi pi-minus"/>
                            </div>
                        </div>
                        <button type="submit" className="btn btn-primary">Buy</button>
                    </form>
                </Modal.Body>
                <Modal.Footer>
                    <Button variant="secondary" onClick={handleClose}>
                        Close
                    </Button>
                    <Button variant="primary" onClick={handleClose}>
                        Save Changes
                    </Button>
                </Modal.Footer>

            </Modal>
        </>
    )
}

export default Products;
