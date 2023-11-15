import { useContext, useEffect, useState } from "react";
import styles from "./WorkerOrders.module.css";
import { get } from "../../util/api.js";
import OrderItem from "./OrderItem.jsx";
import { UserContext } from "../UserProfile.jsx";
import Category from "./Category.jsx";
import BoardHeader from "./BoardHeader.jsx";

function WorkerOrders() {
  const { user } = useContext(UserContext);
  const [workerSequence, setWorkerSequence] = useState([]);

  useEffect(function () {
    async function getJobs() {
      const workerSequence = await get("/data/workerSequence");
      setWorkerSequence(workerSequence);
    }
    getJobs();

    return () => {
      getJobs();
    };
  }, []);

  return (
    <>
      <h2 className={styles.dashHeading}>Orders in sequence</h2>
      <section className={styles.board}>
        <BoardHeader />
        <div className={styles.orders}>
          {workerSequence.length > 0 &&
            workerSequence.map((order) => (
              <OrderItem {...order} key={order._id} />
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
