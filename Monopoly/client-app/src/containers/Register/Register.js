import React, {Component} from 'react'
import classes from './Register.css'
import { Link } from 'react-router-dom'

export default class Register extends Component{
    render(){
        return(
            <div className={classes.Register}> 
                <h1>Register</h1>
                <form>
                <div className="form-group">
                    <label>Email</label>
                    <input type="email" className="form-control" placeholder="Enter email" />
                </div>

                <div className="form-group">
                    <label>Username</label>
                    <input type="text" className="form-control" placeholder="Username" />
                </div>

                <div className="form-group">
                    <label>Password</label>
                    <input type="password" className="form-control" placeholder="Enter password" />
                </div>

                <button type="submit" className="btn btn-dark btn-lg btn-block">Register</button>
                <p className="forgot-password text-right">
                    Already registered <Link to="/login">log in?</Link>
                </p>
            </form>
            </div>
        )
    }
}