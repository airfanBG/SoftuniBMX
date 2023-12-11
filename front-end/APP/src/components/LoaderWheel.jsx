import styles from "./LoaderWheel.module.css";

function LoaderWheel({ width }) {
  return (
    <div className={styles.loaderContainer}>
      <img
        src="https://s3-us-west-2.amazonaws.com/s.cdpn.io/26344/bike_wheel-512.png"
        className={`${styles["thing-to-spin"]} ${
          width === "small" ? styles.small : ""
        }`}
      />
    </div>
  );
}

export default LoaderWheel;
