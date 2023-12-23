import styles from "./Order.module.css";

import Button from "../../Button.jsx";
import {
  onDeleteHandler,
  onRejectHandler,
  approveHandlerAction,
} from "./managerActions/orderActions.js";

function Order({ order, onStatusChange, isRejected = true, isDeleted = true }) {
  const { orderId, dateCreated, serialNumber, orderParts } = order;
  const frame = orderParts[0];
  const wheel = orderParts[1];
  const accessory = orderParts[2];

  async function onBtnClickHandler(type, orderId) {
    let result = {};
    if (type === "approve") {
      result = await approveHandlerAction(orderId);
      console.log(result);
      onStatusChange();
    } else if (type === "reject") {
      result = await onRejectHandler(orderId);
      console.log(result);
      onStatusChange();
    } else if (type === "delete") {
      if (window.confirm("Delete this order?")) {
        result = await onDeleteHandler(orderId);
        console.log(result);
        onStatusChange();
      }
    }
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
            <span>Order date </span>
            {dateCreated.split(" ")[0]}
          </p>
          <p>
            <span>SN# </span>
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
                {frame.description}
              </p>
              <div className={styles.qtyBlock}>
                <p
                  className={`${styles.qty} ${
                    frame.partQuantity > frame.partQunatityInStock
                      ? styles.notEnough
                      : null
                  }`}
                >
                  <span
                    className={`${
                      frame.partQuantity > frame.partQunatityInStock
                        ? styles.notEnough
                        : null
                    }`}
                  >
                    Available:
                  </span>
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
                {wheel.description}
              </p>
              <div className={styles.qtyBlock}>
                <p
                  className={`${styles.qty} ${
                    wheel.partQuantity > wheel.partQunatityInStock
                      ? styles.notEnough
                      : null
                  }`}
                >
                  <span
                    className={`${
                      wheel.partQuantity > wheel.partQunatityInStock
                        ? styles.notEnough
                        : null
                    }`}
                  >
                    Available:
                  </span>
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
                {accessory.description}
              </p>
              <div className={styles.qtyBlock}>
                <p
                  className={`${styles.qty} ${
                    accessory.partQuantity > accessory.partQunatityInStock
                      ? styles.notEnough
                      : null
                  }`}
                >
                  <span
                    className={`${
                      accessory.partQuantity > accessory.partQunatityInStock
                        ? styles.notEnough
                        : null
                    }`}
                  >
                    Available:
                  </span>
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
            {isDeleted && (
              <Button
                type={"approve"}
                onClick={onBtnClickHandler}
                // onClick={() => approveHandler(id)}
                id={orderId}
                disabled={
                  frame.partQuantity > frame.partQunatityInStock ||
                  wheel.partQuantity > wheel.partQunatityInStock ||
                  accessory.partQuantity > accessory.partQunatityInStock
                }
              >
                Approve
              </Button>
            )}

            {isRejected && (
              <Button type={"reject"} onClick={onBtnClickHandler} id={orderId}>
                {/* <Button type={"reject"} onClick={() => rejectHandler(id)} id={id}> */}
                Reject
              </Button>
            )}

            {isDeleted && (
              <Button type={"delete"} onClick={onBtnClickHandler} id={orderId}>
                {/* <Button type={"delete"} onClick={() => deleteHandler(id)} id={id}> */}
                Delete
              </Button>
            )}
          </div>
        </section>
      </div>
    </>
  );
}

export default Order;
