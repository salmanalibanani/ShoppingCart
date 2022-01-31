import { React } from "react";
import { BrowserRouter, Routes, Route } from "react-router-dom";
import Navbar from "./component/Navbar";
import Home from "./pages/Home";
import Checkout from "./pages/Checkout";
import { CartProvider } from "./CartContext";
import { ThankYou } from "./component/ThankYou";

export const App = () => {
  return (
    <CartProvider>
      <BrowserRouter>
        <Navbar />
        <Routes>
          <Route exact path="/" element={<Home />} />
          <Route path="/checkout" element={<Checkout />} />
          <Route path="/thankyou" element={<ThankYou />} />
        </Routes>
      </BrowserRouter>
    </CartProvider>
  );
};

// export default App;
