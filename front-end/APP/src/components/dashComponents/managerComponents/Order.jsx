import { useEffect, useState } from "react";
import styles from "./Order.module.css";

import Button from "../../Button.jsx";
import {
  onApproveHandler,
  onDeleteHandler,
  onRejectHandler,
} from "./managerActions/orderActions.js";

function Order({ order }) {
  const { frame, wheel, accessory, ownerId, id } = order;

  function buttonApproveHandler() {
    onApproveHandler(order);
  }

  return (
    <>
      <div className={styles.box}>
        <div className={styles.additional}>
          <p>
            <span>Order ID: </span>
            {id}
          </p>
          <p>
            <span>Customer ID: </span>
            {ownerId}
          </p>
        </div>

        <section className={styles.section}>
          <div className={styles.itemInfo}>
            <div className={styles.info}>
              <p className={styles.content}>
                <span>Frame:</span>
                {frame.name}
              </p>
              <p className={styles.content}>
                <span>OEM Number:</span>
                {frame.OEMNumber}
              </p>
              <p className={styles.qty}>Qty: 2</p>
            </div>

            <div id={"wheel"} className={styles.info}>
              <p className={styles.content}>
                <span>Wheels:</span>
                {wheel.name}
              </p>
              <p className={styles.content}>
                <span>OEM Number:</span>
                {wheel.OEMNumber}
              </p>
              <p className={styles.qty}>Qty: 2</p>
            </div>

            <div id={"accessory"} className={styles.info}>
              <p className={styles.content}>
                <span>Accessory:</span>
                {accessory.name}
              </p>
              <p className={styles.content}>
                <span>OEM Number:</span>
                {accessory.OEMNumber}
              </p>
              <p className={styles.qty}>Qty: 2</p>
            </div>
          </div>

          <div className={styles.actions}>
            <Button type={"approve"} onClick={buttonApproveHandler} id={id}>
              Approve
            </Button>
            <Button type={"reject"} onClick={onRejectHandler} id={id}>
              Reject
            </Button>
            <Button type={"delete"} onClick={onDeleteHandler} id={id}>
              Delete
            </Button>
          </div>
        </section>
      </div>
    </>
  );
}

export default Order;
