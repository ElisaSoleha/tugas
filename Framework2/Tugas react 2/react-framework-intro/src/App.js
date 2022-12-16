
import React, { Component } from 'react';
import Logo from './logo_unri.png';
import './App.css';
import User from './components/User';
import Blog from './components/Blog';
import Account from './components/Account';
import { BrowserRouter as Router, Route, Link, Routes} from 'react-router-dom';



class App extends Component{
  render(){
    return (
      <Router>
        <div>
            
            <Link to="/">Home</Link>
            <Link to="/Account">|Account</Link>
            <link to="/Blog">|Blog</link>
            
            <hr/>
            <img src={Logo} className="App-logo" alt="logo/"/>
            
              <Routes>
              <Route exact path ="/" element={<User/>}/>
              <Route path="/Account" element={<Account/>}/>
              <Route path="/Blog" element={<Blog/>}/>
              </Routes>


        </div>
      </Router>

    );
  }
}

export default App;
