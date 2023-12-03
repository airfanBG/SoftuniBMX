import { useContext, useEffect, useState } from "react";
import styles from "./Order.module.css";

import Button from "../../Button.jsx";
import {
  onDeleteHandler,
  onRejectHandler,
  useApproveHandler,
} from "../../../customHooks/orderActions.js";
import { OrdersContext } from "../../../context/GlobalUserProvider.jsx";

function Order({ order }) {
  // const { frame, wheel, accessory, ownerId, id } = order;
  const { orders, onOrdersChange } = useContext(OrdersContext);
  const { frame, wheel, accessory, createdAt, count, ownerId, id } = order;

  async function approveHandler(id) {
    // const approvedOrder = {
    //   frame,
    //   wheel,
    //   accessory,
    //   frameStartedTime: "",
    //   frameFinishedTime: "",
    //   wheelStartedTime: "",
    //   wheelFinishedTime: "",
    //   accessoryStartedTime: "",
    //   accessoryFinishedTime: "",
    //   count,
    //   createdAt,
    //   id: id,
    //   customerId: ownerId,
    // };

    // console.log(approvedOrder);
    console.log(id);

    // const approve = await del(environment.del_order + id);
    // console.log(approve);
    // onApprove((o) => Object.values((orders) => console.log(x)));
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
                {frame.oemNumber}
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
                {wheel.oemNumber}
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
                {accessory.oemNumber}
              </p>
              <p className={styles.qty}>Qty: 2</p>
            </div>
          </div>

          <div className={styles.actions}>
            <Button
              type={"approve"}
              onClick={() => approveHandler(order)}
              id={id}
            >
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
