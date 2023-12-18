import { useContext, useEffect, useState } from "react";

import styles from "./WorkerOrders.module.css";

import { get } from "../../../util/api.js";
import OrderItem from "../OrderItem.jsx";
import BoardHeader from "../BoardHeader.jsx";
import { UserContext } from "../../../context/GlobalUserProvider.jsx";
import { environment } from "../../../environments/environment.js";

function WorkerOrders() {
  const { user } = useContext(UserContext);
  const [workerList, setWorkerList] = useState([]);
  const [isFinished, setIsFinished] = useState(false);

  useEffect(
    function () {
      let orderArray;
      const abortController = new AbortController();

      async function getJobs() {
        const workerSequence = await get(
          environment.worker_order_queue + user.id
        );
        workerSequence.orders.sort(
          (a, b) => a.datetimeAsigned - b.datetimeAsigned
        );
        setWorkerList(workerSequence.orders);
      }
      getJobs();
      return () => abortController.abort();
    },
    [isFinished, user.id]
  );
  function onBtnHandler() {
    setIsFinished(!isFinished);
    console.log("rerender");
  }
  return (
    <>
      <h2 className={styles.dashHeading}>Orders in sequence</h2>
      <section className={styles.board}>
        <BoardHeader />
        <div className={styles.orders}>
          {workerList.length > 0 &&
            workerList.map((order, i) => (
              <OrderItem
                product={order}
                key={order.orderId}
                onBtnHandler={onBtnHandler}
                orderId={order.orderId}
                orderIndex={i}
              />
            ))}
          {workerList.length === 0 && (
            <h2>There is no orders in this category</h2>
          )}
        </div>
      </section>
    </>
  );
}

export default WorkerOrders;
