import styles from "./ContactInfoElement.module.css";

function ContactInfoElement({ width, label, content }) {
  return (
    <div className={styles.userData} style={{ width: width }}>
      <span>{label}: </span>
      <p>{content}</p>
    </div>
  );
}

export default ContactInfoElement;
