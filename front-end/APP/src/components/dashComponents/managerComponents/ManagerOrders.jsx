import { useEffect, useState } from "react";
import BoardHeader from "../BoardHeader.jsx";
import styles from "./ManagerOrders.module.css";
import { getOrdersList } from "../../../bikeServices/service.js";
import Order from "./Order.jsx";
import Paginator from "../../Paginator.jsx";

function ManagerOrders() {
  const [orders, setOrders] = useState({});
  const [page, setPage] = useState(1);

  useEffect(function () {
    const abortController = new AbortController();

    async function getOrders() {
      const orders = await getOrdersList();
      orders.sort((a, b) => a.createdAt - b.createdAt);
      setOrders(orders);
    }
    getOrders();

    return () => abortController.abort();
  }, []);

  function onOrdersChange(newData) {
    setOrders(newData);
  }

  function handlePage(page) {
    console.log(page);
    setPage(page);
  }

  if (orders.length === 0) return <h2>There is no orders in this category</h2>;
  if (orders.length > 0)
    return (
      <>
        <h2 className={styles.dashHeading}>Orders in sequence</h2>
        <section className={styles.board}>
          <BoardHeader />
          <div className={styles.orders}>
            {orders.map((order) => (
              <Order key={order.orderId} order={order} />
            ))}
          </div>
          <Paginator
            // pages={orders.length}
            page={page}
            pages={30}
            countOnPage={4}
            size={24}
            fontSize={1.6}
            // bgColor=""
            // brColor=""
            handlePage={handlePage}
            // selected="red"
          />
        </section>
      </>
    );
}

export default ManagerOrders;
