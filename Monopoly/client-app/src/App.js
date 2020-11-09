import React from 'react'
import './App.css';
import Layout from './hoc/Layout/Layout'
import Lobby from './containers/Lobby/Lobby'
import AppContext from './contexts/appContext'
import {Route, Switch} from 'react-router-dom'


function App() {
  return (
    <AppContext.Provider value={{}}>
      <Layout>
        <Switch>
          <Route path="/" component={Lobby} />
          <Route path="/register" component={Lobby} />
          <Route path="/login" component={Lobby} />
          <Route path="/game/:id" component={Lobby} />
        </Switch>
      </Layout>
    </AppContext.Provider>
  );
}

export default App;
