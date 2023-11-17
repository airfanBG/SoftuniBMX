import { useState } from "react";
import styles from "./OptionComponent.module.css";

function OptionComponent({ optionData }) {
  const { description, price, _id, name, oem, imageUrl, quantity, rating } =
    optionData;

  return (
    <option value={_id} className={styles.option}>
      {name}
    </option>
  );
}

export default OptionComponent;
