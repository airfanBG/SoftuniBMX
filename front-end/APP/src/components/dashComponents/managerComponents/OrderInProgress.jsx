import styles from "./OrderInProgress.module.css";

function OrderInProgress({ order, i, onOrderButtonClick }) {
  return (
    <>
      <div className={styles.orderLine}>
        <p>#{i}.</p>
        <p className={styles.serial}>
          <span>SN:</span>
          {order.serialNumber}
        </p>

        <div className={styles.figureLine}>
          <div className={styles.circle}>
            {order.orderStates[0].isProduced ? (
              <span className={styles.icon}>&#10004;</span>
            ) : (
              ""
            )}
            <span>{order.orderStates[0].partType}</span>
          </div>
          <div className={styles.line}></div>
          <div className={styles.circle}>
            {order.orderStates[1].isProduced ? (
              <span className={styles.icon}>&#10004;</span>
            ) : (
              ""
            )}
            <span>{order.orderStates[1].partType}</span>
          </div>
          <div className={styles.line}></div>
          <div className={styles.circle}>
            {order.orderStates[2].isProduced ? (
              <span className={styles.icon}>&#10004;</span>
            ) : (
              ""
            )}
            <span>{order.orderStates[2].partType}</span>
          </div>
        </div>

        <p className={styles.dateCreated}>
          <span>Date Created:</span>
          {order.dateCreated.replaceAll("/", ".")}
        </p>
        <button
          className={styles.btn}
          onClick={() => onOrderButtonClick(order)}
        >
          More Info
        </button>
      </div>
    </>
  );
}

export default OrderInProgress;
