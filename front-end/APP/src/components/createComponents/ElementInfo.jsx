import StarsRating from "../Stars.jsx";
import styles from "./ElementInfo.module.css";
const color = {
  backgroundColor: "yellow",
};
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
          {data.oemNumber}
        </div>
      </div>
      <div className={styles.price}>
        <div className={`${styles.info} `}>
          {/* <div className={`${styles.info} ${styles.price}`}> */}
          <span className={styles.label}>Price</span>
          {data.salesPrice}
        </div>
        <StarsRating
          size={20}
          defaultRating={data.rating}
          color="#FFA81E"
          className={"stars"}
        />
      </div>

      <p className={styles.intend}>
        <span className={styles.label}>Intended for:</span>
        {data.intend}
      </p>

      <div className={`${styles.info} ${styles.description}`}>
        <span className={styles.label}>Description</span>
        {data.description}
      </div>
    </div>
  );
}

export default ElementInfo;
