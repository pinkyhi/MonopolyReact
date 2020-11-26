import React, { useContext, useEffect } from 'react'
import { useHttpInterceptor } from '../../hooks/httpInterceptor.hook'
import Navigation from '../Navigation/Navigation'
import fetchIntercept from 'fetch-intercept';

import classes from './Layout.css'
import AppContext from '../../contexts/appContext';
import { useRoutes } from '../../hooks/routesSwitch.hook';

export const Layout = (props) => {
    const {decodedToken} = useContext(AppContext);
    console.log(decodedToken);
    const {interceptor} = useHttpInterceptor();
    const routes = useRoutes();
    useEffect(()=>{
      fetchIntercept.register(interceptor);
    // eslint-disable-next-line react-hooks/exhaustive-deps
    }, [])
    return(
        <div className={classes.Layout}>
            <Navigation />
            <main>
                {routes}
                {props.children}
            </main>
        </div>
    )
}

export default Layout