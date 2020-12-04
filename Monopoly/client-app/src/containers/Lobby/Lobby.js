import React, { useCallback, useEffect, useState } from 'react'
import classes from './Lobby.css'
import GamesList from '../../components/GamesList/GamesList'
import { useLobby } from './lobby.hook'
import { BiSearchAlt2 } from 'react-icons/bi'

const Lobby = () => {
    const {games, loadGames} = useLobby();
    const [searchPart, setSearchPart] = useState("");
    const searchButtonHandler = useCallback(() => {
        loadGames(searchPart)
    }, [searchPart, loadGames])
    useEffect(()=>{
        loadGames(searchPart)
    // eslint-disable-next-line react-hooks/exhaustive-deps
    }, [])
    const searchFieldHandler = event => {
        setSearchPart(event.target.value);
    }
    return(
        <div className={classes.Lobby}>
            <div className={classes.LobbyGames}>
                <h1>Lobby</h1>
                <div>
                    <div className={classes.SearchBox}>
                        <input type="text" onChange={searchFieldHandler} placeholder="Search" />
                        <span className="input-group-btn">
                            <button className="btn btn-danger" type="button" onClick={searchButtonHandler}>
                                <BiSearchAlt2 />
                            </button>
                        </span>
                    </div>
                </div>
                <GamesList games={games}></GamesList>
            </div>
        </div>
    )
}

export default Lobby