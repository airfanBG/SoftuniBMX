import styles from "./UserProfile.module.css";

// import { useContext, useEffect, useState } from "react";
import { getUserData } from "../util/util.js";

import Navigation from "./navigationsComponents/Navigation.jsx";
import UserDash from "./dashComponents/UserDash.jsx";
import WorkerDash from "./dashComponents/WorkerDash.jsx";
import Footer from "./Footer.jsx";
import { createContext } from "react";

export const UserContext = createContext({});

function UserProfile() {
  const user = getUserData();

  return (
    <UserContext.Provider value={{ user }}>
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
