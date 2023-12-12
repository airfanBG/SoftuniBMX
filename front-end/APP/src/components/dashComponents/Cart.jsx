import { useContext, useEffect, useState } from "react";

import styles from "./Cart.module.css";

import BoardHeader from "./BoardHeader.jsx";
// import { UserContext } from "../UserProfile.jsx";
import { clearOrderData, getOrderData, getStockData } from "../../util/util.js";
import {
  getOneFrame,
  getOnePart,
  getOneWheel,
} from "../../bikeServices/service.js";
import LoaderWheel from "../LoaderWheel.jsx";
import { get, post, put } from "../../util/api.js";
import { useNavigate } from "react-router-dom";
import { UserContext } from "../../context/GlobalUserProvider.jsx";
import { environment } from "../../environments/environment.js";

function Cart() {
  const { user, setHasOrder, updateUser } = useContext(UserContext);

  const [loading, setLoading] = useState(false);
  const [frame, setFrame] = useState({});
  const [wheel, setWheel] = useState({});
  const [parts, setParts] = useState({});
  const [userText, setUserText] = useState("");
  const [select, setSelect] = useState("");
  const [error, setError] = useState({});
  const [headImg, setHeadImg] = useState({ frame: "", wheel: "", parts: "" });

  const navigate = useNavigate();

  const order = getOrderData();
  const defaultBike = getStockData();

  // if (defaultBike) navigate("/profile/get-stock");

  useEffect(function () {
    const abortController = new AbortController();
    setLoading(true);
    if (!order) {
      return setLoading(false);
    }
    const { frame, wheel, parts } = order;

    setHeadImg({
      ...headImg,
      frame: frame.imageUrls[0],
      wheel: wheel.imageUrls[0],
      parts: parts.imageUrls[0],
    });
    setFrame({ ...frame });
    setWheel({ ...wheel });
    setParts({ ...parts });
    setLoading(false);
    return () => abortController.abort();
  }, []);

  function onChangeHandler(e) {
    setSelect(Number(e.target.value));
    setError({});
  }

  async function orderClickHandler(e) {
    e.preventDefault();
    if (!order) return;
    const additionalFields = {
      ownerId: user.id,
      // according to documentation customer pays while ordering 20% of the total order price
      // cashReserved: (frame.salesPrice + wheel.salesPrice + parts.salesPrice) * 0.2,
    };

    //user balance after order
    const userReducedBalance =
      user.balance -
      (frame.salesPrice + wheel.salesPrice + parts.salesPrice) * 0.2 * select;

    const currentOrder = {
      frame,
      wheel,
      accessory: parts,
      userText,
      count: select,
      createdAt: Date.now(),
      ...additionalFields,
    };

    if (
      user.balance <
      (frame.salesPrice + wheel.salesPrice + parts.salesPrice) * 0.2 * select
    ) {
      return setError({ message: "Not enough money!" });
    }
    if (!select) return setError({ message: "Select quantity" });
    // TODO:
    // ONLY FOR DEV SERVER
    //DATA FOR UPDATE USER AFTER ORDER
    const currentUser = await get(environment.info_client + user.id);
    console.log(currentUser);
    const userPayment = {
      ...currentUser,
      balance: userReducedBalance,
      password: currentUser.repass,
    };

    console.log(userPayment);

    // IN PROD
    // const userPayment = { ...user, balance: userReducedBalance };
    setLoading(true);
    try {
      const orderResponse = await post("/orders/", currentOrder);
      const userAfterOrder = await put(`/users/${user.id}`, userPayment); //TAKE MONEY FROM USER ACCOUNT
      console.log(userAfterOrder);
    } catch (err) {
      console.error(err);
    } finally {
      updateUser({ ...user, balance: userReducedBalance });
      setLoading(false);
      navigate("/profile");
      clearOrderData();
      setHasOrder(false);
    }
  }

  function orderCancelHandler() {}

  return (
    <>
      <h2 className={styles.dashHeading}>Selected items</h2>

      <section className={styles.board}>
        <BoardHeader />
        {loading && <LoaderWheel />}
        {order && (
          <>
            <div className={styles.userInfoWrapper}>
              <figure className={styles.mainInfo}>
                <div className={styles.img}>
                  <img src={headImg.frame} alt="" />
                </div>
                <div className={styles.header}>
                  <h2 className={styles.heading}>{frame.name}</h2>
                  <p className={styles.price}>{frame.salesPrice}</p>
                </div>
                <p className={styles.description}>{frame.description}</p>
              </figure>

              <figure className={styles.mainInfo}>
                <div className={styles.img}>
                  <img src={headImg.wheel} alt="" />
                </div>
                <div className={styles.header}>
                  <h2 className={styles.heading}>{wheel.name}</h2>
                  <p className={styles.price}>{wheel.salesPrice}</p>
                </div>
                <p className={styles.description}>{wheel.description}</p>
              </figure>

              <figure className={styles.mainInfo}>
                <div className={styles.img}>
                  <img src={headImg.parts} alt="" />
                </div>
                <div className={styles.header}>
                  <h2 className={styles.heading}>{parts.name}</h2>
                  <p className={styles.price}>{parts.salesPrice}</p>
                </div>
                <p className={styles.description}>{parts.description}</p>
              </figure>
            </div>

            <div className={styles.additionalInfo}>
              <textarea
                className={styles.textarea}
                value={userText}
                onChange={(e) => setUserText(e.target.value)}
                maxLength={"400"}
                cols="97"
                rows="4"
              ></textarea>
              <div className={styles.control}>
                <div className={styles.count}>
                  <label htmlFor="qtySelect">Quantity:</label>
                  <select
                    className={styles.quantity}
                    value={select}
                    onChange={onChangeHandler}
                    id={"qtySelect"}
                    required
                  >
                    <option value=""></option>
                    <option value="1">1</option>
                    <option value="2">2</option>
                    <option value="3">3</option>
                    <option value="4">4</option>
                    <option value="5">5</option>
                  </select>
                </div>

                <div className={styles.priceBlock}>
                  <p className={styles.totalPrice}>
                    <span>Total:</span>
                    {!isNaN(
                      frame.salesPrice + wheel.salesPrice + parts.salesPrice
                    ) &&
                      (
                        (frame.salesPrice +
                          wheel.salesPrice +
                          parts.salesPrice) *
                          select ||
                        frame.salesPrice + wheel.salesPrice + parts.salesPrice
                      ).toFixed(2)}
                  </p>
                  <button
                    className={`${styles.btn} ${styles.btnGreen}`}
                    onClick={orderClickHandler}
                  >
                    Finish order
                  </button>
                  {/* <button
                    className={`${styles.btn} ${styles.btnRed}`}
                    onClick={orderCancelHandler}
                  >
                    Cancel order
                  </button> */}
                  <p className={styles.warning}>{error.message}</p>
                </div>
              </div>
            </div>
          </>
        )}
        {!order && <h2>Your orders will appear here</h2>}
      </section>
    </>
  );
}

export default Cart;
