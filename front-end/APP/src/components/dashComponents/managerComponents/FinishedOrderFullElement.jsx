import { minutesToHours, timeResolver } from "../../../util/resolvers.js";
import { useState, useContext } from "react";
import styles from "./FinishedOrderFullElement.module.css";

import { UserContext } from "../../../context/GlobalUserProvider.jsx";

function FinishedOrderElement({ order, i, onFinishedOrderButtonClick }) {
  const { user } = useContext(UserContext);

  const { clientName, paidAmount, unpaidAmount, finalAmount, orderStates } =
    order;

  return (
    <div className={styles.container}>
      <div className={styles.logo}>
        <p className={styles.logoFirstLine}>
          e<span>&#10006;</span>treme - BMX
        </p>
      </div>

      <header className={styles.header}>
        <p className={styles.date}>
          <span className={styles.label}>Paid amount:</span>
          {paidAmount}.00 BGN
        </p>
        <div className={styles.qtyBlock}>
          <p
            className={`${styles.qty} ${
              unpaidAmount > 0 ? styles.notEnough : null
            }`}
          >
            <span className={`${unpaidAmount > 0 ? styles.notEnough : null}`}>
              Unpaid amount:
            </span>
            {unpaidAmount}.00 BGN
          </p>
        </div>

        <p className={styles.date}>
          <span className={styles.label}>Total amount:</span>
          {finalAmount}.00 BGN
        </p>
      </header>

      <div className={styles.orderStatesList}>
        {/* Имена и Email */}
        <div className={styles.headLine}>
          <p className={`${styles.field} ${styles.headElement}`}>
            <span className={styles.fieldLabel}>Client name:</span>
            {order.clientName}
          </p>
          <p className={`${styles.field} ${styles.headElement}`}>
            <span className={styles.fieldLabel}>Email:</span>
            <button
              to="javascript:void(0)"
              onClick={() => (window.location = `mailto:${order.clientEmail}`)}
            >
              {order.clientEmail}
            </button>
          </p>
        </div>

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
                <p className={styles.field}>
                  <span className={styles.fieldLabel}>Employee Name:</span>
                  {s.nameOfEmplоyeeProducedThePart}
                </p>
                <p className={styles.field}>
                  <span className={styles.fieldLabel}>Prodiced time:</span>
                  {minutesToHours(s.elementProduceTimeInMinutes)}
                </p>
              </div>
              {/* <div className={styles.metaData}>
                <p className={styles.field}>
                  <span className={styles.fieldLabel}>Description:</span>
                  {s.description}
                </p>
              </div> */}
            </div>
          </div>
        ))}
        {user.role !== "user" && (
          <button
            className={styles.btn}
            onClick={() => onFinishedOrderButtonClick(order)} //Трябва да прати orderId на ендпойнта за изпращане!?
          >
            Send order
          </button>
        )}
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
