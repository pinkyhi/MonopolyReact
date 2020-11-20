import React from 'react'
import './App.css';
import AppContext, {useDefaultValue} from './contexts/appContext';
import Layout from './hoc/Layout/Layout'
import { useRoutes } from './routes';
import {unregister} from '../src/core/interceptors/httpInterceptor'


function App() {
  const routes = useRoutes(false);
  return (
    <AppContext.Provider value={useDefaultValue()}>
      <Layout>
        {routes}
      </Layout>
    </AppContext.Provider>
  );
}

export default App;
