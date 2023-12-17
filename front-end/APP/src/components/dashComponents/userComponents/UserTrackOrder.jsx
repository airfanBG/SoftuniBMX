import styles from "./UserTrackOrder.module.css";

import { useContext, useState } from "react";
import { UserContext } from "../../../context/GlobalUserProvider.jsx";

import LoaderWheel from "../../LoaderWheel.jsx";
import BoardHeader from "../BoardHeader.jsx";
import UserOrderItem from "./UserOrderItem.jsx";

function UserTrackOrder() {
  const { user } = useContext(UserContext);
  const [loading, setLoading] = useState(false);
  const [orders, setOrders] = useState(null);

  return (
    <>
      <h2 className={styles.dashHeading}>Selected items</h2>

      <section className={styles.board}>
        <BoardHeader />
        {loading && <LoaderWheel />}

        {!orders && <h2>Your orders will appear here</h2>}
      </section>
    </>
  );
}

export default UserTrackOrder;
