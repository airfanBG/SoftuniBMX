import styles from "./ManagerRejected.module.css";

import { useContext, useEffect, useReducer, useState } from "react";

import { UserContext } from "../../../context/GlobalUserProvider.jsx";

import BoardHeader from "../BoardHeader.jsx";
import LoaderWheel from "../../LoaderWheel.jsx";
import { get } from "../../../util/api.js";
import { environment } from "../../../environments/environment.js";
import Order from "./Order.jsx";

const initialState = {
  loading: false,
  status: false,
  orders: [],
};

function reducer(state, action) {
  switch (action.type) {
    case "loading":
      return { ...state, loading: true };
    case "component/rerender":
      return { ...state, status: !state.status, loading: false };
    case "orders/received":
      return { ...state, orders: action.payload, loading: false };

    default:
      throw new Error("Unknown action type");
  }
}

function ManagerRejected() {
  const { user } = useContext(UserContext);
  const [{ loading, status, orders }, dispatch] = useReducer(
    reducer,
    initialState
  );

  useEffect(
    function () {
      async function getOrders() {
        const result = await get(environment.rejected_orders_list);
        dispatch({ type: "loading" });
        dispatch({ type: "orders/received", payload: result });
      }
      getOrders();
    },
    [status]
  );

  function rerender() {
    dispatch({ type: "loading" });
    dispatch({ type: "component/rerender" });
  }

  return (
    <>
      <h2 className={styles.dashHeading}>Selected items</h2>

      <section className={styles.board}>
        <BoardHeader />
        {loading && <LoaderWheel />}
        <div className={styles.orders}>
          {orders.length === 0 && <h2>There is no rejected orders</h2>}
          {orders &&
            orders.map((order) => (
              <Order
                key={order.orderId}
                order={order}
                onStatusChange={rerender}
                isRejected={false}
              />
            ))}
        </div>
      </section>
    </>
  );
}

export default ManagerRejected;
