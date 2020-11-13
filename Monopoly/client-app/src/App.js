import React from 'react'
import './App.css';
import Layout from './hoc/Layout/Layout'
import AppContext from './contexts/appContext'
import { useRoutes } from './routes';

function App() {
  const routes = useRoutes(false);
  return (
    <AppContext.Provider value={{}}>
      <Layout>
        {routes}
      </Layout>
    </AppContext.Provider>
  );
}

export default App;
