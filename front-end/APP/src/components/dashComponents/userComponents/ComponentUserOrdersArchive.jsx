import styles from "./ComponentUserOrdersArchive.module.css";
import UserOrdersTable from "./UserOrdersTable.jsx";

import { useContext, useState } from "react";

import { UserContext } from "../../../context/GlobalUserProvider.jsx";
import { environment } from "../../../environments/environment.js";
import BoardHeader from "../BoardHeader.jsx";
import LoaderWheel from "../../LoaderWheel.jsx";
import React, { useEffect } from "react";
import { get } from "../../../util/api.js";

function ComponentUserOrdersArchive() {
  const { user } = useContext(UserContext);
  const [loading, setLoading] = useState(false);

  const [data, setData] = useState([]);

  useEffect(() => {
    async function getData() {
      const result = await get(environment.orders_archive + user.id);
      setData(result);
    }
    getData();
  }, [user.id]);

  return (
    <>
      <h2 className={styles.dashHeading}>Orders history</h2>

      <section className={styles.board}>
        <BoardHeader />
        {loading && <LoaderWheel />}
        <UserOrdersTable orders={data} />
      </section>
    </>
  );
}

export default ComponentUserOrdersArchive;
