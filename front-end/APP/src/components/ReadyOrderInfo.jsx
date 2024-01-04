import styles from "./ReadyOrderInfo.module.css";

function ReadyOrderInfo() {
  return (
    <div className={styles.waviy}>
      <span style={{ animationDelay: "calc(0.2s * 1)" }}>r</span>
      <span style={{ animationDelay: "calc(0.2s * 2)" }}>e</span>
      <span style={{ animationDelay: "calc(0.2s * 3)" }}>a</span>
      <span style={{ animationDelay: "calc(0.2s * 4)" }}>d</span>
      <span style={{ animationDelay: "calc(0.2s * 5)" }}>y</span>
      <span style={{ opacity: 0 }}>j</span>
      <span
        style={{
          color: "var(--color-hd)",
          fontSize: "1.2rem",
        }}
      >
        X
      </span>
    </div>
  );
}

export default ReadyOrderInfo;
