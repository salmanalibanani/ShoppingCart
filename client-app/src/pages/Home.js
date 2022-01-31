import { React, useState, useEffect } from "react";
import { makeStyles } from "@material-ui/core/styles";
import Grid from "@material-ui/core/Grid";

import { ProductBox } from "../component/ProductBox";
const useStyles = makeStyles((theme) => ({
  paper: {
    padding: theme.spacing(1),
    marginTop: theme.spacing(1),
    marginLeft: theme.spacing(1),
    marginBottom: theme.spacing(0),
    marginRight: theme.spacing(1),
    textAlign: "left",
    color: theme.palette.text.secondary,
    height: 200,
  },
}));

const Home = () => {
  const [data, setData] = useState([]);

  useEffect(() => {
    const fetchData = async () => {
      const response = await fetch("products");
      const d = await response.json();
      setData(d);
    };
    fetchData();
  }, []);

  const styles = useStyles();

  return (
    <Grid container spacing={1}>
      {data.map((item) => {
        return (
          <ProductBox
            key={item.id}
            id={item.id}
            styles={styles}
            title={item.title}
            image={item.image}
            unitprice={item.unitPrice}
          />
        );
      })}
    </Grid>
  );
};
export default Home;
