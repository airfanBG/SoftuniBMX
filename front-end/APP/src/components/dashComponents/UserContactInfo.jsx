import { useContext, useEffect, useState } from "react";
import styles from "./UserContactInfo.module.css";
import { UserContext } from "../../context/GlobalUserProvider.jsx";
import { userInfo } from "../../userServices/userService.js";
// import { UserContext } from "../UserProfile.jsx";

function UserContactInfo({ user }) {
  // const { user } = useContext(UserContext);
  const [info, setInfo] = useState("");

  useEffect(function () {
    async function getClientInfo() {
      const data = await userInfo(user.id);
      setInfo(data);
    }
    getClientInfo();
  }, []);
  return (
    <>
      {info && (
        <div className={styles.contactWrapper}>
          <h2 className={styles.infoHeader}>Contact information</h2>
          <div className={styles.fullData}>
            <p className={styles.userData}>
              <span>Street: </span>
              {info.address.street}
            </p>
            <p className={styles.userData}>
              <span>Street number: </span>
              {info.address.strNumber}
            </p>

            <p className={styles.userData}>
              <span>District: </span>
              {info.address.district}
            </p>
            <p className={styles.userData}>
              <span>City: </span>
              {info.city}
            </p>

            <p className={styles.userData}>
              <span>Post code: </span>
              {info.address.postCode}
            </p>
            <p className={styles.userData}>
              <span>Country: </span>
              {info.address.country}
            </p>
            <p className={styles.userData}>
              <span>Building: </span>
              {info.address.block}
            </p>
            <p className={styles.userData}>
              <span>Floor: </span>
              {info.address.floor}
            </p>
            <p className={styles.userData}>
              <span>Balance: </span>
              {info.balance.toFixed(2)} BGN
            </p>
            <p className={styles.userData}>
              <span>IBAN: </span>
              {info.iban}
            </p>
          </div>
        </div>
      )}
    </>
  );
}

export default UserContactInfo;
