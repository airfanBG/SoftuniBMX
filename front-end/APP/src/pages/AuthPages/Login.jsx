import Footer from "../../components/Footer.jsx";
import LoginComponent from "../../components/authComponents/LoginComponent.jsx";
import Navigation from "../../components/Navigation.jsx";
import styles from "./Login.module.css";

function Login() {
  return (
    <div className={styles.compBody}>
      <Navigation />
      <div className={styles.container}>
        <div className={styles.content}>
          <LoginComponent />
        </div>
      </div>
      <Footer />
    </div>
  );
}

export default Login;
