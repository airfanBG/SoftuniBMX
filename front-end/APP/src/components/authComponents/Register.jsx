import styles from "./Register.module.css";

import { useState } from "react";
import { useNavigate } from "react-router-dom";

// import { PhoneInput } from "react-international-phone";
// import "react-international-phone/style.css";

import { register } from "../../util/auth.js";
import { EMAIL_REGEX, PASS_REGEX } from "../../util/util.js";
import LoaderWheel from "../LoaderWheel.jsx";
import InputComponent from "./InputComponent.jsx";
import { inputSVG } from "./inputSVG.jsx";
import PhoneComponent from "./PhoneComponent.jsx";
import InputPasswordComponent from "./InputPasswordComponent.jsx";

const initialState = {
  firstName: "",
  lastName: "",
  email: "",
  password: "",
  repass: "",
  iban: "",
  balance: "",
  phone: "",
  country: "",
  city: "",
  postCode: "",
  district: "",
  block: "",
  floor: "",
  apartment: "",
  street: "",
  strNumber: "",
  role: "user",
};

function Register() {
  const [values, setValues] = useState(initialState);
  const [inputError, setInputError] = useState(initialState);
  // const [isHiddenRepass, setIsHiddenRepass] = useState(true);
  const [phone, setPhone] = useState("");
  const [resError, setResError] = useState({ status: false, message: "" });
  // const [isRequired, setIsRequired] = useState()
  const [isAllowed, setIsAllowed] = useState(false);
  const [isLoading, setIsLoading] = useState(false);

  const navigate = useNavigate();

  function onChangeHandler(e) {
    if (e.target.name === "balance") {
      setValues({
        ...values,
        [e.target.name]: Number(e.target.value),
      });
    } else if (e.target.name === "iban") {
      setValues({
        ...values,
        [e.target.name]: e.target.value.trim().toUpperCase(),
      });
    } else {
      setValues({ ...values, [e.target.name]: e.target.value.trim() });
    }
  }

  function phoneValidate(e) {
    const userPhone = e.target.value.split(" ").at(1);
    if (userPhone.length < 6) {
      return setInputError((err) => ({
        ...err,
        [e.target.name]: "Invalid phone number",
      }));
    }
    setValues({ ...values, phone: e.target.value });
  }

  function validateInput(e) {
    const inputName = e.target.name;
    const inputValue = values[e.target.name];

    if (inputValue.length === 0) return;

    // FIRST NAME VALIDATION
    if (
      inputName === "firstName" &&
      (inputValue.length < 3 || inputValue.length > 30)
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
      (inputValue.length < 3 || inputValue.length > 30)
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
    // TODO: length
    if (inputName === "phone") {
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

    // ADDRESS VALIDATION
    if (
      inputName === "address" &&
      (inputValue.length < 5 || inputValue.length > 50)
    ) {
      return setInputError((err) => ({
        ...err,
        [e.target.name]: "Invalid Address ",
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

    const user = {
      firstName: values.firstName,
      lastName: values.lastName,
      email: values.email,
      password: values.password,
      repass: values.repass,
      iban: values.iban,
      balance: Number(values.balance),
      phone: values.phone,
      city: values.city,
      role: "user",
      address: {
        country: values.country,
        postCode: values.postCode,
        district: values.district,
        block: values.block,
        floor: values.floor,
        // floor: Number(values.floor),
        apartment: values.apartment,
        street: values.street,
        strNumber: values.strNumber,
      },
    };

    try {
      setIsLoading(true);
      const regResponse = await register(user);

      if (regResponse.code) {
        setIsLoading(false);
        setResError({ status: true, message: regResponse.message });
        throw new Error(regResponse);
      }
      setTimeout(() => {
        navigate("/");
        setIsLoading(false);
        setValues(initialState);
      }, 1000);
    } catch (err) {
      setTimeout(() => {
        navigate("/");
        setResError({ status: false, message: "" });
      }, 3000);
      throw new Error(err.message);
    }
  }
  const propsFunc = {
    valueMode: (mainValue) => values[mainValue],
    onChangeHandler,
    validateInput,
    clearErrorState,
    errorMode: (mainValue) => inputError[mainValue],
    svg: inputSVG,
  };
  const props = {
    firstName: {
      mainValue: "firstName",
      label: "First Name",
      type: "text",
      placeholder: "Enter your First Name",
      required: true,
    },
    lastName: {
      mainValue: "lastName",
      label: "Last Name",
      type: "text",
      placeholder: "Enter your Last Name",
      required: true,
    },
    email: {
      mainValue: "email",
      label: "Email",
      type: "email",
      placeholder: "Enter your Email",
      required: true,
    },
    password: {
      mainValue: "password",
      label: "Password",
      type: "password",
      placeholder: "Enter your Password",
      required: true,
    },
    repass: {
      mainValue: "repass",
      label: "Repeat Password",
      type: "password",
      placeholder: "Repeat Password",
      required: true,
    },
    balance: {
      mainValue: "balance",
      label: "Account",
      type: "number",
      placeholder: "Enter balance",
      required: true,
    },
    iban: {
      mainValue: "iban",
      label: "IBAN",
      type: "text",
      placeholder: "Enter IBAN number",
      required: true,
    },
    phone: {
      label: "Telephone",
      mainValue: "phone",
    },
    country: {
      mainValue: "country",
      label: "Country",
      type: "text",
      placeholder: "Enter Country",
      required: true,
    },
    city: {
      mainValue: "city",
      label: "City",
      type: "text",
      placeholder: "Enter City",
      required: true,
    },
    street: {
      mainValue: "street",
      label: "Street",
      type: "text",
      placeholder: "Enter Street",
      required: true,
    },
    strNumber: {
      mainValue: "strNumber",
      label: "Number",
      type: "text",
      placeholder: "Enter Street number",
      required: true,
    },
    district: {
      mainValue: "district",
      label: "District",
      type: "text",
      placeholder: "Enter District",
      required: false,
    },
    postCode: {
      mainValue: "postCode",
      label: "Post code",
      type: "text",
      placeholder: "Enter Post code",
      required: false,
    },
    block: {
      mainValue: "block",
      label: "Block",
      type: "text",
      placeholder: "Enter Building name/number",
      required: false,
    },
    floor: {
      mainValue: "floor",
      label: "Floor",
      type: "number",
      placeholder: "Enter Floor",
      required: false,
    },
    apartment: {
      mainValue: "apartment",
      label: "Apartment",
      type: "text",
      placeholder: "Enter Apartment",
      required: false,
    },
  };

  return (
    <>
      {isLoading && <LoaderWheel />}
      <div className="modal">
        <form className={styles.form} onSubmit={formSubmitHandler}>
          <h2 className={styles.heading}>Register</h2>

          <section className={styles.fieldsGroup}>
            <aside className={styles.asideLeft}>
              {/*FIRST NAME */}
              <InputComponent {...props.firstName} {...propsFunc} />

              {/*LAST NAME */}
              <InputComponent {...props.lastName} {...propsFunc} />

              {/* EMAIL */}
              <InputComponent {...props.email} {...propsFunc} />

              {/* PASSWORD */}
              <InputPasswordComponent {...props.password} {...propsFunc} />

              {/* REPEAT PASSWORD */}
              <InputPasswordComponent {...props.repass} {...propsFunc} />

              {/* PHONE */}
              <PhoneComponent
                {...props.phone}
                {...propsFunc}
                values={values}
                setValues={setValues}
                phone={phone}
                setPhone={setPhone}
                phoneValidate={phoneValidate}
              />

              {/* IBAN */}
              <InputComponent {...props.iban} {...propsFunc} />

              {/* Account balance */}
              <InputComponent {...props.balance} {...propsFunc} />
            </aside>
            <aside className={styles.asideRight}>
              {/* COUNTRY */}
              <InputComponent {...props.country} {...propsFunc} />

              {/* CITY */}
              <InputComponent {...props.city} {...propsFunc} />

              {/* POSTCODE */}
              <InputComponent {...props.postCode} {...propsFunc} />

              {/* DISTRICT */}
              <InputComponent {...props.district} {...propsFunc} />

              {/* BLOCK */}
              <InputComponent {...props.block} {...propsFunc} />

              {/* FLOOR */}
              <InputComponent {...props.floor} {...propsFunc} />

              {/* APARTMENT */}
              <InputComponent {...props.apartment} {...propsFunc} />

              {/* STREET */}
              <InputComponent {...props.street} {...propsFunc} />

              {/* STREET NUMBER */}
              <InputComponent {...props.strNumber} {...propsFunc} />
            </aside>
          </section>

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
