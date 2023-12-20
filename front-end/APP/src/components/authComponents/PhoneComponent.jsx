import styles from "./PhoneComponent.module.css";

import { PhoneInput } from "react-international-phone";
import "react-international-phone/style.css";

function PhoneComponent({
  label,
  mainValue,
  values,
  setValues,
  phone,
  setPhone,
  phoneValidate,
  clearErrorState,
  errorMode,
}) {
  return (
    <div className={styles.wrapper}>
      <div className={styles["flex-column"]}>
        <label>{label}</label>
      </div>
      <div className={styles["inputForm"]}>
        <PhoneInput
          name={"phone"}
          defaultCountry="bg"
          value={phone}
          onChange={(phone) => setPhone(phone)}
          // onBlur={() => setValues({ ...values, phone: phone })}
          onBlur={phoneValidate}
          onFocus={clearErrorState}
          inputStyle={{
            border: "none",
            borderRadius: "10px",
            fontSize: "2rem",
          }}
          buttonStyle={false}
        />
      </div>
      {errorMode(mainValue) && (
        <p className={styles.warning}>{errorMode(mainValue)}</p>
      )}
    </div>
  );
}

export default PhoneComponent;
