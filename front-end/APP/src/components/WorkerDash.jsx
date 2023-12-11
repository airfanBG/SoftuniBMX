import NavigationSecondary from "./NavigationSecondary.jsx";
import styles from "./WorkerDash.module.css";
import OrderItem from "./dashComponents/OrderItem.jsx";

const data = {
  firstName: "Peter",
  lastName: "Petrov",
  _id: "89023ujru3u093i-jfr0303",
  type: "worker",
  category: "Frames ❘ Painting ❘ Assembly",
};

const workerSequence = [
  {
    unitType: "frame",
    model: "BGS5657",
    brand: "Scott",
    jobType: "painting",
    id: "ufiuy73737948",
    startedTime: null,
    finishedTime: null,
    description:
      "Lorem ipsum dolor sit amet consectetur adipisicing elit. At, dolorum.",
  },
  {
    unitType: "frame",
    model: "BGKL5657",
    brand: "BMC",
    jobType: "painting",
    id: "ufiuy73wert7948",
    startedTime: null,
    finishedTime: null,
    description:
      "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Quis molestias recusandae ipsa.",
  },
  {
    unitType: "frame",
    model: "S-WORKS",
    brand: "Specialized",
    jobType: "painting",
    id: "ufiaslkdkas948",
    startedTime: null,
    finishedTime: null,
    description: "Lorem ipsum dolor sit amet, consectetur adipisicing elit.",
  },
];

function WorkerDash() {
  return (
    <div className={styles.wrapper}>
      <NavigationSecondary />
      <h2 className={styles.dashHeading}>Orders in sequence</h2>;
      <section className={styles.board}>
        <header className={styles.boardHeader}>
          <span>Category: </span>

          {/* dynamic data */}
          <h3>
            Frames<span> &#10072; </span>Painting<span> &#10072; </span>Assembly
          </h3>
        </header>
        <div className={styles.orders}>
          {workerSequence.length > 0 &&
            workerSequence.map((order, i) => (
              <OrderItem {...order} key={order.id} />
            ))}
          {workerSequence.length === 0 && (
            <h2>There is no orders in this category</h2>
          )}
        </div>
      </section>
    </div>
  );
}

export default WorkerDash;
