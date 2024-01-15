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
import LoaderWheel from "../../LoaderWheel.jsx";
import { post, put } from "../../../util/api.js";
import { environment } from "../../../environments/environment.js";
import { useNavigate } from "react-router-dom";
import { fetchImageFile } from "../../../util/imageUpload.js";

function UserInfo() {
  const { user, updateUser } = useContext(UserContext);
  // const [add, setAdd] = useState("");
  const [loading, setLoading] = useState(false);
  const [image, setImage] = useState(null);
  const [base64, setBase64] = useState("");
  const [edit, setEdit] = useState(false);
  const [info, setInfo] = useState("");
  const [newImage, setNewImage] = useState("");
  const uploadedImage = useRef(null);
  const navigate = useNavigate();

  useEffect(
    function () {
      setLoading(true);
      async function getClientInfo() {
        const data = await userInfo(user.id, user.role);
        // console.log(data);
        setInfo({ ...data });
        if (data.role === "user") {
          setInfo({ ...data, balance: Number(data.balance.toFixed(2)) });
        }
      }
      getClientInfo();
      setLoading(false);
    },
    [user]
  );

  // upload image file from local machine
  async function handleFileUpload(e) {
    const [file] = e.target.files;
    setNewImage(file);

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

  function editBtnHandler() {
    setEdit(true);
  }

  function backBtnHandler() {
    navigate("/profile");
  }

  async function addMoneyBtnHandler(amount) {
    setLoading(true);
    const data = {
      id: user.id,
      balance: Number(amount),
    };

    const result = await put(environment.update_balance, data);
    updateUser({ ...user, balance: Number(user.balance) + Number(amount) });
    // console.log(result);
    setLoading(false);
  }

  async function updateImage() {
    // const data = { id: user.id, role: user.role, image: base64 };
    // const result = await post(environment.upload_avatar, data);
    // // console.log(result);
    // navigate("/profile");
    // if (!result.isError) {
    //   updateUser({ ...user, imageUrl: base64 });
    //   setImage(null);
    //   setBase64("");
    //   setInfo({ ...info, imageUrl: null });
    // }
    fetchImageFile(newImage, user.id, user.role);
    setEdit(false);
  }

  return (
    <>
      <h2 className={styles.dashHeading}>
        {user.firstName} {user.lastName}
      </h2>
      {loading && <LoaderWheel />}
      <section className={styles.board}>
        <BoardHeader />

        <div className={styles.userInfoWrapper}>
          <figure className={styles.mainInfo}>
            <div className={styles["imgHolder"]}>
              {!user.imageUrl && (
                <User size={196} color="#363636" weight="thin" />
              )}
              {user.imageUrl && (
                <img className={styles.userImg} src={user.imageUrl} alt="" />
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

          {!edit && (
            <UserContactInfo
              info={info}
              setInfo={setInfo}
              addMoneyBtnHandler={addMoneyBtnHandler}
            />
          )}
          {edit && (
            <EditContactInfo info={info} setInfo={setInfo} base64={base64} />
          )}
        </div>
        <div className={styles.userInfoControl}>
          <div className={styles.infoWrapper}>
            {edit && !!image && (
              <button className={styles.editBtn} onClick={updateImage}>
                Upload image
              </button>
            )}
            <button
              className={styles.editBtn}
              onClick={!edit ? editBtnHandler : backBtnHandler}
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
