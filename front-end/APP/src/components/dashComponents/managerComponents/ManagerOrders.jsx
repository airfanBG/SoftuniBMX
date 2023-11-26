import { useContext, useEffect, useState } from "react";
import BoardHeader from "../BoardHeader.jsx";
import styles from "./ManagerOrders.module.css";
import { getList } from "../../../bikeServices/service.js";
import Order from "./Order.jsx";
import { OrdersContext } from "../../../context/GlobalUserProvider.jsx";

function ManagerOrders() {
  const { orders } = useContext(OrdersContext);

  // const [ordersList, setOrdersList] = useState([]);

  // useEffect(function () {
  //   const abortController = new AbortController();

  //   async function ordersFunc() {
  //     const orders = await getList("orders");
  //     orders.sort((a, b) => a.createdAt - b.createdAt);
  //     setOrdersList(orders);
  //   }
  //   ordersFunc();

  //   return () => abortController.abort();
  // }, []);

  if (orders.length === 0) return <h2>There is no orders in this category</h2>;
  return (
    <>
      <h2 className={styles.dashHeading}>Orders in sequence</h2>
      <section className={styles.board}>
        <BoardHeader />
        <div className={styles.orders}>
          {orders.map((order) => (
            <Order key={order.id} order={order} />
          ))}
        </div>
      </section>
    </>
  );
}

export default ManagerOrders;
