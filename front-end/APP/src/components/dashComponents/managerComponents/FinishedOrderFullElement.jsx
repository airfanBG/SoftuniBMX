import styles from "./FinishedOrderFullElement.module.css";
import {
  formatCurrency,
  minutesToHours,
  timeResolver,
} from "../../../util/resolvers.js";
import { useState, useContext } from "react";

import { UserContext } from "../../../context/GlobalUserProvider.jsx";

//import { timeResolver } from "../../../util/resolvers.js";

function FinishedOrderElement({ order, i, onFinishedOrderButtonClick }) {
  const { user } = useContext(UserContext);

  const { clientName, paidAmount, unpaidAmount, finalAmount, orderStates } =
    order;

  function jobTIme(t1, t2) {
    let timeResult = "";
    const date1 = new Date(t1).getTime();
    const date2 = new Date(t2).getTime();
    // TODO: only for development
    if (date2 - date1 < 100000) {
      timeResult = timeResolver(date1, Math.floor(Math.random() * 10 * date2));
    } else {
      timeResult = timeResolver(date1, date2);
    }

    return timeResult;
  }

  return (
    <div className={styles.container}>
      <div className={styles.logo}>
        <p className={styles.logoFirstLine}>
          e<span>&#10006;</span>treme - BMX
        </p>
      </div>

      <header className={styles.header}>
        <p className={styles.date}>
          <span className={styles.label}>Paid:</span>
          {formatCurrency(paidAmount)}
        </p>
        <div className={styles.qtyBlock}>
          <p
            className={`${styles.qty} ${
              unpaidAmount > 0 ? styles.notEnough : null
            }`}
          >
            <span className={`${unpaidAmount > 0 ? styles.notEnough : null}`}>
              REMAINING:
            </span>
            {formatCurrency(unpaidAmount)}
          </p>
        </div>

        <p className={styles.date}>
          <span className={styles.label}>Total:</span>
          {formatCurrency(finalAmount)}
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
                  {/* {s.elementProduceTimeInMinutes} */}
                  {!!s.startDate &&
                    !!s.endDate &&
                    jobTIme(s.startDate, s.endDate)}
                </p>
              </div>
            </div>
          </div>
        ))}
        {user.role !== "user" && (
          <button
            className={styles.btn}
            style={unpaidAmount > 0 ? { cursor: "not-allowed" } : null}
            onClick={() => onFinishedOrderButtonClick(order)} //Трябва да прати orderId на ендпойнта за изпращане!?
            disabled={unpaidAmount > 0}
          >
            {unpaidAmount > 0 ? "UNPAID" : "Send order"}
          </button>
        )}
      </div>
    </div>
  );
}

export default FinishedOrderElement;
