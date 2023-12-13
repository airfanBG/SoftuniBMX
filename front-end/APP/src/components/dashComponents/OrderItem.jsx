import styles from "./OrderItem.module.css";

import { useContext, useEffect, useState } from "react";
import { secondsToTime } from "../../util/util.js";
import { UserContext } from "../../context/GlobalUserProvider.jsx";
import { useNavigate } from "react-router-dom";
import { put } from "../../util/api.js";
import { environment } from "../../environments/environment.js";
import LoaderWheel from "../LoaderWheel.jsx";

function OrderItem({ product, onBtnHandler, orderId, orderIndex }) {
  const { user } = useContext(UserContext);
  const [index, setIndex] = useState(null);
  const [item, setItem] = useState("");
  const [firstCall, setFirstCall] = useState(false);
  const [isDone, setIsDone] = useState(false);
  const [loading, setLoading] = useState(false);
  const [meta, setMeta] = useState({});

  let newProduct = {};

  // useEffect(function () {
  //   const abortController = new AbortController();
  //   // setId(product.id);
  //   console.log(product);

  //   setMeta({
  //     id: product.partId,
  //     dateCreated: product.datetimeAsigned,
  //     serialNumber: product.orderSerialNumber,
  //   });

  //   setItem(product);
  //   setIndex(0);

  //   return () => abortController.abort();
  // }, []);

  //   {
  //     "orderSerialNumber": "BID12345679",
  //     "partId": 1,
  //     "partName": "Frame Road",
  //     "partOEMNumber": "oemtest1",
  //     "quantity": 1,
  //     "datetimeAsigned": "13/12/2023 20:40",
  //     "datetimeFinished": null,
  //     "description": null
  // }

  useEffect(
    function () {
      if (item.isProduced || firstCall) {
        // make copy on original object
        newProduct = { ...product };

        // replace array data with modified in state
        newProduct.orderStates[index] = item;
        // console.log(newProduct);

        // write data to database
        finishedJob(meta.id);
        // rerender parent component
        onBtnHandler();
      }
    },
    [isDone, firstCall]
  );

  function onButtonClick() {
    let currentDate = new Date().getTime();
    // let currentDate = new Date();
    // console.log("in btn");

    if (item.startedTime === "" && item.finishedTime === "") {
      setItem({
        ...item,
        startedTime: currentDate,
        nameOfEmplоyeeProducedThePart: `${user.firstName} ${user.lastName}`,
      });
      setFirstCall(!firstCall);
    } else if (item.startedTime !== "" && item.finishedTime === "") {
      setItem({ ...item, finishedTime: currentDate, isProduced: true });
      setIsDone(!isDone);
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
        <header className={styles.header}>
          <p className={styles.model}>
            <span>SN: </span>
            {product.orderSerialNumber}
          </p>
          {/* <p className={styles.model}>
            <span>Date created: </span>
            {product.dateCreated}
          </p> */}
        </header>

        {/* <div className={styles.info}> */}
        <h3 className={styles.brand}>
          <span>Brand: </span>
          {product.partName}
        </h3>
        <p className={styles.model}>
          <span>OEM Number: </span>
          {product.partOEMNumber}
        </p>
        <div className={styles.model}>
          <span>Description:</span>
          {product.description}
        </div>
        {/* </div> */}
        {/* <div className={styles.info}> */}
        <p className={styles.model}>
          <span>Started on: </span>
          {product.datetimeAsigned &&
            product.datetimeAsigned.replaceAll("/", ".")}
        </p>
        <p className={`${styles.model} ${styles.shortLine}`}>
          <span>Finished on: </span>
          {product.datetimeFinished &&
            product.datetimeFinished.replaceAll("/", ".")}
        </p>
        {/* <p className={styles.partId}>ID# {item.partId}</p> */}
        <p className={styles.partId}>ID# {orderId + "-" + item.partId}</p>
        {/* </div> */}

        <div className={styles.timer}>
          <p className={styles.prod}>
            <span>Produced by: </span>
            {`${user.firstName} ${user.lastName}`}
          </p>
          <button
            className={styles.startBtn}
            onClick={onButtonClick}
            disabled={orderIndex !== 0}
          >
            {/* {product.datetimeAsigned === "" &&
              product.datetimeFinished === "" &&
              orderIndex !== 0 &&
              "to Queue"}
            {product.datetimeAsigned === "" &&
              product.datetimeFinished === "" &&
              orderIndex === 0 &&
              "Start"}
            {product.datetimeAsigned !== "" &&
              product.datetimeFinished === "" &&
              "In Progress"}
            {product.datetimeAsigned !== "" &&
              product.datetimeFinished !== "" &&
              "Finished"} */}
            {orderIndex === 0 && !product.datetimeAsigned && "Start"}
            {orderIndex === 0 && product.datetimeAsigned && "In Progress"}
            {orderIndex !== 0 && "to Queue"}
          </button>
        </div>

        <img className={styles.background} src="/img/bg-bike.webp" alt="" />
      </figure>
    </>
  );
}

export default OrderItem;
