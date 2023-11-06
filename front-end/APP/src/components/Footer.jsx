import { Link, NavLink } from "react-router-dom";

import styles from "./Footer.module.css";

function Footer() {
  function toStart() {
    window.scrollTo({
      top: 0,
      behavior: "smooth",
    });
  }

  return (
    <footer className={styles["footer"]}>
      <section
        className={`${styles["footer-content"]} ${styles["m-bottom-80"]}`}
      >
        <figure className={styles.social}>
          <p className={styles.logo}>
            <NavLink onClick={toStart} className={styles.logoFirstLine}>
              e<span>&#10006;</span>treme - BMX
            </NavLink>
            <span className={styles.logoSecondary}>Bicycle Management</span>
          </p>

          <section className={styles["social-icons"]}>
            <Link to={"#"}>
              <i className="fa-brands fa-square-github" />
            </Link>
            <Link to={"#"}>
              <i className="fa-brands fa-square-facebook" />
            </Link>
            <Link to={"#"}>
              <i className="fa-brands fa-instagram" />
            </Link>
            <Link to={"#"}>
              <i className="fa-brands fa-linkedin" />
            </Link>
          </section>
          <p className={styles.copyright}>
            All rights reserved - ©{new Date().getFullYear()}
          </p>
        </figure>

        <figure className={styles["footer-links"]}>
          <ul className={styles["footer-list"]} role="list">
            <li className={styles["footer-list-item"]}>
              <Link to={"#"} className={styles["footer-link"]}>
                Option 1
              </Link>
            </li>
            <li className={styles["footer-list-item"]}>
              <Link to={"#"} className={styles["footer-link"]}>
                Option 2
              </Link>
            </li>
            <li className={styles["footer-list-item"]}>
              <Link to={"#"} className={styles["footer-link"]}>
                Option 3
              </Link>
            </li>
            <li className={styles["footer-list-item"]}>
              <Link to={"#"} className={styles["footer-link"]}>
                Option 4
              </Link>
            </li>
            <li className={styles["footer-list-item"]}>
              <Link to={"#"} className={styles["footer-link"]}>
                Option 5
              </Link>
            </li>
          </ul>
        </figure>
        <figure className={styles["footer-links"]}>
          <ul className={styles["footer-list"]} role="list">
            <li className={styles["footer-list-item"]}>
              <Link to={"#"} className={styles["footer-link"]}>
                Option 1
              </Link>
            </li>
            <li className={styles["footer-list-item"]}>
              <Link to={"#"} className={styles["footer-link"]}>
                Option 2
              </Link>
            </li>
            <li className={styles["footer-list-item"]}>
              <Link to={"#"} className={styles["footer-link"]}>
                Option 3
              </Link>
            </li>
            <li className={styles["footer-list-item"]}>
              <Link to={"#"} className={styles["footer-link"]}>
                Option 4
              </Link>
            </li>
            <li className={styles["footer-list-item"]}>
              <Link to={"#"} className={styles["footer-link"]}>
                Option 5
              </Link>
            </li>
          </ul>
        </figure>
        <figure className={styles["footer-links"]}>
          <ul className={styles["footer-list"]} role="list">
            <li className={styles["footer-list-item"]}>
              <Link to={"#"} className={styles["footer-link"]}>
                Option 1
              </Link>
            </li>
            <li className={styles["footer-list-item"]}>
              <Link to={"#"} className={styles["footer-link"]}>
                Option 2
              </Link>
            </li>
            <li className={styles["footer-list-item"]}>
              <Link to={"#"} className={styles["footer-link"]}>
                Option 3
              </Link>
            </li>
            <li className={styles["footer-list-item"]}>
              <Link to={"#"} className={styles["footer-link"]}>
                Option 4
              </Link>
            </li>
            <li className={styles["footer-list-item"]}>
              <Link to={"#"} className={styles["footer-link"]}>
                Option 5
              </Link>
            </li>
          </ul>
        </figure>
      </section>
    </footer>
  );
}

export default Footer;
