import React, { useContext, useEffect } from 'react'
import { useHttpInterceptor } from '../../hooks/httpInterceptor.hook'
import Navigation from '../Navigation/Navigation'
import fetchIntercept from 'fetch-intercept';
import classes from './Layout.css'
import { useRoutes } from '../../hooks/routesSwitch.hook';
import AppContext from '../../contexts/appContext';

export const Layout = (props) => {
    useContext(AppContext);
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