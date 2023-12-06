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
  // const { orders, onOrdersChange } = useContext(OrdersContext);
  const { orderId, serialNumber, orderParts } = order;
  const frame = orderParts[0];
  const wheel = orderParts[1];
  const accessory = orderParts[2];

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
            {orderId}
          </p>
          <p>
            <span>SN: </span>
            {serialNumber}
          </p>
        </div>

        <section className={styles.section}>
          <div className={styles.itemInfo}>
            <div className={styles.info}>
              <p className={styles.content}>
                <span>Frame:</span>
                {frame.partName}
              </p>
              <p className={styles.content}>
                <span>Client request:</span>
                {frame.descrioption}
              </p>
              <div className={styles.qtyBlock}>
                <p className={styles.qty}>
                  <span>Available:</span>
                  {frame.partQunatityInStock}
                </p>
                <p className={styles.qty}>
                  <span>Qty:</span>
                  {frame.partQuantity}
                </p>
              </div>
            </div>

            <div className={styles.info}>
              <p className={styles.content}>
                <span>Wheel:</span>
                {wheel.partName}
              </p>
              <p className={styles.content}>
                <span>Client request:</span>
                {wheel.descrioption}
              </p>
              <div className={styles.qtyBlock}>
                <p className={styles.qty}>
                  <span>Available:</span>
                  {wheel.partQunatityInStock}
                </p>
                <p className={styles.qty}>
                  <span>Qty:</span>
                  {wheel.partQuantity}
                </p>
              </div>
            </div>

            <div id={"accessory"} className={styles.info}>
              <p className={styles.content}>
                <span>Accessory:</span>
                {accessory.partName}
              </p>
              <p className={styles.content}>
                <span>Client request:</span>
                {accessory.descrioption}
              </p>
              <div className={styles.qtyBlock}>
                <p className={styles.qty}>
                  <span>Available:</span>
                  {accessory.partQunatityInStock}
                </p>
                <p className={styles.qty}>
                  <span>Qty:</span>
                  {accessory.partQuantity}
                </p>
              </div>
            </div>
          </div>

          <div className={styles.actions}>
            <Button
              type={"approve"}
              onClick={() => approveHandler(order)}
              id={orderId}
              disabled={
                frame.partQuantity > frame.partQunatityInStock ||
                wheel.partQuantity > wheel.partQunatityInStock ||
                accessory.partQuantity > accessory.partQunatityInStock
              }
            >
              Approve
            </Button>
            <Button type={"reject"} onClick={onRejectHandler} id={orderId}>
              Reject
            </Button>
            <Button type={"delete"} onClick={onDeleteHandler} id={orderId}>
              Delete
            </Button>
          </div>
        </section>
      </div>
    </>
  );
}

export default Order;

// [
//   {
//       "orderId": 3,
//       "serialNumber": "BID12345680",
//       "orderParts": [
//           {
//               "partId": 1,
//               "descrioption": "test",
//               "partName": "Frame OG",
//               "partQuantity": 1,
//               "partQunatityInStock": 2
//           },
//           {
//               "partId": 5,
//               "descrioption": "test",
//               "partName": "Wheel of the Year for montain",
//               "partQuantity": 6,
//               "partQunatityInStock": 40
//           },
//           {
//               "partId": 11,
//               "descrioption": "test",
//               "partName": "Road budget Shifts",
//               "partQuantity": 4,
//               "partQunatityInStock": 21
//           }
//       ]
//   }
// ]
