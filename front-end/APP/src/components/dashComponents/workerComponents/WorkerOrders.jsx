import { useContext, useEffect, useState } from "react";

import styles from "./WorkerOrders.module.css";

import { get } from "../../../util/api.js";
import OrderItem from "../OrderItem.jsx";
import BoardHeader from "../BoardHeader.jsx";
import { UserContext } from "../../../context/GlobalUserProvider.jsx";

function WorkerOrders() {
  const { user } = useContext(UserContext);
  const [workerList, setWorkerList] = useState([]);
  const [isFinished, setIsFinished] = useState(false);
  const [meta, setMeta] = useState({});

  useEffect(
    function () {
      let orderArray;
      const abortController = new AbortController();

      async function getJobs() {
        const workerSequence = await get("/production/");
        workerSequence.sort((a, b) => a.dateCreated - b.dateCreated);

        setMeta({ id: workerSequence.id });

        // Worker will see only his own work
        if (user.department === "Frames") {
          orderArray = workerSequence.filter(
            (x) => !x.orderStates[0].isProduced
          );
        } else if (user.department === "Wheels") {
          orderArray = workerSequence.filter(
            (x) => x.orderStates[0].isProduced && !x.orderStates[1].isProduced
          );
        } else if (user.department === "Accessory") {
          orderArray = workerSequence.filter(
            (x) =>
              x.orderStates[0].isProduced &&
              x.orderStates[1].isProduced &&
              !x.orderStates[2].isProduced
          );
        }
        // console.log(workerSequence);
        setWorkerList(orderArray);
      }
      getJobs();

      return () => abortController.abort();
    },
    [isFinished]
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
                key={order.id}
                onBtnHandler={onBtnHandler}
                orderId={order.id}
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
