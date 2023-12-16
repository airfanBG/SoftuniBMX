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
            user.role === "frameworker" ? { color: "var(--color-line)" } : null
          }
        >
          Frames
        </span>{" "}
        &#10072;{" "}
        <span
          className={styles.element}
          style={
            user.role === "wheelworker" ? { color: "var(--color-line)" } : null
          }
        >
          Wheels
        </span>{" "}
        &#10072;{" "}
        <span
          className={styles.element}
          style={
            user.role === "accessoriesworker"
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
