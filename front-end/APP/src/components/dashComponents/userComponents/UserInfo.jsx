import styles from "./UserInfo.module.css";

import { useContext, useEffect, useRef, useState } from "react";
import { User, CameraPlus } from "@phosphor-icons/react";

import BoardHeader from "../BoardHeader.jsx";
import UserContactInfo from "./UserContactInfo.jsx";
// import WorkerContactInfo from "../workerComponents/WorkerContactInfo.jsx";
// import ManagerContactInfo from "../managerComponents/ManagerContactInfo.jsx";
import { setUserData } from "../../../util/util.js";
import { updateUserData, userInfo } from "../../../userServices/userService.js";

import { UserContext } from "../../../context/GlobalUserProvider.jsx";
import EditContactInfo from "./EditContactInfo.jsx";

function UserInfo() {
  const { user, updateUser } = useContext(UserContext);
  const [add, setAdd] = useState("");
  const [image, setImage] = useState(null);
  const [base64, setBase64] = useState("");
  const [edit, setEdit] = useState(false);
  const [info, setInfo] = useState("");
  const uploadedImage = useRef(null);

  useEffect(
    function () {
      async function getClientInfo() {
        const data = await userInfo(user.id);
        // console.log(data);
        setInfo({ ...data });
        if (data.role === "user") {
          setInfo({ ...data, balance: Number(data.balance.toFixed(2)) });
        }
      }
      getClientInfo();
    },
    [user]
  );

  async function handleFileUpload(e) {
    const [file] = e.target.files;
    // console.log(file);

    if (file) {
      const reader = new FileReader();
      const { current } = uploadedImage;
      current.file = file;
      setImage({ ...file });
      reader.onload = (e) => {
        current.src = e.target.result;
        setBase64(current.src);
        setInfo({ ...info, imageUrl: current.src });
        // setImage(reader.result.toString()); //without this
        // console.log(current.src);
      };
      reader.readAsDataURL(file);
    }
  }

  // const handleFileUpload = (e) => {
  //   const file = e.target.files[0];
  //   if (file) {// https://developer.mozilla.org/en-US/docs/Web/API/File_API/Using_files_from_web_applications
  //     const reader = new FileReader();
  //     reader.onloadend = () => {
  //       onUserImageUpload(reader.result);
  //     };
  //     reader.readAsDataURL(file);
  //   }
  // };

  // async function addMoneyBtnHandler() {
  //   // TODO: make request to update user balance
  //   //next is only for testing

  //   const currentUser = await userInfo(user.id);

  //   if (add === 0) return;
  //   updateUser({ ...user, balance: user.balance + add });
  //   setUserData({ ...user, balance: user.balance + add });
  //   setAdd("");

  //   const data = {
  //     ...currentUser,
  //     password: currentUser.repass,
  //     balance: currentUser.balance + add,
  //   };

  //   const result = await updateUserData(user.id, data);
  // }

  function addMoneyBtnHandler() {}

  function editBtnHandler() {
    setEdit(true);
  }

  return (
    <>
      <h2 className={styles.dashHeading}>
        {user.firstName} {user.lastName}
      </h2>

      <section className={styles.board}>
        <BoardHeader />

        <div className={styles.userInfoWrapper}>
          <figure className={styles.mainInfo}>
            <div className={styles["imgHolder"]}>
              {!info.imageUrl && (
                <User size={196} color="#363636" weight="thin" />
              )}
              {info.imageUrl && (
                <img className={styles.userImg} src={info.imageUrl} alt="" />
              )}
              {edit && (
                <label htmlFor="imgFile">
                  <CameraPlus
                    size={32}
                    color="#0a0a0a"
                    weight="thin"
                    className={styles.uploadPicture}
                  />
                </label>
              )}
              <input
                type="file"
                accept="image/png, image/jpeg"
                id="imgFile"
                style={{ display: "none" }}
                onChange={handleFileUpload}
              />
              <div className={styles.userImgBox}>
                <img ref={uploadedImage} alt="" className={styles.userImg} />
              </div>
            </div>
          </figure>

          {!edit && <UserContactInfo info={info} setInfo={setInfo} />}
          {edit && (
            <EditContactInfo info={info} setInfo={setInfo} base64={base64} />
            // <EditContactInfo  />
          )}
          {/* {user.role === "user" && <UserContactInfo user={user} />} */}
          {/* {user.role === "worker" && <WorkerContactInfo user={user} />} */}
          {/* {user.role === "manager" && <ManagerContactInfo />} */}
        </div>
        <div className={styles.userInfoControl}>
          <div className={styles.infoWrapper}>
            {/* {user.role === "user" && (
              <>
                {edit && (
                  <input
                    className={styles.addMoneyInput}
                    type="number"
                    value={add}
                    onChange={(e) => setAdd(Number(e.target.value))}
                    placeholder="00.00"
                  />
                )}
                {edit && (
                  <button
                    className={styles.addMoney}
                    onClick={addMoneyBtnHandler}
                  >
                    Add money
                  </button>
                )}
              </>
            )} */}
            <button
              className={styles.editBtn}
              onClick={!edit ? editBtnHandler : () => setEdit(false)}
            >
              {edit ? "Back" : "Edit profile"}
            </button>
          </div>
          <div className={styles.infoWrapper}></div>
        </div>
      </section>
    </>
  );
}

export default UserInfo;
