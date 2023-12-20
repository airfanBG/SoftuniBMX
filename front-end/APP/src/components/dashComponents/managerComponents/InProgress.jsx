import styles from "./InProgress.module.css";

import { useEffect, useState } from "react";

import { get } from "../../../util/api.js";
import { environment } from "../../../environments/environment.js";

import BoardHeader from "../BoardHeader.jsx";
import OrderInProgress from "./OrderInProgress.jsx";
import LoaderWheel from "../../LoaderWheel.jsx";
// import Popup from "./Popup.jsx";
import OrderFullElement from "./OrderFullElement.jsx";
import Popup from "../../Popup.jsx";

function InProgress() {
  const [orderList, setOrderList] = useState([]);
  const [error, setError] = useState({});
  const [loading, setLoading] = useState(true);
  const [background, setBackground] = useState(false);
  const [currentOrder, setCurrentOrder] = useState({});

  useEffect(function () {
    setLoading(true);
    const abortController = new AbortController();

    async function getInProgressOrders() {
      const result = await get(environment.in_progress_orders);
      if (!result) {
        setLoading(false);
        return setError({
          message: "Something went wrong. Service can not get data!",
        });
      }
      setOrderList(result);
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
  return (
    <>
      {background && (
        <Popup onClose={close}>
          <OrderFullElement order={currentOrder} />
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
            <OrderInProgress
              key={order.orderId}
              order={order}
              i={i + 1}
              onOrderButtonClick={onOrderButtonClick}
            />
          ))}
        </div>
      </section>
    </>
  );
}

export default InProgress;
