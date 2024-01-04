import styles from "./EmployersList.module.css";

import { useEffect, useMemo, useState } from "react";

import BoardHeader from "../BoardHeader.jsx";
import Employee from "./Employee.jsx";
import PopupInfo from "./PopupInfo.jsx";

import {
  useEmployers,
  getEmployers,
} from "../../../customHooks/useEmployers.js";
import { Link } from "react-router-dom";

function Employers() {
  const [emp, setEmp] = useState([]);
  const [con, setCon] = useState([]);
  const [man, setMan] = useState([]);
  const [person, setPerson] = useState({});
  const [background, setBackground] = useState(false);

  // TODO: change this when fixed in backend
  const employersList = useMemo(() => {
    return getEmployers();
  }, []);

  useEffect(
    function () {
      const abortController = new AbortController();
      async function getEmps() {
        // TODO: change this when fixed in backend
        const data = await employersList;
        // const data = list;
        let empArr = [];
        let conArr = [];
        let manArr = [];
        const empData = data.map((x) => {
          if (x.role === "worker") {
            empArr.push(x);
          } else if (x.role === "qControl") {
            conArr.push(x);
          } else {
            manArr.push(x);
          }
        });
        setEmp(empArr);
        setCon(conArr);
        setMan(manArr);
      }
      getEmps();

      return () => abortController.abort();
    },

    // TODO: change this when fixed in backend
    [employersList]
    // []
  );

  function handleClick(p) {
    setPerson(p);
    setBackground(true);
  }

  function close(e) {
    setPerson({});
    setBackground(false);
  }

  return (
    <>
      {background && <PopupInfo person={person} onClose={close} />}
      <h2 className={styles.dashHeadingMain}>Employees List</h2>

      <section className={styles.board}>
        <BoardHeader />
        {/* <div className={styles.spacer}></div> */}

        <div className={styles.wrapper}>
          <aside className={styles.control}>
            <Link to={"/profile/salaries"} className={styles.actionLink}>
              Salaries
            </Link>
            <Link to={"/profile/add-member"} className={styles.actionLink}>
              Add employee
            </Link>
          </aside>
          <main className={styles.main}>
            <h2 className={styles.dashHeading}>Employers list</h2>
            <div className={styles.cardHolder}>
              {emp &&
                emp.map((employee) => (
                  <Employee
                    key={employee.id}
                    person={employee}
                    onNameClick={handleClick}
                  />
                ))}
            </div>
            <h2 className={styles.dashHeading}>Quality Control list</h2>
            <div className={styles.cardHolder}>
              {con &&
                con.map((qControl) => (
                  <Employee
                    key={qControl.id}
                    person={qControl}
                    onNameClick={handleClick}
                  />
                ))}
            </div>
            <h2 className={styles.dashHeading}>Managers List</h2>
            <div className={styles.cardHolder}>
              {man &&
                man.map((manager) => (
                  <Employee
                    key={manager.id}
                    person={manager}
                    onNameClick={handleClick}
                  />
                ))}
            </div>
          </main>
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
