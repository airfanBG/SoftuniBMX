import LoaderWheel from "../../../LoaderWheel.jsx";
import styles from "./EmployeesListComponent.module.css";

import { memo, useState } from "react";

function EmployeesListComponent() {
  const [loading, setLoading] = useState(false);
  return (
    <>
      <h2 className={styles.dashHeading}>Employees List</h2>

      <section className={styles.board}>
        {loading && <LoaderWheel />}
        {/* всички части */}
      </section>
    </>
  );
}

export default memo(EmployeesListComponent);
