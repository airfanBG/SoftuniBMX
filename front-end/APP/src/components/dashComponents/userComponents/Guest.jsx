import styles from "./Guest.module.css";

function Guest() {
  return (
    <>
      <span>Balance: </span>
      <h3 className={styles.cash}>
        <span className={styles.smaller}>Guest</span>
      </h3>
    </>
  );
}

export default Guest;
