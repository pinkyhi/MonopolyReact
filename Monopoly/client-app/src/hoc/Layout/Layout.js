import React, {Component} from 'react'
import Navigation from '../Navigation/Navigation'
import classes from './Layout.css'

class Layout extends Component{
    render(){
        return(
            <div className={classes.Layout}>
                <Navigation />
                <main>
                    {this.props.children}
                </main>
            </div>
        )
    }
}

export default Layout