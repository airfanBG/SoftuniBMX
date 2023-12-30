import { timeResolver } from "../../../util/resolvers.js";
import styles from "./FinishedOrderFullElement.module.css";

function FinishedOrderElement({ order }) {
  const { clientName, clientEmail, totalProductionTime, orderStates } = order;

  return (
    <div className={styles.container}>
      <div className={styles.logo}>
        <p className={styles.logoFirstLine}>
          e<span>&#10006;</span>treme - BMX
        </p>
      </div>

      <header className={styles.header}>
        <p className={styles.heading}>
          <span className={styles.label}>Client name:</span>
          {clientName}
        </p>
        <p className={styles.orderId}>
          <span className={styles.label}>Client email:</span>
          {clientEmail}
        </p>
        <p className={styles.date}>
          <span className={styles.label}>Production time:</span>
          {totalProductionTime} minutes
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
                  <span className={styles.fieldLabel}>Part model:</span>
                  {s.partModel}
                </p>
              </div>
              <div className={styles.metaData}>
                <p className={styles.field}>
                  <span className={styles.fieldLabel}>Part quantity:</span>
                  {s.partQuantity}
                </p>
              </div>
              <div className={styles.metaData}>
                <p className={styles.field}>
                  <span className={styles.fieldLabel}>Description:</span>
                  {s.description}
                </p>
              </div>
            </div>
          </div>
        ))}
      </div>
    </div>
  );
}

export default FinishedOrderElement;

// {
//   "partId": 1,
//   "partType": "Frame",
//   "partModel": "Frame Road",
//   "nameOfEmplоyeeProducedThePart": "Marin Marinov",
//   "isProduced": true,
//   "serialNumber": "oemtest1",
//   "employeeId": null,
//   "elementProduceTimeInMinutes": null,
//   "description": null,
//   "partQuantity": 1,
//   "startDate": "2023-12-21 22:59:26.6380000",
//   "endDate": "2023-12-21 22:59:35.8470000"
// }
