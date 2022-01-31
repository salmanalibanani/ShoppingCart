import { React, useContext } from "react";
import { Card, Button } from "@material-ui/core";
import Grid from "@material-ui/core/Grid";
import { CartContext } from "../CartContext";

const removeProductFromCart = (cart, props) => {
  const newProducts = cart.products.filter((x) => x.guid !== props.guid);
  cart.setProducts(newProducts);
};
export const ShoppingCartItem = (props) => {
  const cart = useContext(CartContext);
  return (
    <Grid item xs={12} sm={12} md={12}>
      <Card className={props.styles.paper}>
        {props.title}
        <br />
        Unit price: {props.unitprice}
        <br />
        <Button
          variant="outlined"
          onClick={() => removeProductFromCart(cart, props)}
        >
          Remove from cart
        </Button>
      </Card>
    </Grid>
  );
};
