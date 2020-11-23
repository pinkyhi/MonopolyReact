import fetchIntercept from 'fetch-intercept';

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
        // Called when an error occured during another 'request' interceptor call
        return Promise.reject(error);
    },
 
    response: function (response) {
        // Modify or log the reponse object
        return response;
    },
 
    responseError: function (error) {
        // Handle a fetch error
        return Promise.reject(error);
    }
});

export default unregister