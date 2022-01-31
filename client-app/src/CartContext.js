import React, { createContext, useState } from "react";

export const CartContext = createContext();

// This context provider is passed to any component requiring the context
export const CartProvider = ({ children }) => {
  const [name, setName] = useState("William");
  const [location, setLocation] = useState("Mars");
  const [products, setProducts] = useState([]);

  return (
    <CartContext.Provider
      value={{
        name,
        location,
        setName,
        setLocation,
        products,
        setProducts,
      }}
    >
      {children}
    </CartContext.Provider>
  );
};
