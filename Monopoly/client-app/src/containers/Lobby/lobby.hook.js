import { useCallback, useState } from "react";
import { apiRoutes } from "../../apiRoutes";

export const useLobby = () => {
    const [games, setGames] = useState();
    const loadGames = useCallback(async ()=>{
        const response = await fetch(apiRoutes.lobby, {method: 'GET', body: {}, headers: {}})
        if(response.ok){
            const data = await response.json();
            console.log(data);
        }
    })
}