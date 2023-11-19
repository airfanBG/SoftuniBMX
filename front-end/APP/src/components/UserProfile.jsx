import styles from "./UserProfile.module.css";

// import { useContext, useEffect, useState } from "react";
import { clearUserData, getUserData, setUserData } from "../util/util.js";

import Navigation from "./navigationsComponents/Navigation.jsx";
import UserDash from "./dashComponents/UserDash.jsx";
import WorkerDash from "./dashComponents/WorkerDash.jsx";
import Footer from "./Footer.jsx";
import { createContext, useState } from "react";

export const UserContext = createContext({});

function UserProfile() {
  const userData = getUserData();
  const [user, setUser] = useState(userData);

  function userBalanceHandler(value) {
    if (user === null) return;
    const changedLS = { ...user, balance: user.balance - value };
    setUser({ ...user, balance: user.balance - value });
    setUserData(changedLS);
  }
  return (
    <UserContext.Provider value={{ user, userBalanceHandler }}>
      <div className={styles.componentBody}>
        <Navigation />
        <div className={styles.spacer}></div>
        <div className={styles.container}>
          {user.role === "user" && <UserDash />}
          {user.role === "worker" && <WorkerDash />}
        </div>
        <Footer />
      </div>
    </UserContext.Provider>
  );
}

export default UserProfile;
