import styles from "./ComponentUserOrdersReady.module.css";
import UserOrdersTable from "./UserOrdersTable.jsx";

import { useContext, useState } from "react";

import { UserContext } from "../../../context/GlobalUserProvider.jsx";

import BoardHeader from "../BoardHeader.jsx";
import LoaderWheel from "../../LoaderWheel.jsx";
//import { environment } from "../../../environments/environment.js";
import React, { useEffect } from "react";

function ComponentUserOrdersReady() {
  const { user } = useContext(UserContext);
  const [loading, setLoading] = useState(false);

  const [data, setData] = useState([]);
  const clientId = user.id;
  //To be replaced with the envirement urls
  const apiUrl = `https://localhost:7047/api/client_order/get_orders_ready?clientId=${clientId}`;

  useEffect(() => {
    fetch(apiUrl)
      .then((response) => {
        if (!response.ok) {
          throw new Error(`HTTP error! Status: ${response.status}`);
        }
        return response.json();
      })
      .then((resultData) => {
        setData(resultData);
      })
      .catch((error) => {
        console.error("Error fetching data:", error);
      });
  }, [clientId]);

  return (
    <>
      <h2 className={styles.dashHeading}>Selected items</h2>

      <section className={styles.board}>
        <BoardHeader />
        {loading && <LoaderWheel />}
        <UserOrdersTable orders={data} />
      </section>
    </>
  );
}

export default ComponentUserOrdersReady;
