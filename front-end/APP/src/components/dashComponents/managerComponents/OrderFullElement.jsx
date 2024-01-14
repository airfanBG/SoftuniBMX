import { timeResolver } from "../../../util/resolvers.js";
import styles from "./OrderFullElement.module.css";

function OrderElement({ order }) {
  const { serialNumber, orderId: id, dateCreated, orderStates } = order;

  function startedAt(t) {
    const startDate = t.split(".").at(0).replaceAll("-", ".");
    console.log(t);
    return startDate;
  }

  function fieldLabel(s, e) {
    let result = "";
    console.log(s);
    if (s === null && e === null) {
      result = "On queue";
    } else if (s !== null && e === null) {
      result = "Started at:";
    } else {
      result = "Produced in:";
    }
    return result;
  }

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

  function orderStatus(s, e) {
    if (s === null && e === null) return "In Queue";
    else if (!!s && e === null) return "In Process";
    else if (!!s && !!e) return "Finished";
  }

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
          {dateCreated.replaceAll("/", ".")}
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
                    s.isProduced
                      ? { color: "var(--button-agree)" }
                      : { color: "var(--color-main-dark)" }
                  }
                >
                  <span className={styles.fieldLabel}>Status:</span>
                  {/* {s.isProduced ? "Finished" : "In Process"} */}
                  {orderStatus(s.startDate, s.endDate)}
                </p>
              </div>
              <div className={`${styles.metaData} ${styles.emptyField}`}>
                {
                  <p className={styles.field}>
                    <span className={`${styles.fieldLabel} `}>
                      Description:
                    </span>
                    {s.description}
                  </p>
                }
                <p className={styles.field}>
                  <span className={styles.fieldLabel}>
                    {fieldLabel(s.startDate, s.endDate)}
                  </span>
                  {!!s.startDate &&
                    s.endDate === null &&
                    startedAt(s.startDate)}
                  {!!s.startDate &&
                    !!s.endDate &&
                    jobTIme(s.startDate, s.endDate)}
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
