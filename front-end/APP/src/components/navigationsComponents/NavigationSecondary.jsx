import { UserContext } from "../../context/GlobalUserProvider.jsx";
import styles from "./NavigationSecondary.module.css";
import NavSecListItem from "./NavSecListItem.jsx";
import { useContext, useEffect, useMemo, useState } from "react";
// import { UserContext } from "../UserProfile.jsx";

function NavigationSecondary() {
  const { user } = useContext(UserContext);

  const [currentMenu, setCurrentMenu] = useState([]);

  const userMenu = useMemo(
    () => ({
      user: [
        { link: "info", textContent: "Profile" },
        { link: "cart", textContent: "Cart" },
        // { link: "user-ready", textContent: "Ready" },
        { link: "user-in-progress", textContent: "In production" },
        // { link: "user-archive", textContent: "Archive" },
      ],
      accessoriesworker: [
        { link: "info", textContent: "Profile" },
        { link: "worker-orders", textContent: "Orders" },
      ],
      frameworker: [
        { link: "info", textContent: "Profile" },
        { link: "worker-orders", textContent: "Orders" },
      ],
      wheelworker: [
        { link: "info", textContent: "Profile" },
        { link: "worker-orders", textContent: "Orders" },
      ],
      qualitycontrol: [
        { link: "info", textContent: "Profile" },
        { link: "q-control-orders", textContent: "Quality Control" },
      ],
      manager: [
        { link: "info", textContent: "Profile" },
        { link: "managerOrders", textContent: "Orders" },
        { link: "manager-in-progress", textContent: "In production" },
        // { link: "manager-finished", textContent: "Finished" },
        // { link: "manager-dispatched", textContent: "Dispatched" },
        { link: "employers", textContent: "Employers" },
        // { link: "manager-storage", textContent: "Storage" },
        // { link: "statistic", textContent: "Statistic" },
      ],
    }),
    []
  );

  useEffect(() => {
    if (!user) return;
    setCurrentMenu(userMenu[user.role]);
  }, [user, userMenu]);

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
