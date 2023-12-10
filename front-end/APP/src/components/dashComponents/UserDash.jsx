import NavigationSecondary from "../navigationsComponents/NavigationSecondary.jsx";
import styles from "./UserDash.module.css";
import { Outlet } from "react-router-dom";

function UserDash() {
  return (
    <div className={styles.wrapper}>
      <NavigationSecondary />
      <Outlet />
    </div>
  );
}

export default UserDash;
