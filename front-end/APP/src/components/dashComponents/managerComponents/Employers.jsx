import styles from "./Employers.module.css";
import { Link } from "react-router-dom";
import BoardHeader from "../BoardHeader.jsx";
import { useState } from "react";
import PopupInfo from "./PopupInfo.jsx";
import EmployeesListComponent from "./employeesComponents/EmployeesListComponent.jsx";
import Salaries from "./employeesComponents/Salaries.jsx";
import AddMember from "./employeesComponents/AddMember.jsx";

function Employers() {
  const [active, setActive] = useState("employees");
  const [background, setBackground] = useState(false);
  const [person, setPerson] = useState({});

  function onSelectActive(selected) {
    if (active === selected) return;
    setActive(selected);
  }

  return (
    <>
      {background && <PopupInfo person={person} onClose={close} />}
      <h2 className={styles.dashHeadingMain}>Employees</h2>

      <section className={styles.board}>
        <BoardHeader />
        {/* <div className={styles.spacer}></div> */}

        <div className={styles.wrapper}>
          <aside className={styles.control}>
            <button
              className={styles.actionLink}
              onClick={() => onSelectActive("employees")}
            >
              Employees
            </button>
            <button
              className={styles.actionLink}
              onClick={() => onSelectActive("salaries")}
            >
              Salaries
            </button>
            <button
              className={styles.actionLink}
              onClick={() => onSelectActive("add")}
            >
              Add employee
            </button>
          </aside>
          {/* <main className={styles.main}>
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
          </main> */}

          <main className={styles.main}>
            {active === "employees" && <EmployeesListComponent />}
            {active === "salaries" && <Salaries />}
            {active === "add" && <AddMember />}
            {/* {active === "scrap" && <Scrap />}
            {active === "supplier" && (
              <AddSupplier onFinish={onSelectActive} active="warehouse" />
            )} */}
          </main>
        </div>
      </section>
    </>
  );
}

export default Employers;
