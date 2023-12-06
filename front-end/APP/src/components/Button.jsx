import styles from "./Button.module.css";

function Button({ children, type, onClick, id, disabled }) {
  return (
    <button
      className={`${styles.btn} ${styles[type]} ${
        disabled ? styles.disabled : null
      }`}
      onClick={() => onClick(id, type)}
      disabled={disabled}
    >
      {children}
    </button>
  );
}

export default Button;
