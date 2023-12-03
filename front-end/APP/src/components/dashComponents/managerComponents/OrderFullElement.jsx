import styles from "./OrderFullElement.module.css";

function OrderElement({ order }) {
  const { serialNumber, id, dateCreated, orderStates } = order;
  return (
    <div className={styles.container}>
      <p className={styles.logo}>
        <p className={styles.logoFirstLine}>
          e<span>&#10006;</span>treme - BMX
        </p>
        <span className={styles.logoSecondary}>Bicycle Management</span>
      </p>

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
          <span className={styles.label}>Date:</span>
          {dateCreated.replaceAll("/", ".")}
        </p>
      </header>

      <div className={styles.orderStatesList}>
        {orderStates.map((s, i) => (
          <div key={i} className={styles.sector}>
            <div className={styles.block}>
              <h3 className={styles.line}>{s.partType}</h3>

              <p className={styles.field}>
                <span className={styles.fieldLabel}>Model:</span>
                {s.partModel}
              </p>

              <div className={styles.metaData}>
                <p className={styles.field}>
                  <span className={styles.fieldLabel}>Employee Name:</span>
                  {s.nameOfEmplоyeeProducedThePart}
                </p>
                <p
                  className={styles.field}
                  style={
                    s.isProduced
                      ? { color: "var(--button-agree)" }
                      : { color: "var(--color-main-dark)" }
                  }
                >
                  <span className={styles.fieldLabel}>Status:</span>
                  {s.isProduced ? "Finished" : "In Process"}
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

// {
//     "orderId": 2,
//     "serialNumber": "BID243UOCH0",
//     "dateCreated": "04/09/2023",
//     "orderStates": [
//         {
//             "partId": 1,
//             "partType": "Frame",
//             "partModel": "Frame OG",
//             "nameOfEmplоyeeProducedThePart": " ",
//             "isProduced": true
//         },
//         {
//             "partId": 2,
//             "partType": "Wheel",
//             "partModel": "Wheel of the Year",
//             "nameOfEmplоyeeProducedThePart": " ",
//             "isProduced": true
//         },
//         {
//             "partId": 3,
//             "partType": "Shift",
//             "partModel": "Shift",
//             "nameOfEmplоyeeProducedThePart": " ",
//             "isProduced": false
//         }
//     ]
// }
