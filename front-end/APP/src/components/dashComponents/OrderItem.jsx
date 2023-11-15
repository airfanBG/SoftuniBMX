import { useState } from "react";
import styles from "./OrderItem.module.css";
import { secondsToTime } from "../../util/util.js";
import { put } from "../../util/api.js";

function OrderItem({ ...product }) {
  const [item, setItem] = useState(product);

  function onButtonClick() {
    let currentTime = new Date();

    if (item.startedTime === "" && item.finishedTime === "") {
      setItem({ ...item, startedTime: currentTime });
    } else {
      const endTime =
        (currentTime.getTime() - item.startedTime.getTime()) / 1000;

      setItem({ ...item, finishedTime: endTime });
    }
    console.log(item._id);
    let id = item._id;
    updateOrder();
    async function updateOrder() {
      const res = await put("/data/workerSequence/" + id, item);
      const data = await res.json();
      console.log(data);
    }
  }

  let time = secondsToTime(item.finishedTime);

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
          <span>Finished in: </span>
          {time}
        </p>
      </div>

      <div className={styles.description}>
        <span>Description:</span>
        {product.description}
      </div>
      <div className={styles.timer}>
        <button
          className={styles.startBtn}
          onClick={onButtonClick}
          disabled={!!item.finishedTime}
        >
          {item.startedTime === "" && item.finishedTime === "" && "Start"}
          {item.startedTime !== "" && item.finishedTime === "" && "In Progress"}
          {item.startedTime !== "" && item.finishedTime !== "" && "Finished"}
        </button>
      </div>
    </figure>
  );
}

export default OrderItem;
