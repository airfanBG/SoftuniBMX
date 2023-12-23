import styles from "./Scrap.module.css";

import { useContext, useState } from "react";

import { UserContext } from "../../context/GlobalUserProvider.jsx";

import BoardHeader from "../dashComponents/BoardHeader.jsx";
import LoaderWheel from "../LoaderWheel.jsx";

function Scrap() {
  const { user } = useContext(UserContext);
  const [loading, setLoading] = useState(false);

  return (
    <>
      <h2 className={styles.dashHeading}>Scrap</h2>

      <section className={styles.board}>
        {/* <BoardHeader /> */}
        {loading && <LoaderWheel />}
        {/* <h2 className={styles.header}>Scrap</h2> */}
      </section>
    </>
  );
}

export default Scrap;
