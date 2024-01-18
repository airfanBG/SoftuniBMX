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
import { Link } from "react-router-dom";

function ComponentUserOrdersReady() {
  const { user, updateUser } = useContext(UserContext);
  const [loading, setLoading] = useState(false);
  const [data, setData] = useState([]);
  const [error, setError] = useState();
  const [render, setRender] = useState(false);
  const [notEnough, setNotEnough] = useState(false);
  // const [_, forceRerender] = useReducer((x) => !x, true);

  useEffect(() => {
    async function getData() {
      const result = await get(environment.orders_ready + user.id);
      setData(result);
    }
    getData();
  }, [user.id, render]);

  async function orderIsPayed(orderId, sum) {
    if (user.balance < sum) {
      setNotEnough(true);
      return;
    }

    const query = `userId=${user.id}&orderId=${orderId}`;
    const result = await post(environment.rest_payment + query);
    if (result.isError) {
      setError({ error: true, message: result.title });
    } else {
      // forceRerender();
      updateUser({ ...user, orderIsReady: false, balance: user.balance - sum });
      setRender(!render);
    }
  }

  return (
    <>
      <h2 className={styles.dashHeading}>Ready orders</h2>

      <section className={styles.board}>
        <BoardHeader />
        {loading && <LoaderWheel />}
        {/* <UserOrdersTable orders={data} /> */}

        {notEnough && (
          <div className={styles.ordersBlock}>
            <div className={styles.message}>
              <h2 className={styles.notEnoughHeader}>
                You have not enough money to pay your bill.
              </h2>
              <p className={styles.notEnoughMessage}>
                Please, go to your {<Link to={"/profile"}>profile page</Link>},
                enter in &#8221;Bank account&#8221; menu and fill your bank
                account to finish the payment.
              </p>
            </div>
          </div>
        )}
        {!notEnough && (
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
              <h3 className={styles.fontHd}>
                You have no ready orders at this moment
              </h3>
            )}
          </div>
        )}
      </section>
    </>
  );
}

export default ComponentUserOrdersReady;
