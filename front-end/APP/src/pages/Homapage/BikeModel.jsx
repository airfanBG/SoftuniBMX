import styles from "./BikeModel.module.css";

import { Link } from "react-router-dom";

function BikeModel({ imageUrl, model, price, top, description }) {
  return (
    <figure
      className={styles.card}
      style={top === price ? { backgroundColor: "#fff5f5" } : null}
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
          <span className={styles.price}>{price.toFixed(2)}</span>
          <p>
            {/* <p className={styles["card-pf"]}> */}
            <Link to={"#"} className={styles["card-link"]}>
              Get it!
            </Link>
          </p>
        </div>
      </div>
    </figure>
  );
}

export default BikeModel;
