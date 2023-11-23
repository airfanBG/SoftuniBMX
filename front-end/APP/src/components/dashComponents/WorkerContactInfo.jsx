import { useContext } from "react";
import styles from "./WorkerContactInfo.module.css";
import { UserContext } from "../../context/GlobalUserProvider.jsx";
// import { UserContext } from "../UserProfile.jsx";

function WorkerContactInfo() {
  const { user } = useContext(UserContext);
  return (
    <>
      <div className={styles.contactWrapper}>
        <h2 className={styles.infoHeader}>Contact information</h2>
        <div className={styles.fullData}></div>
      </div>
    </>
  );
}

export default WorkerContactInfo;
