import styles from "./Register.module.css";

import { useState } from "react";
import { useNavigate } from "react-router-dom";

import { PhoneInput } from "react-international-phone";
import "react-international-phone/style.css";

import Navigation from "../Navigation.jsx";
import Footer from "../Footer.jsx";
import { register } from "../../util/auth.js";
import Loader from "../Loader.jsx";
import { setUserData } from "../../util/util.js";
import LoaderWheel from "../LoaderWheel.jsx";

const initialState = {
  firstName: "",
  lastName: "",
  email: "",
  password: "",
  repass: "",
  iban: "",
  balance: "",
  phone: "",
  address: "",
};

function Register() {
  const [phone, setPhone] = useState("");
  const [isHidden, setIsHidden] = useState(true);
  const [isHiddenRepass, setIsHiddenRepass] = useState(true);
  const [isLoading, setIsLoading] = useState(false);
  const [resError, setResError] = useState({ status: false, message: "" });
  const [inputError, setInputError] = useState(initialState);
  const [values, setValues] = useState(initialState);
  const [isAllowed, setIsAllowed] = useState(false);

  const navigate = useNavigate();

  const EMAIL_REGEX =
    /^[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?$/;
  const PASS_REGEX = /^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[a-zA-Z]).{6,}$/;

  function onChangeHandler(e) {
    if (e.target.name === "balance") {
      setValues({
        ...values,
        [e.target.name]: Number(e.target.value),
      });
    } else if (e.target.name === "iban") {
      setValues({ ...values, [e.target.name]: e.target.value.toUpperCase() });
    } else {
      setValues({ ...values, [e.target.name]: e.target.value });
    }
  }

  function validateInput(e) {
    const inputName = e.target.name;
    const inputValue = values[e.target.name];

    if (inputValue.length === 0) return;

    // FIRST NAME VALIDATION
    if (
      inputName === "firstName" &&
      (inputValue.length < 2 || inputValue.length > 20)
    ) {
      return setInputError((err) => ({
        ...err,
        [e.target.name]:
          "First name should be between 2 and 20 characters long",
      }));
    }

    // LAST NAME VALIDATION
    if (
      inputName === "lastName" &&
      (inputValue.length < 3 || inputValue.length > 20)
    ) {
      return setInputError((err) => ({
        ...err,
        [e.target.name]: "Last name should be between 3 and 20 characters long",
      }));
    }

    //EMAIL VALIDATION
    if (inputName === "email" && !EMAIL_REGEX.test(inputValue)) {
      return setInputError((err) => ({
        ...err,
        [e.target.name]: "Invalid email address!",
      }));
    }

    //PASSWORD VALIDATION
    if (inputName === "password" && !PASS_REGEX.test(inputValue)) {
      const passErrorText =
        "The password should be a minimum 6 characters long. At least one upper case, one lower case letter and at least one digit.";

      return setInputError((err) => ({
        ...err,
        [e.target.name]: passErrorText,
      }));
    }

    //REPASS VALIDATION
    if (inputName === "repass" && inputValue !== values.password) {
      return setInputError((err) => ({
        ...err,
        [e.target.name]: "Passwords don't match",
      }));
    }

    //PHONE VALIDATION
    if (inputName === "phone" && inputValue) {
      return setInputError((err) => ({
        ...err,
        [e.target.name]: "Invalid phone number",
      }));
    }

    //IBAN VALIDATION
    if (
      inputName === "iban" &&
      (inputValue.length < 5 || inputValue.length > 34)
    ) {
      return setInputError((err) => ({
        ...err,
        [e.target.name]: "Invalid IBAN number",
      }));
    }

    //BALANCE VALIDATION

    if (inputName === "balance") {
      if (inputValue === 0) {
        return setInputError((err) => ({
          ...err,
          [e.target.name]: "Balance should be greater than 0",
        }));
      } else {
        setValues({
          ...values,
          [e.target.name]: Number(Number(e.target.value).toFixed(2)),
        });
      }
    }

    //ADDRESS VALIDATION
    // if (
    //   inputName === "address" &&
    //   (inputValue.length < 5 || inputValue.length > 34)
    // ) {
    //   return setInputError((err) => ({
    //     ...err,
    //     [e.target.name]: "Invalid IBAN number",
    //   }));
    // }
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
      const regResponse = await register(user);
      console.log(user);

      setValues({
        firstName: "",
        lastName: "",
        email: "",
        password: "",
        repass: "",
        iban: "",
        balance: "",
        phone: "",
        address: "",
      });

      if (regResponse.code) {
        setIsLoading(false);
        setResError({ status: true, message: regResponse.message });
        throw new Error(regResponse);
      }
      setTimeout(() => {
        navigate("/");
        setIsLoading(false);
      }, 2000);
    } catch (err) {
      setTimeout(() => {
        navigate("/");
        setResError({ status: false, message: "" });
      }, 3000);
      throw new Error(err.message);
    }
  }

  return (
    <>
      {isLoading && <LoaderWheel />}
      <div className="modal">
        <form className={styles.form} onSubmit={formSubmitHandler}>
          <h2 className={styles.heading}>Register</h2>

          {/*FIRST NAME */}
          <div className={styles.wrapper}>
            <div className={styles["flex-column"]}>
              <label>First Name </label>
            </div>

            <div className={styles.inputForm}>
              <div className={styles.svg}>
                <svg
                  xmlns="http://www.w3.org/2000/svg"
                  fill="none"
                  viewBox="0 0 24 24"
                  strokeWidth={1.5}
                  stroke="currentColor"
                  className="w-6 h-6"
                >
                  <path
                    strokeLinecap="round"
                    strokeLinejoin="round"
                    d="M17.982 18.725A7.488 7.488 0 0012 15.75a7.488 7.488 0 00-5.982 2.975m11.963 0a9 9 0 10-11.963 0m11.963 0A8.966 8.966 0 0112 21a8.966 8.966 0 01-5.982-2.275M15 9.75a3 3 0 11-6 0 3 3 0 016 0z"
                  />
                </svg>
              </div>

              <input
                type="text"
                className={styles.input}
                placeholder="Enter your Name"
                name={"firstName"}
                value={values.firstName}
                onChange={(e) => onChangeHandler(e)}
                onBlur={(e) => validateInput(e)}
                onFocus={(e) => clearErrorState(e)}
              />
            </div>
            {inputError.firstName && (
              <p className={styles.warning}>{inputError.firstName}</p>
            )}
          </div>

          {/*LAST NAME */}
          <div className={styles.wrapper}>
            <div className={styles["flex-column"]}>
              <label>Last Name </label>
            </div>

            <div className={styles.inputForm}>
              <div className={styles.svg}>
                <svg
                  xmlns="http://www.w3.org/2000/svg"
                  fill="none"
                  viewBox="0 0 24 24"
                  strokeWidth={1.5}
                  stroke="currentColor"
                  className="w-6 h-6"
                >
                  <path
                    strokeLinecap="round"
                    strokeLinejoin="round"
                    d="M15 9h3.75M15 12h3.75M15 15h3.75M4.5 19.5h15a2.25 2.25 0 002.25-2.25V6.75A2.25 2.25 0 0019.5 4.5h-15a2.25 2.25 0 00-2.25 2.25v10.5A2.25 2.25 0 004.5 19.5zm6-10.125a1.875 1.875 0 11-3.75 0 1.875 1.875 0 013.75 0zm1.294 6.336a6.721 6.721 0 01-3.17.789 6.721 6.721 0 01-3.168-.789 3.376 3.376 0 016.338 0z"
                  />
                </svg>
              </div>

              <input
                type="text"
                className={styles.input}
                placeholder="Enter your Last Name"
                name={"lastName"}
                value={values.lastName}
                onChange={(e) => onChangeHandler(e)}
                onBlur={(e) => validateInput(e)}
                onFocus={(e) => clearErrorState(e)}
              />
            </div>
            {inputError.lastName && (
              <p className={styles.warning}>{inputError.lastName}</p>
            )}
          </div>

          {/* EMAIL */}
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

          {/* PASSWORD */}
          <div className={styles.wrapper}>
            <div className={styles["flex-column"]}>
              <label>Password </label>
            </div>

            <div className={`${styles["inputForm"]}`}>
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

          {/* REPEAT PASSWORD */}
          <div className={styles.wrapper}>
            <div className={styles["flex-column"]}>
              <label>Repeat Password </label>
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
                type={isHiddenRepass ? "password" : "text"}
                className={styles["input"]}
                placeholder="Repeat Password"
                name={"repass"}
                value={values.repass}
                onChange={(e) => onChangeHandler(e)}
                onBlur={(e) => validateInput(e)}
                onFocus={(e) => clearErrorState(e)}
              />
              <div
                className={styles.svg}
                onClick={() => setIsHiddenRepass(!isHiddenRepass)}
              >
                {isHiddenRepass ? (
                  <i
                    className="fa-regular fa-eye"
                    style={
                      inputError.repass
                        ? { display: "none", color: "red" }
                        : null
                    }
                  ></i>
                ) : (
                  <i
                    className="fa-regular fa-eye-slash"
                    style={
                      inputError.repass
                        ? { display: "none", color: "red" }
                        : null
                    }
                  ></i>
                )}
              </div>
            </div>
            {inputError.repass && (
              <p className={styles.warning}>{inputError.repass}</p>
            )}
          </div>

          {/* PHONE */}
          <div className={styles.wrapper}>
            <div className={styles["flex-column"]}>
              <label>Telepfone </label>
            </div>
            <div className={styles["inputForm"]}>
              <PhoneInput
                defaultCountry="bg"
                value={phone}
                onChange={(phone) => setPhone(phone)}
                onBlur={() => setValues({ ...values, phone: phone })}
                inputStyle={{
                  // width: "90%",
                  // height: "50px",
                  // border: "1.5px solid #ecedec",
                  border: "none",
                  borderRadius: "10px",
                  fontSize: "2rem",
                }}
                buttonStyle={false}
              />
            </div>
          </div>

          {/* IBAN */}
          <div className={styles.wrapper}>
            <div className={styles["flex-column"]}>
              <label>IBAN </label>
            </div>

            <div className={styles["inputForm"]}>
              <div className={styles.svg}>
                <svg
                  xmlns="http://www.w3.org/2000/svg"
                  fill="none"
                  viewBox="0 0 24 24"
                  strokeWidth={1.2}
                  stroke="currentColor"
                  className="w-6 h-6"
                >
                  <path
                    strokeLinecap="round"
                    strokeLinejoin="round"
                    d="M2.25 8.25h19.5M2.25 9h19.5m-16.5 5.25h6m-6 2.25h3m-3.75 3h15a2.25 2.25 0 002.25-2.25V6.75A2.25 2.25 0 0019.5 4.5h-15a2.25 2.25 0 00-2.25 2.25v10.5A2.25 2.25 0 004.5 19.5z"
                  />
                </svg>
              </div>

              <input
                type="text"
                className={styles["input"]}
                placeholder="Enter IBAN number"
                name={"iban"}
                value={values.iban}
                onChange={(e) => onChangeHandler(e)}
                onBlur={(e) => validateInput(e)}
                onFocus={(e) => clearErrorState(e)}
              />
              {/* <div className={styles.svg}>
                <svg
                  xmlns="http://www.w3.org/2000/svg"
                  fill="none"
                  viewBox="0 0 24 24"
                  strokeWidth={1.5}
                  stroke="currentColor"
                  className="w-6 h-6"
                >
                  <path
                    strokeLinecap="round"
                    strokeLinejoin="round"
                    d="M4.5 12.75l6 6 9-13.5"
                  />
                </svg>
              </div> */}
            </div>
            {inputError.iban && (
              <p className={styles.warning}>{inputError.iban}</p>
            )}
          </div>

          {/* Account balance */}
          <div className={styles.wrapper}>
            <div className={styles["flex-column"]}>
              <label>Account </label>
            </div>

            <div className={styles["inputForm"]}>
              <div className={styles.svg}>
                <svg
                  xmlns="http://www.w3.org/2000/svg"
                  fill="none"
                  viewBox="0 0 24 24"
                  strokeWidth={1.5}
                  stroke="currentColor"
                  className="w-6 h-6"
                >
                  <path
                    strokeLinecap="round"
                    strokeLinejoin="round"
                    d="M2.25 18.75a60.07 60.07 0 0115.797 2.101c.727.198 1.453-.342 1.453-1.096V18.75M3.75 4.5v.75A.75.75 0 013 6h-.75m0 0v-.375c0-.621.504-1.125 1.125-1.125H20.25M2.25 6v9m18-10.5v.75c0 .414.336.75.75.75h.75m-1.5-1.5h.375c.621 0 1.125.504 1.125 1.125v9.75c0 .621-.504 1.125-1.125 1.125h-.375m1.5-1.5H21a.75.75 0 00-.75.75v.75m0 0H3.75m0 0h-.375a1.125 1.125 0 01-1.125-1.125V15m1.5 1.5v-.75A.75.75 0 003 15h-.75M15 10.5a3 3 0 11-6 0 3 3 0 016 0zm3 0h.008v.008H18V10.5zm-12 0h.008v.008H6V10.5z"
                  />
                </svg>
              </div>

              <input
                type="number"
                className={styles["input"]}
                placeholder="Enter balance"
                name={"balance"}
                value={values.balance}
                onChange={(e) => onChangeHandler(e)}
                onBlur={(e) => validateInput(e)}
                onFocus={(e) => clearErrorState(e)}
              />
            </div>

            {inputError.balance && (
              <p className={styles.warning}>{inputError.balance}</p>
            )}
          </div>

          {/* ADDRESS */}
          <div className={styles.wrapper}>
            <div className={styles["flex-column"]}>
              <label>Address </label>
            </div>

            <div className={styles["address"]}>
              <div className={styles.svgTextArea}>
                <svg
                  xmlns="http://www.w3.org/2000/svg"
                  fill="none"
                  viewBox="0 0 24 24"
                  strokeWidth={1.2}
                  stroke="currentColor"
                  className="w-6 h-6"
                >
                  <path
                    strokeLinecap="round"
                    strokeLinejoin="round"
                    d="M2.25 8.25h19.5M2.25 9h19.5m-16.5 5.25h6m-6 2.25h3m-3.75 3h15a2.25 2.25 0 002.25-2.25V6.75A2.25 2.25 0 0019.5 4.5h-15a2.25 2.25 0 00-2.25 2.25v10.5A2.25 2.25 0 004.5 19.5z"
                  />
                </svg>
              </div>
              <textarea
                rows="3"
                cols="80"
                placeholder="Enter address"
                className={styles["textarea"]}
                name={"address"}
                onChange={(e) => onChangeHandler(e)}
                onBlur={(e) => validateInput(e)}
                onFocus={(e) => clearErrorState(e)}
                value={values.address}
              ></textarea>
            </div>
            {inputError.address && (
              <p className={styles.warning}>{inputError.address}</p>
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
            Sign Up
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
      </div>
    </>
  );
}

export default Register;

// {
//   "firstName": "First Name Test",
//   "lastName": "Last Name Test",
//   "email": "test@test.bg",
//   "password": "Test-1",
//   "repass": "Test-1",
//   "iban": "QWE123345567789",
//   "balance": 9536433.24,
//   "phone": "+359888888888",
//   "address": "Testuser str. 123 , Washington DC , USA"
// }
