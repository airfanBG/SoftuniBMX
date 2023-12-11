import styles from "./Block.module.css";
import FrameInfo from "./FrameInfo.jsx";
import SelectComponent from "./SelectComponent.jsx";

function Block({ dispatch }) {
  return (
    <>
      <div className={styles.selection}>
        <SelectComponent
          data={frames}
          dispatch={dispatch}
          type={"selectedFrame"}
        />
        {/* {selectedFrame && <FrameInfo frame={currentFrame} />} */}
        <FrameInfo frame={currentFrame} />
      </div>

      <div className={styles.selectionImg}>
        {!selectedFrame && <p className={styles.questionMark}>?</p>}
        {selectedFrame && (
          <img src={currentFrame.imageUrl} alt={currentFrame.name} />
        )}
      </div>
    </>
  );
}

export default Block;
