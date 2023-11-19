import styles from "./CreateBike.module.css";

import { useEffect, useReducer } from "react";

import {
  getFrames,
  getOneFrame,
  getOnePart,
  getOneWheel,
  getParts,
  getWheels,
} from "../../bikeServices/service.js";

import LoaderWheel from "../LoaderWheel.jsx";
import SelectComponent from "./SelectComponent.jsx";
import ElementInfo from "./ElementInfo.jsx";

const initialState = {
  frames: [],
  wheels: [],
  parts: [],
  loading: false,
  selectedFrame: "",
  selectedWheel: "",
  selectedPart: "",
  currentFrame: {},
  currentWheel: {},
  currentPart: {},
  framePrice: 0,
  wheelPrice: 0,
  partsPrice: 0,
  canBuy: false,
  total: 0,
};

function reducer(state, action) {
  switch (action.type) {
    case "frameList":
      return { ...state, frames: action.payload };
    case "dataReceived":
      return { ...state, loading: action.payload };
    case "selectedFrame":
      return { ...state, selectedFrame: action.payload };
    case "selectedWheel":
      return { ...state, selectedWheel: action.payload };
    case "selectedPart":
      return { ...state, selectedPart: action.payload };
    case "isFrameSelected":
      return { ...state, currentFrame: { ...action.payload } };
    case "isWheelSelected":
      return { ...state, currentWheel: { ...action.payload } };
    case "isPartSelected":
      return { ...state, currentPart: { ...action.payload } };
    case "wheelsList":
      return { ...state, wheels: [...action.payload] };
    case "dataFailed":
      return { ...state, status: action.payload };
    case "partsList":
      return { ...state, parts: action.payload };
    case "framePrice":
      return { ...state, framePrice: action.payload };
    case "wheelPrice":
      return { ...state, wheelPrice: action.payload };
    case "partsPrice":
      return { ...state, partsPrice: action.payload };
    case "buy":
      return { ...state, canBuy: action.payload };
    case "cash":
      return { ...state, total: action.payload };
    default:
      throw new Error("Action is unknown!");
  }
}

