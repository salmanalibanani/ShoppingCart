import { React, useContext } from "react";
import { CartContext } from "../CartContext";
import { Card, Button } from "@material-ui/core";
import Grid from "@material-ui/core/Grid";
import { v4 as uuid } from "uuid";

const addProductToCart = (cart, itemId, title, unitPrice) => {
  const products = cart.products;

  products.push({
    guid: uuid(),
    id: itemId,
    title: title,
    unitprice: unitPrice,
  });

  cart.setProducts(products);
};

export const ProductBox = (props) => {
  const cart = useContext(CartContext);
  return (
    <Grid item xs={12} sm={6} md={4}>
      <Card className={props.styles.paper}>
        {props.title}
        <br />
        Unit price: {props.unitprice}
        <br />
        <img src={props.image} style={{ height: 100 }} />
        <br />
        <Button
          variant="outlined"
          onClick={() =>
            addProductToCart(cart, props.id, props.title, props.unitprice)
          }
        >
          Add to cart
        </Button>
      </Card>
    </Grid>
  );
};
