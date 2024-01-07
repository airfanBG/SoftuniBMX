import { useState, useContext } from "react";
import styles from "./DispathedOrder.module.css";

function DispathedOrder({ order, i }) {
  return (
    <>
      <div className={styles.box}>
        <div className={styles.additional}>
          <p>
            <span>Order ID: </span>
            {order.orderId}
          </p>
          <p>
            <span>Sale amount: </span>
            {order.saleAmount}.00 BGN
          </p>
          <p>
            <span>Bike SN: </span>
            {order.serialNumber}
          </p>
        </div>

        <section className={styles.section}>
          <div className={styles.itemInfo}>
            <div className={styles.info}>
              <p className={styles.content}>
                <span>Client name:</span>
                {order.clientName}
              </p>
              <p className={styles.content}>
                <span>Client email:</span>
                {order.clientEmail}
              </p>
              {/* <div className={styles.itemInfo}> */}
              <p className={styles.content}>
                <span>Client phone:</span>
                {order.clientPhone}
              </p>
              <p className={styles.content}>
                <span>Dispatch date:</span>
                {order.sendDate}
              </p>
              {/* </div> */}
            </div>
            <div className={styles.info}>
              <p className={styles.content}>
                <span>Country:</span>
                {order.clientAdress.country}
              </p>
              <p className={styles.content}>
                <span>District:</span>
                {order.clientAdress.district}
              </p>
              <p className={styles.content}>
                <span>Street name:</span>
                {order.clientAdress.street}
              </p>
              <p className={styles.content}>
                <span>Street number:</span>
                {order.clientAdress.strNumber}
              </p>
            </div>
            <div className={styles.info}>
              <p className={styles.content}>
                <span>Building number:</span>
                {order.clientAdress.block}
              </p>
              <p className={styles.content}>
                <span>Floor:</span>
                {order.clientAdress.floor}
              </p>
              <p className={styles.content}>
                <span>Apartment:</span>
                {order.clientAdress.apartment}
              </p>
            </div>
          </div>
          <div className={styles.picture}>
            <img
              src={order.imageUrl}
              alt={order.serialNumber}
              className={styles["card-img"]}
            />
          </div>
        </section>
      </div>
    </>
  );
}

export default DispathedOrder;
