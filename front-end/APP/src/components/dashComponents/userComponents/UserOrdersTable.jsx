import React, { useState, useContext } from "react";
import { UserContext } from "../../../context/GlobalUserProvider.jsx";
import styles from "./UserOrdersTable.module.css";
import Popup from "../../Popup";
import { get } from "../../../util/api";
import ComponentUserOrderInfo from "./ComponentUserOrdersInfo";
import { environment } from "../../../environments/environment.js";

function UserOrdersTable({ orders }) {
  const [background, setBackground] = useState(false);
  const [background2, setBackground2] = useState(false);
  const [background3, setBackground3] = useState(false);
  const [data, setData] = useState({});
  const [comment, setComment] = useState({});
  const { user } = useContext(UserContext);

  //View Part
  function viewPart(partId) {
    async function getData(partId) {
      const result = await get(environment.find_part + partId);
      result.images = Array.from(result.images);
      setData(result);
      getComment(partId, user.id);
    }
    async function getComment(partId, clientId) {
      try {
        const result = await get(
          environment.find_comment + clientId + `&partId=${partId}`
        );

        if (result === null) {
          console.log(result);
        } else {
          setComment(result);
        }
      } catch {
        console.error("error");
      }
    }
    getData(partId);
    setBackground2(true);
  }

  function close2() {
    setBackground2(false);
  }

  function close3() {
    setBackground3(false);
  }

  function viewComment() {
    setBackground3(true);
  }

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
      {background2 && (
        <Popup onClose={close2}>
          <div className={styles.partContainer}>
            <h2>{data.name}</h2>
            <div>
              {data.images &&
                data.images.map((image, index) => (
                  <img
                    key={index}
                    src={image}
                    alt={`Part Image ${index + 1}`}
                    style={{ maxWidth: "300px", marginRight: "10px" }}
                  />
                ))}
            </div>
            <p>
              Description: <span>{data.description}</span>
            </p>
            <p>
              Intend: <span>{data.intend}</span>
            </p>
            <p>
              OEM Number: <span>{data.oemNumber}</span>
            </p>
            <p>
              Type: <span>{data.type}</span>
            </p>
            <p>
              Category: <span>{data.category}</span>
            </p>
            <p>
              Sale Price: <span>{data.salePrice}</span>
            </p>
          </div>
          <p
            className={styles.view}
            onClick={(e) => {
              e.preventDefault();
              viewComment();
            }}
          >
            View Comment
          </p>
          {background3 && (
            <Popup onClose={close3}>
              <div className={styles.comment}>
                <p className={styles.commentTitle}>{comment.title}</p>
                <p className={styles.commentText}>{comment.description}</p>
                <p>Edit</p>
              </div>
            </Popup>
          )}
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
    </>
  );
}

export default UserOrdersTable;
