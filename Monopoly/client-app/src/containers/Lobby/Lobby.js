import React, {Component} from 'react'
import classes from './Lobby.css'
import GamesList from '../../components/GamesList/GamesList'

class Lobby extends Component{
    state = {
        lobby: [
            {
                id: 1,
                title: 'ForK',
                password: true,
                countNow: 4,
                capacity: 6,
                ownerName: 'pinky',
                cityName: 'Kharkiv'
            },
            {
                id: 2,
                title: 'ForUs',
                password: false,
                countNow: 3,
                capacity: 4,
                ownerName: 'pinky',
                cityName: 'Kharkiv'
            }
        ]
    }
    render(){
        return(
            <div className={classes.Lobby}>
                <div className={classes.LobbyGames}>
                    <h1>Lobby</h1>
                    <GamesList
                        games = {this.state.lobby}
                    />
                </div>
            </div>
        )
    }
}

export default Lobby