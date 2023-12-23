import styles from "./PhoneComponent.module.css";

import { PhoneInput } from "react-international-phone";
import "react-international-phone/style.css";

function PhoneComponent({ label, values, setValues, phone, setPhone }) {
  return (
    <div className={styles.wrapper}>
      <div className={styles["flex-column"]}>
        <label>{label}</label>
      </div>
      <div className={styles["inputForm"]}>
        <PhoneInput
          defaultCountry="bg"
          value={phone}
          onChange={(phone) => setPhone(phone)}
          onBlur={() => setValues({ ...values, phone: phone })}
          inputStyle={{
            border: "none",
            borderRadius: "10px",
            fontSize: "2rem",
          }}
          buttonStyle={false}
        />
      </div>
    </div>
  );
}

export default PhoneComponent;
