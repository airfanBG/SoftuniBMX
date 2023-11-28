import styles from "./EmployersList.module.css";

import { useEffect, useState } from "react";

import BoardHeader from "../BoardHeader.jsx";
import Employee from "./Employee.jsx";
import PopupInfo from "./PopupInfo.jsx";

import { useEmployers } from "../../../customHooks/useEmployers.js";
import { Link } from "react-router-dom";

function Employers() {
  const [emp, setEmp] = useState([]);
  const [man, setMan] = useState([]);
  const [person, setPerson] = useState({});
  const [background, setBackground] = useState(false);

  const employersList = useEmployers();

  useEffect(function () {
    const abortController = new AbortController();
    async function getEmps() {
      const data = await employersList;
      let empArr = [];
      let manArr = [];
      const empData = data.map((x) => {
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
      <section className={styles.board}>
        <BoardHeader />
        {/* <div className={styles.spacer}></div> */}

        <div className={styles.wrapper}>
          <aside>
            <Link to={"/profile/add-member"} className={styles.actionLink}>
              Add employee
            </Link>
          </aside>
          <main>
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
