import styles from "./UserHomeScreenSelection.module.css";

import { useContext, useEffect, useState } from "react";
import { clearStockData, getStockData } from "../../../util/util.js";
import LoaderWheel from "../../LoaderWheel.jsx";
import BoardHeader from "../BoardHeader.jsx";
import { get, post } from "../../../util/api.js";
import { environment } from "../../../environments/environment.js";
import { useNavigate } from "react-router-dom";
import { UserContext } from "../../../context/GlobalUserProvider.jsx";

function UserHomeScreenSelection() {
  const [loading, setLoading] = useState(false);
  const [bike, setBike] = useState({});
  const [price, setPrice] = useState("");
  const [confirm, setConfirm] = useState(false);
  const [error, setError] = useState(false);
  const navigate = useNavigate();

  const { user, updateUser } = useContext(UserContext);

  const data = getStockData();

  const iconStyle = {
    position: "absolute",
    top: "-0.2rem",
    right: "1rem",
    fontSize: "2.4rem",
    paddingBottom: "0.2rem",
    cursor: "pointer",
    borderBottom: "1px solid var(--color-line)",
  };

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

  function onBtnClick() {
    setConfirm(true);
  }

  function onCancelClick() {
    clearStockData();
    navigate("/");
  }

  async function onConfirm() {
    const [frame, wheel, parts] = bike.parts;
    console.log(frame.partId);

    //user balance after order
    const userReducedBalance = user.balance - bike.price * 0.2;

    const currentOrder = {
      id: user.id,
      description: "",
      quantity: 1,
      vatId: 1,
      parts: [
        {
          partId: frame.partId,
        },
        {
          partId: wheel.partId,
        },
        {
          partId: parts.partId,
        },
      ],
    };

    if (user.balance < bike.price * 0.2) {
      return "Not enough money!";
    }

    setLoading(true);
    try {
      const orderResponse = await post(environment.create_order, currentOrder);
      console.log(orderResponse);
    } catch (err) {
      console.error(err);
      setError(true);
    } finally {
      updateUser({ ...user, balance: userReducedBalance });
      setLoading(false);
      navigate("/profile");
      clearStockData();
    }
  }

  return (
    <>
      <h2 className={styles.dashHeading}>Selected items</h2>

      <section className={styles.board}>
        <BoardHeader />
        {loading && <LoaderWheel />}
        {confirm && (
          <div className={styles.confirmation}>
            <div className={styles.confirmContent}>
              <p className={styles.contentText}>
                You&apos;re about to buy this bike. Are you shure?
              </p>
              <div className={styles.actions}>
                <button className={`${styles.btn}`} onClick={onConfirm}>
                  Yes, I do!
                </button>
                <button
                  className={`${styles.btn} ${styles.decline}`}
                  onClick={onCancelClick}
                >
                  No, I don&apos;t!
                </button>
              </div>
            </div>
          </div>
        )}
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
              {error && (
                <p className={styles.error}>
                  Something went wrong! Please, try again later
                </p>
              )}
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

// bike1
// {
//   "id": "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd",
//   "description": "",
//   "quantity": 1,
//   "vatId": 1,
//   "parts": [
//       {
//           "partId": 1
//       },
//       {
//           "partId": 4
//       },
//       {
//           "partId": 9
//       }
//   ]
// }

// bike2  minava
// {
//   "id": "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd",
//   "description": "",
//   "quantity": 1,
//   "vatId": 1,
//   "parts": [
//       {
//           "partId": 3
//       },
//       {
//           "partId": 12
//       },
//       {
//           "partId": 14
//       }
//   ]
// }

// bike3
// {
//   "id": "ae0da70f-6e0b-4ef8-85a2-0c5cccd4b4fd",
//   "description": "",
//   "quantity": 1,
//   "vatId": 1,
//   "parts": [
//       {
//           "partId": 2
//       },
//       {
//           "partId": 5
//       },
//       {
//           "partId": 13
//       }
//   ]
// }
