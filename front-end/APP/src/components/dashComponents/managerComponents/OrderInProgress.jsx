import { useState, useContext } from "react";
import styles from "./OrderInProgress.module.css";

import { UserContext } from "../../../context/GlobalUserProvider.jsx";

function OrderInProgress({ order, i, onOrderButtonClick }) {
  const [frame, setFrame] = useState(false);
  const [wheel, setWheel] = useState(false);
  const [parts, setParts] = useState(false);
  const { user } = useContext(UserContext);

  function statusCheck(index) {
    const base = order.orderStates;

    let result = null;

    if (base[index].isProduced) {
      return (result = <span className={styles.icon}>&#10004;</span>);
    } else if (base[index].startDate === null && base[index].endDate === null) {
      return (result = (
        <span className={`${styles.ionIcon} ${styles.preview}`}>
          <ion-icon name="hourglass-outline"></ion-icon>
        </span>
      ));
    } else if (base[index].startDate !== null && base[index].endDate === null) {
      return (result = (
        <span className={`${styles.ionIcon} ${styles.started}`}>
          <ion-icon name="hammer-outline"></ion-icon>
        </span>
      ));
    }
  }

  console.log(order);

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
            {/* {order.orderStates[0].isProduced ? (
              <span className={styles.icon}>&#10004;</span>
            ) : order.orderStates[0].startDate === null &&
              order.orderStates[0].endDate === null ? (
              <span className={`${styles.ionIcon} ${styles.preview}`}>
                <ion-icon name="hourglass-outline"></ion-icon>
              </span>
            ) : (
              <span className={`${styles.ionIcon} ${styles.started}`}>
                <ion-icon name="hammer-outline"></ion-icon>
              </span>
            )} */}
            {statusCheck(0)}
            {/* <span>{order.orderStates[0].partType}</span> */}
            <span>Frame</span>
          </div>

          <div className={styles.line}></div>
          <div className={styles.circle}>
            {/* {order.orderStates[1].isProduced ? (
              <span className={styles.icon}>&#10004;</span>
            ) : order.orderStates[1].startDate === null &&
              order.orderStates[1].endDate === null ? (
              <span className={`${styles.ionIcon} ${styles.preview}`}>
                <ion-icon name="hourglass-outline"></ion-icon>
              </span>
            ) : (
              <span className={`${styles.ionIcon} ${styles.started}`}>
                <ion-icon name="hammer-outline"></ion-icon>
              </span>
            )} */}
            {statusCheck(1)}
            {/* <span>{order.orderStates[1].partType}</span> */}
            <span>Wheels</span>
          </div>
          <div className={styles.line}></div>
          <div className={styles.circle}>
            {/* {order.orderStates[2].isProduced ? (
              <span className={styles.icon}>&#10004;</span>
            ) : order.orderStates[2].startDate === null &&
              order.orderStates[2].endDate === null ? (
              <span className={`${styles.ionIcon} ${styles.preview}`}>
                <ion-icon name="hourglass-outline"></ion-icon>
              </span>
            ) : (
              <span className={`${styles.ionIcon} ${styles.started}`}>
                <ion-icon name="hammer-outline"></ion-icon>
              </span>
            )} */}
            {statusCheck(2)}
            {/* <span>{order.orderStates[2].partType}</span> */}
            <span>Accessory</span>
          </div>
        </div>

        <p className={styles.dateCreated}>
          <span>Date Created:</span>
          {order.dateCreated.split(" ").at(0).replaceAll("-", ".")}
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
