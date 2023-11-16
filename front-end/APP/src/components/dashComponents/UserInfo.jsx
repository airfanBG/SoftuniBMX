import { useContext } from "react";

import Balance from "./Balance.jsx";
import Category from "./Category.jsx";
import styles from "./UserInfo.module.css";
import { UserContext } from "../UserProfile.jsx";
import UserContactInfo from "./UserContactInfo.jsx";
import BoardHeader from "./BoardHeader.jsx";

function UserInfo() {
  const { user } = useContext(UserContext);

  // console.log(user);

  return (
    <>
      {/* <h2 className={styles.dashHeading}>Orders in sequence</h2> */}
      <h2 className={styles.dashHeading}>
        {user.firstName} {user.lastName}
      </h2>

      <section className={styles.board}>
        <BoardHeader />

        <div className={styles.userInfoWrapper}>
          <figure className={styles.mainInfo}>
            <div className={styles["imgHolder"]}>
              <img src="https://i.pravatar.cc/300" alt="User picture" />
            </div>

            <p className={styles.userEmail}>{user.email}</p>
            <p className={styles.userEmail}>{user.phone}</p>
          </figure>

          {user.role === "user" && <UserContactInfo />}
          {user.role === "worker" && <UserContactInfo />}
        </div>
      </section>
    </>
  );
}

export default UserInfo;
