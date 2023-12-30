import styles from "./PopupInfo.module.css";

import { Link } from "react-router-dom";

import { User } from "@phosphor-icons/react";

function PopupInfo({ person, onClose, isSalaries = false }) {
  function getMonthName() {
    const prevMonth = new Date();
    prevMonth.setMonth(prevMonth.getMonth() - 1);
    return new Intl.DateTimeFormat("en-GB", { month: "long" }).format(
      prevMonth
    );
  }
  return (
    <div className={styles.modalBg} onClick={onClose}>
      <figure className={styles.fullInfo} onClick={(e) => e.stopPropagation()}>
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

        {/* IN REGULAR MODAL */}
        {!isSalaries && (
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
        )}

        {/* SALARIES CALCULATOR */}
        {isSalaries && (
          <div className={`${styles.personData}`}>
            <div className={`${styles.inSalary}`}>
              <h2 className={styles.heading}>
                {person.firstName} {person.lastName}
              </h2>
              <p className={`${styles.info}`}>
                <span>Position:</span>
                {person.position}
              </p>
            </div>
            <div className={styles.infoBox}>
              <div className={styles.oneRow}>
                <p className={`${styles.info}`}>
                  <span>Hire date:</span>
                  {person.dateOfHire.replaceAll("/", ".")}
                </p>
                <p className={`${styles.info}`}>
                  <span>Department:</span>
                  {person.department}
                </p>
              </div>
              <div className={styles.oneRow}>
                <p className={`${styles.info}`}>
                  <span>Current Mont Hours:</span>5 hours 15 minutes
                </p>
              </div>
              <div className={styles.oneRow}>
                <p className={`${styles.info}`}>
                  <span>Last Mont:</span>
                  {getMonthName()}
                </p>
                <p className={`${styles.info}`}>
                  <span>Hours/Mont:</span>
                  75 hours 45 minutes
                </p>
              </div>
            </div>
          </div>
        )}
      </figure>
    </div>
  );
}

export default PopupInfo;
