import styles from "./InputComponent.module.css";
import passStyles from "./InputPasswordComponent.module.css";

import { useState } from "react";

function InputPasswordComponent({
  mainValue,
  label,
  placeholder,
  required,
  valueMode,
  onChangeHandler,
  validateInput,
  clearErrorState,
  errorMode,
  svg,
}) {
  const [isHidden, setIsHidden] = useState(true);
  return (
    <div className={styles.wrapper}>
      <div className={styles["flex-column"]}>
        <label>{label}</label>
      </div>

      <div className={`${styles["inputForm"]}`}>
        {svg(mainValue)}
        <input
          type={isHidden ? "password" : "text"}
          className={styles["input"]}
          placeholder={placeholder}
          name={mainValue}
          required={required}
          value={valueMode(mainValue)}
          onChange={(e) => onChangeHandler(e)}
          onBlur={(e) => validateInput(e)}
          onFocus={(e) => clearErrorState(e)}
        />
        <div
          className={passStyles.svgPass}
          onClick={() => setIsHidden(!isHidden)}
        >
          {isHidden ? (
            <i
              className="fa-regular fa-eye"
              style={
                errorMode(mainValue) ? { display: "none", color: "red" } : null
              }
            ></i>
          ) : (
            <i
              className="fa-regular fa-eye-slash"
              style={
                errorMode(mainValue) ? { display: "none", color: "red" } : null
              }
            ></i>
          )}
        </div>
      </div>
      {errorMode(mainValue) && (
        <p className={styles.warning}>{errorMode(mainValue)}</p>
      )}
    </div>
  );
}

export default InputPasswordComponent;
