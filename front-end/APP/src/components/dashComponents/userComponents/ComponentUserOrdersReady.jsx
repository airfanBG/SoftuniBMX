import styles from "./ComponentUserOrdersReady.module.css";
import UserOrdersTable from "./UserOrdersTable.jsx";

import { useContext, useState, useReducer } from "react";

import { UserContext } from "../../../context/GlobalUserProvider.jsx";

import BoardHeader from "../BoardHeader.jsx";
import LoaderWheel from "../../LoaderWheel.jsx";
import { environment } from "../../../environments/environment.js";
import React, { useEffect } from "react";
import { get, post } from "../../../util/api.js";
import Order from "../managerComponents/Order.jsx";
import ReadyOrder from "./ReadyOrder.jsx";

function ComponentUserOrdersReady() {
  const { user, updateUser } = useContext(UserContext);
  const [loading, setLoading] = useState(false);
  const [data, setData] = useState([]);
  const [error, setError] = useState();
  const [render, setRender] = useState(false);
  // const [_, forceRerender] = useReducer((x) => !x, true);

  useEffect(() => {
    async function getData() {
      const result = await get(environment.orders_ready + user.id);
      setData(result);
    }
    getData();
  }, [user.id, render]);

  async function orderIsPayed(orderId, sum) {
    const query = `userId=${user.id}&orderId=${orderId}`;
    const result = await post(environment.rest_payment + query);
    if (result.isError) {
      setError({ error: true, message: result.title });
    } else {
      // forceRerender();
      console.log(user);
      updateUser({ ...user, orderIsReady: false, balance: user.balance - sum });
      console.log(user);
      setRender(!render);
    }
  }

  return (
    <>
      <h2 className={styles.dashHeading}>Selected items</h2>

      <section className={styles.board}>
        <BoardHeader />
        {loading && <LoaderWheel />}
        {/* <UserOrdersTable orders={data} /> */}
        <div className={styles.ordersBlock}>
          {data &&
            data.length > 0 &&
            data.map((order, i) => (
              <ReadyOrder
                key={i}
                order={order}
                payed={orderIsPayed}
                error={error?.error}
                message={error?.message}
                clearError={setError}
              />
            ))}
          {data.length === 0 && (
            <h3>You have no ready orders at this moment</h3>
          )}
        </div>
      </section>
    </>
  );
}

export default ComponentUserOrdersReady;
