import { Outlet } from "react-router-dom";
import Navigation from "../components/Navigation.jsx";
import styles from "./AppLayout.module.css";
import Footer from "../components/Footer.jsx";
import Login from "../components/authComponents/Login.jsx";

function AppLayout() {
  return (
    <div className={styles["app-component"]}>
      <Navigation />
      <Login />
      <Footer />
    </div>
  );
}

export default AppLayout;
