import styles from "./OrderFullElement.module.css";

function OrderElement({ order }) {
  const { serialNumber, id, dateCreated, orderParts } = order;

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
          <span className={styles.label}>Date:</span>
          {dateCreated.replaceAll("/", ".")}
        </p>
      </header>

      <div className={styles.orderStatesList}>
        {orderParts.map((s, i) => (
          <div key={i} className={styles.sector}>
            <div className={styles.block}>
              <h3 className={styles.line}>{s.partName}</h3>

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
//   "orderId": 1,
//   "serialNumber": "BID12345678",
//   "dateCreated": "2023-12-17 13:09:57.5250286",
//   "dateFinished": null,
//   "orderParts": [
//       {
//           "partId": 1,
//           "description": "test",
//           "partName": "Frame OG",
//           "partQuantity": 1,
//           "partQunatityInStock": 28,
//           "startDate": "2023-12-17 13:29:56.3270000",
//           "endDate": "2023-12-17 13:35:34.6850000",
//           "isComplete": true
//       },
//       {
//           "partId": 2,
//           "description": "test",
//           "partName": "Wheel of the YearG",
//           "partQuantity": 1,
//           "partQunatityInStock": 42,
//           "startDate": "2023-12-17 13:37:52.4510000",
//           "endDate": "2023-12-17 13:37:53.6690000",
//           "isComplete": true
//       },
//       {
//           "partId": 3,
//           "description": "test",
//           "partName": "Shift",
//           "partQuantity": 1,
//           "partQunatityInStock": 32,
//           "startDate": "2023-12-17 13:38:19.7070000",
//           "endDate": "2023-12-17 13:38:20.7370000",
//           "isComplete": true
//       }
//   ]
// }
