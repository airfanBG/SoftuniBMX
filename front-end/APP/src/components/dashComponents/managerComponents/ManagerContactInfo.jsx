import styles from "./ManagerContactInfo.module.css";

import ContactInfoElement from "../ContactInfoElement.jsx";
import { useContext } from "react";
import { UserContext } from "../../../context/GlobalUserProvider.jsx";

function ManagerContactInfo() {
  const { user } = useContext(UserContext);
  return (
    <>
      <div className={styles.contactWrapper}>
        <h2 className={styles.infoHeader}>
          <span>Contact information</span>
        </h2>
        <div className={styles.fullData}>
          <div className={styles.row}>
            <ContactInfoElement
              content={user.firstName}
              label={"First Name"}
              width={"50%"}
            />
            <ContactInfoElement
              content={user.lastName}
              label={"First Name"}
              width={"50%"}
            />
          </div>
        </div>
      </div>
    </>
  );
}

export default ManagerContactInfo;
