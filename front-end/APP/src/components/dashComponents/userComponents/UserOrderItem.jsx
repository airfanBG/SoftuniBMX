import styles from "./UserOrderItem.module.css";
import { useEffect, useState } from "react";

function UserOrderItem({ order }) {
  const [orderStatus, setOrderStatus] = useState("In Process");
  const titles = ["Frame", "Wheels", "Accessory"];
  console.log(order.orderStates);

  useEffect(
    function () {
      if (
        order.orderStates[0].isProduced &&
        order.orderStates[1].isProduced &&
        order.orderStates[2].isProduced
      ) {
        setOrderStatus("Finished");
      }
    },
    [order]
  );

  return (
    <>
      <section className={styles.orderBlock}>
        <header className={styles.orderServiceInfo}>
          <p className={styles.serviceInfo}>
            <span className={styles.label}>Date:</span>
            {order.dateCreated.replaceAll("/", ".")}
          </p>
          <p className={styles.serviceInfo}>
            <span className={styles.label}>SN:</span>
            {order.serialNumber}
          </p>
          <p className={styles.serviceInfo}>
            <span className={styles.label}>ID:</span>
            {order.id}
          </p>
          <p className={styles.serviceInfo}>
            <span className={styles.label}>Status</span>
            {orderStatus}
          </p>
        </header>
        <div className={styles.products}>
          {order.orderStates.map((x, i) => (
            <div key={i} className={styles.container}>
              <p className={styles.title}>{titles[i]}</p>
              <div className={styles.product}>
                <p className={styles.element}>
                  <span className={styles.label}>Brand:</span>
                  {x.partType}
                </p>
                <p className={styles.element}>
                  <span className={styles.label}>Model:</span>
                  {x.partModel}
                </p>
                <p className={styles.element}>
                  <span className={styles.label}>Employee:</span>
                  {x.nameOfEmplоyeeProducedThePart}
                </p>
                <p className={styles.element}>
                  <span className={styles.label}>Status:</span>
                  {x.isProduced ? (
                    <span className={styles.icon}>&#10004;</span>
                  ) : (
                    <span className={styles.ionIcon}>
                      <ion-icon name="hourglass-outline"></ion-icon>
                    </span>
                  )}
                </p>
              </div>
            </div>
          ))}
        </div>
      </section>
    </>
  );
}

export default UserOrderItem;
// {
//     "id": 4,
//     "ownerId": 1,
//     "serialNumber": "BID28YUOCH0",
//     "dateCreated": "15/09/2023",
//     "orderStates": [
//         {
//             "partId": 1,
//             "partType": "Frame 4",
//             "partModel": "First Frame OG 4",
//             "nameOfEmplоyeeProducedThePart": "Stamat Spiridonov",
//             "isProduced": true,
//             "startedTime": 1701974864834,
//             "finishedTime": 1701974877891,
//             "description": ""
//         },
//         {
//             "partId": 2,
//             "partType": "Wheel from ID 4",
//             "partModel": "Wheel of the Year from ID 4",
//             "nameOfEmplоyeeProducedThePart": "",
//             "isProduced": false,
//             "startedTime": "",
//             "finishedTime": "",
//             "description": ""
//         },
//         {
//             "partId": 3,
//             "partType": "Shift from ID 4",
//             "partModel": "Shift from ID 4",
//             "nameOfEmplоyeeProducedThePart": "",
//             "isProduced": false,
//             "startedTime": "",
//             "finishedTime": "",
//             "description": ""
//         }
//     ]
// }
