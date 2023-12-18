import { useState } from "react";
import styles from "./OrderInProgress.module.css";

function OrderInProgress({ order, i, onOrderButtonClick }) {
  const [frame, setFrame] = useState(false);
  const [wheel, setWheel] = useState(false);
  const [parts, setParts] = useState(false);

  function statusCheck(index) {
    const base = order.orderParts;
    let result = null;
    if (base[index].isComplete) {
      return (result = "&#10004;");
    } else if (base[index].startDate === null && base[index].endDate === null) {
      return (result = <ion-icon name="hourglass-outline"></ion-icon>);
    } else if (base[index].startDate !== null && base[index].endDate === null) {
      return (result = <ion-icon name="hammer-outline"></ion-icon>);
    }
  }

  return (
    <>
      <div className={styles.orderLine}>
        <p>#{i}.</p>
        <p className={styles.serial}>
          <span>SN:</span>
          {order.serialNumber}
        </p>

        <div className={styles.figureLine}>
          <div className={styles.circle}>
            {order.orderParts[0].isComplete ? (
              <span className={styles.icon}>&#10004;</span>
            ) : order.orderParts[0].startDate === null &&
              order.orderParts[0].endDate === null ? (
              <span className={`${styles.ionIcon} ${styles.preview}`}>
                <ion-icon name="hourglass-outline"></ion-icon>
              </span>
            ) : (
              <span className={`${styles.ionIcon} ${styles.started}`}>
                <ion-icon name="hammer-outline"></ion-icon>
              </span>
            )}
            {/* <span>{order.orderStates[0].partType}</span> */}
            <span>Frame</span>
          </div>
          <div className={styles.line}></div>
          <div className={styles.circle}>
            {order.orderParts[1].isComplete ? (
              <span className={styles.icon}>&#10004;</span>
            ) : order.orderParts[1].startDate === null &&
              order.orderParts[1].endDate === null ? (
              <span className={`${styles.ionIcon} ${styles.preview}`}>
                <ion-icon name="hourglass-outline"></ion-icon>
              </span>
            ) : (
              <span className={`${styles.ionIcon} ${styles.started}`}>
                <ion-icon name="hammer-outline"></ion-icon>
              </span>
            )}
            {/* <span>{order.orderStates[1].partType}</span> */}
            <span>Wheels</span>
          </div>
          <div className={styles.line}></div>
          <div className={styles.circle}>
            {order.orderParts[2].isComplete ? (
              <span className={styles.icon}>&#10004;</span>
            ) : order.orderParts[2].startDate === null &&
              order.orderParts[2].endDate === null ? (
              <span className={`${styles.ionIcon} ${styles.preview}`}>
                <ion-icon name="hourglass-outline"></ion-icon>
              </span>
            ) : (
              <span className={`${styles.ionIcon} ${styles.started}`}>
                <ion-icon name="hammer-outline"></ion-icon>
              </span>
            )}
            {/* <span>{order.orderStates[2].partType}</span> */}
            <span>Accessory</span>
          </div>
        </div>

        <p className={styles.dateCreated}>
          <span>Date Created:</span>
          {order.dateCreated.split(" ").at(0).replaceAll("-", ".")}
        </p>
        <button
          className={styles.btn}
          onClick={() => onOrderButtonClick(order)}
        >
          More Info
        </button>
      </div>
    </>
  );
}

export default OrderInProgress;
