import styles from "./MonthlySalary.module.css";

import BoardHeader from "./BoardHeader.jsx";

function MonthlySalary() {
  return (
    <>
      <h2 className={styles.dashHeading}>Orders in sequence</h2>
      <section className={styles.board}>
        <BoardHeader />
      </section>
    </>
  );
}
export default MonthlySalary;
