import styles from "./PageNotFound.module.css";
import Navigation from "./navigationsComponents/Navigation.jsx";

function PageNotFound() {
  return (
    <>
      <Navigation />
      <div className={styles.errorPage}>{/* <h2>Page Not Found</h2> */}</div>
    </>
  );
}

export default PageNotFound;
