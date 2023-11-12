import styles from "./UserProfile.module.css";

import { useEffect, useState } from "react";
import { getUserData } from "../util/util.js";

import Navigation from "./navigationsComponents/Navigation.jsx";
import UserDash from "./dashComponents/UserDash.jsx";
import WorkerDash from "./dashComponents/WorkerDash.jsx";
import Footer from "./Footer.jsx";

function UserProfile() {
  const [user, setUser] = useState({});

  useEffect(function () {
    const user = getUserData();
    if (!user) return;
    setUser({ ...user });
  }, []);

  return (
    <div className={styles.componentBody}>
      <Navigation />
      <div className={styles.spacer}></div>
      <div className={styles.container}>
        {/* {user.role === "worker" && <UserDash {...user} />}
        {user.role === "user" && <WorkerDash {...user} />} */}
        {user.role === "user" && <UserDash {...user} />}
        {user.role === "worker" && <WorkerDash {...user} />}
      </div>
      <Footer />
    </div>
  );
}

export default UserProfile;
