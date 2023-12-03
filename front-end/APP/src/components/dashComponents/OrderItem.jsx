import { useContext, useEffect, useState } from "react";
import styles from "./OrderItem.module.css";
import { secondsToTime } from "../../util/util.js";
import { UserContext } from "../../context/GlobalUserProvider.jsx";

function OrderItem({ ...product }) {
  const { user } = useContext(UserContext);

  const [item, setItem] = useState("");
  let started = new Date().toLocaleDateString();

  useEffect(function () {
    const abortController = new AbortController();

    if (user.department === "Frames") {
      setItem(product.orderStates[0]);
    }
    if (user.department === "Wheels") {
      setItem(product.orderStates[1]);
    }
    if (user.department === "Accessory") {
      setItem(product.orderStates[2]);
    }

    return () => abortController.abort();
  }, []);

  function onButtonClick() {
    let currentTime = new Date();

    if (item.startedTime === "" && item.finishedTime === "") {
      setItem({ ...item, startedTime: currentTime });
    } else {
      const endTime =
        (currentTime.getTime() - item.startedTime.getTime()) / 1000;

      setItem({ ...item, finishedTime: endTime });
    }
    console.log(item.id);
    let id = item.id;
    // updateOrder();
    // async function updateOrder() {
    //   const res = await put("/data/workerSequence/" + id, item);
    //   const data = await res.json();
    //   console.log(data);
    // }
  }

  let time = secondsToTime(item.finishedTime);
  console.log(item);

  return (
    <figure className={styles.order}>
      <div className={styles.info}>
        <h3 className={styles.brand}>
          <span>Brand: </span>
          {item.partType}
        </h3>
        <p className={styles.model}>
          <span>Model: </span>
          {item.partModel}
        </p>
        <p className={styles.model}>
          <span>Started on: </span>
          {new Date().toLocaleDateString(item.startedTime)}
        </p>
        <p className={styles.model}>
          <span>Finished on: </span>
          {new Date().toLocaleDateString(item.finishedTime)}
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

// {
//   "partId": 2,
//   "partType": "Wheel",
//   "partModel": "Wheel of the Year",
//   "nameOfEmplоyeeProducedThePart": " ",
//   "isProduced": false,
//   "startedTime": "",
//   "finishedTime": ""
// }
