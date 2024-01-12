import { useState } from "react";
import Cards from "react-credit-cards-2";
import "react-credit-cards-2/dist/es/styles-compiled.css";
import styles from "./CreditCard.module.css";

function CreditCard({ amountBtnHandler }) {
  const [state, setState] = useState({
    number: "",
    expiry: "",
    cvc: "",
    name: "",
    focus: "",
    amount: "",
  });

  const handleInputChange = (evt) => {
    const { name, value, inputMode } = evt.target;
    if (inputMode === "numeric" && !Number(value)) return;
    setState((prev) => ({ ...prev, [name]: value }));
  };

  const handleInputFocus = (evt) => {
    setState((prev) => ({ ...prev, focus: evt.target.name }));
  };

  return (
    <div className={styles.cardContainer}>
      <form className={styles.cardForm}>
        <div className={styles.inputCardField}>
          <label htmlFor="" className={styles.fieldCardLabel}>
            Card number
          </label>
          <input
            type="text"
            inputMode="numeric"
            name="number"
            // placeholder="Card Number"
            value={state.number}
            onChange={handleInputChange}
            onFocus={handleInputFocus}
            className={styles.cardInput}
            maxLength={15}
          />
        </div>

        <div className={styles.inputCardField}>
          <label htmlFor="" className={styles.fieldCardLabel}>
            Name on card
          </label>
          <input
            type="text"
            name="name"
            // placeholder="Name on card"
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
              // placeholder="Card expiry date"
              value={state.expiry}
              onChange={handleInputChange}
              onFocus={handleInputFocus}
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
              // placeholder="CVC/CVV"
              value={state.cvc}
              onChange={handleInputChange}
              onFocus={handleInputFocus}
              className={styles.cardInput}
              maxLength={4}
            />
          </div>
        </div>
        <div className={styles.twoOnRow}>
          <div className={`${styles.inputCardField} ${styles.expDateField}`}>
            <label htmlFor="" className={styles.fieldCardLabel}>
              Add amount
            </label>
            <input
              type="text"
              inputMode="numeric"
              name="amount"
              // placeholder="Card expiry date"
              value={state.amount}
              onChange={handleInputChange}
              onFocus={handleInputFocus}
              className={styles.cardInput}
            />
          </div>

          <button
            className={styles.amountBtn}
            onClick={() => console.log(state.amount)}
          >
            Add
          </button>
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
  );
}
export default CreditCard;
