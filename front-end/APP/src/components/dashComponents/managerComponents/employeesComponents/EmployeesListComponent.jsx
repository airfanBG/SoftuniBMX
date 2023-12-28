import styles from "./EmployeesListComponent.module.css";

import { Link } from "react-router-dom";
import { getEmployers } from "../../../../customHooks/useEmployers.js";
import LoaderWheel from "../../../LoaderWheel.jsx";

import { memo, useEffect, useMemo, useState } from "react";
import Employee from "../Employee.jsx";
import PopupInfo from "../PopupInfo.jsx";

function EmployeesListComponent() {
  const [loading, setLoading] = useState(false);
  const [emp, setEmp] = useState([]);
  const [con, setCon] = useState([]);
  const [man, setMan] = useState([]);
  const [person, setPerson] = useState({});
  const [background, setBackground] = useState(false);

  const employersList = useMemo(() => {
    return getEmployers();
  }, []);

  useEffect(
    function () {
      const abortController = new AbortController();
      async function getEmps() {
        const data = await employersList;
        let empArr = [];
        let conArr = [];
        let manArr = [];
        const empData = data.map((x) => {
          if (
            x.position === "Accessoriesworker" ||
            x.position === "FrameWorker" ||
            x.position === "Wheelworker"
          ) {
            empArr.push(x);
          } else if (x.position === "Qualitycontrol") {
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

    [employersList]
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
    // <>
    //   <h2 className={styles.dashHeading}>Employees List</h2>

    //   <section className={styles.board}>
    //     {loading && <LoaderWheel />}
    //     {/* всички части */}
    //   </section>
    // </>

    <>
      {background && <PopupInfo person={person} onClose={close} />}
      <h2 className={styles.dashHeading}>Employees List</h2>

      <section className={styles.board}>
        {/* <div className={styles.spacer}></div> */}

        {/* <div className={styles.wrapper}> */}
        <main className={styles.main}>
          <h2 className={styles.dashHeadingSec}>Employers list</h2>
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
          <h2 className={styles.dashHeadingSec}>Quality Control list</h2>
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
          <h2 className={styles.dashHeadingSec}>Managers List</h2>
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
        {/* </div> */}
      </section>
    </>
  );
}

export default memo(EmployeesListComponent);
