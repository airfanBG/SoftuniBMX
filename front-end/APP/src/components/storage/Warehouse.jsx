import styles from "./Warehouse.module.css";

import LoaderWheel from "../LoaderWheel.jsx";
import { useEffect, useState, memo } from "react";

import { get } from "../../util/api.js";
import { environment } from "../../environments/environment.js";

import PartInWarehouse from "./PartInWarehouse.jsx";
import BoardHeader from "../dashComponents/BoardHeader.jsx";

function Warehouse() {
  const [partList, setPartList] = useState([]);
  const [loading, setLoading] = useState(false);
  const [error, setError] = useState({});

  useEffect(function () {
    setLoading(true);

    const abortController = new AbortController();

    async function getPartsInWarehouse() {
      const result = await get(environment.parts_in_stock);
      if (!result) {
        setLoading(false);
        return setError({
          message: "Something went wrong. Service can not get data!",
        });
      }
      setPartList(result.parts);
      setLoading(false);
    }
    getPartsInWarehouse();

    return () => abortController.abort();
  }, []);

  if (partList.length === 0) return <h2>There is no parts in stock</h2>;

  return (
    <>
      <h2 className={styles.dashHeading}>Warehouse</h2>

      <section className={styles.board}>
        {/* <BoardHeader /> */}
        {loading && <LoaderWheel />}
        {partList.map((part, i) => (
          <PartInWarehouse key={part.id} part={part} i={i + 1} />
        ))}
      </section>
    </>
  );
}

export default memo(Warehouse);
