import React, {Component} from 'react'
import { Navbar,Nav } from 'react-bootstrap'
import { Link } from 'react-router-dom'

class Navigation extends Component{
    render(){
        return(
            <div>
                <Navbar bg="light" expand="lg">
                <Navbar.Brand to="/">Monopoly</Navbar.Brand>
                <Navbar.Toggle aria-controls="basic-navbar-nav" />
                <Navbar.Collapse id="basic-navbar-nav">
                    <Nav className="mr-auto">
                    <Nav.Link as={Link} to="/">Lobby</Nav.Link>
                    <Nav.Link as={Link} to="/register">Register</Nav.Link>
                    <Nav.Link as={Link} to="/login">Login</Nav.Link>
                    <Nav.Item>Username</Nav.Item>
                    <Nav.Link>Logout</Nav.Link>
                    </Nav>
                </Navbar.Collapse>
                </Navbar>
            </div>
        )
    }
}

export default Navigation