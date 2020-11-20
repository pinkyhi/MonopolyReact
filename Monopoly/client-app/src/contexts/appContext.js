import React, { useState } from 'react'


const AppContext = React.createContext();

export default AppContext;

export const useDefaultValue = () => {
    const [decodedToken, setDecodedToken] = useState(null);

    const isLogged = () => {
        if(decodedToken){
            var current_time = new Date().getTime() / 1000
            if (!(current_time > decodedToken.exp)) {
                return true
            }
        }
        return false
    }
    return {decodedToken, setDecodedToken, isLogged}
}