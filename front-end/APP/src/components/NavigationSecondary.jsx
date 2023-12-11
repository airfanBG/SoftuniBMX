import { Link } from "react-router-dom";
import styles from "./NavigationSecondary.module.css";

const customerNav = {};

const worker = {
  orders: [],
};

function NavigationSecondary() {
  return (
    <nav className={styles.nav}>
      <ul className={styles.lists}>
        <li className={styles.litItem}>
          <Link className={styles.secNavLink} to={"#"}>
            Option 1
          </Link>
        </li>
        <li className={styles.litItem}>
          <Link className={styles.secNavLink} to={"#"}>
            Option 2
          </Link>
        </li>
        <li className={styles.litItem}>
          <Link className={styles.secNavLink} to={"#"}>
            Option 3
          </Link>
        </li>
      </ul>
    </nav>
  );
}

export default NavigationSecondary;
