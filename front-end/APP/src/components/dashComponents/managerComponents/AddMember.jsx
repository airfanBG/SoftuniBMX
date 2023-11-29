import styles from "./AddMember.module.css";

import BoardHeader from "../BoardHeader.jsx";
import { PhoneInput } from "react-international-phone";

function AddMember() {
  return (
    <>
      <section className={styles.board}>
        <BoardHeader />
      </section>

      <form action="" className={styles.form}>
        <div>
          <label htmlFor="firstName">First Name</label>
          <input type="text" id="firstName" />
        </div>
        <div>
          <label htmlFor="LastName">Last Name</label>
          <input type="text" id="LastName" />
        </div>
        <div>
          <label htmlFor="email">Email</label>
          <input type="email" id="email" />
        </div>
        <div>
          <PhoneInput
            defaultCountry="bg"
            inputStyle={{
              border: "none",
              borderRadius: "10px",
              fontSize: "1.8rem",
            }}
            buttonStyle={false}
          />
        </div>
      </form>
    </>
  );
}

export default AddMember;

// "email": "stamat@abv.bg",
// "password": "$2a$10$uOpMPHni6eF.gaFQAKXfve4SSO.xgebUFA7vvOaCPcIMSm7urfCMK",
// "firstName": "Stamat",
// "lastName": "Spiridonov",
// "repass": "Stamat-1",
// "role": "worker",
// "department": "Wheels",
// "id": 3,
// "phoneNumber": "+359567474237",
// "position": "Senior mechanic",
// "dateOfHire": "02/10/1987",
// "isManager": false,
// "imageUrl": ""
