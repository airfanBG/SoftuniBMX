import { useState, useContext } from "react";
import styles from "./PartInWarehouse.module.css";


function PartInWarehouse({ part, i }) {


  return (
    <>
      <div className={styles.orderLine}>
        <p>#{part.id}.</p>
        <p className={styles.serial}>
          <span>SN:</span>
          {part.oemNumber}
        </p>
        <p className={styles.serial}>
          <span>Quantity:</span>
          {part.quantity}
        </p>
        <p className={styles.serial}>
          <span>Name:</span>
          {part.name}
        </p>
        <p className={styles.serial}>
          <span>Category:</span>
          {part.category}
        </p>
      </div>
    </>
  );
}

export default PartInWarehouse;
