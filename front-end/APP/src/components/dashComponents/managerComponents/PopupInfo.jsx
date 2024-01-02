import styles from "./PopupInfo.module.css";

import { Link } from "react-router-dom";

import { User } from "@phosphor-icons/react";
import { getMonthName, minutesToHours } from "../../../util/resolvers.js";
import { useState } from "react";

function PopupInfo({ person, onClose, isSalaries = false, times }) {
  const [reveal, setReveal] = useState(
    new Date().getDate() >= 1 && new Date().getDate() <= 5 ? true : false
  );
  const [salary, setSalary] = useState("");

  // function minutesToHours(t) {
  //   const hours = parseInt(t / 60);
  //   const minutes = t % 60;
  //   return `${hours} hours and ${minutes} minutes`;
  // }

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
                  <span>
                    Current Mont Hours -{" "}
                    {new Date().toLocaleDateString(undefined, {
                      month: "long",
                    })}
                  </span>
                  {minutesToHours(times.currentMonthEmployeeWorkingMinutes)}
                </p>
              </div>
              <div className={styles.oneRow}>
                <p className={`${styles.info}`}>
                  <span>Last Mont</span>
                  {getMonthName()}
                </p>
                <p className={`${styles.info}`}>
                  <span>Hours/Mont</span>
                  {minutesToHours(times.pastMonthEmployeeWorkingMinutes)}
                </p>
              </div>

              <button
                onClick={() => setReveal(!reveal)}
                style={{ textAlign: "right" }}
              >
                <ion-icon name="logo-euro"></ion-icon>
              </button>

              {/* {new Date().getDate() > 5 && (
                <button
                  onClick={() => setReveal(!reveal)}
                  style={{ textAlign: "right" }}
                >
                  <ion-icon name="logo-euro"></ion-icon>
                </button>
              )} */}
              {reveal && (
                <div className={styles.oneRow}>
                  <div className={`${styles.info}`}>
                    <span>Salary</span>
                    <input
                      list="salary"
                      className={styles.input}
                      type="tel"
                      value={salary}
                      onChange={(e) => setSalary(e.target.value)}
                      onFocus={() => setSalary("")}
                    />
                    <datalist id="salary">
                      <option value="1000" />
                    </datalist>
                  </div>
                  <button className={styles.btn}>Pay salary</button>
                </div>
              )}
            </div>
          </div>
        )}
      </figure>
    </div>
  );
}

export default PopupInfo;
