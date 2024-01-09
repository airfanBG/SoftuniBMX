import styles from "./BoardHeader.module.css";

import { memo, useContext } from "react";
import { Link, useNavigate } from "react-router-dom";

// import { UserContext } from "../UserProfile.jsx";
import Balance from "./Balance.jsx";
import Category from "./Category.jsx";
import { logout } from "../../util/auth.js";
import { UserContext } from "../../context/GlobalUserProvider.jsx";
import Guest from "./userComponents/Guest.jsx";
import { useAuth } from "../../context/AuthContext.jsx";

function BoardHeader() {
  const { logoutUser } = useAuth();
  const { user, updateUser } = useContext(UserContext);
  const navigate = useNavigate();

  const partPage = window.location.pathname.includes("/app/part/");

  function onLogout() {
    const exit = logout();
    logoutUser();
    updateUser("");
    navigate("/");
  }
  return (
    <header className={styles.boardHeader}>
      {user === "free" && <Guest />}
      {user.role === "user" && !partPage && <Balance user={user} />}
      {(user.role === "accessoriesworker" ||
        user.role === "frameworker" ||
        user.role === "wheelworker") && <Category />}

      <div className={`${styles.logout} ${styles.userControls}`}>
        {!!user.salary && user.role !== "user" && (
          <Link to={"/profile/employee-salary"} className={styles.salary}>
            Monthly Salary
          </Link>
        )}
        <button className={styles.logout} onClick={onLogout}>
          Logout
        </button>
      </div>
    </header>
  );
}

export default memo(BoardHeader);
