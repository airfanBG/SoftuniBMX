import { useContext } from "react";
import styles from "./Balance.module.css";
import { UserContext } from "../../context/GlobalUserProvider.jsx";
import { formatCurrency } from "../../util/resolvers.js";

function Balance() {
  const { user } = useContext(UserContext);
  return (
    <>
      <span>Balance: </span>
      <h3 className={styles.cash}>
        {/* {user.balance.toFixed(2)} <span className={styles.smaller}>BGN</span> */}
        {formatCurrency(user.balance)}
      </h3>
    </>
  );
}

export default Balance;
