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
            </div>
        </div>
    )
}

export default Lobby