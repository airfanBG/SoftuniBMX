import React, { useState } from "react";
import styles from "./UserOrdersTable.module.css";
import Popup from "../../Popup";
import { get } from "../../../util/api";
import ComponentUserOrderInfo from "./ComponentUserOrdersInfo";
import { environment } from "../../../environments/environment.js";
import { useNavigate } from "react-router-dom";

function UserOrdersTable({ orders }) {
  const [background, setBackground] = useState(false);

  const [data, setData] = useState({});
  const navigate = useNavigate();

  //Order View
  function viewOrder(orderId) {
    setBackground(true);
    async function getData(orderId) {
      const result = await get(environment.find_order + orderId);
      setData(result);
    }
    getData(orderId);
  }

  function close() {
    setBackground(false);
  }

  return (
    <>
      {background && (
        <Popup onClose={close}>
          <ComponentUserOrderInfo data={data} />
        </Popup>
      )}
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
                          navigate(`/app/part/${part.id}`);
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
    </>
  );
}

export default UserOrdersTable;
