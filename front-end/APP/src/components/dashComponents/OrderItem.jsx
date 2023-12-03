import { useContext, useEffect, useState } from "react";
import styles from "./OrderItem.module.css";
import { secondsToTime } from "../../util/util.js";
import { UserContext } from "../../context/GlobalUserProvider.jsx";
import { useNavigate } from "react-router-dom";
import { put } from "../../util/api.js";
import { environment } from "../../environments/environment_dev.js";
import LoaderWheel from "../LoaderWheel.jsx";

function OrderItem({ product, onBtnHandler, orderId }) {
  const { user } = useContext(UserContext);
  const [index, setIndex] = useState(null);
  const [item, setItem] = useState("");
  const [id, setId] = useState("");
  const [isDone, setIsDone] = useState(false);
  const [loading, setLoading] = useState(false);

  let newProduct = {};

  useEffect(function () {
    const abortController = new AbortController();

    if (user.department === "Frames") {
      setItem(product.orderStates[0]);
      setIndex(0);
      setId(product.id);
    }
    if (user.department === "Wheels") {
      setItem(product.orderStates[1]);
      setIndex(1);
    }
    if (user.department === "Accessory") {
      setItem(product.orderStates[2]);
      setIndex(2);
    }

    return () => abortController.abort();
  }, []);

  useEffect(
    function () {
      if (item.isProduced) {
        // make copy on original object
        newProduct = { ...product };

        // replace array data with modified in state
        newProduct.orderStates[index] = item;
        // console.log(newProduct);

        // write data to database
        finishedJob(id);
        // rerender parent component
        onBtnHandler();
      }
    },
    [isDone]
  );

  function onButtonClick() {
    let currentDate = new Date();
    // console.log("in btn");

    if (item.startedTime === "" && item.finishedTime === "") {
      setItem({
        ...item,
        startedTime: currentDate,
        nameOfEmplоyeeProducedThePart: `${user.firstName} ${user.lastName}`,
      });
    }
    if (item.startedTime !== "" && item.finishedTime === "") {
      setItem({ ...item, finishedTime: currentDate, isProduced: true });
      setIsDone(true);
    }
  }

  async function finishedJob(id) {
    setLoading(true);
    // console.log("request");

    try {
      const result = await put(environment.in_progress + id, newProduct);
      // console.log(result);
    } catch (err) {
      console.error(err);
    } finally {
      setLoading(false);
    }
  }

  return (
    <>
      {loading && <LoaderWheel />}
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
        </div>
        <div className={styles.info}>
          <p className={styles.model}>
            <span>Started on: </span>
            {item.startedTime &&
              item.startedTime
                .toLocaleString()
                .split(", ")[0]
                .replaceAll("/", ".")}
          </p>
          <p className={styles.model}>
            <span>Finished on: </span>
            {item.finishedTime &&
              item.finishedTime.toLocaleString().split(", ")[0]}
          </p>
          {/* <p className={styles.partId}>ID# {item.partId}</p> */}
          <p className={styles.partId}>ID# {orderId + "-" + item.partId}</p>
        </div>

        <div className={styles.timer}>
          <p className={styles.prod}>
            <span>Produced by: </span>
            {item.nameOfEmplоyeeProducedThePart}
          </p>
          <button
            className={styles.startBtn}
            onClick={onButtonClick}
            disabled={item.isProduced}
          >
            {item.startedTime === "" && item.finishedTime === "" && "Start"}
            {item.startedTime !== "" &&
              item.finishedTime === "" &&
              "In Progress"}
            {item.startedTime !== "" && item.finishedTime !== "" && "Finished"}
          </button>
        </div>

        <img className={styles.background} src="/img/bg-bike.webp" alt="" />
      </figure>
    </>
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
