import { Link, useNavigate } from "react-router-dom";
// import { useNavigate } from "react-router-dom";

import styles from "./NavigationSecondary.module.css";
import NavSecListItem from "./navSecListItem.jsx";
import { useEffect, useState } from "react";
import OrderItem from "../dashComponents/OrderItem.jsx";
import { logout } from "../../util/auth.js";

function NavigationSecondary({ role }) {
  const [currentMenu, setCurrentMenu] = useState([]);
  const navigate = useNavigate();

  const userMenu = {
    user: [
      { link: "tUserLink1", textContent: "Profile" },
      { link: "tUserLink2", textContent: "Ready" },
      { link: "tUserLink3", textContent: "In process" },
      { link: "UserLink4", textContent: "Past orders" },
    ],
    worker: [
      { link: "testWorkerLink1", textContent: "Profile" },
      { link: "testWorkerLink2", textContent: "Orders" },
      { link: "testWorkerLink3", textContent: "Finished" },
    ],
    manager: [
      { link: "managerLink1", textContent: "Profile" },
      { link: "managerLink2", textContent: "Orders" },
      { link: "managerLink3", textContent: "Finished" },
    ],
  };

  function onLogout() {
    const exit = logout();
    navigate("/");
  }

  useEffect(() => {
    if (!role) return;
    setCurrentMenu(userMenu[role]);
  }, [role]);

  return (
    <nav className={styles.nav}>
      <ul className={styles.lists}>
        {currentMenu.length !== 0 &&
          currentMenu.map((x) => (
            <NavSecListItem
              key={x.textContent}
              link={x.link}
              text={x.textContent}
            />
          ))}
      </ul>
      <button className={styles.logout} onClick={onLogout}>
        Logout
      </button>
    </nav>
  );
}

export default NavigationSecondary;

{
  /* <li className={styles.litItem}>
<Link className={styles.secNavLink} to={{ role }}>
  Profile
</Link>
</li>
<li className={styles.litItem}>
<Link className={styles.secNavLink} to={"#"}>
  Orders
</Link>
</li>
<li className={styles.litItem}>
<Link className={styles.secNavLink} to={"#"}>
  Finished
</Link>
</li>  */
}
