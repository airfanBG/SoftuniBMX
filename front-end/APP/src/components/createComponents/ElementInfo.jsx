import styles from "./ElementInfo.module.css";

function ElementInfo({ data }) {
  return (
    <div className={styles.frameInfo}>
      <div className={styles.infoBox}>
        <div className={styles.info}>
          <span className={styles.label}>Brand</span>
          {data.name}
        </div>

        <div className={styles.info}>
          <span className={styles.label}>Model/OEM number</span>
          {data.oem}
        </div>
      </div>
      {/* TODO: missing rating */}
      <div className={`${styles.info} ${styles.price}`}>
        <span className={styles.label}>Price</span>
        {data.price}
      </div>

      <div className={`${styles.info} ${styles.description}`}>
        <span className={styles.label}>Description</span>
        {data.description}
      </div>
    </div>
  );
}

export default ElementInfo;
