import styles from "./LoaderWheel.module.css";

function LoaderWheel() {
  return (
    <div className={styles.loaderContainer}>
      <img
        src="https://s3-us-west-2.amazonaws.com/s.cdpn.io/26344/bike_wheel-512.png"
        className={styles["thing-to-spin"]}
      />
    </div>
  );
}

export default LoaderWheel;
