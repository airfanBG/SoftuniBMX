import styles from "./MonthlySalary.module.css";

import { useContext } from "react";
import { useState } from "react";
import { useNavigate } from "react-router-dom";
import BoardHeader from "./BoardHeader.jsx";
import MonthlySalaryDocument from "./MonthlySalaryDocument.jsx";
import LoaderWheel from "../LoaderWheel.jsx";
import { UserContext } from "../../context/GlobalUserProvider.jsx";
import { post } from "../../util/api.js";
import { environment } from "../../environments/environment.js";
import Popup from "../Popup.jsx";

function MonthlySalary() {
  const [background, setBackground] = useState(false);

  const { user, updateUser } = useContext(UserContext);
  const [loading, setLoading] = useState(false);
  const [error, setError] = useState("");
  const navigate = useNavigate();

  async function getSalary() {
    setError(false);
    setLoading(true);
    const gotSalary = { ...user, salary: null };

    const result = await post(environment.worker_get_salary + user.id);
    console.log(result);
    setLoading(false);

    if (result?.isError) {
      setError(true);
      setBackground(true);
      setError(result.isError.title);
      return;
    }
    updateUser(gotSalary);
    navigate("/profile");
  }

  function close() {
    setBackground(false);
    setError("");
  }

  return (
    <>
      <h2 className={styles.dashHeading}>Salary</h2>
      <section className={styles.board}>
        <BoardHeader />

        {background && (
          <Popup onClose={close}>
            <div className={styles.errorContainer}>
              <h3>{error}</h3>
            </div>
          </Popup>
        )}
        {loading && <LoaderWheel />}
        <div className={styles.salaryWrapper}>
          <MonthlySalaryDocument getSalary={getSalary} user={user} />
        </div>
      </section>
    </>
  );
}
export default MonthlySalary;

function Test() {
  return <div>tests</div>;
}
