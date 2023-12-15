import styles from "./UserTrackOrder.module.css";

import LoaderWheel from "../../LoaderWheel.jsx";
import BoardHeader from "../BoardHeader.jsx";
import { useContext, useEffect, useState } from "react";
import { get } from "../../../util/api.js";
import { environment } from "../../../environments/environment.js";
import { UserContext } from "../../../context/GlobalUserProvider.jsx";
import UserOrderItem from "./UserOrderItem.jsx";

function UserTrackOrder() {
  const { user } = useContext(UserContext);
  const [loading, setLoading] = useState(false);
  const [orders, setOrders] = useState(null);

  useEffect(
    function () {
      setLoading(true);
      const abortController = new AbortController();
      async function fetchUserOrders() {
        const result = await get(environment.user_in_progress + user.id);
        // console.log(result);
        setOrders(result);
      }
      fetchUserOrders();
      setLoading(false);
      return () => abortController.abort();
    },
    [user.id]
  );

  return (
    <>
      <h2 className={styles.dashHeading}>Selected items</h2>

      <section className={styles.board}>
        <BoardHeader />
        {loading && <LoaderWheel />}
        {orders &&
          orders.map((order, i) => (
            <UserOrderItem key={order.id} order={order} />
          ))}
        {!orders && <h2>Your orders will appear here</h2>}
      </section>
    </>
  );
}

export default UserTrackOrder;
