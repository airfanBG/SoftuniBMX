import React from "react";
import styles from "./UserOrdersTable.module.css";
import { useNavigate } from "react-router-dom";

function UserOrdersTable({ orders }) {
  const navigatePart = useNavigate("/");
  const navigateOrder = useNavigate("/");
  function viewPart(partId) {
    //for now and to be fixed
    navigatePart("/about");
  }

  function viewOrder(orderId) {
    //for now and to be fixed
    navigateOrder("/about");
  }

  return (
    <table className={styles.table}>
      <thead className={styles.head}>
        <tr className={styles.rowHead}>
          <th>Serial Number</th>
          <th>Order Date</th>
          <th>Amount</th>
          <th>Parts</th>
        </tr>
      </thead>
      <tbody>
        {orders.map((order) => (
          <tr key={order.orderId} className={styles.row}>
            <td>
              <a
                href="#"
                onClick={(e) => {
                  e.preventDefault();
                  viewOrder(order.orderId);
                }}
              >
                {order.serialNumber}
              </a>
            </td>
            <td>{order.orderDate}</td>
            <td>{order.amount.toFixed(2)}</td>
            <td>
              <ul>
                {order.parts.map((part) => (
                  <li key={part.id}>
                    {part.name}{" "}
                    <a
                      href="#"
                      onClick={(e) => {
                        e.preventDefault();
                        viewPart(part.id);
                      }}
                    >
                      View Part
                    </a>
                  </li>
                ))}
              </ul>
            </td>
          </tr>
        ))}
      </tbody>
    </table>
  );
}

export default UserOrdersTable;
