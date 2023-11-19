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

function Cart() {
  const { user, userBalanceHandler } = useContext(UserContext);

  const [loading, setLoading] = useState(false);
  const [frame, setFrame] = useState({});
  const [wheel, setWheel] = useState({});
  const [parts, setParts] = useState({});
  const order = getOrderData();

  useEffect(function () {
    if (!order) return;
    setLoading(true);
    async function getOrder() {
      const { selectedFrame, selectedWheel, selectedPart } = order;

      try {
        const frame = await getOneFrame(selectedFrame);
        const wheel = await getOneWheel(selectedWheel);
        const parts = await getOnePart(selectedPart);
        setFrame({ ...frame });
        setWheel({ ...wheel });
        setParts({ ...parts });
        console.log(frame, wheel, parts);
        setLoading(false);
      } catch (err) {
        console.error(err);
        setLoading(false);
      }
    }
    getOrder();
    // eslint-disable-next-line react-hooks/exhaustive-deps
  }, []);
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
                  <p className={styles.price}>{frame.price}</p>
                </div>

                <p className={styles.description}>{frame.description}</p>
              </figure>
              <figure className={styles.mainInfo}>
                <div className={styles.img}>
                  <img src={wheel.imageUrl} alt="" />
                </div>
                <div className={styles.header}>
                  <h2 className={styles.heading}>{wheel.name}</h2>
                  <p className={styles.price}>{wheel.price}</p>
                </div>

                <p className={styles.description}>{wheel.description}</p>
              </figure>
              <figure className={styles.mainInfo}>
                <div className={styles.img}>
                  <img src={parts.imageUrl} alt="" />
                </div>
                <div className={styles.header}>
                  <h2 className={styles.heading}>{parts.name}</h2>
                  <p className={styles.price}>{parts.price}</p>
                </div>

                <p className={styles.description}>{parts.description}</p>
              </figure>
            </div>

            <p className={styles.totalPrice}>
              <span>Total:</span>
              {frame.price + wheel.price + parts.price}
            </p>
            {/* TODO: check if user has enough money */}
            <button
              className={styles.btn}
              disabled={user.balance < frame.price + wheel.price + parts.price}
              onClick={() => console.log("click")}
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
