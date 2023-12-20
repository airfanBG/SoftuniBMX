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

const list = [
  {
    imageUrl: "",
    password: "$2a$10$0ukyVgaoPQxJdANgXMmj.eXeKgoEx8qzGB0TnkwIP1Pf558J4KVEi",
    repass: "User123",
    role: "manager",
    email: "manager@b-free.com",
    firstName: "Master",
    lastName: "Yoda",
    phoneNumber: "+359567474237",
    dateOfHire: "29/02/2012",
    isManager: true,
    id: 4,
  },

  {
    email: "hansolo@b-free.com",
    password: "$2a$10$5M9rOgUh9axwVa5mkN9YmOxq0WsPQFQvQbhgT9GOe0f6ombSZzXWq",
    firstName: "Han",
    lastName: "Solo",
    repass: "Han-12",
    role: "qControl",
    phoneNumber: "+359987654321",
    isManager: false,
    dateOfHire: "12/2/2023",
    imageUrl: "",
    id: 6,
  },
  {
    imageUrl: "",
    password: "$2a$10$Z4GxMk11HyO1JGIiC0l9xOYaUfTqvHoyxSUSFWzsA/FBCP2ijqS9S",
    repass: "Lea-12",
    role: "worker",
    email: "leaorgana@b-free.com",
    firstName: "Lea",
    lastName: "Organa",
    department: "Accessory",
    phoneNumber: "+359656456456343",
    position: "Master",
    dateOfHire: "12/2/2023",
    isManager: false,
    id: 7,
  },
  {
    email: "palpatine@b-free.com",
    password: "$2a$10$tCLqcHEBc5N9fv0.atuWGuzi1fU5T9Gz5BmvG0Lfi6Ck8yvxEQfhm",
    firstName: "Senator",
    lastName: "Palpatine",
    repass: "Palpatine1",
    role: "manager",
    phoneNumber: "+3599999999",
    isManager: true,
    dateOfHire: "12/3/2023",
    imageUrl: "",
    id: 9,
  },
  {
    email: "luke_skywalker@b-free.com",
    password: "$2a$10$EnauOU8gT80TD7gQ.QPq4uOre4AbC4xXoN9Kajy51/D9StmbF/aXe",
    firstName: "Luke",
    lastName: "Skywalker",
    repass: "Luke-1",
    role: "worker",
    phoneNumber: "+35974289739842",
    isManager: false,
    dateOfHire: "12/8/2023",
    imageUrl: "",
    department: "Wheels",
    position: "Senior mechanic",
    id: 10,
  },
  {
    email: "jaba@b-free.com",
    password: "$2a$10$LX1HdNjbtiMEJMpr/IYIB.gHmOXxebvr/z6iI6O7iZ4sJkJXnKztW",
    firstName: "Jaba",
    lastName: "The Hut",
    repass: "Jaba-1",
    role: "worker",
    phoneNumber: "+35967443563",
    isManager: false,
    dateOfHire: "12/8/2023",
    imageUrl: "",
    department: "Frames",
    position: "Junior mechanic",
    id: 11,
  },
];

function Employers() {
  const [emp, setEmp] = useState([]);
  const [con, setCon] = useState([]);
  const [man, setMan] = useState([]);
  const [person, setPerson] = useState({});
  const [background, setBackground] = useState(false);

  // TODO: change this when fixed in backend
  // const employersList = useMemo(() => {
  //   return getEmployers();
  // }, []);

  useEffect(
    function () {
      const abortController = new AbortController();
      async function getEmps() {
        // TODO: change this when fixed in backend
        // const data = await employersList;
        const data = list;
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
    // [employersList]
    []
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
