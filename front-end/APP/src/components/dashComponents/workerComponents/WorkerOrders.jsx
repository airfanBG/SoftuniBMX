import { useContext, useEffect, useState } from "react";

import styles from "./WorkerOrders.module.css";

import { get } from "../../../util/api.js";
import OrderItem from "../OrderItem.jsx";
// import { UserContext } from "../UserProfile.jsx";
import Category from "../Category.jsx";
import BoardHeader from "../BoardHeader.jsx";
import { UserContext } from "../../../context/GlobalUserProvider.jsx";

function WorkerOrders() {
  const { user } = useContext(UserContext);
  const [workerSequence, setWorkerSequence] = useState([]);

  useEffect(function () {
    let orderArray;
    const abortController = new AbortController();
    async function getJobs() {
      const workerSequence = await get("/production/");
      // Worker will see only his own work
      if (user.department === "Frames") {
        orderArray = workerSequence.filter((x) => !x.orderStates[0].isProduced);
      }
      if (user.department === "Wheels") {
        orderArray = workerSequence.filter(
          (x) => x.orderStates[0].isProduced && !x.orderStates[1].isProduced
        );
      }
      if (user.department === "Accessory") {
        orderArray = workerSequence.filter(
          (x) =>
            x.orderStates[0].isProduced &&
            x.orderStates[1].isProduced &&
            !x.orderStates[2].isProduced
        );
      }
      console.log(orderArray);

      setWorkerSequence(orderArray);
    }
    getJobs();

    return () => abortController.abort();
  }, []);

  return (
    <>
      <h2 className={styles.dashHeading}>Orders in sequence</h2>
      <section className={styles.board}>
        <BoardHeader />
        <div className={styles.orders}>
          {workerSequence.length > 0 &&
            workerSequence.map((order) => (
              <OrderItem {...order} key={order.id} />
            ))}
          {workerSequence.length === 0 && (
            <h2>There is no orders in this category</h2>
          )}
        </div>
      </section>
    </>
  );
}

export default WorkerOrders;
