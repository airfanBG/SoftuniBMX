import { Link, NavLink } from "react-router-dom";
import styles from "./NavSecListItem.module.css";

function NavSecListItem({ link, text }) {
  return (
    <li className={styles.litsItem}>
      <NavLink className={styles.secNavLink} to={link}>
        {text}
      </NavLink>
    </li>
  );
}

export default NavSecListItem;
