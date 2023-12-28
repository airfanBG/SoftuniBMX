import styles from "./ManagerFinished.module.css";

import { useEffect, useState } from "react";
// <<<<<<< Updated upstream

// =======
// >>>>>>> Stashed changes
import BoardHeader from "../BoardHeader.jsx";
import LoaderWheel from "../../LoaderWheel.jsx";

import { get } from "../../../util/api.js";
import { environment } from "../../../environments/environment.js";

function ManagerFinished() {
  // <<<<<<< Updated upstream

  const [orderList, setOrderList] = useState([]);
  const [error, setError] = useState({});
  const [loading, setLoading] = useState(true);
  const [background, setBackground] = useState(false);
  const [currentOrder, setCurrentOrder] = useState({});

  // State to hold user input
  const [startDate, setStartDate] = useState("");
  const [endDate, setEndDate] = useState("");

  //Firstly I have to render a form with filds and after that to get orders with async function - I do not need useEffect !!!
  useEffect(function () {
    setLoading(true);
    const abortController = new AbortController();

    async function getInProgressOrders() {
      const queryString = `?startDate=${startDate}&endDate=${endDate}`;
      const result = await get(environment.finished_orders + queryString);
      console.log(result);
      if (!result) {
        setLoading(false);
        return setError({
          message: "Something went wrong. Service can not get data!",
        });
      }
      const sortedResult = result.sort((a, b) => a.dateCreated - b.dateCreated);
      setOrderList(sortedResult);
      setLoading(false);
    }
    getInProgressOrders();

    return () => abortController.abort();
  }, []);

  function onOrderButtonClick(o) {
    setCurrentOrder(o);
    setBackground(true);
  }

  function close(e) {
    setCurrentOrder({});
    setBackground(false);
  }

  if (orderList.length === 0)
    return <h2>There is no orders in this category</h2>;
  // =======
  // const [loading, setLoading] = useState(false);
  // const [orderList, setOrderList] = useState([]);
  // const [background, setBackground] = useState(false);
  // const [currentOrder, setCurrentOrder] = useState({});

  //   use
  // >>>>>>> Stashed changes

  return (
    <>
      <h2 className={styles.dashHeading}>Selected items</h2>

      <section className={styles.board}>
        <BoardHeader />
        {loading && <LoaderWheel />}
        <h2>Manager finished</h2>

        <form>
          <label>
            Start Date:
            <input
              type="date"
              value={startDate}
              onChange={(e) => setStartDate(e.target.value)}
            />
          </label>
          <br />
          <label>
            End Date:
            <input
              type="date"
              value={endDate}
              onChange={(e) => setEndDate(e.target.value)}
            />
          </label>
          <br />
          <button type="submit">Submit</button>
        </form>
      </section>
    </>
  );
}

export default ManagerFinished;
