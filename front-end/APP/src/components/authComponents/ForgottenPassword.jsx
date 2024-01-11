import styles from "./ForgottenPassword.module.css";

import { useNavigate } from "react-router-dom";
import { useAuth } from "../../context/AuthContext.jsx";
import { useEffect, useState } from "react";
import { EMAIL_REGEX } from "../../util/util.js";
import { post } from "../../util/api.js";
import LoaderWheel from "../LoaderWheel.jsx";
import Paginator from "../Paginator.jsx";

function ForgottenPassword() {
  const { isAuthenticated } = useAuth();
  const navigate = useNavigate();
  const [isLoading, setIsLoading] = useState(false);
  const [email, setEmail] = useState("");
  const [inputError, setInputError] = useState(false);
  const [emailHasSent, setEmailHasSent] = useState(false);

  useEffect(
    function () {
      if (isAuthenticated) {
        navigate("/", { replace: true });
      }
    },
    [isAuthenticated, navigate]
  );

  function onInputHandler(e) {
    setEmail(e.target.value.trim());
  }

  function validateInput(e) {
    if (e.target.value.length === 0) return;

    //EMAIL VALIDATION
    if (!EMAIL_REGEX.test(e.target.value)) {
      return setInputError(true);
    }
  }

  function onFocus(e) {
    if (inputError) {
      setInputError(false);
      setEmail("");
    }
  }

  async function onSubmitHandler(e) {
    e.preventDefault();
    setIsLoading(true);
    let reset = "";

    if (email.split("@")[1] === "b-free.com") {
      reset = await post(`/api/employee/reset?email=${email}`, email);
    } else {
      reset = await post(`/api/client/reset?email=${email}`, email);
    }

    setTimeout(function info() {
      navigate("/auth/login");
      setIsLoading(false);
    }, 3000);
    setEmailHasSent(true);
  }

  return (
    <div className={styles.wrapper}>
      {isLoading && <LoaderWheel />}
      {!emailHasSent ? (
        <form className={styles.form} onSubmit={onSubmitHandler}>
          <h2 className={styles.heading}>Password reset</h2>
          {inputError ? (
            <p className={styles.warning}>Invalid email address</p>
          ) : (
            <p className={styles.info}>Please, fill your email address</p>
          )}
          <input
            name={email}
            type="email"
            className={styles.input}
            value={email}
            onChange={onInputHandler}
            onBlur={validateInput}
            onFocus={onFocus}
            maxLength={40}
          />
          <button
            className={styles.btn}
            disabled={inputError || email.length === 0}
          >
            Reset
          </button>
          <p className={styles["p"]}>
            Already have an account?
            <span
              className={styles["span"]}
              onClick={() => navigate("/auth/login")}
            >
              Sign In
            </span>
          </p>
        </form>
      ) : (
        <div className={styles.form}>
          <p className={styles.afterSentInfo}>
            You will receive an email shortly.
          </p>
          <p className={styles.afterSentInfo}>
            Please, follow the instructions
          </p>
        </div>
      )}
    </div>
  );
}

export default ForgottenPassword;
