import { useContext, useState } from "react";
import { Link, NavLink } from "react-router-dom";

import styles from "./ResponsiveMenu.module.css";
import Popup from "../Popup.jsx";
import { UserContext } from "../../context/GlobalUserProvider.jsx";

function ResponsiveMenu() {
  const [isVisible, setIsVisible] = useState(false);
  const { user, hasOrder } = useContext(UserContext);

  function toggle() {
    setIsVisible(!isVisible);
  }
  return (
    <div>
      <button onClick={toggle} className={styles.menuIcon}>
        &#9776;
      </button>
      {isVisible && (
        <Popup onClose={toggle}>
          <ul className={styles.navList} role="list">
            <li className={styles.navListItem}>
              {window.location.pathname === "/" && user.role === "user" ? (
                <NavLink to={"/app"} className={styles.navLink}>
                  Create
                </NavLink>
              ) : (
                <NavLink to={"/"} className={styles.navLink}>
                  Home
                </NavLink>
              )}
            </li>
            {window.location.pathname !== "/" &&
              user &&
              user.role === "user" && (
                <NavLink to={"/app"} className={styles.navLink}>
                  Create
                </NavLink>
              )}
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
              {user ? (
                <NavLink to={"/profile"} className={styles.navLink}>
                  {user.firstName} {user.lastName}
                </NavLink>
              ) : (
                <NavLink to={"/auth"} className={styles.navLink}>
                  Sign in
                </NavLink>
              )}
            </li>
            {user && hasOrder && (
              <li className={styles.navListItem}>
                <Link to={"/profile/cart"} className={styles.cartIcon}>
                  <ion-icon name="cart-sharp"></ion-icon>
                </Link>
              </li>
            )}
          </ul>
        </Popup>
      )}
    </div>
  );
}

export default ResponsiveMenu;
