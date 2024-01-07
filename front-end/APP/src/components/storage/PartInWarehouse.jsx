import { useState, useContext } from "react";
import styles from "./PartInWarehouse.module.css";

function PartInWarehouse({ part }) {
  return (
    <>
      <div className={styles.box}>
        <div className={styles.additional}>
          <p>
            <span>#ID: </span>
            {part.id}
          </p>
          <p>
            <span>Intended: </span>
            {part.intend}
          </p>
          <p>
            <span>SN# </span>
            {part.oemNumber}
          </p>
        </div>

        <section className={styles.section}>
          <div className={styles.itemInfo}>
            <div className={styles.info}>
              <p className={styles.content}>
                <span>Part name:</span>
                {part.name}
              </p>
              <p className={styles.content}>
                <span>Description:</span>
                {part.description}
              </p>
              <div className={styles.category}>
                <span>Category:</span>
                <p className={styles.catContent}>{part.category}</p>
              </div>
            </div>

            <div className={styles.info}>
              <p className={styles.content}>
                <span>Rating:</span>
                {part.rating}
              </p>
              <p className={styles.content}>
                <span>Sale price:</span>
                {part.salePrice}.00 BGN
              </p>
              <div className={styles.qtyBlock}>
                <p
                  className={`${styles.qty} ${
                    part.quantity < 6 ? styles.notEnough : null
                  }`}
                >
                  <span
                    className={`${part.quantity < 6 ? styles.notEnough : null}`}
                  >
                    Parts in stock:
                  </span>
                  {part.quantity} pcs.
                </p>
              </div>
            </div>
          </div>
          <div className={styles.picture}>
            <img
              src={part.imageUrls[0]}
              alt={part.category}
              className={styles["card-img"]}
            />
          </div>
        </section>
      </div>
    </>
  );
}

export default PartInWarehouse;
