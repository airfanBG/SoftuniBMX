import styles from "./AddMember.module.css";

import BoardHeader from "../BoardHeader.jsx";
import { PhoneInput } from "react-international-phone";
import { useReducer, useState } from "react";
import { initialState, reducer } from "./managerUtil/addMemberReducer.js";
import { post } from "../../../util/api.js";
import { environment } from "../../../environments/environment_dev.js";
import { useNavigate } from "react-router-dom";

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
      role,
      department,
      phoneNumber,
      position,
      isManager,
      dateOfHire,
      imageUrl,
    },
    dispatch,
  ] = useReducer(reducer, initialState);

  function onSetInputData(e) {
    const actionType = e.target.id;
    const payloadData = e.target.value;
    dispatch({ type: actionType, payload: payloadData });
  }

  async function handleFormSubmit(e) {
    e.preventDefault();

    const finalState = {
      email: email + "@b-free.com",
      password,
      firstName,
      lastName,
      repass,
      role,
      phoneNumber,
      isManager: role === "manager" ? true : false,
      dateOfHire: new Date().toLocaleDateString(),
      imageUrl,
    };

    if (role === "worker") {
      finalState.department = department;
      finalState.position = position;
    }

    const result = await post(environment.register_employee, finalState);
    console.log(result);

    navigate("/profile/employers");
  }
  return (
    <>
      <div className={styles.wrapper}>
        <h2 className={styles.dashHeading}>Add member</h2>

        <section className={styles.board}>
          <BoardHeader />
          <div className={styles.formContainer}>
            <form className={styles.form} onSubmit={handleFormSubmit}>
              <div className={styles.inputField}>
                <label htmlFor="firstName/input">First Name</label>
                <input
                  type="text"
                  id="firstName/input"
                  value={firstName}
                  onChange={onSetInputData}
                  required
                />
              </div>

              <div className={styles.inputField}>
                <label htmlFor="lastName/input">Last Name</label>
                <input
                  type="text"
                  id="lastName/input"
                  value={lastName}
                  onChange={onSetInputData}
                  required
                />
              </div>

              <div className={styles.inputField}>
                <label htmlFor="email/input">Email</label>
                <div className={styles.emailContainer}>
                  <input
                    type="text"
                    id="email/input"
                    value={email}
                    onChange={onSetInputData}
                    required
                  />
                  <span>@b-free.com</span>
                </div>
              </div>

              <div className={styles.inputField}>
                <label htmlFor="password/input">Password</label>
                <input
                  type="password"
                  id="password/input"
                  value={password}
                  onChange={onSetInputData}
                  required
                />
              </div>

              <div className={styles.inputField}>
                <label htmlFor="repass/input">Repeat password</label>
                <input
                  type="password"
                  id="repass/input"
                  value={repass}
                  onChange={onSetInputData}
                  required
                />
              </div>

              <div className={styles.inputField}>
                <label htmlFor="role/select">Role</label>
                <select
                  id="role/select"
                  value={role}
                  onChange={onSetInputData}
                  required
                >
                  <option value=""></option>
                  <option value="worker">Worker</option>
                  <option value="qControl">Quality Control</option>
                  <option value="manager">Manager</option>
                </select>
              </div>

              {role === "worker" && (
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

              {role === "worker" && (
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

              <div className={styles.inputField}>
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
                  onBlur={() =>
                    dispatch({ type: "phone/input", payload: phone })
                  }
                />
              </div>

              <button className={styles.addMemberBtn}>Add member</button>
            </form>
          </div>
        </section>
      </div>
    </>
  );
}

export default AddMember;
