import React, {Component} from 'react'
import classes from './Login.css'

export default class Login extends Component{
    constructor(props){
        super(props);
        this.setState({
            email: '', password: ''
        });
        this.changeHandler = this.changeHandler.bind(this);
    }

    changeHandler(event){
        this.setState(prev =>{return{...prev, [event.target.name]: event.target.value}})
    }
    
    render(){
        return(
            <div className={classes.Login}>
                <h1>Login</h1>
                <form>
                    <div className="form-group">
                        <label>Email</label>
                        <input onChange={this.changeHandler} type="email" className="form-control" placeholder="Enter email" name="email" />
                    </div>

                    <div className="form-group">
                        <label>Password</label>
                        <input onChange={this.changeHandler} type="password" className="form-control" placeholder="Enter password" name="password" />
                    </div>

                    <button type="submit" className="btn btn-dark btn-lg btn-block">Sign in</button>
                </form>
            </div>
        )
    }
}