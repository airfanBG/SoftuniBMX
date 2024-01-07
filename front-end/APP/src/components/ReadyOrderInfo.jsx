import styles from "./ReadyOrderInfo.module.css";

function ReadyOrderInfo({ hideReady }) {
  return (
    <div className={styles.waviy}>
      <span style={{ animationDelay: "calc(0.2s * 1)" }}>r</span>
      <span style={{ animationDelay: "calc(0.2s * 2)" }}>e</span>
      <span style={{ animationDelay: "calc(0.2s * 3)" }}>a</span>
      <span style={{ animationDelay: "calc(0.2s * 4)" }}>d</span>
      <span style={{ animationDelay: "calc(0.2s * 5)" }}>y</span>
      <span style={{ animationDelay: "calc(0.2s * 6)" }}>!</span>
      {/* <span style={{ opacity: 0 }}>j</span> */}
      <button
        onClick={() => hideReady(false)}
        className={styles.closeBtn}
        style={window.location.pathname === "/" ? { color: "#fff" } : null}
      >
        &#10006;
      </button>
    </div>
  );
}

export default ReadyOrderInfo;
