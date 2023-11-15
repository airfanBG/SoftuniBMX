import styles from "./InputComponent.module.css";

function InputComponent({
  mainValue,
  label,
  type,
  placeholder,
  required,
  valueMode,
  onChangeHandler,
  validateInput,
  clearErrorState,
  errorMode,
  svg,
}) {
  return (
    <div className={styles.wrapper}>
      <div className={styles["flex-column"]}>
        <label>{label}</label>
      </div>

      <div className={styles.inputForm}>
        <div className={styles.svg}>{svg(mainValue)}</div>

        <input
          type={type}
          className={styles.input}
          placeholder={placeholder}
          name={mainValue}
          required={required}
          value={valueMode(mainValue)}
          onChange={(e) => onChangeHandler(e)}
          onBlur={(e) => validateInput(e, mainValue)}
          onFocus={(e) => clearErrorState(e)}
        />
      </div>
      {errorMode(mainValue) && (
        <p className={styles.warning}>{errorMode(mainValue)}</p>
      )}
    </div>
  );
}

export default InputComponent;
