import { Link } from "react-router-dom";
import styles from "./navSecListItem.module.css";

function NavSecListItem({ link, text }) {
  return (
    <li className={styles.litsItem}>
      <Link className={styles.secNavLink} to={link}>
        {text}
      </Link>
    </li>
  );
}

export default NavSecListItem;
