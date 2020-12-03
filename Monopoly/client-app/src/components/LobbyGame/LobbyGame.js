import React from 'react'
import classes from './LobbyGame.css'
import { ImLock, ImUnlocked } from 'react-icons/im'

const LobbyGame = props => {
    return(
        <tr className={classes.LobbyGame}>
            <td>{ props.game.gameId }</td>
            <td>{ props.game.title }</td>
            <td>{ props.game.password ? <ImLock/> : <ImUnlocked/> }</td>
            <td>{ props.game.countNow+'/'+props.game.capacity}</td>
            <td>{ props.game.ownerName }</td>
            <td>{ props.game.cityName }</td>
        </tr>
    )
}

export default LobbyGame