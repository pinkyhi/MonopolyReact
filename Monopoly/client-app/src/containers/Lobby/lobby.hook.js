import { useCallback, useState } from "react";
import { apiRoutes } from "../../apiRoutes";

export const useLobby = () => {
    const [games, setGames] = useState({});
    const loadGames = useCallback(async (searchPart)=>{
        const response = await fetch(apiRoutes.lobby+'?searchPart='+searchPart)
        if(response.ok){
            const data = await response.json();
            console.log(data);
        }
    }, [])

    return {games, loadGames}
}