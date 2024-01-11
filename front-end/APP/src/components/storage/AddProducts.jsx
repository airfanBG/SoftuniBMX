import styles from "./AddProducts.module.css";

import LoaderWheel from "../LoaderWheel.jsx";
import { useContext, useEffect, useState } from "react";
import { UserContext } from "../../context/GlobalUserProvider.jsx";
import { get } from "../../util/api.js";
import { environment } from "../../environments/environment.js";

function AddProducts() {
  const { user } = useContext(UserContext);
  const [loading, setLoading] = useState(false);
  const [suppliers, setSuppliers] = useState([]);

  useEffect(() => {
    async function getSuppliers() {
      const result = await get(environment.suppliers_list);
      if (!result.isError) {
        setSuppliers(result);
      }
      // console.log(result);
    }
    getSuppliers();
  }, []);

  return (
    <>
      <h2 className={styles.dashHeading}>Create parts request</h2>

      <section className={styles.board}>
        {/* <BoardHeader /> */}
        {loading && <LoaderWheel />}
        {/* <h2 className={styles.header}>Scrap</h2> */}
      </section>
    </>
  );
}
export default AddProducts;
