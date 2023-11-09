import styles from "./ContactButton.module.css";

function ContactButton() {
  return (
    <div className={styles.modal}>
      {/* <!-- Number input --> */}
      <label>Address</label>
      <input type="number" id="form6Example6" className="form-control" />
      {/* <!-- Number input --> */}
      <label>Phone</label>
      <input type="number" id="form6Example6" className="form-control" />
      {/* <!-- Number input --> */}
      <label>Phone</label>
      <input type="number" id="form6Example6" className="form-control" />

      {/* <!-- Message input --> */}
      <label>Additional information</label>
      <textarea className="form-control" id="form6Example7" rows="4"></textarea>
    </div>
  );
}

export default ContactButton;
