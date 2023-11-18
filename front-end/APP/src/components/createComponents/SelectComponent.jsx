import { useEffect, useState } from "react";
import styles from "./SelectComponent.module.css";
import OptionComponent from "./OptionComponent.jsx";

function SelectComponent({ data, dispatch, type, disabled }) {
  const [hasData, setHasData] = useState(false);
  const iterable = data.sort((a, b) => a.name.localeCompare(b.name));
  // const frameResult = [];
  const frameResult = [...iterable, { name: "Select brand", _id: "" }];

  function onSelectHandler(e) {
    dispatch({ type: type, payload: e.target.value });
  }

  useEffect(() => {
    if (Object.keys(data).length > 0) return setHasData(true);
    // console.log(iterable);
  }, [data, iterable]);

  return (
    <select
      disabled={disabled}
      className={styles.select}
      // defaultValue={""}
      onChange={onSelectHandler}
      // value="Select"
      placeholder={"Select"}
    >
      {frameResult.map((x) => (
        <OptionComponent optionData={x} key={x._id} />
      ))}
    </select>
  );
}

export default SelectComponent;
