import { useState, useContext } from "react";
import styles from "./OrderInProgress.module.css";

import { UserContext } from "../../../context/GlobalUserProvider.jsx";

function OrderInProgress({ order, i, onOrderButtonClick }) {
  const { user } = useContext(UserContext);

  function statusCheck(index) {
    const base = order.orderStates;

    let result = null;

    if (base[index].isProduced) {
      result = <span className={styles.icon}>&#10004;</span>;
    } else if (base[index].startDate === null && base[index].endDate === null) {
      result = (
        <span
          className={`${styles.ionIcon} ${styles.preview} ${
            base[index].description ? styles.returned : null
          }`}
        >
          <ion-icon name="hourglass-outline"></ion-icon>
        </span>
      );
    } else if (base[index].startDate !== null && base[index].endDate === null) {
      result = (
        <span
          className={`${styles.ionIcon} ${styles.started} ${
            base[index].description ? styles.returned : null
          }`}
        >
          <ion-icon name="hammer-outline"></ion-icon>
        </span>
      );
    }
    return result;
  }

  return (
    <>
      <div className={styles.orderLine}>
        <p>#{order.orderId}.</p>
        <p className={styles.serial}>
          <span>SN:</span>
          {order.serialNumber}
        </p>
        <div className={styles.figureLine}>
          <div className={styles.circle}>
            {statusCheck(0)}
            <span>Frame</span>
          </div>

          <div className={styles.line}></div>
          <div className={styles.circle}>
            {statusCheck(1)}
            <span>Wheels</span>
          </div>
          <div className={styles.line}></div>
          <div className={styles.circle}>
            {statusCheck(2)}
            <span>Accessory</span>
          </div>
        </div>

        <p className={styles.dateCreated}>
          <span>Date Created:</span>
          {order.dateCreated.split(" ").at(0).replaceAll("/", ".")}
        </p>
        {user.role !== "user" && (
          <button
            className={styles.btn}
            onClick={() => onOrderButtonClick(order)}
          >
            More Info
          </button>
        )}
      </div>
    </>
  );
}

export default OrderInProgress;
