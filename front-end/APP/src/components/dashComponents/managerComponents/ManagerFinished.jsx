import styles from "./ManagerFinished.module.css";

import { useEffect, useState } from "react";
<<<<<<< HEAD

=======
// <<<<<<< Updated upstream

// =======
// >>>>>>> Stashed changes
>>>>>>> 3c7588366d56f3b976a561a77eebcd71b883de62
import BoardHeader from "../BoardHeader.jsx";
import LoaderWheel from "../../LoaderWheel.jsx";

import { get } from "../../../util/api.js";
import { environment } from "../../../environments/environment.js";

<<<<<<< HEAD
import FinishedOrderFullElement from "./FinishedOrderFullElement.jsx";
import FinishedOrder from "./FinishedOrder.jsx";
import Popup from "../../Popup.jsx";

function ManagerFinished() {

   
=======
function ManagerFinished() {
  const [orderList, setOrderList] = useState([]);
  const [error, setError] = useState({});
  const [loading, setLoading] = useState(true);
>>>>>>> 3c7588366d56f3b976a561a77eebcd71b883de62
  const [background, setBackground] = useState(false);
  const [currentOrder, setCurrentOrder] = useState({});
  
  const [error, setError] = useState({});
  const [loading, setLoading] = useState(false);
  const [orderList, setOrderList] = useState([]);

<<<<<<< HEAD
    // State to hold user input
    const [startDate, setStartDate] = useState('');
    const [endDate, setEndDate] = useState('');

=======
  // State to hold user input
  const [startDate, setStartDate] = useState("");
  const [endDate, setEndDate] = useState("");

  //Firstly I have to render a form with filds and after that to get orders with async function - I do not need useEffect !!!
  useEffect(function () {
    setLoading(true);
>>>>>>> 3c7588366d56f3b976a561a77eebcd71b883de62
    const abortController = new AbortController();

    async function getFinishedOrders(e) {
      e.preventDefault();
      setLoading(true);
      const queryString = `?startDate=${startDate}&endDate=${endDate}`;
      const result = await get(environment.finished_orders + queryString);
      if (!result) {
        setLoading(false);
        return setError({
          message: "Something went wrong. Service can not get data!",
        });
      }
      setOrderList(result);
      setLoading(false);
  
      if (orderList.length === 0)
      return <h2>There is no orders in this category</h2>;
    }
    
    function onOrderButtonClick(o) {
      setCurrentOrder(o);
      setBackground(true);
    }
<<<<<<< HEAD
=======
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
>>>>>>> 3c7588366d56f3b976a561a77eebcd71b883de62

    function close(e) {
      setCurrentOrder({});
      setBackground(false);
    }
    
  return (
    <>
      <section className={styles.board}>
        <BoardHeader />
        {loading && <LoaderWheel />}

<<<<<<< HEAD
        <h2>Select time period:</h2>

        <section className={styles.section}>
        <form className={styles.form}>
      <label className={styles.label}>
        Start Date:
        <input
          className={styles.input}
          type="date"
          value={startDate}
          onChange={(e) => setStartDate(e.target.value)}
        />
      </label>
      <br />
      <label className={styles.label}>
        End Date:
        <input
          className={styles.input}
          type="date"
          value={endDate}
          onChange={(e) => setEndDate(e.target.value)}
        />
      </label>
      <br />
      <button className={styles.btnAdd} onClick={getFinishedOrders}>
      Get Orders
      </button>
    </form>
        </section>
      </section>

      {background && (
        <Popup onClose={close}>
          <FinishedOrderFullElement order={currentOrder} />
        </Popup>
      )}
      <h2 className={styles.dashHeading}>
        Orders in sequence by time of creation
      </h2>
      <section className={styles.board}>
        <BoardHeader />
        <div className={styles.orders}>
          {loading && <LoaderWheel />}
          {orderList.map((order, i) => (
            <FinishedOrder
              key={order.orderId}
              order={order}
              i={i + 1}
              onOrderButtonClick={onOrderButtonClick}
            />
          ))}
        </div>
=======
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
>>>>>>> 3c7588366d56f3b976a561a77eebcd71b883de62
      </section>
    </>
  );
}

export default ManagerFinished;
