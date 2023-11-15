import { useContext } from "react";
import styles from "./UserContactInfo.module.css";
import { UserContext } from "../UserProfile.jsx";

function UserContactInfo() {
  const { user } = useContext(UserContext);
  return (
    <>
      <div className={styles.contactWrapper}>
        <h2 className={styles.infoHeader}>Contact information</h2>
        <div className={styles.fullData}>
          <p className={styles.userData}>
            <span>Street: </span>
            {user.address.street}
          </p>
          <p className={styles.userData}>
            <span>Street number: </span>
            {user.address.strNumber}
          </p>

          <p className={styles.userData}>
            <span>District: </span>
            {user.address.district}
          </p>
          <p className={styles.userData}>
            <span>City: </span>
            {user.city}
          </p>

          <p className={styles.userData}>
            <span>Post code: </span>
            {user.address.postCode}
          </p>
          <p className={styles.userData}>
            <span>Country: </span>
            {user.address.country}
          </p>
          <p className={styles.userData}>
            <span>Building: </span>
            {user.address.block}
          </p>
          <p className={styles.userData}>
            <span>Floor: </span>
            {user.address.floor}
          </p>
          <p className={styles.userData}>
            <span>Balance: </span>
            {user.balance} BGN
          </p>
          <p className={styles.userData}>
            <span>IBAN: </span>
            {user.iban}
          </p>
        </div>
      </div>
    </>
  );
}

export default UserContactInfo;
