import React from 'react'
import classes from './GamesList.css'
import LobbyGame from './../LobbyGame/LobbyGame'

const GamesList = props => {
    return(
        <div className={classes.GamesList}>
            <table>
                <tbody>
                    <tr>
                        <th>Id</th>
                        <th>Title</th>
                        <th>Password</th>
                        <th>Capacity</th>
                        <th>OwnerName</th>
                        <th>CityName</th>
                    </tr>
                    { Array.isArray(props.games.games) && props.games.games.map((game)=>{
                        return(
                            <LobbyGame 
                                key={game.gameId}
                                game={game}
                            />
                        )
                    }) }
                </tbody>
            </table>
        </div>
    )
}


export default GamesList