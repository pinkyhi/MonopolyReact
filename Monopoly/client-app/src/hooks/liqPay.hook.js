import { useCallback } from "react"
import { apiRoutes } from "../apiRoutes"

export const useLiqPay = () => {
    const getLiqPay = useCallback(async (body = null, headers = {'Content-Type': 'application/json'}) => {
        const response = await fetch(apiRoutes.liqpay, {method: 'POST', body: JSON.stringify(body), headers})
        if(response.ok){
            const responseData = await response.json()
            const data = responseData.data
            const signature = responseData.signature
            return {data, signature}
        }
        return response
    }, [])
    return {getLiqPay}
}