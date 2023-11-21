import { useContext, useState } from "react";

import styles from "./UserInfo.module.css";

import { UserContext } from "../UserProfile.jsx";
import UserContactInfo from "./UserContactInfo.jsx";
import BoardHeader from "./BoardHeader.jsx";
import WorkerContactInfo from "./WorkerContactInfo.jsx";

function UserInfo() {
  const { user, userBalanceHandler } = useContext(UserContext);
  const [add, setAdd] = useState("");

  // console.log(user);

  function addMoneyBtnHandler() {
    // TODO: make request to update user balance
    //next is only for testing

    if (add === 0) return;
    userBalanceHandler("add", add);
  }

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
            {user.role === "user" && (
              <>
                <input
                  className={styles.addMoneyInput}
                  type="text"
                  value={add}
                  onChange={(e) => setAdd(Number(e.target.value))}
                />
                <button
                  className={styles.addMoney}
                  onClick={addMoneyBtnHandler}
                >
                  Add money
                </button>
              </>
            )}
          </figure>

          {user.role === "user" && <UserContactInfo />}
          {user.role === "worker" && <WorkerContactInfo />}
        </div>
      </section>
    </>
  );
}

export default UserInfo;
