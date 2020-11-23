import React from 'react';
import fetchIntercept from 'fetch-intercept';
import { useIdentity } from '../../hooks/identity.hook';
import { apiRoutes } from '../../apiRoutes'
import { useHistory } from 'react-router-dom';
function insertParam(key, value) {
    key = encodeURIComponent(key);
    value = encodeURIComponent(value);

    // kvp looks like ['key1=value1', 'key2=value2', ...]
    var kvp = document.location.search.substr(1).split('&');
    let i=0;

    for(; i<kvp.length; i++){
        if (kvp[i].startsWith(key + '=')) {
            let pair = kvp[i].split('=');
            pair[1] = value;
            kvp[i] = pair.join('=');
            break;
        }
    }

    if(i >= kvp.length){
        kvp[kvp.length] = [key,value].join('=');
    }

    // can return this or...
    let params = kvp.join('&');

    // reload page with new params
    document.location.search = params;
}

const HttpInterceptor = () => {
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
            return [url, config];
        },
     
        requestError: function (error) {
            return Promise.reject(error);
        },
        
        response: function (response) {
            // Modify or log the reponse object
            console.log(response)
            if(!response.ok){
                switch(response.status) {
                    case 401:
                        let pointPath = window.location.pathname;
                        console.log(pointPath)
                        let token = localStorage.getItem('token')
                        let refresh = localStorage.getItem('refresh')
                        if(token && refresh){
                            // Refreshing
                            let response = refreshToken(token, refresh)
                            if(response.ok){
                                history.push(pointPath)
                            }
                            else{
                                history.push('/register')
                                insertParam('to', pointPath)
                                
                            }
                        }
                        else{
                            history.push('/register')
                            insertParam('to', pointPath)
                        }
                        break;
                    case 400:
                        alert(response.error);
                        break;
                    default:
                        break;
                }
            }
            return response;
        },
     
        responseError: function (error) {
            // Handle a fetch error
            return Promise.reject(error);
        }
    });

    return <></>;
}

export default HttpInterceptor;
// export default unregister