import NavigationSecondary from "../navigationsComponents/NavigationSecondary.jsx";
import styles from "./WorkerDash.module.css";
import OrderItem from "./OrderItem.jsx";
import { useEffect, useState } from "react";
import { get } from "../../util/api.js";

const data = {
  firstName: "Peter",
  lastName: "Petrov",
  _id: "89023ujru3u093i-jfr0303",
  type: "role",
  category: "frames",
};

// const workerSequence = [
//   {
//     unitType: "frame",
//     model: "BGS5657",
//     brand: "Scott",
//     jobType: "painting",
//     id: "ufiuy73737948",
//     startedTime: null,
//     finishedTime: null,
//     description:
//       "Lorem ipsum dolor sit amet consectetur adipisicing elit. At, dolorum.",
//   },
//   {
//     unitType: "frame",
//     model: "BGKL5657",
//     brand: "BMC",
//     jobType: "painting",
//     id: "ufiuy73wert7948",
//     startedTime: null,
//     finishedTime: null,
//     description:
//       "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Quis molestias recusandae ipsa.",
//   },
//   {
//     unitType: "frame",
//     model: "S-WORKS",
//     brand: "Specialized",
//     jobType: "painting",
//     id: "ufiaslkdkas948",
//     startedTime: null,
//     finishedTime: null,
//     description: "Lorem ipsum dolor sit amet, consectetur adipisicing elit.",
//   },
// ];

function WorkerDash({ ...receivedUser }) {
  const [user, setUser] = useState({});
  const [workerSequence, setWorkerSequence] = useState([]);

  useEffect(function () {
    if (!receivedUser?._id) return;
    console.log("has user");
    setUser((user) => (user = { ...receivedUser }));
  }, []);

  useEffect(function () {
    async function getJobs() {
      const workerSequence = await get("/data/workerSequence");
      console.log(workerSequence);
      setWorkerSequence(workerSequence);
    }
    getJobs();

    return () => {
      getJobs();
    };
  }, []);

  const headingType = {
    frames:
      "<span className={styles.selected}>Frames</span> &#10072; <span>Tyres</span> &#10072; <span>Assembly</span>",
    tyres:
      "<span>Frames</span> &#10072; <span className={styles.selected}>Tyres</span> &#10072; <span>Assembly</span>",
    assembly:
      "<span>Frames</span> &#10072; <span>Tyres</span> &#10072; <span className={styles.selected}>Assembly</span>",
  };

  return (
    <div className={styles.wrapper}>
      {user && <NavigationSecondary role={user.role} />}
      <h2 className={styles.dashHeading}>Orders in sequence</h2>
      <section className={styles.board}>
        <header className={styles.boardHeader}>
          <span>Category: </span>
          {/* dynamic data */}
          <h3>
            {console.log(headingType[user.role])}
            {/* Frames<span> &#10072; </span>Painting<span> &#10072; </span>Assembly */}
          </h3>
        </header>
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
    </div>
  );
}

export default WorkerDash;
// workerSequence: {
//   hkjhsf766ds86f7s: {
//     unitType: "frame",
//     model: "BGS5657",
//     brand: "Scott",
//     jobType: "painting",
//     id: "ufiuy73737948",
//     startedTime: null,
//     finishedTime: null,
//     description:
//       "Lorem ipsum dolor sit amet consectetur adipisicing elit. At, dolorum.",
//     _id: "hkjhsf766ds86f7s",
//   },
//   hkjhsf7lkjsfs66ds86f7s: {
//     unitType: "frame",
//     model: "BGKL5657",
//     brand: "BMC",
//     jobType: "painting",
//     id: "ufiuy73wert7948",
//     startedTime: null,
//     finishedTime: null,
//     description:
//       "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Quis molestias recusandae ipsa.",
//     _id: "hkjhsf7lkjsfs66ds86f7s",
//   },
//   hkjhsf766djhdkjhs86f7s: {
//     unitType: "frame",
//     model: "S-WORKS",
//     brand: "Specialized",
//     jobType: "painting",
//     id: "ufiaslkdkas948",
//     startedTime: null,
//     finishedTime: null,
//     description:
//       "Lorem ipsum dolor sit amet, consectetur adipisicing elit.",
//     _id: "hkjhsf766djhdkjhs86f7s",
//   },
// },
