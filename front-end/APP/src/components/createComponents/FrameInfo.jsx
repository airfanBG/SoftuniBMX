import styles from "./FrameInfo.module.css";

function FrameInfo({ frame }) {
  return (
    <div className={styles.frameInfo}>
      <div className={styles.infoBox}>
        <div className={styles.info}>
          <span className={styles.label}>Brand</span>
          {frame.name}
        </div>

        <div className={styles.info}>
          <span className={styles.label}>Model/OEM number</span>
          {frame.oem}
        </div>
      </div>

      <div className={`${styles.info} ${styles.price}`}>
        <span className={styles.label}>Price</span>
        {frame.price}
      </div>

      <div className={`${styles.info} ${styles.description}`}>
        <span className={styles.label}>Description</span>
        {frame.description}
      </div>
    </div>
  );
}

export default FrameInfo;
