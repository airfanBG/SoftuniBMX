import { Link } from "react-router-dom";
import styles from "./ErrorBoundaryPage.module.css";

function ErrorBoundaryPage({ error }) {
  // console.log(error);
  return (
    <>
      <div className={styles.page}>
        <h2 className={styles.heading}>Something went wrong!</h2>
        <p className={styles.friendlyMessage}>Please, try again later</p>
        <pre className={styles.errorMessage}>{error.message}</pre>
        <a href="/" className={styles.link}>
          Return to Home
        </a>
      </div>
    </>
  );
}

export default ErrorBoundaryPage;
