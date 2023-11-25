import styles from "./Category.module.css";

function Category({ user }) {
  return (
    <>
      <span>Category: </span>
      <h3>
        {/* TODO: change with actual - probably user.category === 'frames' */}
        <span
          className={styles.element}
          style={
            user.department === "frames" ? { color: "var(--color-line)" } : null
          }
        >
          Frames
        </span>{" "}
        &#10072;{" "}
        <span
          className={styles.element}
          style={
            user.department === "wheels" ? { color: "var(--color-line)" } : null
          }
        >
          Tyres
        </span>{" "}
        &#10072;{" "}
        <span
          className={styles.element}
          style={
            user.department === "accessory"
              ? { color: "var(--color-line)" }
              : null
          }
        >
          Assembly
        </span>
      </h3>
    </>
  );
}

export default Category;
