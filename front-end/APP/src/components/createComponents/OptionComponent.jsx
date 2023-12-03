import { useState } from "react";
import styles from "./OptionComponent.module.css";

function OptionComponent({ optionData }) {
  const { description, salesPrice, id, name, oemNumber, imageUrl, rating } =
    optionData;

  return (
    <option value={id} className={styles.option}>
      {name}
    </option>
  );
}

export default OptionComponent;
