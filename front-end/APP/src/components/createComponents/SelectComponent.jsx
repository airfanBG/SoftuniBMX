import { useEffect, useState } from "react";
import styles from "./SelectComponent.module.css";
import OptionComponent from "./OptionComponent.jsx";

function SelectComponent({ data, dispatch }) {
  const [hasData, setHasData] = useState(false);
  const iterable = Object.values(data).sort((a, b) =>
    a.name.localeCompare(b.name)
  );
  const frameResult = [...iterable, { name: "Select brand", _id: "000" }];
  // .unshift();
  console.log(frameResult);

  function onSelectHandler(e) {
    dispatch({ type: "selectedFrame", payload: e.target.value });
  }

  useEffect(() => {
    if (Object.keys(data).length > 0) return setHasData(true);
    // console.log(iterable);
  }, [data, iterable]);

  return (
    <select
      className={styles.select}
      // defaultValue={""}
      onChange={onSelectHandler}
      // value="Select"
    >
      {frameResult.map((x) => (
        <OptionComponent optionData={x} key={x._id} />
      ))}
    </select>
  );
}

export default SelectComponent;
