import { useState } from "react";
import styles from "./Employee.module.css";

import { User } from "@phosphor-icons/react";

function Employee({ person, onNameClick }) {
  function positioner(p) {
    if (p === "manager") return "Manager";
    else if (p === "Qualitycontrol") return "Quality Control";
    else if (p === "Wheelworker") return "Wheels";
    else if (p === "FrameWorker") return "Frames";
    else if (p === "Accessoriesworker") return "Accessory";
  }

  return (
    <figure className={styles.figure}>
      <div className={styles["imgHolder"]}>
        {person.imageUrl ? (
          <img
            className={styles.tumbs}
            src={person.imageUrl}
            alt={`${person.firstName} ${person.lastName} image`}
          />
        ) : (
          <User
            size={48}
            color="#363636"
            weight="thin"
            className={styles.baseImg}
          />
        )}
      </div>

      <section className={styles.workerInfo}>
        <h2 className={styles.heading} onClick={() => onNameClick(person)}>
          {person.firstName} {person.lastName}
        </h2>
        {/* {person.position !== "Qualitycontrol" &&
          person.position !== "manager" && ( */}
        <div className={styles.infoBox}>
          <p className={`${styles.info}`}>
            <span>Department:</span>
            {person.department}
          </p>

          <p className={`${styles.info}`}>
            <span>Position:</span>
            {positioner(person.position)}
          </p>
        </div>
        {/* )} */}
      </section>
    </figure>
  );
}

export default Employee;
