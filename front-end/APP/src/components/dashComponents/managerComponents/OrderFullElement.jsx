import styles from "./OrderFullElement.module.css";

function OrderElement({ order }) {
  const { serialNumber, orderId, dateCreated, orderStates } = order;
  return (
    <div className={styles.container}>
      <h2>
        <span className={styles.label}>SN:</span>
        {serialNumber}
      </h2>
      <p className={styles.orderId}>
        <span>ID:</span>
        {orderId}
      </p>
      <p className={styles.date}>
        <span>Date created:</span>
        {dateCreated}
      </p>
      <div className={styles.orderStatesList}>
        {orderStates.map((s, i) => (
          <div key={i}>
            <p>{s.partId}</p>
            <p>{s.partType}</p>
            <p>{s.partModel}</p>
            <p>{s.nameOfEmplоyeeProducedThePart}</p>
            <p>{s.isProduced}</p>
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
