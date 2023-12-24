import styles from "./Scrap.module.css";

import { useContext, useEffect, useReducer, useState } from "react";

import { UserContext } from "../../context/GlobalUserProvider.jsx";

import BoardHeader from "../dashComponents/BoardHeader.jsx";
import LoaderWheel from "../LoaderWheel.jsx";
import Order from "../dashComponents/managerComponents/Order.jsx";
import { get } from "../../util/api.js";
import { environment } from "../../environments/environment.js";

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

function Scrap() {
  const { user } = useContext(UserContext);
  // const [loading, setLoading] = useState(false);

  const [{ loading, status, orders }, dispatch] = useReducer(
    reducer,
    initialState
  );

  useEffect(
    function () {
      async function getOrders() {
        // const result = await get(environment); //TODO: FIX THIS
        const data = [
          {
            orderId: 2,
            serialNumber: "BID12345679",
            dateCreated: "2023-10-10 10:10:00.0000000",
            dateFinished: null,
            orderParts: [
              {
                partId: 1,
                description: "test",
                oemNumber: null,
                categoryName: null,
                partName: "Frame OG",
                partQuantity: 1,
                partQunatityInStock: 32,
                startDate: null,
                endDate: null,
                employeeName: null,
                isComplete: false,
              },
              {
                partId: 4,
                description: "test",
                oemNumber: null,
                categoryName: null,
                partName: "Wheel of the Year for road",
                partQuantity: 1,
                partQunatityInStock: 50,
                startDate: null,
                endDate: null,
                employeeName: null,
                isComplete: false,
              },
              {
                partId: 12,
                description: "test",
                oemNumber: null,
                categoryName: null,
                partName: "Shift",
                partQuantity: 1,
                partQunatityInStock: 29,
                startDate: null,
                endDate: null,
                employeeName: null,
                isComplete: false,
              },
            ],
          },
        ];
        const result = data;
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
      <h2 className={styles.dashHeading}>Scrap</h2>

      <section className={styles.board}>
        {/* <BoardHeader /> */}
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
                isDeleted={false}
              />
            ))}
        </div>
      </section>
    </>
  );
}

export default Scrap;
