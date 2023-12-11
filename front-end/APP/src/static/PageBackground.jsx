import styles from "./PageBackground.module.css";

function PageBackground() {
  return (
    <div className={styles.pageBackground}>
      <img src="./img/bg.webp" alt="site static background image" />
    </div>
  );
}

export default PageBackground;
