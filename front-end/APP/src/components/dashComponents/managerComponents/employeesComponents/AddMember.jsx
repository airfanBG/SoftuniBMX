import styles from "./AddMember.module.css";

import BoardHeader from "../../BoardHeader.jsx";
import { PhoneInput } from "react-international-phone";
import { memo, useReducer, useState } from "react";
import { initialState, reducer } from "./../managerUtil/addMemberReducer.js";
import { post } from "../../../../util/api.js";
import { environment } from "../../../../environments/environment.js";
import { useNavigate } from "react-router-dom";
import { PASS_REGEX } from "../../../../util/util.js";

function AddMember() {
  const [phone, setPhone] = useState("");
  const navigate = useNavigate();
  const [
    {
      email,
      password,
      firstName,
      lastName,
      repass,
      userRole,
      department,
      phoneNumber,
      position,
      isManager,
      dateOfHire,
      error,
    },
    dispatch,
  ] = useReducer(reducer, initialState);
  let role = "";

  function onSetInputData(e) {
    const actionType = e.target.id;
    const payloadData = e.target.value;
    dispatch({ type: actionType, payload: payloadData });
  }

  function onBlurInput(e) {
    const actionType = e.target.id;
    const fieldValue = e.target.value;

    if (!fieldValue) return;

    if (actionType === "firstName/input" && fieldValue.length < 3) {
      dispatch({ type: "error/set", payload: actionType });
    } else if (actionType === "lastName/input" && fieldValue.length < 3) {
      dispatch({ type: "error/set", payload: actionType });
    } else if (actionType === "email/input" && fieldValue.length < 3) {
      dispatch({ type: "error/set", payload: actionType });
    } else if (
      actionType === "password/input" &&
      !PASS_REGEX.test(fieldValue)
    ) {
      dispatch({ type: "error/set", payload: actionType });
    } else if (actionType === "repass/input" && fieldValue !== password) {
      dispatch({ type: "error/set", payload: actionType });
    }
  }

  function clearInput(e) {
    const actionType = e.target.id;

    if (error[actionType])
      dispatch({ type: "error/clear", payload: actionType });
  }

  async function handleFormSubmit(e) {
    e.preventDefault();

    if (department === "Frames") {
      role = "frameworker";
    } else if (department === "Wheels") {
      role = "wheelworker";
    } else if (department === "Accessory") {
      role = "accessoriesworker";
    }

    const finalState = {
      email: email + "@b-free.com",
      password,
      firstName,
      lastName,
      repass,
      role,
      phone: phoneNumber,
      isManager: userRole === "manager" ? true : false,
      // dateOfHire: new Date().toLocaleDateString(),
      dateOfHire: new Date().toISOString(),
    };

    if (userRole === "worker") {
      finalState.department = department;
      finalState.position = position;
    }

    // console.log(finalState);
    const result = await post(environment.register_employee, finalState);
    // console.log(result);

    navigate("/profile/employers");
  }
  return (
    <>
      {/* <div className={styles.wrapper}> */}
      <h2 className={styles.dashHeading}>Add member</h2>

      <section className={styles.board}>
        {/* <BoardHeader /> */}
        <div className={styles.formContainer}>
          <form className={styles.form} onSubmit={handleFormSubmit}>
            <div className={styles.inputField}>
              <label htmlFor="firstName/input">First Name</label>
              <input
                type="text"
                id="firstName/input"
                value={firstName}
                onChange={onSetInputData}
                onBlur={onBlurInput}
                onFocus={clearInput}
                required
              />
              {error["firstName/input"] && (
                <p className={styles.error}>
                  First name should be between 3 and 20 characters
                </p>
              )}
            </div>

            <div className={styles.inputField}>
              <label htmlFor="lastName/input">Last Name</label>
              <input
                type="text"
                id="lastName/input"
                value={lastName}
                onChange={onSetInputData}
                onBlur={onBlurInput}
                onFocus={clearInput}
                required
                // disabled={true}
              />
              {error["lastName/input"] && (
                <p className={styles.error}>
                  Last name should be between 3 and 20 characters
                </p>
              )}
            </div>

            <div className={styles.inputField}>
              <label htmlFor="email/input">Email</label>
              <div className={styles.emailContainer}>
                <input
                  type="text"
                  id="email/input"
                  value={email}
                  onChange={onSetInputData}
                  onBlur={onBlurInput}
                  onFocus={clearInput}
                  required
                />
                <span>@b-free.com</span>
                {error["email/input"] && (
                  <p className={styles.error}>
                    Email should be at least 3 characters
                  </p>
                )}
              </div>
            </div>

            <div className={styles.inputField}>
              <label htmlFor="password/input">Password</label>
              <input
                type="password"
                id="password/input"
                value={password}
                name={password}
                onChange={onSetInputData}
                onBlur={onBlurInput}
                onFocus={clearInput}
                required
              />
              {error["password/input"] && (
                <p className={styles.error}>Invalid password</p>
              )}
            </div>

            <div className={styles.inputField}>
              <label htmlFor="repass/input">Repeat password</label>
              <input
                type="password"
                id="repass/input"
                value={repass}
                onChange={onSetInputData}
                onBlur={onBlurInput}
                onFocus={clearInput}
                required
              />
              {error["repass/input"] && (
                <p className={styles.error}>Password do not match</p>
              )}
            </div>

            <div className={styles.inputField}>
              <label htmlFor="role/select">Role</label>
              <select
                id="role/select"
                value={userRole}
                onChange={onSetInputData}
                required
              >
                <option value=""></option>
                <option value="worker">Worker</option>
                <option value="qControl">Quality Control</option>
                <option value="manager">Manager</option>
              </select>
            </div>

            {userRole === "worker" && (
              <div className={styles.inputField}>
                <label htmlFor="department/select">Department</label>
                <select
                  id="department/select"
                  value={department}
                  onChange={onSetInputData}
                >
                  <option value=""></option>
                  <option value="Frames">Frames</option>
                  <option value="Wheels">Wheels</option>
                  <option value="Accessory">Accessory</option>
                </select>
              </div>
            )}

            {userRole === "worker" && (
              <div className={styles.inputField}>
                <label htmlFor="position/select">Position</label>
                <select
                  id="position/select"
                  value={position}
                  onChange={onSetInputData}
                >
                  <option value=""></option>
                  <option value="Junior mechanic">Junior mechanic</option>
                  <option value="Senior mechanic">Senior mechanic</option>
                  <option value="Master">Master</option>
                </select>
              </div>
            )}

            <div className={styles.inputField} id={styles.inputField}>
              <PhoneInput
                required
                defaultCountry="bg"
                inputStyle={{
                  border: "none",
                  borderRadius: "10px",
                  fontSize: "1.8rem",
                }}
                buttonStyle={false}
                id="phone/input"
                value={phoneNumber}
                onChange={(phone) => setPhone(phone)}
                onBlur={() => dispatch({ type: "phone/input", payload: phone })}
              />
            </div>

            <button
              className={styles.addMemberBtn}
              disabled={Object.values(error).some((x) => x)}
            >
              Add member
            </button>
          </form>
        </div>
      </section>
      {/* </div> */}
    </>
  );
}

export default memo(AddMember);
