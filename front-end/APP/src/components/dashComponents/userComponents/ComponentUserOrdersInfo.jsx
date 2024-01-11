import styles from "./ComponentUserOrdersInfo.module.css";

import React from "react";

function ComponentUserOrderInfo({ data }) {
  return (
    <>
      <section>
        <div className={styles.orderContainer}>
          <h2>Order {data.serialNumber}</h2>
          <div className={styles.orderDetails}>
            <p>
              <strong>Description:</strong> {data.description}
            </p>
            <p>
              <strong>Amount:</strong> {data.finalAmount}
            </p>
            <p>
              <strong>Unpaid Amount:</strong> {data.unpaidAmount}
            </p>
            <p>
              <strong>Status:</strong> {data.status}
            </p>
            <p>
              <strong>Date Created:</strong> {data.dateCreated}
            </p>
            <p>
              <strong>Date Finished:</strong> {data.dateFinished}
            </p>
          </div>
        </div>
      </section>
    </>
  );
}

export default ComponentUserOrderInfo;
