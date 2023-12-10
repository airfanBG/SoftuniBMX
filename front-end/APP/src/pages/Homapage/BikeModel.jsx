import { useContext } from "react";
import { setStockBike } from "../../util/util.js";
import styles from "./BikeModel.module.css";

import { Link } from "react-router-dom";
import { UserContext } from "../../context/GlobalUserProvider.jsx";

function BikeModel({ imageUrl, model, price, top, description, id }) {
  const { user } = useContext(UserContext);
  const pSplit = price.toFixed(2).split(".");
  const bikeId = id;

  function onClickSelection() {
    if (user) {
      setStockBike({
        userId: user.id,
        bikeId: id,
      });
    }
  }

  return (
    <figure
      className={styles.card}
      style={top === price ? { backgroundColor: "#F3EED9" } : null}
    >
      {top === price && <p className={styles.top}>best value</p>}
      <img src={imageUrl} alt={model} className={styles["card-img"]} />
      <div className={styles["card-content"]}>
        <h3 className={styles["card-hd"]}>
          {/* Bike type <span>#</span>1 */}
          {model}
        </h3>
        <p className={styles["card-pf"]}>{description}</p>
        <div className={styles.priceTag}>
          <span className={styles.price}>
            {pSplit.at(0)}.
            <span className={styles.priceDecimal}>{pSplit.at(1)}</span>
          </span>
          <p>
            {/* <p className={styles["card-pf"]}> */}
            <Link
              to={user ? "/profile/get-stock" : "/auth/login"}
              className={styles["card-link"]}
              onClick={onClickSelection}
            >
              Get it!
            </Link>
          </p>
        </div>
      </div>
    </figure>
  );
}

export default BikeModel;
