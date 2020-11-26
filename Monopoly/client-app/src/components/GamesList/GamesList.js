import React from 'react'
import classes from './GamesList.css'
import LobbyGame from './../LobbyGame/LobbyGame'

const GamesList = props => {
    console.log(props)

    return(
        <table className={classes.GamesList}>
            <tbody>
                <tr>
                    <th>Id</th>
                    <th>Title</th>
                    <th>Password</th>
                    <th>Capacity</th>
                    <th>OwnerName</th>
                    <th>CityName</th>
                </tr>
                { props.games.map((game)=>{
                    return(
                        <LobbyGame 
                            key={game.id}
                            game={game}
                        />
                    )
                }) }
            </tbody>
        </table>
    )
}


export default GamesList