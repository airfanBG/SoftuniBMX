import styles from "./CreateBike.module.css";

import { useEffect, useReducer } from "react";

import { getFrames, getOneFrame } from "../../bikeServices/service.js";

import LoaderWheel from "../LoaderWheel.jsx";
import SelectComponent from "./SelectComponent.jsx";
import FrameInfo from "./FrameInfo.jsx";

const initialState = {
  frames: {},
  wheels: [],
  mechanics: [],
  loading: true,
  selectedFrame: "",
  currentFrame: {},
};

function reducer(state, action) {
  switch (action.type) {
    case "frameList":
      return { ...state, frames: action.payload };
    case "dataReceived":
      return { ...state, loading: action.payload };
    case "selectedFrame":
      return { ...state, selectedFrame: action.payload };
    case "isFrameSelected":
      return { ...state, currentFrame: { ...action.payload } };
    case "dataFailed":
      return { ...state, status: action.payload };
    default:
      throw new Error("Action is unknown!");
  }
}

function CreateBike() {
  const [
    { frames, wheels, mechanics, loading, selectedFrame, currentFrame },
    dispatch,
  ] = useReducer(reducer, initialState);

  // GET ALL FRAMES
  useEffect(function () {
    async function frames() {
      try {
        const frames = await getFrames();
        console.log(frames);

        dispatch({ type: "frameList", payload: frames });
        dispatch({ type: "dataReceived", payload: false });
      } catch (err) {
        dispatch({ type: "dataFailed" });
      }
    }
    frames();
  }, []);

  useEffect(
    function () {
      async function getSelected() {
        try {
          const data = await getOneFrame(selectedFrame);
          console.log(data);

          dispatch({ type: "isFrameSelected", payload: data });
          // dispatch({ type: "dataReceived", payload: false });
        } catch (err) {
          dispatch({ type: "dataFailed" });
        }
      }
      getSelected();
    },
    [selectedFrame]
  );

  return (
    <>
      {loading && <LoaderWheel />}
      <div className={styles.wrapper}>
        <h2 className={styles.dashHeading}>Create your custom</h2>

        <section className={styles.board}>
          <header className={styles.boardHeader}>
            <h3 className={styles.cash}>
              Choose frame, tyres and the mechanics by selecting from the
              dropdown
            </h3>
          </header>

          <div className={styles.dropdownWrapper}>
            <article className={styles.framesBlock}>
              <h3 className={styles.heading}>Select frame</h3>
              <div className={styles.selection}>
                <SelectComponent data={frames} dispatch={dispatch} />
                {/* {selectedFrame && <FrameInfo frame={currentFrame} />} */}
                <FrameInfo frame={currentFrame} />
              </div>

              <div className={styles.selectionImg}>
                {!selectedFrame && <p className={styles.questionMark}>?</p>}
                {selectedFrame && (
                  <img src={currentFrame.imageUrl} alt={currentFrame.name} />
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
