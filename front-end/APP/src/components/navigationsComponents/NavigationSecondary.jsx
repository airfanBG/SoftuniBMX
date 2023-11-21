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
      { link: "cart", textContent: "Cart" },
      { link: "user-orders-ready", textContent: "Ready" },
      { link: "user-orders-in_process", textContent: "In production" },
      { link: "user-past-orders", textContent: "Past orders" },
    ],
    worker: [
      { link: "info", textContent: "Profile" },
      { link: "orders", textContent: "Orders" },
      { link: "finished", textContent: "Finished" },
    ],
    manager: [
      { link: "managerLink2", textContent: "Orders" },
      { link: "managerLink4", textContent: "In production" },
      { link: "managerLink3", textContent: "Ready" },
      { link: "managerLink5", textContent: "Finished" },
      { link: "managerLink6", textContent: "Employees" },
      { link: "managerLink1", textContent: "Statistic" },
    ],
  };

  useEffect(() => {
    if (!user) return;
    setCurrentMenu(userMenu[user.role]);
  }, [user]);

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
