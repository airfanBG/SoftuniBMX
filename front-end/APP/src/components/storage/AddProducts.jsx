import styles from "./AddProducts.module.css";

import LoaderWheel from "../LoaderWheel.jsx";
import { useContext, useState } from "react";
import { UserContext } from "../../context/GlobalUserProvider.jsx";

function AddProducts() {
  const { user } = useContext(UserContext);
  const [loading, setLoading] = useState(false);
  return (
    <>
      <h2 className={styles.dashHeading}>Add Products</h2>

      <section className={styles.board}>
        {/* <BoardHeader /> */}
        {loading && <LoaderWheel />}
        {/* <h2 className={styles.header}>Scrap</h2> */}
      </section>
    </>
  );
}
export default AddProducts;
