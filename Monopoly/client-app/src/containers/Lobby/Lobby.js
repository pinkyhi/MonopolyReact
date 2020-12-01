import React, { useEffect } from 'react'
import classes from './Lobby.css'
import GamesList from '../../components/GamesList/GamesList'
import { useLobby } from './lobby.hook'

const Lobby = () => {
    // state = {
    //     lobby: [
    //         {
    //             id: 1,
    //             title: 'ForK',
    //             password: true,
    //             countNow: 4,
    //             capacity: 6,
    //             ownerName: 'pinky',
    //             cityName: 'Kharkiv'
    //         },
    //         {
    //             id: 2,
    //             title: 'ForUs',
    //             password: false,
    //             countNow: 3,
    //             capacity: 4,
    //             ownerName: 'pinky',
    //             cityName: 'Kharkiv'
    //         }
    //     ]
    // }
    const {games, loadGames} = useLobby();
    useEffect(()=>{
        console.log('xx')
        let searchPart = "test";
        loadGames(searchPart)
    }, [loadGames])
    console.log('Lobby');
    return(
        <div className={classes.Lobby}>
            <div className={classes.LobbyGames}>
                <h1>Lobby</h1>
                <form method="POST" action="https://www.liqpay.ua/api/3/checkout" accept-charset="utf-8">
                    <input type="hidden" name="data" value="eyJ2ZXJzaW9uIjozLCJwdWJsaWNfa2V5IjoiaTQ0MjI3OTY2MTkiLCJwcml2YXRlX2tleSI6InI5STJMRDFMMkh0aTFhWEc0aXpnekRSOWxSSGZyMDA5ZTh6TzMzS3oiLCJhY3Rpb24iOiJwYXkiLCJhbW91bnQiOjEuMCwiY3VycmVuY3kiOiJydWIiLCJkZXNjcmlwdGlvbiI6InFpd2kyIiwib3JkZXJfaWQiOiJxaXdpMiIsInNhbmRib3giOjB9"/>
                    <input type="hidden" name="signature" value="TkG8LEccxRPbPSFjibOuha93s+s="/>
                    <input type="submit" src="//static.liqpay.ua/buttons/p1ru.radius.png"/>
                </form>
            </div>
        </div>
    )
}

export default Lobby