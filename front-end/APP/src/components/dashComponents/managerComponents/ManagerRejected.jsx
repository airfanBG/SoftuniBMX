import styles from "./ManagerRejected.module.css";

import { useContext, useState } from "react";

import { UserContext } from "../../../context/GlobalUserProvider.jsx";

import BoardHeader from "../BoardHeader.jsx";
import LoaderWheel from "../../LoaderWheel.jsx";

function ManagerRejected() {
  const { user } = useContext(UserContext);
  const [loading, setLoading] = useState(false);

  return (
    <>
      <h2 className={styles.dashHeading}>Selected items</h2>

      <section className={styles.board}>
        <BoardHeader />
        {loading && <LoaderWheel />}
        <h2>Manager rejected</h2>
      </section>
    </>
  );
}

export default ManagerRejected;
