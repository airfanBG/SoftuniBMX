import styles from "./UserHomeScreenSelection.module.css";

import { useEffect, useState } from "react";
import { clearStockData, getStockData } from "../../../util/util.js";
import LoaderWheel from "../../LoaderWheel.jsx";
import BoardHeader from "../BoardHeader.jsx";
import { get } from "../../../util/api.js";
import { environment } from "../../../environments/environment_dev.js";
import { useNavigate } from "react-router-dom";

function UserHomeScreenSelection() {
  const [loading, setLoading] = useState(false);
  const [bike, setBike] = useState({});
  const [price, setPrice] = useState("");
  const data = getStockData();

  const navigate = useNavigate();

  useEffect(
    function () {
      const abortController = new AbortController();
      async function getBike() {
        const result = await get(environment.indexPage);
        const selected = result.defaultBikes.filter(
          (x) => x.id === data.bikeId
        );
        setBike(selected[0]);
        setPrice(selected[0].price.toFixed(2));
      }
      getBike();

      return () => abortController.abort();
    },
    [data.bikeId]
  );

  function onBtnClick() {}

  function onCancelClick() {
    clearStockData();
    navigate("/");
  }

  const iconStyle = {
    position: "absolute",
    top: "-0.2rem",
    right: "1rem",
    fontSize: "2.4rem",
    paddingBottom: "0.2rem",
    cursor: "pointer",
    borderBottom: "1px solid var(--color-line)",
  };

  return (
    <>
      <h2 className={styles.dashHeading}>Selected items</h2>

      <section className={styles.board}>
        <BoardHeader />
        {loading && <LoaderWheel />}
        {bike && (
          <div className={styles.result}>
            <div className={styles.imageBox}>
              <img src={bike.imageUrl} alt="" />
            </div>
            <div className={styles.content}>
              <header className={styles.header}>
                <h2 className={styles.heading}>{bike.modelName}</h2>
                <button className={styles.iconBox} onClick={onCancelClick}>
                  <ion-icon name="trash-outline" style={iconStyle}></ion-icon>
                </button>
              </header>
              <p className={styles.description}>{bike.description}</p>
              <p className={styles.price}>{price}</p>
              <button className={styles.btn} onClick={onBtnClick}>
                Buy
              </button>
            </div>
            <img
              className={styles.imgBG}
              src="https://yuchormanski.free.bg/bikes/wheel1.webp
"
              alt=""
            />
          </div>
        )}
      </section>
    </>
  );
}

export default UserHomeScreenSelection;
// https://yuchormanski.free.bg/bikes/wheel1.webp
