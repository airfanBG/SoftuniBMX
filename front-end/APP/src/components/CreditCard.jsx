import { useState } from "react";
import Cards from "react-credit-cards-2";
import "react-credit-cards-2/dist/es/styles-compiled.css";
import styles from "./CreditCard.module.css";

function CreditCard({ amountBtnHandler, switcher }) {
  const [state, setState] = useState({
    number: "",
    expiry: "",
    cvc: "",
    name: "",
    focus: "",
    amount: "",
  });
  const [error, setError] = useState({
    isError: false,
    message: "",
    isAllowed: false,
    // number: "",
    // expiry: "",
    // amount: "",
  });

  const handleInputChange = (evt) => {
    const { name, value, inputMode } = evt.target;
    setState((prev) => ({ ...prev, [name]: value }));
  };

  const handleInputFocus = (evt) => {
    const { name, value, inputMode } = evt.target;
    setState((prev) => ({ ...prev, focus: evt.target.name }));
    setError((error) => ({ ...error, isError: false, message: "" }));
  };

  function sendAmount(e) {
    e.preventDefault();
    if (state.amount <= 0) {
      setError((prev) => ({ ...prev, isError: true }));
    }
    if (!error.isAllowed) return;
    amountBtnHandler(state.amount);
    setState((prev) => ({ ...prev, amount: "" }));
    switcher(false);
  }

  function onButtonValidate() {
    const yy = Number(new Date().getFullYear().toString().slice(2));
    const MM = Number((new Date().getMonth() + 1).toString());

    if (Object.values(state).some((x) => x === "")) {
      setError((error) => ({
        ...error,
        isError: true,
        message: "All fields are required",
      }));
    }
    // MONTH VALIDATION
    else if (
      Number(state.expiry.slice(0, 2)) > 12 ||
      Number(state.expiry.slice(0, 2)) <= 0
    ) {
      setError((error) => ({
        ...error,
        isError: true,
        message: "Invalid month value",
      }));
    }
    // YEAR VALIDATION
    else if (
      Number(state.expiry.slice(2)) < yy ||
      (Number(state.expiry.slice(0, 2)) < MM &&
        Number(state.expiry.slice(2)) >= yy)
    ) {
      setError((error) => ({
        ...error,
        isError: true,
        message: "Your card is expired!",
      }));
    } else {
      setError((error) => ({ ...error, isError: false, isAllowed: true }));
    }
  }

  //   function onBlurValidate(e) {
  //     const { name, value, inputMode } = e.target;
  //     // if (inputMode === "numeric") {
  //     //   if (name === "expiry" && Number(value.slice(0, 2)) === 12) {
  //     //     console.log(Number(value));
  //     //     setError((error) => ({
  //     //       ...error,
  //     //       isError: true,
  //     //       message: "Invalid month value",
  //     //     }));
  //     //   }
  //     // }
  //     if (name === "expiry") {
  //       if (Number(value.slice(0, 2)) > 12) {
  //         console.log("isdjf");
  //         setError((e) => ({
  //           ...e,
  //           //   [name]: "Invalid month value",
  //           isError: true,
  //           isAllowed: false,
  //         }));
  //       }
  //     }
  //   }

  return (
    <div className={styles.board}>
      <div className={styles.cardContainer}>
        <form className={styles.cardForm} onSubmit={sendAmount}>
          <div className={styles.inputCardField}>
            <label htmlFor="" className={styles.fieldCardLabel}>
              Card number
            </label>
            <input
              type="text"
              inputMode="numeric"
              name="number"
              placeholder="Card Number"
              value={state.number}
              onChange={handleInputChange}
              onFocus={handleInputFocus}
              className={styles.cardInput}
              minLength={16}
              maxLength={19}
            />
          </div>

          <div className={styles.inputCardField}>
            <label htmlFor="" className={styles.fieldCardLabel}>
              Name on card
            </label>
            <input
              type="text"
              name="name"
              placeholder="Name on card"
              value={state.name}
              onChange={handleInputChange}
              onFocus={handleInputFocus}
              className={styles.cardInput}
              maxLength={18}
            />
            {/* <div className={styles.onTop}>h</div> */}
          </div>

          <div className={styles.twoOnRow}>
            <div className={`${styles.inputCardField} ${styles.expDateField}`}>
              <label htmlFor="" className={styles.fieldCardLabel}>
                Expiry date
              </label>
              <input
                type="text"
                inputMode="numeric"
                name="expiry"
                placeholder="MM / YY"
                value={state.expiry}
                onChange={handleInputChange}
                onFocus={handleInputFocus}
                // onBlur={onBlurValidate}
                className={styles.cardInput}
                maxLength={4}
              />
            </div>

            <div className={`${styles.inputCardField} ${styles.cvcField}`}>
              <label htmlFor="" className={styles.fieldCardLabel}>
                CVC/CVV
              </label>
              <input
                type="text"
                inputMode="numeric"
                name="cvc"
                placeholder="123"
                value={state.cvc}
                onChange={handleInputChange}
                onFocus={handleInputFocus}
                className={styles.cardInput}
                minLength={3}
                maxLength={4}
              />
            </div>
          </div>
          <div className={styles.twoOnRow}>
            <div className={`${styles.inputCardField} ${styles.amount}`}>
              <label htmlFor="" className={styles.fieldCardLabel}>
                Add amount
              </label>
              <input
                type="number"
                inputMode="numeric"
                name="amount"
                // placeholder="Card expiry date"
                value={state.amount}
                onChange={handleInputChange}
                onFocus={handleInputFocus}
                className={styles.cardInput}
              />
            </div>
            <div className={`${styles.inputCardField} ${styles.cvcField}`}>
              <button className={styles.amountBtn} onClick={onButtonValidate}>
                Add
              </button>
            </div>
          </div>
        </form>
        <Cards
          number={state.number}
          expiry={state.expiry}
          cvc={state.cvc}
          name={state.name}
          focused={state.focus}
        />
      </div>
      <div className={styles.errorContainer}>
        {error.isError && <p>{error.message}</p>}
      </div>
    </div>
  );
}
export default CreditCard;
