import styles from "./UserContactInfo.module.css";

import { useContext, useState } from "react";
import { UserContext } from "../../../context/GlobalUserProvider.jsx";
import ContactInfoElement from "../ContactInfoElement.jsx";
import { userInfo } from "../../../userServices/userService.js";
import { formatCurrency } from "../../../util/resolvers.js";

function UserContactInfo({ info, addMoneyBtnHandler }) {
  const { user } = useContext(UserContext);
  const [amount, setAmount] = useState("");
  const [isAccount, setIsAccount] = useState(false);

  function onAddAmountHandler(e) {
    e.preventDefault();
    if (amount < 1 || amount === "") return;
    addMoneyBtnHandler(amount);
    setAmount("");
  }

  function switcher(panel) {
    if (panel === isAccount) return;
    setIsAccount(panel);
  }

  return (
    <>
      {info && (
        <div className={styles.contactWrapper}>
          <h2 className={styles.infoHeader}>
            {/* <span>Contact information</span> */}
            <button onClick={() => switcher(false)}>
              <span>Contact information</span>
            </button>
            {user.role === "user" && (
              <button onClick={() => switcher(true)}>
                <span>Bank account</span>
              </button>
            )}
          </h2>

          {!isAccount && (
            <div className={styles.fullData}>
              <div className={styles.row}>
                <ContactInfoElement
                  content={info.firstName}
                  label={"First Name"}
                  width={"50%"}
                />
                <ContactInfoElement
                  content={info.lastName}
                  label={"Last Name"}
                  width={"50%"}
                />
              </div>

              <div className={styles.row}>
                <ContactInfoElement
                  content={info.email}
                  label={"Email"}
                  width={"60%"}
                />

                <ContactInfoElement
                  content={info.phoneNumber}
                  label={"Phone"}
                  width={"40%"}
                />
              </div>

              {user.role === "user" && (
                <div className={styles.row}>
                  <ContactInfoElement
                    content={info.address.street}
                    label={"Street"}
                    width={"80%"}
                  />

                  <ContactInfoElement
                    content={info.address.strNumber}
                    label={"Number"}
                    width={"20%"}
                  />
                </div>
              )}

              {user.role === "user" && (
                <div className={styles.row}>
                  <ContactInfoElement
                    content={info.address.block}
                    label={"Building"}
                    width={"60%"}
                  />

                  <ContactInfoElement
                    content={info.address.floor}
                    label={"Floor"}
                    width={"20%"}
                  />
                  <ContactInfoElement
                    content={info.address.apartment}
                    label={"Unit/Suite"}
                    width={"20%"}
                  />
                </div>
              )}

              {user.role === " user" && (
                <div className={styles.row}>
                  <ContactInfoElement
                    content={info.city}
                    label={"City"}
                    width={"50%"}
                  />

                  <ContactInfoElement
                    content={info.address.district}
                    label={"State"}
                    width={"30%"}
                  />
                  <ContactInfoElement
                    content={info.address.postCode}
                    label={"ZIP"}
                    width={"20%"}
                  />
                </div>
              )}

              {user.role === "user" && (
                <div className={styles.row}>
                  <ContactInfoElement
                    content={info.address.country}
                    label={"Country"}
                  />
                </div>
              )}
            </div>
          )}

          {isAccount && (
            <div className={styles.formContainer}>
              <form onSubmit={onAddAmountHandler} className={styles.form}>
                <label htmlFor="" className={styles.labelInput}>
                  {/* Add amount */}
                  <input
                    type="number"
                    className={styles.balanceInput}
                    value={amount}
                    onChange={(e) => setAmount(Number(e.target.value))}
                    placeholder={"Add amount"}
                  />
                </label>
                <button className={styles.amountBtn}>Add to balance</button>
              </form>
            </div>
          )}

          {/* {user.role === "user" && (
            <h2 className={styles.infoHeader}>
              <span>Account information</span>
            </h2>
          )}
          {user.role === "user" && (
            <div className={styles.fullData}>
              <div className={styles.row}>
                <ContactInfoElement
                  // content={user.balance.toFixed(2)}
                  content={formatCurrency(user.balance)}
                  label={"Account balance"}
                  width={"40%"}
                />
                <ContactInfoElement
                  content={info.iban}
                  label={"IBAN"}
                  width={"60%"}
                />
              </div>
            </div>
          )} */}

          {user.role === "user" && (
            <div className={styles.formContainer}>
              <form onSubmit={onAddAmountHandler} className={styles.form}>
                <label htmlFor="" className={styles.labelInput}>
                  {/* Add amount */}
                  <input
                    type="number"
                    className={styles.balanceInput}
                    value={amount}
                    onChange={(e) => setAmount(Number(e.target.value))}
                    placeholder={"Add amount"}
                  />
                </label>
                <button className={styles.amountBtn}>Add to balance</button>
              </form>
            </div>
          )}
        </div>
      )}
    </>
  );
}

export default UserContactInfo;
