import { useEffect, useState } from "react";
import styles from "./Navigation.module.css";
import { NavLink } from "react-router-dom";
import { getUserData } from "../../util/util.js";

function Navigation() {
  const [isUser, setIsUser] = useState(null);
  const navLocation = window.location.href;

  useEffect(function () {
    const user = getUserData();
    if (user) setIsUser(user);
    // console.log(user);

    return () => {
      setIsUser(user);
    };
  }, []);

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
            {navLocation === "http://localhost:5173/" ? (
              <NavLink to={"app"} className={styles.navLink}>
                Create
              </NavLink>
            ) : (
              <NavLink to={"/"} className={styles.navLink}>
                Home
              </NavLink>
            )}
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
            {isUser ? (
              <NavLink to={"/profile"} className={styles.navLink}>
                {isUser.firstName} {isUser.lastName}
              </NavLink>
            ) : (
              <NavLink to={"/auth"} className={styles.navLink}>
                Sign in
              </NavLink>
            )}
          </li>
        </ul>
      </nav>
    </div>
  );
}

export default Navigation;
