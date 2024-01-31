import styles from "./Salaries.module.css";

import { useEffect, useState } from "react";
import { getEmployers } from "../../../../customHooks/useEmployers.js";
import LoaderWheel from "../../../LoaderWheel.jsx";
import PopupInfo from "../PopupInfo.jsx";
import { get, post } from "../../../../util/api.js";
import { environment } from "../../../../environments/environment.js";

function Salaries() {
  const [loading, setLoading] = useState(false);
  const [employeesList, setEmployeesList] = useState([]);
  const [person, setPerson] = useState({});
  const [background, setBackground] = useState(false);
  const [times, setTimes] = useState({});

  useEffect(function () {
    async function getEmps() {
      const data = await getEmployers();
      const sorted = data.sort((a, b) =>
        a.firstName.localeCompare(b.firstName)
      );
      setEmployeesList(sorted);
      // console.log(data);
    }
    getEmps();
  }, []);

  async function setEmployee(e) {
    const data = await get(environment.worker_times + e.id);
    setPerson(e);
    setTimes(data);
    setBackground(true);
  }

  async function paySalary(amount, baseSalary, id) {
    setLoading(true);
    const bonus = Number(amount) - baseSalary;
    const data = {
      bonus: bonus,
      employeeId: id,
    };
    const result = await post(environment.pay_salary, data);
    // console.log(result);
    setLoading(false);
    close();
  }

  function close(e) {
    setPerson({});
    setTimes({});
    setBackground(false);
  }

  return (
    <>
      {background && (
        <PopupInfo
          person={person}
          onClose={close}
          isSalaries={true}
          times={times}
          paySalary={paySalary}
        />
      )}

      <h2 className={styles.dashHeading}>Employees List</h2>

      <section className={styles.board}>
        {loading && <LoaderWheel />}
        {employeesList && employeesList.length > 0 && (
          <div className={styles.container}>
            {employeesList.map((e, i) => (
              <div
                key={i}
                className={styles.employeeLine}
                onClick={() => setEmployee(e)}
              >
                <p className={styles.empData}>
                  <span className={styles.label}>Name:</span>
                  {e.firstName} {e.lastName}
                </p>
                <p className={styles.empData}>
                  <span className={styles.label}>Position</span>
                  {e.position}
                </p>
                <p className={styles.empData}>
                  <span className={styles.label}>Department:</span>
                  {e.department}
                </p>
                <p className={styles.empData}>
                  <span className={styles.label}>Date of Hire</span>
                  {e.dateOfHire}
                </p>
              </div>
            ))}
          </div>
        )}
        {employeesList.length === 0 && <h2>There is no employees</h2>}
      </section>
    </>
  );
}

export default Salaries;
