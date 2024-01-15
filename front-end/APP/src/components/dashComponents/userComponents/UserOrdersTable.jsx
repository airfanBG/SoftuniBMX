import styles from "./UserOrdersTable.module.css";
import { useNavigate } from "react-router-dom";

function UserOrdersTable({ orders }) {
  const navigate = useNavigate();

  return (
    <>
      <table className={styles.table}>
        <thead className={styles.head}>
          <tr className={styles.rowHead}>
            <th>Serial Number</th>
            <th>Date of Order</th>
            <th>Date Finished</th>
            <th>Amount</th>
            <th>Parts</th>
          </tr>
        </thead>
        <tbody>
          {orders.map((order) => (
            <tr key={order.orderId} className={styles.row}>
              <td>{order.serialNumber}</td>
              <td>{order.orderDateStart}</td>
              <td>{order.orderDateFinish}</td>
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
