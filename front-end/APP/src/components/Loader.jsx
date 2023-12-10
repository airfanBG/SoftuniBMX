import styles from "./Loader.module.css";

function Loader() {
  return (
    <div className={styles.loader}>
      <div className={styles["spinner-10"]}></div>;
    </div>
  );
}

export default Loader;
