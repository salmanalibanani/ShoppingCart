import { React, createContext, useState } from "react";

export const CartContext = createContext();

// This context provider is passed to any component requiring the context
export const CartProvider = ({ children }) => {
  const [products, setProducts] = useState([]);

  return (
    <CartContext.Provider
      value={{
        products,
        setProducts,
      }}
    >
      {children}
    </CartContext.Provider>
  );
};
