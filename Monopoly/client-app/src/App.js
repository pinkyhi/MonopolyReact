import React from 'react'
import './App.css';
import Layout from './hoc/Layout/Layout'
import Lobby from './containers/Lobby/Lobby'
import Login from './containers/Login/Login'
import Register from './containers/Register/Register'
import AppContext from './contexts/appContext'
import {Route, Switch} from 'react-router-dom'

function App() {
  return (
    <AppContext.Provider value={{}}>
      <Layout>
        <Switch>
          <Route path="/" component={Lobby} exact/>
          <Route path="/register" component={Register} />
          <Route path="/login" component={Login} />
          <Route path="/game/:id" component={Lobby} />
        </Switch>
      </Layout>
    </AppContext.Provider>
  );
}

export default App;
