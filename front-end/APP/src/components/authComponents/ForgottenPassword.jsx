import styles from "./ForgottenPassword.module.css";
import InputComponent from "./InputComponent.jsx";

function ForgottenPassword() {
  return (
    <div>
      Please, fill your email address
      <InputComponent />
      <button>Reset</button>
    </div>
  );
}

export default ForgottenPassword;
