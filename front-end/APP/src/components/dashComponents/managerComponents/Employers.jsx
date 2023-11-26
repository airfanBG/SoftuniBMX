import { useEffect, useState } from "react";
import { useEmployers } from "../../../customHooks/useEmployers.js";
import styles from "./Employers.module.css";
import BoardHeader from "../BoardHeader.jsx";

function Employers() {
  const [emp, setEmp] = useState([]);

  const employersList = useEmployers();

  useEffect(function () {
    const abortController = new AbortController();
    async function getEmps() {
      const data = await employersList;
      setEmp(data);
      console.log(data);
    }
    getEmps();

    return () => abortController.abort();
  }, []);

  return (
    <>
      <h2 className={styles.dashHeading}>Employers list</h2>
      <section className={styles.board}>
        <BoardHeader />
        <div className={styles.cardHolder}>
          <figure className={styles.figure}>
            <div className={styles.userPic}>
              <img src="./img/user.png" alt="" />
            </div>
            <div className={styles.content}>
              <h3>Pjhfdjs OJJ</h3>
            </div>
          </figure>
        </div>
      </section>
    </>
  );
}

export default Employers;
