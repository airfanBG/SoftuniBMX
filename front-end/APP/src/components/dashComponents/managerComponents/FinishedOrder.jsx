import { useState, useContext } from "react";
import styles from "./FinishedOrder.module.css";

import { UserContext } from "../../../context/GlobalUserProvider.jsx";

function FinishedOrder({ order, i, onOrderButtonClick }) {
  const { user } = useContext(UserContext);

  return (
    <>
      <div className={styles.orderLine}>
        <p>#{order.orderId}.</p>
        <p className={styles.serial}>
          <span>SN:</span>
          {order.serialNumber}
        </p>
        <p className={styles.dateCreated}>
          <span>Date Created:</span>
          {order.dateCreated.split(" ").at(0).replaceAll("/", ".")}
        </p>
        <p className={styles.dateCreated}>
          <span>DateFinished:</span>
          {order.dateFinished.split(" ").at(0).replaceAll("/", ".")}
        </p>
        <p className={styles.serial}>
          <span>Sale amount:</span>
          {order.saleAmount}.00 BGN
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

export default FinishedOrder;
