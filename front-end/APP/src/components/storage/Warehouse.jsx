import styles from "./Warehouse.module.css";

import LoaderWheel from "../LoaderWheel.jsx";
import { useContext, useState } from "react";
import { UserContext } from "../../context/GlobalUserProvider.jsx";

function Warehouse() {
  const { user } = useContext(UserContext);
  const [loading, setLoading] = useState(false);

  // Response
  const receivedData = {
    category: "",
    partName: "",
    oemNUmber: "",
    quantity: "",
    partId: "",
  };

  return (
    <>
      <h2 className={styles.dashHeading}>Warehouse</h2>

      <section className={styles.board}>
        {loading && <LoaderWheel />}
        {/* всички части */}
      </section>
    </>
  );
}

export default Warehouse;
