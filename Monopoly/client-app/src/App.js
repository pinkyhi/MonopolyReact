import React from 'react'
import './App.css';
import Layout from './hoc/Layout/Layout'
import Lobby from './containers/Lobby/Lobby'

function App() {
  return (
    <Layout>
      <Lobby />
    </Layout>
  );
}

export default App;
