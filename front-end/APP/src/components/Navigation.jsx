import styles from "./Navigation.module.css";
import { NavLink } from "react-router-dom";

function Navigation() {
  return (
    <div className={styles.navigation}>
      <p className={styles.logo}>
        <NavLink to={"/"} id="start" className={styles.logoFirstLine}>
          e<span>&#10006;</span>treme - BMX
        </NavLink>
        <span className={styles.logoSecondary}>Bicycle Management</span>
      </p>
      <nav className={styles.nav}>
        <ul className={styles.navList} role="list">
          <li className={styles.navListItem}>
            <NavLink to={"/"} className={styles.navLink}>
              Home
            </NavLink>
          </li>
          <li className={styles.navListItem}>
            <NavLink to={"/about"} className={styles.navLink}>
              About
            </NavLink>
          </li>
          <li className={styles.navListItem}>
            <NavLink to={"/contacts"} className={styles.navLink}>
              Contacts
            </NavLink>
          </li>
          <li className={styles.navListItem}>
            <NavLink to={"/login"} className={styles.navLink}>
              Sign in
            </NavLink>
          </li>
        </ul>
      </nav>
    </div>
  );
}

export default Navigation;
