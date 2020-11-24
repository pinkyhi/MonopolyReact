import React from 'react';
import fetchIntercept from 'fetch-intercept';
import { useIdentity } from '../../hooks/identity.hook';
import { useHistory } from 'react-router-dom';
import { useQueryParams } from '../../hooks/queryParams.hook';

const HttpInterceptor = () => {
    const {insertParameter} = useQueryParams();
    const {refreshToken} = useIdentity();
    const history = useHistory();
    fetchIntercept.register({
        request: function (url, config) {
            // Modify the url or config here
            let token = localStorage.getItem('token')

            if(token)
            {
                const headers = {
                    'Content-Type': 'application/json',
                    'Authorization': `Bearer ${token}`,
                    'Accept': 'application/json'
                }
                return [url, { ...config, headers }];
            }
            else{
                const headers = {
                    'Content-Type': 'application/json',
                    'Accept': 'application/json'
                }
                return [url, { ...config, headers }];
            }
        },
     
        requestError: function (error) {
            console.log('requestError')
            console.log(error)
            return Promise.reject(error)
        },
        
        response: function (response) {
            // Modify or log the reponse object
            console.log('error');
            if(!response.ok){
                switch(response.status) {
                    case 401:
                        console.log('401 response')
                        let pointPath = window.location.pathname;
                        let token = localStorage.getItem('token')
                        let refresh = localStorage.getItem('refreshToken')
                        if(token && refresh){
                            // Refreshing
                            refreshToken(token, refresh).then(response => {
                                console.log(response);
                                if(response.ok){
                                    history.push(pointPath)
                                }
                                else{
                                    history.push('/login')
                                    insertParameter('to', pointPath)
                                }
                            })
                        }
                        else{
                            history.push('/login')
                            insertParameter('to', pointPath)
                        }
                        break;
                    case 400:
                        console.log('400 response')
                        alert(response.message);
                        break;
                    default:
                        break;
                }
            }
            return response;
        },
     
        responseError: function (error) {
            // Handle a fetch error
            console.log('response')
            console.log(error)
            return Promise.reject(error);
        }
    });

    return <></>;
}

export default HttpInterceptor;
// export default unregister