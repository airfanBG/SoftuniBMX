import styles from "./ManagerDispatched.module.css";

import { useEffect, useState } from "react";

import { memo } from "react";
import LoaderWheel from "../../LoaderWheel.jsx";
import BoardHeader from "../BoardHeader.jsx";

import { get } from "../../../util/api.js";
import { environment } from "../../../environments/environment.js";

import DispathedOrder from "../managerComponents/DispathedOrder.jsx";

function ManagerDispatched(){
const [loading, setLoading] = useState(false);
const [orderList, setOrderList] = useState([]);
const [error, setError] = useState({});

  useEffect(
    function () {
      setLoading(true);
      const abortController = new AbortController();

      async function getSendedOrders() {
        const result = await get(environment.sended_orders);
        if (!result) {
          setLoading(false);
          return setError({
            message: "Something went wrong. Service can not get data!",
          });
        }
        const sortedResult = result.sort(
          (a, b) => a.dateCreated - b.dateCreated
        );
        setOrderList(sortedResult);
        setLoading(false);
      }
      getSendedOrders();
      return () => abortController.abort();
    },
    []
  );

  return (
    <>
      <section className={styles.board}>
        <BoardHeader />
        {loading && <LoaderWheel />}
        <div className={styles.orders}>
          {orderList.length === 0 && <h2>There is no sended orders</h2>}
          {orderList &&
            orderList.map((order) => (
              <DispathedOrder
                key={order.orderId}
                order={order}
              />
            ))}
        </div>
      </section>
    </>
  );
}

export default memo(ManagerDispatched);
