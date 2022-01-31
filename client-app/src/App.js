import { React } from "react";
import { BrowserRouter as Router, Switch, Route } from "react-router-dom";
import Navbar from "./component/Navbar";
import Home from "./pages/Home";
import Checkout from "./pages/Checkout";
import { CartProvider } from "./CartContext";

export const App = () => {
  return (
    <CartProvider>
      <Router>
        <Navbar />
        <Switch>
          <Route exact path="/" component={Home} />
          <Route path="/checkout" component={Checkout} />
        </Switch>
      </Router>
    </CartProvider>
  );
};

// export default App;
