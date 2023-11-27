import styles from "./Employee.module.css";

import { User, CameraPlus } from "@phosphor-icons/react";

function Employee({ emp }) {
  return (
    <figure className={styles.figure}>
      <div className={styles["imgHolder"]}>
        <User size={96} color="#363636" weight="thin" />
      </div>

      <section className={styles.workerInfo}>
        <h2 className={styles.heading}>Worker Name</h2>
        <p className={`${styles.info}`}>worker@email.com</p>
        <p className={`${styles.info}`}>Phone: 0478493747</p>
        <p className={`${styles.info}`}>Department: Frames</p>
        <p className={`${styles.info}`}>Date of hiring: 03/09/2000</p>
      </section>
    </figure>
  );
}

export default Employee;
