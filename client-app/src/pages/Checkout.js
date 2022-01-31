import { React, useState, useEffect, useContext } from "react";
import { makeStyles } from "@material-ui/core/styles";
import { CartContext } from "../CartContext";
import Grid from "@material-ui/core/Grid";
import { ShoppingCartItem } from "../component/ShoppingCartItem";
import { Button } from "@material-ui/core";
import { useNavigate } from "react-router-dom";

const useStyles = makeStyles((theme) => ({
  paper: {
    padding: theme.spacing(1),
    marginTop: theme.spacing(1),
    marginLeft: theme.spacing(1),
    marginBottom: theme.spacing(0),
    marginRight: theme.spacing(1),
    textAlign: "left",
    color: theme.palette.text.secondary,
    height: 100,
    width: 300,
  },
}));

const Checkout = (props) => {
  const [shippingCost, setShippingCost] = useState();

  const cart = useContext(CartContext);
  const productsInCart = cart.products;

  const styles = useStyles();

  const placeOrder = async () => {
    const response = await fetch("order", {
      method: "POST",
      body: JSON.stringify(productsInCart),
      headers: {
        "Content-Type": "application/json",
      },
    });

    //console.log(content);

    navigate("/thankyou");
    cart.setProducts([]);
  };

  let navigate = useNavigate();

  useEffect(() => {
    const calculateShipping = async () => {
      console.log("calculateShipping");
      console.log("productsInCart: ", productsInCart);

      const response = await fetch("shipping", {
        method: "POST",
        body: JSON.stringify(productsInCart),
        headers: {
          "Content-Type": "application/json",
        },
      });
      const content = await response.json();
      console.log(content.shippingCost);
      setShippingCost(content.shippingCost);
    };
    calculateShipping();
  });

  return (
    <>
      Total shipping cost for the order: {shippingCost}
      <br />
      <Button
        variant="outlined"
        disabled={productsInCart.length == 0}
        onClick={() => placeOrder(cart, props.id, props.title, props.unitprice)}
      >
        Place Order
      </Button>
      <br />
      <Grid container>
        {productsInCart.map((item) => {
          return (
            <ShoppingCartItem
              key={item.guid}
              guid={item.guid}
              id={item.id}
              title={item.title}
              styles={styles}
              unitprice={item.unitprice}
            />
          );
        })}
      </Grid>
    </>
  );
};
export default Checkout;
