import { useEffect, useState } from "react";
import { Link } from "react-router-dom";
import styles from "./Images.module.css";

function Images({ imgArray }) {
  const [arr, setArr] = useState([]);
  const [modal, setModal] = useState(false);
  const [currentImg, setCurrentImg] = useState({});

  useEffect(
    function () {
      const abortController = new AbortController();

      setArr(imgArray);

      return () => abortController.abort();
    },
    [imgArray]
  );

  function onClickHandler(i) {
    if (i < 0 || i >= arr.length) return;
    setCurrentImg({ img: arr[i], index: i });
    setModal(true);
  }

  function closeModalHandler() {
    setModal(false);
    setCurrentImg("");
  }

  if (!arr) return <></>;

  return (
    <>
      {modal && (
        <div className={styles.modal}>
          <div className={styles.topContent}>
            <button className={styles.closeBtn} onClick={closeModalHandler}>
              <ion-icon name="close-outline"></ion-icon>
            </button>
            <div className={styles.imgControl}>
              <button
                className={styles.arrow}
                onClick={() => onClickHandler(currentImg.index - 1)}
              >
                <ion-icon name="chevron-back-outline"></ion-icon>
              </button>
              <img src={currentImg.img} alt="Frame Image" />
              <button
                className={styles.arrow}
                onClick={() => onClickHandler(currentImg.index + 1)}
              >
                <ion-icon name="chevron-forward-outline"></ion-icon>
              </button>
            </div>
          </div>
        </div>
      )}

      <div className={styles.imgBox}>
        {arr.length > 0 &&
          arr.map((x, i) => (
            <img
              src={arr[i]}
              alt="Frame image"
              key={i}
              onClick={() => onClickHandler(i)}
            />
          ))}
      </div>
    </>
  );
}

export default Images;
