import styles from "./Category.module.css";

function Category({ user }) {
  return (
    <>
      <span>Category: </span>
      <h3>
        {/* TODO: change with actual - probably user.category === 'frames' */}
        <span
          className={styles.element}
          style={user.role === "worker" ? { color: "var(--color-line)" } : null}
        >
          Frames
        </span>{" "}
        &#10072;{" "}
        <span
          className={styles.element}
          style={
            user.category === "tyres" ? { color: "var(--color-line)" } : null
          }
        >
          Tyres
        </span>{" "}
        &#10072;{" "}
        <span
          className={styles.element}
          style={
            user.category === "assembly" ? { color: "var(--color-line)" } : null
          }
        >
          Assembly
        </span>
      </h3>
    </>
  );
}

export default Category;
