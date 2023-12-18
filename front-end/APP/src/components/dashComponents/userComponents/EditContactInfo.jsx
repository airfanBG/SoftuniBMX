import { useContext, useEffect, useReducer } from "react";
import styles from "./EditContactInfo.module.css";
import EditTextInput from "./editComponents/EditTextInput.jsx";
import { reducer } from "./editComponents/reducer.js";
import { updateUserData } from "../../../userServices/userService.js";
import { UserContext } from "../../../context/GlobalUserProvider.jsx";
import { useNavigate } from "react-router-dom";
import { get } from "../../../util/api.js";
import { environment } from "../../../environments/environment.js";

function EditContactInfo({ info, setInfo, base64 }) {
  const { user, updateUser } = useContext(UserContext);
  const navigate = useNavigate();

  const initialState = {
    email: info.email,
    firstName: info.firstName,
    lastName: info.lastName,
    iban: info?.iban,
    balance: info?.balance,
    phone: info.phoneNumber,
    city: info.town,
    role: user.role,
    country: info.address?.country,
    district: info.address?.district,
    postCode: info.address?.postCode,
    block: info.address?.block,
    apartment: info.address?.apartment,
    street: info.address?.street,
    floor: info.address?.floor,
    strNumber: info.address?.strNumber,
    id: info.id,
    imageUrl: base64,
    department: info?.department,
    phoneNumber: info?.phoneNumber,
    position: info?.position,
    dateOfHire: info?.dateOfHire,
    isManager: info?.isManager,
  };

  const [
    {
      email,
      firstName,
      lastName,
      iban,
      balance,
      phone,
      city,
      country,
      district,
      postCode,
      block,
      street,
      strNumber,
      apartment,
      floor,
      imageUrl,
      password,
      repass,
      role,
    },
    dispatch,
  ] = useReducer(reducer, initialState);

  useEffect(
    function () {
      dispatch({ type: "setImage", payload: base64 });
    },
    [base64]
  );

  async function formSubmitHandler(e) {
    e.preventDefault();

    let updatedImg = info.imageUrl || imageUrl;

    const newAddress = {
      country,
      district,
      postCode,
      block,
      apartment,
      street: street,
      strNumber,
      floor,
    };
    let data;
    if (role === "user") {
      data = {
        // password: info.repass,
        // repass: info.repass,
        // role: info.role,
        // email,
        firstName,
        lastName,
        // iban,
        // balance,
        phone,
        city,
        // imageUrl: updatedImg,
        address: newAddress,
      };
    } else {
      data = {
        // imageUrl: updatedImg,
        // password: info.repass,
        // repass: info.repass,
        // role: info.role,
        // email,
        firstName,
        lastName,
        department: info?.department,
        phoneNumber: info?.phoneNumber,
        position: info?.position,
        dateOfHire: info?.dateOfHire,
        isManager: info?.isManager,
      };
    }

    setInfo({
      ...info,
      email: email,
      firstName: firstName,
      lastName: lastName,
      iban: iban,
      balance: balance,
      phone: phone,
      city: city,
      address: newAddress,
      imageUrl: updatedImg,
    });

    // UPDATE CONTEXT USER
    updateUser({
      ...user,
      firstName: firstName,
      lastName: lastName,
      balance: balance,
    });

    const result = await updateUserData(info.id, data);
    console.log(result);
    navigate("/profile");
  }

  return (
    <>
      <form className={styles.form} onSubmit={formSubmitHandler}>
        {/* FIRST NAME */}
        <EditTextInput
          inputValue={firstName}
          dispatch={dispatch}
          action="setFirstName"
          type="text"
          content={"First Name"}
        />
        {/* LAST NAME */}
        <EditTextInput
          inputValue={lastName}
          dispatch={dispatch}
          action="setLastName"
          type="text"
          content={"Last Name"}
        />
        {/* EMAIL */}
        {/* <EditTextInput
          inputValue={email}
          dispatch={dispatch}
          action="setEmail"
          type="email"
          content={"Email"}
        /> */}
        {/* IBAN */}
        {/* {role === "user" && (
          <EditTextInput
            inputValue={iban}
            dispatch={dispatch}
            action="setIban"
            type="text"
            content={"IBAN"}
          />
        )} */}
        {/* PHONE */}
        <EditTextInput
          inputValue={phone}
          dispatch={dispatch}
          action="setPhone"
          type="text"
          content={"Phone"}
        />
        {/* CITY */}
        {role === "user" && (
          <EditTextInput
            inputValue={city}
            dispatch={dispatch}
            action="setCity"
            type="text"
            content={"City"}
          />
        )}
        {/* COUNTRY */}
        {role === "user" && (
          <EditTextInput
            inputValue={country}
            dispatch={dispatch}
            action="setCountry"
            type="text"
            content={"Country"}
          />
        )}
        {/* POSTCODE */}
        {role === "user" && (
          <EditTextInput
            inputValue={postCode}
            dispatch={dispatch}
            action="setPostCode"
            type="text"
            content={"Post Code"}
          />
        )}
        {/* DISTRICT */}
        {role === "user" && (
          <EditTextInput
            inputValue={district}
            dispatch={dispatch}
            action="setDistrict"
            type="text"
            content={"District"}
          />
        )}
        {/* BLOCK*/}
        {role === "user" && (
          <EditTextInput
            inputValue={block}
            dispatch={dispatch}
            action="setBlock"
            type="text"
            content={"Block"}
          />
        )}
        {/* FLOOR*/}
        {role === "user" && (
          <EditTextInput
            inputValue={floor}
            dispatch={dispatch}
            action="setFloor"
            type="text"
            content={"Floor"}
          />
        )}
        {/* APARTMENT*/}
        {role === "user" && (
          <EditTextInput
            inputValue={apartment}
            dispatch={dispatch}
            action="setApartment"
            type="text"
            content={"Apartment"}
          />
        )}
        {/* STREET*/}
        {role === "user" && (
          <EditTextInput
            inputValue={street}
            dispatch={dispatch}
            action="setStreet"
            type="text"
            content={"Street"}
          />
        )}
        {/* STREET NUmber*/}
        {role === "user" && (
          <EditTextInput
            inputValue={strNumber}
            dispatch={dispatch}
            action="setStrNumber"
            type="text"
            content={"Street"}
          />
        )}
        {/* BALANCE */}
        {/* {role === "user" && (
          <EditTextInput
            inputValue={balance}
            dispatch={dispatch}
            action="setBalance"
            type="tel"
            content={"Account"}
          />
        )} */}

        <button className={styles.saveBtn}>Save profile</button>
      </form>
    </>
  );
}

export default EditContactInfo;
