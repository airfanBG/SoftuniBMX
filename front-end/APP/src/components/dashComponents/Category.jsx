import { useContext } from "react";
import styles from "./Category.module.css";
import { UserContext } from "../../context/GlobalUserProvider.jsx";

function Category() {
  const { user } = useContext(UserContext);
  return (
    <>
      <span>Category: </span>
      <h3>
        <span
          className={styles.element}
          style={
            user.department === "Frames" ? { color: "var(--color-line)" } : null
          }
        >
          Frames
        </span>{" "}
        &#10072;{" "}
        <span
          className={styles.element}
          style={
            user.department === "Wheels" ? { color: "var(--color-line)" } : null
          }
        >
          Tyres
        </span>{" "}
        &#10072;{" "}
        <span
          className={styles.element}
          style={
            user.department === "Accessory"
              ? { color: "var(--color-line)" }
              : null
          }
        >
          Accessory
        </span>
      </h3>
    </>
  );
}

export default Category;
