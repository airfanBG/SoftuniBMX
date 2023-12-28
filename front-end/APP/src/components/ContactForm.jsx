import React, { useState } from "react";
import emailjs from "emailjs-com";
import styles from "./ContactForm.module.css";
import { ToastContainer, toast } from "react-toastify";
import "react-toastify/dist/ReactToastify.css";

function ContactForm() {
  const [email, setEmail] = useState("");
  const [title, setTitle] = useState("");
  const [text, setText] = useState("");

  function send(e) {
    e.preventDefault();

    if (!!email && !!title && !!text) {
      const EMAIL_REGEX =
        /^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$/;

      if (email.match(EMAIL_REGEX)) {
        const templateParams = {
          email,
          title,
          text,
        };
        console.log(templateParams);
        emailjs
          .send(
            "service_3l6cd7l",
            "template_sl5q3pu",
            templateParams,
            "UD-yZH0_5n_nv3DwV"
          )
          .then(
            (response) => {
              console.log("Email sent successfully:", response);
              setEmail("");
              setTitle("");
              setText("");
              // Use toast notification for non-blocking message
              toast.success("Email sent successfully.", {
                position: toast.POSITION.BOTTOM_CENTER,
                autoClose: false,
              });
            },
            (error) => {
              console.error("Error sending email:", error);
              toast.error("Error sending email", {
                position: toast.POSITION.BOTTOM_CENTER,
                autoClose: false,
              });
            }
          );
      } else {
        toast.error("Please enter a valid email!", {
          position: toast.POSITION.BOTTOM_CENTER,
          autoClose: false,
        });
      }
    } else {
      toast.error("All fields must be filled with data!", {
        position: toast.POSITION.BOTTOM_CENTER,
        autoClose: false,
      });
    }
  }

  return (
    <form className={styles.formContainer}>
      <div className={styles.divForm}>
        <label className={styles.labelForm} htmlFor="email">
          Email<span className={styles.spanForm}>*</span>
        </label>
        <input
          type="email"
          id="email"
          value={email}
          onChange={(e) => setEmail(e.target.value)}
          placeholder="Example: example@test.bg"
        />
      </div>

      <div className={styles.divForm}>
        <label className={styles.labelForm} htmlFor="title">
          Title<span className={styles.spanForm}>*</span>
        </label>
        <input
          type="text"
          id="title"
          value={title}
          onChange={(e) => setTitle(e.target.value)}
          placeholder="Example: Order"
        />
      </div>

      <div className={styles.divForm}>
        <label className={styles.labelForm} htmlFor="questionText">
          Question<span className={styles.spanForm}>*</span>
        </label>
        <textarea
          className={styles.textForm}
          id="questionText"
          value={text}
          onChange={(e) => setText(e.target.value)}
          placeholder="Write the text here"
        />
      </div>

      <div className={styles.divForm2}>
        <button className={styles.btn} type="button" onClick={send}>
          Send your question
        </button>
      </div>
      <ToastContainer
        position="center"
        autoClose={3000}
        hideProgressBar
        newestOnTop={false}
        closeOnClick
        rtl={false}
        pauseOnFocusLoss
        draggable
        pauseOnHover
      />
    </form>
  );
}

export default ContactForm;
