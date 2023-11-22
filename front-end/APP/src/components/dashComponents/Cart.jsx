import { useContext, useEffect, useState } from "react";

import styles from "./Cart.module.css";

import BoardHeader from "./BoardHeader.jsx";
import { UserContext } from "../UserProfile.jsx";
import { getOrderData } from "../../util/util.js";
import {
  getOneFrame,
  getOnePart,
  getOneWheel,
} from "../../bikeServices/service.js";
import LoaderWheel from "../LoaderWheel.jsx";
import { post, put } from "../../util/api.js";
import { useNavigate } from "react-router-dom";

function Cart() {
  const { user, setUser, userBalanceHandler } = useContext(UserContext);

  const [loading, setLoading] = useState(false);
  const [frame, setFrame] = useState({});
  const [wheel, setWheel] = useState({});
  const [parts, setParts] = useState({});
  const order = getOrderData();
  const navigate = useNavigate();

  useEffect(function () {
    if (!order) return;
    setLoading(true);
    async function getOrder() {
      const { selectedFrame, selectedWheel, selectedPart } = order;

      try {
        const frame = await getOneFrame(Number(selectedFrame));
        const wheel = await getOneWheel(Number(selectedWheel));
        const parts = await getOnePart(Number(selectedPart));
        setFrame({ ...frame });
        setWheel({ ...wheel });
        setParts({ ...parts });
        setLoading(false);
      } catch (err) {
        console.error(err);
        setLoading(false);
      }
    }
    getOrder();
    // eslint-disable-next-line react-hooks/exhaustive-deps
  }, []);

  async function orderClickHandler(e) {
    e.preventDefault();
    if (!order) return;
    const additionalFields = {
      ownerId: user.id,
      orderDate: Date.now(),
      orderTotal: frame.salesPrice + wheel.salesPrice + parts.salesPrice,
      // according to documentation customer pays while ordering 20% of the total order price
      cashReserved:
        (frame.salesPrice + wheel.salesPrice + parts.salesPrice) * 0.2,
    };
    //user balance after order
    const userReducedBalance =
      user.balance -
      (frame.salesPrice + wheel.salesPrice + parts.salesPrice) * 0.2;

    const currentOrder = {
      frameId: frame.id,
      wheelId: wheel.id,
      partsId: parts.id,
      ...additionalFields,
    };

    // TODO:
    // ONLY FOR DEV SERVER
    const userPayment = {
      ...user,
      balance: userReducedBalance,
      password: user.repass,
    };

    // IN PROD
    // const userPayment = { ...user, balance: userReducedBalance };
    setLoading(true);
    try {
      const orderResponse = await post("/orders/", currentOrder);
      const userAfterOrder = await put(`/users/${user.id}`, userPayment);
      console.log(orderResponse);
      console.log(userAfterOrder);
    } catch (err) {
      console.error(err);
    } finally {
      setUser({ ...user, balance: userReducedBalance });
      setLoading(false);
      navigate("/profile");
    }
  }

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
                  <img src={frame.imageUrl} alt="" />
                </div>
                <div className={styles.header}>
                  <h2 className={styles.heading}>{frame.name}</h2>
                  <p className={styles.price}>{frame.salesPrice}</p>
                </div>

                <p className={styles.description}>{frame.description}</p>
              </figure>
              <figure className={styles.mainInfo}>
                <div className={styles.img}>
                  <img src={wheel.imageUrl} alt="" />
                </div>
                <div className={styles.header}>
                  <h2 className={styles.heading}>{wheel.name}</h2>
                  <p className={styles.price}>{wheel.salesPrice}</p>
                </div>

                <p className={styles.description}>{wheel.description}</p>
              </figure>
              <figure className={styles.mainInfo}>
                <div className={styles.img}>
                  <img src={parts.imageUrl} alt="" />
                </div>
                <div className={styles.header}>
                  <h2 className={styles.heading}>{parts.name}</h2>
                  <p className={styles.price}>{parts.salesPrice}</p>
                </div>

                <p className={styles.description}>{parts.description}</p>
              </figure>
            </div>

            <p className={styles.totalPrice}>
              <span>Total:</span>
              {!isNaN(frame.salesPrice + wheel.salesPrice + parts.salesPrice) &&
                (
                  frame.salesPrice +
                  wheel.salesPrice +
                  parts.salesPrice
                ).toFixed(2)}
            </p>
            {/* TODO: check if user has enough money */}
            <button
              className={styles.btn}
              disabled={
                user.balance <
                (frame.salesPrice + wheel.salesPrice + parts.salesPrice) * 0.2
              }
              onClick={orderClickHandler}
            >
              Finish order
            </button>
          </>
        )}
        {!order && <h2>Your orders will appear here</h2>}
      </section>
    </>
  );
}

export default Cart;
