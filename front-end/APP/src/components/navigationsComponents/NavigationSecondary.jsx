import styles from "./NavigationSecondary.module.css";
import NavSecListItem from "./navSecListItem.jsx";
import { useContext, useEffect, useState } from "react";
import { UserContext } from "../UserProfile.jsx";

function NavigationSecondary() {
  const { user } = useContext(UserContext);

  const [currentMenu, setCurrentMenu] = useState([]);

  const userMenu = {
    user: [
      { link: "info", textContent: "Profile" },
      { link: "user-orders-ready", textContent: "Ready" },
      { link: "user-orders-in_process", textContent: "In process" },
      { link: "user-past-orders", textContent: "Past orders" },
    ],
    worker: [
      { link: "info", textContent: "Profile" },
      { link: "orders", textContent: "Orders" },
      { link: "finished", textContent: "Finished" },
    ],
    manager: [
      { link: "managerLink1", textContent: "Profile" },
      { link: "managerLink2", textContent: "Orders" },
      { link: "managerLink3", textContent: "Finished" },
    ],
  };

  useEffect(() => {
    if (!user) return;
    setCurrentMenu(userMenu[user.role]);
  }, [user.role]);

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
    </nav>
  );
}

export default NavigationSecondary;
