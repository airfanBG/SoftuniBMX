import styles from "./EditTextInput.module.css";

function EditTextInput({
  inputValue,
  dispatch,
  action,
  type,
  content,
  required,
}) {
  return (
    <div className={styles.inputBlock}>
      <label htmlFor="inputId" className={styles.label}>
        {content}
      </label>
      <input
        className={styles.inputField}
        type={type}
        id="inputId"
        value={inputValue}
        onChange={(e) => dispatch({ type: action, payload: e.target.value })}
        required={required}
      />
    </div>
  );
}

export default EditTextInput;
