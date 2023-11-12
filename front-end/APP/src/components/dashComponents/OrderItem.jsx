import { useEffect, useState } from "react";
import styles from "./OrderItem.module.css";

function OrderItem({ ...product }) {
  const [item, setItem] = useState(product);
  const [timerStarted, setTimerStarted] = useState(false);
  const [current, setCurrent] = useState(null);

  function onStart() {
    let currentTime = Date.now();
    console.log(currentTime);
    setCurrent(currentTime);
    console.log(current);

    if (!timerStarted) {
      setTimerStarted(true);
      setItem({ ...item, startedTime: currentTime });
    } else {
      setTimerStarted(false);
      setItem({ ...item, finishedTime: currentTime });
      const time = item.finishedTime - item.startedTime;
    }
  }

  return (
    <figure className={styles.order}>
      <div className={styles.info}>
        <h3 className={styles.brand}>
          <span>Brand: </span>
          {product.brand}
        </h3>
        <p className={styles.model}>
          <span>Model: </span>
          {product.model}
        </p>
        <p className={styles.unitType}>
          <span>Unit Type: </span>
          {product.unitType}
        </p>
        <p className={styles.job}>
          <span>Order for: </span>
          {product.jobType}
        </p>
      </div>

      <div className={styles.description}>
        <span>Description:</span>
        {product.description}
      </div>
      <div className={styles.timer}>
        <button className={styles.startBtn} onClick={onStart}>
          Start
        </button>
        <p className={styles.pastTime}>00:00:00</p>
      </div>
    </figure>
  );
}

export default OrderItem;
