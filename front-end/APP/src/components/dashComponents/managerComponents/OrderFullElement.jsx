import styles from "./OrderFullElement.module.css";

function OrderElement({ order }) {
  const { serialNumber, orderId: id, dateCreated, orderStates } = order;

  const currentDate = dateCreated.split(" ").at(0).replaceAll("-", ".");

  return (
    <div className={styles.container}>
      <div className={styles.logo}>
        <p className={styles.logoFirstLine}>
          e<span>&#10006;</span>treme - BMX
        </p>
        <span className={styles.logoSecondary}>Bicycle Management</span>
      </div>

      <header className={styles.header}>
        <p className={styles.heading}>
          <span className={styles.label}>SN:</span>
          {serialNumber}
        </p>
        <p className={styles.orderId}>
          <span className={styles.label}>ID:</span>
          {id}
        </p>
        <p className={styles.date}>
          <span className={styles.label}>Date created:</span>
          {dateCreated}
        </p>
      </header>

      <div className={styles.orderStatesList}>
        {orderStates.map((s, i) => (
          <div key={i} className={styles.sector}>
            <div className={styles.block}>
              <h3 className={styles.line}>{s.partType}</h3>

              <div className={styles.metaData}>
                <p className={styles.field}>
                  <span className={styles.fieldLabel}>OEM Number:</span>
                  {s.serialNumber}
                </p>
                <p className={styles.field}>
                  <span className={styles.fieldLabel}>Quantity:</span>
                  {s.partQuantity}
                </p>
              </div>

              <div className={styles.metaData}>
                <p className={styles.field}>
                  <span className={styles.fieldLabel}>Employee Name:</span>
                  {s.nameOfEmplоyeeProducedThePart}
                </p>
                <p
                  className={styles.field}
                  style={
                    s.IsProduced
                      ? { color: "var(--button-agree)" }
                      : { color: "var(--color-main-dark)" }
                  }
                >
                  <span className={styles.fieldLabel}>Status:</span>
                  {s.IsProduced ? "Finished" : "In Process"}
                </p>
              </div>
            </div>
          </div>
        ))}
      </div>
    </div>
  );
}

export default OrderElement;
