import React from 'react'
import Lobby from './containers/Lobby/Lobby'
import Login from './containers/Login/Login'
import Register from './containers/Register/Register'
import Home from './containers/Home/Home'
import {Route, Switch} from 'react-router-dom'

export const useRoutes = isAuthenticated =>{
    return(
        <Switch>
            {getPublicRoutes()}
            {getAuthRoutes(isAuthenticated)}
        </Switch>
    )
}

function getPublicRoutes() {
    return(
    <>
        <Route exact path='/' component={Home}></Route>
        <Route path="/register" component={Register} />
        <Route path="/login" component={Login} />
    </>
    )
}

function getAuthRoutes(isAuthenticated) {
    if(isAuthenticated){
        return(
            <>
                <Route path="/lobby" component={Lobby}/>
                <Route path="/game/:id" component={Lobby} />
            </>
        )
    }
    else{
        return;
    }
}
