import { useState } from "react";
import { EMAIL_REGEX, PASS_REGEX } from "../util/util.js";

export function useValidateForm(initialState) {
  const [inputError, setInputError] = useState(initialState);
  const validateInput = (e, inputValue) => {
    const inputName = e.target.name;
    // const inputValue = values[e.target.name];

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
      }
      //   } else {
      //     setValues({
      //       ...values,
      //       [e.target.name]: Number(Number(e.target.value).toFixed(2)),
      //     });
      //   }
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
  };

  const validateRePass = (e, inputValue, passValue) => {
    //REPASS VALIDATION
    if (inputValue !== passValue.value) {
      return setInputError((err) => ({
        ...err,
        [e.target.name]: "Passwords don't match",
      }));
    }
  };

  return {
    inputError,
    validateInput,
    validateRePass,
  };
}
