import React, { Component } from 'react';
import Layout from './hoc/Layout/Layout'
import './custom.css'

export default class App extends Component {
  static displayName = App.name;

  render () {
    return (
      <Layout>
        <div className="App">
          <h1>Hello World</h1>
        </div>
      </Layout>
    );
  }
}
