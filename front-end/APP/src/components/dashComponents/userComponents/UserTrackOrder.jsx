import styles from "./UserTrackOrder.module.css";

import { useContext, useState, useEffect } from "react";
import { UserContext } from "../../../context/GlobalUserProvider.jsx";

import LoaderWheel from "../../LoaderWheel.jsx";
import BoardHeader from "../BoardHeader.jsx";
import UserOrderItem from "./UserOrderItem.jsx";

import OrderInProgress from "../managerComponents/OrderInProgress.jsx";
import { post } from "../../../util/api.js";
import { environment } from "../../../environments/environment.js";
import OrderFullElement from "../managerComponents/OrderFullElement.jsx";
import Popup from "../../Popup.jsx";

function UserTrackOrder() {
  const { user } = useContext(UserContext);
  const [orderList, setOrderList] = useState([]);
  const [error, setError] = useState({});
  const [loading, setLoading] = useState(true);
  const [background, setBackground] = useState(false);
  const [currentOrder, setCurrentOrder] = useState({});

  useEffect(
    function () {
      setLoading(true);
      const abortController = new AbortController();

      async function getInProgressOrders() {
        const result = await post(environment.orders_in_progress + user.id);
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
    },
    [user.id]
  );

  // function onOrderButtonClick(o) {
  //   setCurrentOrder(o);
  //   setBackground(true);
  // }

  function close(e) {
    setCurrentOrder({});
    setBackground(false);
  }

  // if (orderList.length === 0)
  //   return <h2>There is no orders in this category</h2>;
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
        {orderList.length > 0 && (
          <div className={styles.orders}>
            {loading && <LoaderWheel />}
            {orderList.map((order, i) => (
              <OrderInProgress key={order.orderId} order={order} i={i} />
            ))}
          </div>
        )}
        {orderList.length === 0 && <h2>There is no orders in this category</h2>}
      </section>
    </>
  );
}

export default UserTrackOrder;
