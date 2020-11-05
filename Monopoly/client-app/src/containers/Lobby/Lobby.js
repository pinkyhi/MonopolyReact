import React, {Component} from 'react'
import classes from './Lobby.css'
import LobbyGame from '../../components/LobbyGame/LobbyGame'

class Lobby extends Component{
    state = {
        lobby: []
    }
    render(){
        return(
            <div className={classes.Lobby}>
                <div className={classes.LobbyGames}>
                    <h1>Lobby</h1>
                    <LobbyGame />
                </div>
            </div>
        )
    }
}

export default Lobby