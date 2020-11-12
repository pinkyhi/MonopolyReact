import React, {Component} from 'react'
import classes from './Login.css'
import { Link } from 'react-router-dom'

export default class Login extends Component{
    render(){
        return(
            <div className={classes.Login}>
                <h1>Login</h1>
                <form>
                    <div className="form-group">
                        <label>Email</label>
                        <input type="email" className="form-control" placeholder="Enter email" />
                    </div>

                    <div className="form-group">
                        <label>Password</label>
                        <input type="password" className="form-control" placeholder="Enter password" />
                    </div>

                    <div className="form-group">
                        <div className="custom-control custom-checkbox">
                            <input type="checkbox" className="custom-control-input" id="customCheck1" />
                            <label className="custom-control-label" htmlFor="customCheck1">Remember me</label>
                        </div>
                    </div>

                    <button type="submit" className="btn btn-dark btn-lg btn-block">Sign in</button>
                    <p className="forgot-password text-right">
                        Forgot <Link to="#">password?</Link>
                    </p>
                </form>
            </div>
        )
    }
}