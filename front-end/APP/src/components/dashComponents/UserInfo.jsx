import { useContext, useState } from "react";

import styles from "./UserInfo.module.css";

import { UserContext } from "../../context/GlobalUserProvider.jsx";

import UserContactInfo from "./UserContactInfo.jsx";
import BoardHeader from "./BoardHeader.jsx";
import WorkerContactInfo from "./workerComponents/WorkerContactInfo.jsx";
import { setUserData } from "../../util/util.js";
import { updateUserData, userInfo } from "../../userServices/userService.js";

import { User, CameraPlus } from "@phosphor-icons/react";
import ManagerContactInfo from "./managerComponents/ManagerContactInfo.jsx";

function UserInfo() {
  const { user, updateUser } = useContext(UserContext);
  const [add, setAdd] = useState("");
  // console.log(user);
  async function addMoneyBtnHandler() {
    const currentUser = await userInfo(user.id, user.role);

    if (add === 0) return;
    updateUser({ ...user, balance: user.balance + add });
    setUserData({ ...user, balance: user.balance + add });
    setAdd("");

    const data = {
      ...currentUser,
      password: currentUser.repass,
      balance: currentUser.balance + add,
    };

    const result = await updateUserData(user.id, data);
  }

  return (
    <>
      <h2 className={styles.dashHeading}>
        {user.firstName} {user.lastName}
      </h2>

      <section className={styles.board}>
        <BoardHeader />

        <div className={styles.userInfoWrapper}>
          <figure className={styles.mainInfo}>
            <div className={styles["imgHolder"]}>
              {!user.img && <User size={196} color="#363636" weight="thin" />}

              <CameraPlus
                size={32}
                color="#0a0a0a"
                weight="thin"
                className={styles.uploadPicture}
              />
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

          {user.role === "user" && <UserContactInfo user={user} />}
          {user.role === "worker" && <WorkerContactInfo user={user} />}
          {user.role === "manager" && <ManagerContactInfo />}
        </div>
      </section>
    </>
  );
}

export default UserInfo;
