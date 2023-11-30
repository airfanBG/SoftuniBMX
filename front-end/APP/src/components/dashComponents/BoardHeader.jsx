import { useContext } from "react";
import { Link, useNavigate } from "react-router-dom";

import styles from "./BoardHeader.module.css";
// import { UserContext } from "../UserProfile.jsx";
import Balance from "./Balance.jsx";
import Category from "./Category.jsx";
import { logout } from "../../util/auth.js";
import { UserContext } from "../../context/GlobalUserProvider.jsx";
import Guest from "./userComponents/Guest.jsx";

function BoardHeader() {
  const { user, updateUser } = useContext(UserContext);
  const navigate = useNavigate();

  function onLogout() {
    const exit = logout();
    updateUser("");
    navigate("/");
  }
  return (
    <header className={styles.boardHeader}>
      {user === "free" && <Guest />}
      {user.role === "user" && <Balance user={user} />}
      {user.role === "worker" && <Category />}
      <button className={styles.logout} onClick={onLogout}>
        Logout
      </button>
    </header>
  );
}

export default BoardHeader;
