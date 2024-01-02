import { useState, useContext } from "react";
import styles from "./FinishedOrder.module.css";

import { UserContext } from "../../../context/GlobalUserProvider.jsx";

function FinishedOrder({ order, i, onOrderButtonClick }) {
  const { user } = useContext(UserContext);

  return (
    <>
      <div className={styles.orderLine}>
        <p className={styles.serial}>
          <span>#ON:</span>
          {order.orderId}
        </p>
        <p className={styles.serial}>
          <span>SN:</span>
          {order.serialNumber}
        </p>
        <p className={styles.dateCreated}>
          <span>Created:</span>
          {order.dateCreated.split(" ").at(0).replaceAll("/", ".")}
        </p>
        <p className={styles.dateCreated}>
          <span>Finished:</span>
          {order.dateFinished.split(" ").at(0).replaceAll("/", ".")}
        </p>
        <p className={styles.dateCreated}>
          <span>Total time:</span>
          {order.totalProductionTime}
        </p>
        <p className={styles.serial}>
          <span className={styles.label}>Client:</span>
          {order.clientName}
        </p>
        {/* <p className={styles.serial}>
          <span className={styles.label}>Email:</span>
          {order.clientEmail}
        </p> */}
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

export default FinishedOrder;
