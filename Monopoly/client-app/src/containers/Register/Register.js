import React, {Component} from 'react'
import classes from './Register.css'
import { Link } from 'react-router-dom'

export default class Register extends Component{
    constructor(props){
        super(props);
        this.setState({
            email: '', username: '', password: ''
        });
        this.changeHandler = this.changeHandler.bind(this);
    }

    changeHandler(event){
        this.setState(prev =>{return{...prev, [event.target.name]: event.target.value}})
    }

    render(){
        return(
            <div className={classes.Register}> 
                <h1>Register</h1>
                <form>
                <div className="form-group">
                    <label>Email</label>
                    <input onChange={this.changeHandler} type="email" name="email" className="form-control" placeholder="Enter email" />
                </div>

                <div className="form-group">
                    <label>Username</label>
                    <input onChange={this.changeHandler} type="text" name="username" className="form-control" placeholder="Username" />
                </div>

                <div className="form-group">
                    <label>Password</label>
                    <input onChange={this.changeHandler} type="password" name="password" className="form-control" placeholder="Enter password" />
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