import { useEffect, useState } from "react";
import { useEmployers } from "../../../customHooks/useEmployers.js";
import styles from "./EmployersList.module.css";
import BoardHeader from "../BoardHeader.jsx";
import Employee from "./Employee.jsx";

function Employers() {
  const [emp, setEmp] = useState([]);
  const [man, setMan] = useState([]);

  const employersList = useEmployers();

  useEffect(function () {
    const abortController = new AbortController();
    async function getEmps() {
      const data = await employersList;
      let empArr = [];
      let manArr = [];
      const empData = data.map((x) => {
        console.log(x.role);
        if (x.role === "worker") {
          empArr.push(x);
        } else {
          manArr.push(x);
        }
      });
      setEmp(empArr);
      setMan(manArr);
    }
    getEmps();

    return () => abortController.abort();
  }, []);

  return (
    <>
      <h2 className={styles.dashHeading}>Employers list</h2>
      <section className={styles.board}>
        <BoardHeader />
        <div className={styles.spacer}></div>
        <div className={styles.cardHolder}>
          {emp && emp.map((x) => <Employee key={x.id} emp={x} />)}
        </div>
      </section>
      <h2 className={styles.dashHeading}>Managers List</h2>
      <section className={styles.board}>
        <div className={styles.cardHolder}>
          {man && man.map((x) => <Employee key={x.id} emp={x} />)}
        </div>
      </section>
    </>
  );
}

export default Employers;

// dateOfHire: "string";
// department: "frames";

// id: 2;
// isManager: false;
// phoneNumber: "+359567474237";
// position: "string";
// role: "worker";
