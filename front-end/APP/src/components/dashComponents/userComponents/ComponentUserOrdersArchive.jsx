import styles from "./ComponentUserOrdersArchive.module.css";
import UserOrdersTable from "./UserOrdersTable.jsx";

import { useContext, useState } from "react";

import { UserContext } from "../../../context/GlobalUserProvider.jsx";

import BoardHeader from "../BoardHeader.jsx";
import LoaderWheel from "../../LoaderWheel.jsx";
import React, { useEffect } from "react";

function ComponentUserOrdersArchive() {
  const { user } = useContext(UserContext);
  const [loading, setLoading] = useState(false);

  const [data, setData] = useState([]);
  //To be replaced with dinamicly geting the id
  const clientId = "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd";
  //To be replaced with the envirement urls
  const apiUrl = `https://localhost:7047/api/client_order/get_orders_archive?clientId=${clientId}`;

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

export default ComponentUserOrdersArchive;
