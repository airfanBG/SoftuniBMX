import styles from "./UserContactInfo.module.css";

import { useContext } from "react";
import { UserContext } from "../../../context/GlobalUserProvider.jsx";
// import { userInfo } from "../../../userServices/userService.js";
import ContactInfoElement from "../ContactInfoElement.jsx";

function UserContactInfo({ info }) {
  const { user } = useContext(UserContext);
  // const [info, setInfo] = useState("");

  // useEffect(
  //   function () {
  //     async function getClientInfo() {
  //       const data = await userInfo(user.id);
  //       console.log(data);
  //       setInfo({ ...data });
  //       if (data.role === "user") {
  //         setInfo({ ...data, balance: Number(data.balance.toFixed(2)) });
  //       }
  //     }
  //     getClientInfo();
  //   },
  //   [user]
  // );
  return (
    <>
      {info && (
        <div className={styles.contactWrapper}>
          <h2 className={styles.infoHeader}>
            <span>Contact information</span>
          </h2>
          <div className={styles.fullData}>
            <div className={styles.row}>
              <ContactInfoElement
                content={info.firstName}
                label={"First Name"}
                width={"50%"}
              />
              <ContactInfoElement
                content={info.lastName}
                label={"Last Name"}
                width={"50%"}
              />
            </div>

            <div className={styles.row}>
              <ContactInfoElement
                content={info.email}
                label={"Email"}
                width={"60%"}
              />

              <ContactInfoElement
                content={info.phoneNumber}
                label={"Phone"}
                width={"40%"}
              />
            </div>

            {info.role === "user" && (
              <div className={styles.row}>
                <ContactInfoElement
                  content={info.address.street}
                  label={"Street"}
                  width={"80%"}
                />

                <ContactInfoElement
                  content={info.address.strNumber}
                  label={"Number"}
                  width={"20%"}
                />
              </div>
            )}

            {info.role === "user" && (
              <div className={styles.row}>
                <ContactInfoElement
                  content={info.address.block}
                  label={"Building"}
                  width={"60%"}
                />

                <ContactInfoElement
                  content={info.address.floor}
                  label={"Floor"}
                  width={"20%"}
                />
                <ContactInfoElement
                  content={info.address.apartment}
                  label={"Unit/Suite"}
                  width={"20%"}
                />
              </div>
            )}

            {info.role === " user" && (
              <div className={styles.row}>
                <ContactInfoElement
                  content={info.city}
                  label={"City"}
                  width={"50%"}
                />

                <ContactInfoElement
                  content={info.address.district}
                  label={"State"}
                  width={"30%"}
                />
                <ContactInfoElement
                  content={info.address.postCode}
                  label={"ZIP"}
                  width={"20%"}
                />
              </div>
            )}

            {info.role === "user" && (
              <div className={styles.row}>
                <ContactInfoElement
                  content={info.address.country}
                  label={"Country"}
                />
              </div>
            )}
          </div>
          {info.role === "user" && (
            <h2 className={styles.infoHeader}>
              <span>Account information</span>
            </h2>
          )}
          {info.role === "user" && (
            <div className={styles.fullData}>
              <div className={styles.row}>
                <ContactInfoElement
                  content={user.balance.toFixed(2)}
                  label={"Account balance"}
                  width={"40%"}
                />
                <ContactInfoElement
                  content={info.iban}
                  label={"IBAN"}
                  width={"60%"}
                />
              </div>
            </div>
          )}
        </div>
      )}
    </>
  );
}

export default UserContactInfo;
