import BoardHeader from "../BoardHeader.jsx";
import styles from "./WorkerFinished.module.css";

function WorkerFinished() {
  return (
    <>
      <h2 className={styles.dashHeading}>Finished orders</h2>
      <section className={styles.board}>
        <BoardHeader />
        {/* <div className={styles.orders}>
          {workerSequence.length > 0 &&
            workerSequence.map((order) => (
              <OrderItem {...order} key={order._id} />
            ))}
          {workerSequence.length === 0 && (
            <h2>There is no orders in this category</h2>
          )}
        </div> */}
      </section>
    </>
  );
}

export default WorkerFinished;
