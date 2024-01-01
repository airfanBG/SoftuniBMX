import styles from "./ManagerDispatched.module.css";

import { memo, useState } from "react";
import LoaderWheel from "../../LoaderWheel.jsx";
import BoardHeader from "../BoardHeader.jsx";

function ManagerDispatched() {
  const [loading, setLoading] = useState(false);

  return (
    <>
      <section className={styles.board}>
        <BoardHeader />
        {loading && <LoaderWheel />}

        <h2 className={styles.boardHeading}>Dispatched</h2>
      </section>
    </>
  );
}

export default memo(ManagerDispatched);
