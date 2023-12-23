import styles from "./Employers.module.css";
import { Link } from "react-router-dom";
import BoardHeader from "../BoardHeader.jsx";
import { useState } from "react";
import PopupInfo from "./PopupInfo.jsx";

function Employers() {
  const [selected, setSelected] = useState("employees");
  const [background, setBackground] = useState(false);
  const [person, setPerson] = useState({});

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
        </div>
      </section>
    </>
  );
}

export default Employers;
