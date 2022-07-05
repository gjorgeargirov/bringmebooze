import './App.css';
import 'bootstrap/dist/css/bootstrap.min.css';
import Header from "./components/Header";
import Home from "./components/Home";
import Products from "./components/Products";
import {BrowserRouter, Route, Routes} from "react-router-dom";
import Login from "./components/Login";
import Register from "./components/Register";

function App() {
  return (
      <div>
          <Header />
          <BrowserRouter>
              <Routes>
                  <Route path="/" element={<Home />} />
                  <Route path="/login" element={<Login />} />
                  <Route path="/products" element={<Products />} />
                  <Route path="/register" element={<Register />} />
              </Routes>
          </BrowserRouter>
      </div>
  );
}

export default App;
