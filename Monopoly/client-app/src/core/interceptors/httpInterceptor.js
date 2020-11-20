import fetchIntercept from 'fetch-intercept';

const unregister = fetchIntercept.register({
    request: function (url, config) {
        // Modify the url or config here
        console.log(1111111);
        console.log(url);
        return [url, config];
    },
 
    requestError: function (error) {
        // Called when an error occured during another 'request' interceptor call
        console.log(22222222);
        console.log(error)
        return Promise.reject(error);
    },
 
    response: function (response) {
        // Modify or log the reponse object
        console.log(333333333);
        console.log(response);
        return response;
    },
 
    responseError: function (error) {
        // Handle a fetch error
        console.log(444444444);
        console.log(error)
        return Promise.reject(error);
    }
});

export default unregister