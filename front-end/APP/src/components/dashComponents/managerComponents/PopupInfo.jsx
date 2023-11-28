import { Link } from "react-router-dom";
import styles from "./PopupInfo.module.css";

import { User } from "@phosphor-icons/react";

function PopupInfo({ person, onClose }) {
  return (
    <div className={styles.modalBg} onClick={onClose}>
      <figure className={styles.fullInfo}>
        <button className={styles.closeIcon} onClick={onClose}>
          <ion-icon name="close-outline"></ion-icon>
        </button>
        <div className={styles.baseImg}>
          {!person.imageUrl && (
            <User size={196} color="#363636" weight="thin" />
          )}
          {person.imageUrl && (
            <img
              src={person.imageUrl}
              alt={`Image of ${person.firstName} ${person.lastName}`}
            />
          )}
        </div>

        <div className={styles.personData}>
          <h2 className={styles.heading}>
            {person.firstName} {person.lastName}
          </h2>
          <div className={styles.infoBox}>
            <p className={`${styles.info}`}>
              <span>Email:</span>
              <button
                to="javascript:void(0)"
                onClick={() => (window.location = `mailto:${person.email}`)}
              >
                {person.email}
              </button>
            </p>
            <p className={`${styles.info}`}>
              <span>Phone:</span>
              {person.phoneNumber}
            </p>
            <p className={`${styles.info}`}>
              <span>Hire date:</span>
              {person.dateOfHire.replaceAll("/", ".")}
            </p>

            <p className={`${styles.info}`}>
              <span>Position:</span>
              {person.position}
            </p>

            <p className={`${styles.info}`}>
              <span>Department:</span>
              {person.department}
            </p>
          </div>
        </div>
      </figure>
    </div>
  );
}

export default PopupInfo;
