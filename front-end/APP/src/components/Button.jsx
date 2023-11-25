import styles from "./Button.module.css";

function Button({ children, type, onClick, id }) {
  return (
    <button
      className={`${styles.btn} ${styles[type]}`}
      onClick={() => onClick(id)}
    >
      {children}
    </button>
  );
}

export default Button;
