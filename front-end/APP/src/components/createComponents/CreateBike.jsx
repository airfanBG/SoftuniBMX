import BoardHeader from "../dashComponents/BoardHeader.jsx";
import styles from "./CreateBike.module.css";

function CreateBike() {
  return (
    <>
      {/* <h2 className={styles.dashHeading}>Orders in sequence</h2> */}
      <h2 className={styles.dashHeading}>Create bike 1</h2>

      <section className={styles.board}>
        <header className={styles.boardHeader}>
          <span>Balance: </span>
          <h3 className={styles.cash}>TEXT</h3>
        </header>

        <div className={styles.userInfoWrapper}>
          <figure className={styles.mainInfo}>
            <div className={styles["imgHolder"]}>
              <img src="https://i.pravatar.cc/300" alt="User picture" />
            </div>
          </figure>
        </div>
      </section>
    </>
  );
}

export default CreateBike;
