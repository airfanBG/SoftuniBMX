import styles from "./ReadyOrder.module.css";

import { useState } from "react";

import { formatCurrency } from "../../../util/resolvers.js";
import Popup from "../../Popup.jsx";

function ReadyOrder({ order }) {
  const [background, setBackground] = useState(false);

  function close(e) {
    setBackground(false);
  }
  return (
    <>
      {background && (
        <Popup onClose={close}>
          <div className={styles.fullImg}>
            <img src="https://yuchormanski.free.bg/bikes/bike-1.webp" alt="" />
          </div>
        </Popup>
      )}

      <div className={styles.box}>
        <div className={styles.additional}>
          <p>
            <span>Order ID: </span>
            {order.orderId}
          </p>
          <p>
            <span>Order date </span>
            {order.orderDate.replaceAll("/", ".")}
          </p>
          <p>
            <span>SN# </span>
            {order.serialNumber}
          </p>
        </div>
        <section className={styles.section}>
          <div className={styles.itemInfo}>
            <div className={styles.info}>
              <p className={styles.content}>
                <span>Frame:</span>
                {order.parts.at(0).name}
              </p>
              <p className={styles.content}>
                <span>Wheels:</span>
                {order.parts.at(1).name}
              </p>
              <p className={styles.content}>
                <span>Accessory:</span>
                {order.parts.at(2).name}
              </p>
            </div>
            <div className={styles.action}>
              <p className={styles.content}>
                <span>Total:</span>
                {formatCurrency(order.amount)}
              </p>
              <p className={styles.content}>
                <span>Paid:</span>
                {formatCurrency(order.paidAmount)}
              </p>
              <button className={styles.btn}>
                <span>rest:</span>
                {formatCurrency(order.unpaidAmount)}
              </button>
            </div>
          </div>
          <div className={styles.imageHolder}>
            <img
              onClick={() => setBackground(true)}
              className={styles.img}
              src="https://yuchormanski.free.bg/bikes/bike-1.webp"
              alt="Image on user's ordered bike"
            />
          </div>
        </section>
      </div>
    </>
  );
}

export default ReadyOrder;
