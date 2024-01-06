import styles from "./ManagerFinished.module.css";

import { useEffect, useState } from "react";

import BoardHeader from "../BoardHeader.jsx";
import LoaderWheel from "../../LoaderWheel.jsx";

import { get, post } from "../../../util/api.js";
import { environment } from "../../../environments/environment.js";

import FinishedOrderFullElement from "./FinishedOrderFullElement.jsx";
import FinishedOrder from "./FinishedOrder.jsx";
import Popup from "../../Popup.jsx";
import { onSendHandler } from "../../dashComponents/managerComponents/managerActions/orderActions.js";

function ManagerFinished() {
  const [background, setBackground] = useState(false);
  const [currentOrder, setCurrentOrder] = useState({});

  const [error, setError] = useState({});
  const [loading, setLoading] = useState(false);
  const [orderList, setOrderList] = useState([]);
  const [rerender, setRerender] = useState(false);

  // State to hold user input
  const [startDate, setStartDate] = useState("2023-04-11");
  const [endDate, setEndDate] = useState(
    new Date().toLocaleDateString("en-CA")
  );

  // function getLastMonth() {
  //   let [year, month, day] = new Date().toLocaleDateString("en-CA").split("-");
  //   if (month === 1) {
  //     month = 12;
  //     year = year - 1;
  //   }
  //   console.log(`${year}-${month}-${day}`);
  //   return `${year}-${month - 1}-${day}`;
  // }

  useEffect(
    function () {
      setLoading(true);
      const abortController = new AbortController();

      async function getFinishedOrders() {
        const queryString = `?startDate=${startDate}&endDate=${endDate}`;
        const result = await get(environment.finished_orders + queryString);
        if (!result) {
          setLoading(false);
          return setError({
            message: "Something went wrong. Service can not get data!",
          });
        }
        const sortedResult = result.sort(
          (a, b) => a.dateCreated - b.dateCreated
        );
        // console.log("hasResult");
        setOrderList(sortedResult);
        setLoading(false);
      }
      getFinishedOrders();

      return () => abortController.abort();
    },
    [startDate, endDate, rerender]
  );

  function onOrderButtonClick(o) {
    setCurrentOrder(o);
    setBackground(true);
  }

  function close(e) {
    setCurrentOrder({});
    setBackground(false);
  }

  async function onFinishedOrderButtonClick(order) {
    // const result = onSendHandler(order.orderId);
    const result = await post(`${environment.send_order}${order.orderId}`);
    setRerender(!rerender);
    console.log(result);
    setCurrentOrder({});
    setBackground(false);
  }

  return (
    <>
      {/* {background && (
        <Popup onClose={close}>
          <FinishedOrderFullElement order={currentOrder} />
        </Popup>
      )} */}
      <h2 className={styles.dashHeading}>
        Orders in sequence by time of creation
      </h2>
      <section className={styles.board}>
        <BoardHeader />
        {loading && <LoaderWheel />}
        <div className={styles.dateContainer}>
          <div className={styles.element}>
            <h2 className={styles.boardHeading}>Select time period:</h2>
            <section className={styles.section}>
              <form className={styles.form}>
                <label className={styles.label}>
                  Start Date:
                  <input
                    className={styles.input}
                    type="date"
                    value={startDate}
                    onChange={(e) =>
                      setStartDate(
                        new Date(e.target.value).toLocaleDateString("en-CA")
                      )
                    }
                  />
                </label>
                <label className={styles.label}>
                  End Date:
                  <input
                    className={styles.input}
                    type="date"
                    value={endDate}
                    onChange={(e) =>
                      setEndDate(
                        new Date(e.target.value).toLocaleDateString("en-CA")
                      )
                    }
                  />
                </label>
              </form>
            </section>
          </div>
          <aside className={styles.element}>
            <h3 className={styles.infoHeading}>
              Information about selecting date interval
            </h3>
            <ul className={styles.list}>
              <li>On initial render will be displayed all available orders</li>
              <li>
                If select start date will limit the interval between selected
                date and today
              </li>
              <li>
                When select start and end date will be displayed only orders,
                created in selected time interval
              </li>
            </ul>
          </aside>
        </div>
      </section>
      {orderList.length === 0 && (
        <h2>There is no orders in selected time interval</h2>
      )}
      {orderList && orderList.length > 0 && (
        <>
          {background && (
            <Popup onClose={close}>
              <FinishedOrderFullElement
                order={currentOrder}
                onFinishedOrderButtonClick={onFinishedOrderButtonClick}
              />
            </Popup>
          )}
          <h2 className={styles.dashHeading}>
            Orders in sequence by time of creation
          </h2>
          <section className={styles.board}>
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
          </section>
        </>
      )}
    </>
  );
}

export default ManagerFinished;
