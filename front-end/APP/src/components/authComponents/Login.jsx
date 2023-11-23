import styles from "./Login.module.css";

import { useContext, useState } from "react";
import { Link, useNavigate } from "react-router-dom";

import { login } from "../../util/auth.js";
import { clearUserData, setUserData } from "../../util/util.js";
import LoaderWheel from "../LoaderWheel.jsx";
import { UserContext } from "../../context/GlobalUserProvider.jsx";

const EMAIL_REGEX =
  /^[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?$/;

const initialState = {
  email: "",
  password: "",
};

function Login() {
  const [isHidden, setIsHidden] = useState(true);
  const [isLoading, setIsLoading] = useState(false);
  const [resError, setResError] = useState({ status: false, message: "" });
  const [inputError, setInputError] = useState(initialState);
  const [values, setValues] = useState(initialState);
  const [isAllowed, setIsAllowed] = useState(false);

  const { updateUser } = useContext(UserContext);

  const navigate = useNavigate();

  function onChangeHandler(e) {
    setValues({ ...values, [e.target.name]: e.target.value });
  }

  function validateInput(e) {
    const inputName = e.target.name;
    const inputValue = values[e.target.name];

    if (inputValue.length === 0) return;

    //EMAIL VALIDATION
    if (inputName === "email" && !EMAIL_REGEX.test(inputValue)) {
      return setInputError((err) => ({
        ...err,
        [e.target.name]: "Invalid email address!",
      }));
    }

    //PASSWORD VALIDATION
    if (inputName === "password" && inputValue.length < 6) {
      const passErrorText = "Invalid password";

      return setInputError((err) => ({
        ...err,
        [e.target.name]: passErrorText,
      }));
    }
  }

  function clearErrorState(e) {
    setInputError((err) => ({
      ...err,
      [e.target.name]: "",
    }));
  }

  async function formSubmitHandler(e) {
    e.preventDefault();
    if (Object.values(values).some((x) => x === "")) {
      return setIsAllowed(true);
    }

    const user = values;

    try {
      setIsLoading(true);
      const result = await login(user);

      // setValues({
      //   email: "",
      //   password: "",
      // });

      if (result.code) {
        setIsLoading(false);
        setResError({ status: true, message: result.message });
        throw new Error(result);
      }
      const currentUser = {
        accessToken: result.accessToken,
        firstName: result.user.firstName,
        lastName: result.user.lastName,
        role: result.user.role,
        id: result.user.id,
      };
      if (result.user.balance) {
        currentUser.balance = Number(result.user.balance.toFixed(2));
      }

      updateUser(currentUser);
      setUserData(currentUser);
      setIsLoading(false);
      navigate("/");
    } catch (err) {
      setTimeout(() => {
        navigate("/");
        clearUserData();

        setResError({ status: false, message: "" });
      }, "5000");
      throw new Error(err.message);
    }
  }
  // TODO: if user is worker clear local storage
  return (
    <>
      {isLoading && <LoaderWheel />}
      <div className="modal">
        <form className={styles.form} onSubmit={formSubmitHandler}>
          <h2 className={styles.heading}>Login</h2>
          <div className={styles.wrapper}>
            <div className={styles["flex-column"]}>
              <label>Email </label>
            </div>
            <div className={styles.inputForm}>
              <svg
                height={20}
                viewBox="0 0 32 32"
                width={20}
                xmlns="http://www.w3.org/2000/svg"
              >
                <g id="Layer_3" data-name="Layer 3">
                  <path d="m30.853 13.87a15 15 0 0 0 -29.729 4.082 15.1 15.1 0 0 0 12.876 12.918 15.6 15.6 0 0 0 2.016.13 14.85 14.85 0 0 0 7.715-2.145 1 1 0 1 0 -1.031-1.711 13.007 13.007 0 1 1 5.458-6.529 2.149 2.149 0 0 1 -4.158-.759v-10.856a1 1 0 0 0 -2 0v1.726a8 8 0 1 0 .2 10.325 4.135 4.135 0 0 0 7.83.274 15.2 15.2 0 0 0 .823-7.455zm-14.853 8.13a6 6 0 1 1 6-6 6.006 6.006 0 0 1 -6 6z" />
                </g>
              </svg>
              <input
                type="email"
                className={styles.input}
                placeholder="Enter your Email"
                name={"email"}
                value={values.email}
                onChange={(e) => onChangeHandler(e)}
                onBlur={(e) => validateInput(e)}
                onFocus={(e) => clearErrorState(e)}
              />
            </div>
            {inputError.email && (
              <p className={styles.warning}>{inputError.email}</p>
            )}
          </div>

          <div className={styles.wrapper}>
            <div className={styles["flex-column"]}>
              <label>Password </label>
            </div>
            <div className={styles["inputForm"]}>
              <svg
                height={20}
                viewBox="-64 0 512 512"
                width={20}
                xmlns="http://www.w3.org/2000/svg"
              >
                <path d="m336 512h-288c-26.453125 0-48-21.523438-48-48v-224c0-26.476562 21.546875-48 48-48h288c26.453125 0 48 21.523438 48 48v224c0 26.476562-21.546875 48-48 48zm-288-288c-8.8125 0-16 7.167969-16 16v224c0 8.832031 7.1875 16 16 16h288c8.8125 0 16-7.167969 16-16v-224c0-8.832031-7.1875-16-16-16zm0 0" />
                <path d="m304 224c-8.832031 0-16-7.167969-16-16v-80c0-52.929688-43.070312-96-96-96s-96 43.070312-96 96v80c0 8.832031-7.167969 16-16 16s-16-7.167969-16-16v-80c0-70.59375 57.40625-128 128-128s128 57.40625 128 128v80c0 8.832031-7.167969 16-16 16zm0 0" />
              </svg>
              <input
                type={isHidden ? "password" : "text"}
                className={styles["input"]}
                placeholder="Enter your Password"
                name={"password"}
                value={values.password}
                onChange={(e) => onChangeHandler(e)}
                onBlur={(e) => validateInput(e)}
                onFocus={(e) => clearErrorState(e)}
              />
              <div
                className={styles.svg}
                onClick={() => setIsHidden(!isHidden)}
              >
                {isHidden ? (
                  <i
                    className="fa-regular fa-eye"
                    style={
                      inputError.password
                        ? { display: "none", color: "red" }
                        : null
                    }
                  ></i>
                ) : (
                  <i
                    className="fa-regular fa-eye-slash"
                    style={
                      inputError.password
                        ? { display: "none", color: "red" }
                        : null
                    }
                  ></i>
                )}
              </div>
            </div>
            {inputError.password && (
              <p className={styles.warning}>{inputError.password}</p>
            )}
          </div>

          {isAllowed && (
            <p style={{ color: "red", fontSize: "1.8rem" }}>
              All fields are required!
            </p>
          )}
          {resError.status && (
            <p className={styles.generalError}>{resError.message}</p>
          )}
          <button className={styles["button-submit"]} disabled={isAllowed}>
            Sign In
          </button>
          <Link
            className={styles["forgotPass"]}
            to={"/auth/forgotten-password"}
          >
            Forgot password<span> ?</span>
          </Link>

          <p className={styles["p"]}>
            Do not have an account?
            <span
              className={styles["span"]}
              onClick={() => navigate("/auth/register")}
            >
              Sign Up
            </span>
          </p>
        </form>
      </div>
    </>
  );
}

export default Login;
