import {useCallback, useContext} from 'react'
import {apiRoutes} from '../apiRoutes'
import jwt from 'jwt-decode'
import AppContext from '../contexts/appContext'

export const useIdentity = () => {
    const {setDecodedToken} = useContext(AppContext);
    
    const login = useCallback(async (body = null, headers = {'Content-Type': 'application/json'}) => {
        const response = await fetch(apiRoutes.login, {method: 'POST', body: JSON.stringify(body), headers})
        if(response.ok){
            const data = await response.json()
            localStorage.setItem('token', data.token);
            localStorage.setItem('refreshToken', data.refreshToken);
            setDecodedToken(jwt(data.token));
        }
        return response
    }, [setDecodedToken])

    const register = useCallback(async (body = null, headers = {'Content-Type': 'application/json'}) => {
        const response = await fetch(apiRoutes.register, {method: 'POST', body: JSON.stringify(body), headers})
        if(response.ok){
            const data = await response.json()
            localStorage.setItem('token', data.token);
            localStorage.setItem('refreshToken', data.refreshToken);
            setDecodedToken(jwt(data.token));
        }
        return response
    }, [setDecodedToken])

    const logout = useCallback(async () => {
        const response = await fetch(apiRoutes.logout, {method: 'POST', body: {}, headers: {'Content-Type': 'application/json'}})
        if(response.ok){
            localStorage.removeItem('token');
            localStorage.removeItem('refreshToken');
            setDecodedToken(null);
        }
        return response
    }, [setDecodedToken])

    const refreshToken = useCallback(async (token, refreshToken) => {
        const response = await fetch(apiRoutes.refreshToken, {method: 'POST', body: {token, refreshToken}, headers: {'Content-Type': 'application/json'}})
        if(response.ok){
            const data = await response.json()
            localStorage.setItem('token', data.token)
            localStorage.setItem('refreshToken', data.refreshToken)
            setDecodedToken(jwt(data.token))
        }
        return response
    }, [setDecodedToken])
    return {login, register, logout, refreshToken}
}