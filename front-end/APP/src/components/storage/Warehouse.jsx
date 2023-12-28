import styles from "./Warehouse.module.css";

import LoaderWheel from "../LoaderWheel.jsx";
import { useEffect, useState, memo } from "react";

import { get } from "../../util/api.js";
import { environment } from "../../environments/environment.js";

import PartInWarehouse from "./PartInWarehouse.jsx";
import BoardHeader from "../dashComponents/BoardHeader.jsx";

function Warehouse() {
  const [loading, setLoading] = useState(false);
  const [error, setError] = useState({});

  return (
    <>
      <h2 className={styles.dashHeading}>Warehouse</h2>

      <section className={styles.board}>
        <BoardHeader />
        {loading && <LoaderWheel />}
      </section>
    </>
  );
}

export default memo(Warehouse);