function CreateBike() {
  const [
    {
      frames,
      wheels,
      parts,
      loading,
      selectedFrame,
      currentFrame,
      selectedWheel,
      currentWheel,
      selectedPart,
      currentPart,
      framePrice,
      wheelPrice,
      partsPrice,
      canBuy,
      total,
    },
    dispatch,
  ] = useReducer(reducer, initialState);

  // GET ALL FRAMES
  useEffect(function () {
    async function frames() {
      try {
        dispatch({ type: "dataReceived", payload: true });

        const frames = await getFrames();

        dispatch({ type: "frameList", payload: frames });
        dispatch({ type: "dataReceived", payload: false });
      } catch (err) {
        dispatch({ type: "dataFailed" });
      }
      // finally {
      //   dispatch({ type: "dataReceived", payload: true });
      // }
    }
    frames();
  }, []);

  // FRAME REQUEST
  useEffect(
    function () {
      if (selectedFrame === "") return;
      async function getSelected() {
        try {
          dispatch({ type: "dataReceived", payload: true });

          // get selected frame
          const data = await getOneFrame(selectedFrame);

          // get wheels depending on selected frame type
          const wheelsData = await getWheels(`frame${data.type}`);
          // console.log(wheelsData);

          dispatch({ type: "isFrameSelected", payload: data });
          dispatch({ type: "framePrice", payload: data.price });
          dispatch({ type: "isWheelSelected", payload: {} });
          dispatch({ type: "isPartSelected", payload: {} });
          dispatch({ type: "wheelsList", payload: wheelsData });
          dispatch({ type: "partsList", payload: [] });
          dispatch({ type: "selectedWheel", payload: "" });
          dispatch({ type: "selectedPart", payload: "" });
          dispatch({ type: "wheelPrice", payload: 0 });
          dispatch({ type: "partsPrice", payload: 0 });
          dispatch({ type: "buy", payload: false });
          dispatch({ type: "dataReceived", payload: false });
        } catch (err) {
          dispatch({ type: "dataFailed" });
        }
      }
      getSelected();
    },
    [selectedFrame]
  );

  // WHEEL REQUEST
  useEffect(
    function () {
      if (selectedWheel === "") return;
      async function getSelected() {
        try {
          dispatch({ type: "dataReceived", payload: true });

          // get selected wheel
          const data = await getOneWheel(selectedWheel);
          // console.log(data);

          // get parts depending on selected wheel type
          const partsData = await getParts(`wheelBase${data.wheelBase}`);
          // console.log(partsData);

          dispatch({ type: "isWheelSelected", payload: data });
          dispatch({ type: "wheelPrice", payload: data.price });
          dispatch({ type: "isPartSelected", payload: {} });
          dispatch({ type: "partsList", payload: partsData });
          dispatch({ type: "selectedPart", payload: "" });
          dispatch({ type: "partsPrice", payload: 0 });
          dispatch({ type: "buy", payload: false });
          dispatch({ type: "dataReceived", payload: false });
        } catch (err) {
          dispatch({ type: "dataFailed" });
        }
      }
      getSelected();
    },
    [selectedWheel]
  );

  // PART REQUEST
  useEffect(
    function () {
      if (selectedPart === "") return;
      async function getSelected() {
        try {
          dispatch({ type: "dataReceived", payload: true });

          // get selected part
          const data = await getOnePart(selectedPart);
          // console.log(data);

          dispatch({ type: "isPartSelected", payload: data });
          dispatch({ type: "partsPrice", payload: data.price });
          dispatch({ type: "buy", payload: true });
          dispatch({ type: "dataReceived", payload: false });
        } catch (err) {
          dispatch({ type: "dataFailed" });
        }
      }
      getSelected();
    },
    [selectedPart]
  );

  useEffect(
    function () {
      dispatch({ type: "cash", payload: framePrice + wheelPrice + partsPrice });
    },
    [framePrice, wheelPrice, partsPrice]
  );

  return (
    <>
      {loading && <LoaderWheel />}
      <div className={styles.wrapper}>
        <h2 className={styles.dashHeading}>Create your custom</h2>

        <section className={styles.board}>
          <header className={styles.boardHeader}>
            <h3 className={styles.cash}>Select from lists</h3>
            <button
              className={styles.totalPrice}
              style={
                canBuy
                  ? {
                      color: "var(--color-link-light)",
                      backgroundColor: "var(--color-line)",
                      border: "1px solid var(--color-link-light)",
                    }
                  : null
              }
            >
              <ion-icon name="cart-outline"></ion-icon>
              <span className={styles.priceNumbers}> {total.toFixed(2)}</span>
            </button>
          </header>

          <div className={styles.dropdownWrapper}>
            <article className={styles.framesBlock}>
              <h3 className={styles.heading}>Select frame</h3>
              <div className={styles.selection}>
                <SelectComponent
                  data={frames}
                  dispatch={dispatch}
                  type={"selectedFrame"}
                />
                {/* {selectedFrame && <ElementInfo frame={currentFrame} />} */}
                <ElementInfo data={currentFrame} />
              </div>

              <div className={styles.selectionImg}>
                {!selectedFrame && <p className={styles.questionMark}>?</p>}
                {selectedFrame && (
                  <img src={currentFrame.imageUrl} alt={currentFrame.name} />
                )}
              </div>
            </article>

            <article className={styles.framesBlock}>
              <h3 className={styles.heading}>Select wheels</h3>
              <div className={styles.selection}>
                <SelectComponent
                  disabled={wheels.length === 0}
                  data={wheels}
                  dispatch={dispatch}
                  type={"selectedWheel"}
                />
                {/* {selectedFrame && <ElementInfo frame={currentFrame} />} */}
                <ElementInfo data={currentWheel} />
              </div>

              <div className={styles.selectionImg}>
                {!selectedWheel && <p className={styles.questionMark}>?</p>}
                {selectedWheel && (
                  <img src={currentWheel.imageUrl} alt={currentWheel.name} />
                )}
              </div>
            </article>

            <article className={styles.framesBlock}>
              <h3 className={styles.heading}>Select wheels</h3>
              <div className={styles.selection}>
                <SelectComponent
                  disabled={parts.length === 0}
                  data={parts}
                  dispatch={dispatch}
                  type={"selectedPart"}
                />
                {/* {selectedFrame && <ElementInfo frame={currentFrame} />} */}
                <ElementInfo data={currentPart} />
              </div>

              <div className={styles.selectionImg}>
                {!selectedPart && <p className={styles.questionMark}>?</p>}
                {selectedPart && (
                  <img src={currentPart.imageUrl} alt={currentPart.name} />
                )}
              </div>
            </article>
          </div>
        </section>
      </div>
    </>
  );
}

export default CreateBike;
