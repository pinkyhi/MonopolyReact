import fetchIntercept from 'fetch-intercept';
import { useIdentity } from '../../hooks/identity.hook';
import { apiRoutes } from '../../apiRoutes'
import { useHistory } from 'react-router-dom';
const unregister = fetchIntercept.register({
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
                        //let response = refreshToken(token, refresh)
                        if(response.ok){
                            //history.push(pointPath)
                        }
                        else{
                            //history.push(apiRoutes.login, {path: pointPath})
                        }
                    }
                    else{
                        //history.push(apiRoutes.login, {path: pointPath})
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

// const redirectTo = () => {
//     const history = useHistory();

//     const redirectTo = (path, [state]) => {
//         history.push(path);
//     }

// };



export default unregister