import styles from "./ManagerStatistic.module.css";

import { useState } from "react";

import OrderPartStatistic from "./OrderPartStatistic.jsx";
import EmployeeStatistic from "./EmployeeStatistic.jsx";
import BoardHeader from "../BoardHeader.jsx";

function ManagerStatistic() {
  const [background, setBackground] = useState(false);
  const [active, setActive] = useState("order-part-statistic");

  function close(e) {
    // setCurrentOrder({});
    // setBackground(false);
  }

  function onSelectActive(selected) {
    if (active === selected) return;
    setActive(selected);
  }

  return (
    <>
      <h2 className={styles.dashHeadingMain}>Storage</h2>

      <section className={styles.board}>
        <BoardHeader />

        <div className={styles.wrapper}>
          <aside className={styles.control}>
            <button
              className={styles.actionLink}
              onClick={() => onSelectActive("order-part-statistic")}
            >
              Order part statistic
            </button>

            <button
              className={styles.actionLink}
              onClick={() => onSelectActive("employee-statistic")}
            >
             Employee statistic
            </button>
          </aside>
          <main className={styles.main}>
            {active === "order-part-statistic" && <OrderPartStatistic/>}
            {active === "employee-statistic" && <EmployeeStatistic />}
          </main>
        </div>
      </section>
    </>
  );
}

export default ManagerStatistic;
