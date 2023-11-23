import styles from "./UserProfile.module.css";

// import { useContext, useEffect, useState } from "react";
import { clearUserData, getUserData, setUserData } from "../util/util.js";

import Navigation from "./navigationsComponents/Navigation.jsx";
import UserDash from "./dashComponents/UserDash.jsx";
import WorkerDash from "./dashComponents/WorkerDash.jsx";
import Footer from "./Footer.jsx";
import { createContext, useContext, useState } from "react";
import { UserContext } from "../context/GlobalUserProvider.jsx";

// export const UserContext = createContext({});

function UserProfile() {
  // const userData = getUserData();
  // const [user, setUser] = useState(userData.user);

  const { user } = useContext(UserContext);

  // function userBalanceHandler(action, value) {
  //   if (user === null) return;

  //   let amount = 0;
  //   if (action === "add") {
  //     amount = user.balance + value;
  //   } else {
  //     amount = user.balance - value;
  //   }
  //   console.log(amount);
  //   const changedLS = {
  //     ...user,
  //     balance: amount,
  //   };
  //   setUser({ ...user, balance: amount });
  //   setUserData(changedLS);
  // }
  return (
    // <UserContext.Provider value={{ user, setUser, userBalanceHandler }}>
    <div className={styles.componentBody}>
      <Navigation />
      <div className={styles.spacer}></div>
      <div className={styles.container}>
        {user.role === "user" && <UserDash />}
        {user.role === "worker" && <WorkerDash />}
        {user.role === "manager" && <WorkerDash />}
      </div>
      <Footer />
    </div>
    // </UserContext.Provider>
  );
}

export default UserProfile;
