import styles from "./WorkerDash.module.css";

import NavigationSecondary from "../../navigationsComponents/NavigationSecondary.jsx";
import { Outlet } from "react-router-dom";

function WorkerDash({ user }) {
  return (
    <div className={styles.wrapper}>
      <NavigationSecondary />
      <Outlet />
    </div>
  );
}

export default WorkerDash;
