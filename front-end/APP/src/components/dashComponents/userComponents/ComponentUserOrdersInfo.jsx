import styles from "./ComponentUserOrdersInfo.module.css";

import React from "react";

function ComponentUserOrderInfo({ data }) {
  return (
    <>
      <section>
        <div className={styles.orderContainer}>
          <h2>Order {data.serialNumber}</h2>
          <div className={styles.orderDetails}>
            <div>
              <strong>Description:</strong> {data.description}
            </div>
            <div>
              <strong>Amount:</strong> {data.finalAmount}
            </div>
            <div>
              <strong>Unpaid Amount:</strong> {data.unpaidAmount}
            </div>
            <div>
              <strong>Status:</strong> {data.status}
            </div>
            <div>
              <strong>Date Created:</strong> {data.dateCreated}
            </div>
            <div>
              <strong>Date Finished:</strong> {data.dateFinished}
            </div>
          </div>
        </div>
      </section>
    </>
  );
}

export default ComponentUserOrderInfo;
