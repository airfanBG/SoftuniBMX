import Navigation from "../components/navigationsComponents/Navigation.jsx";
import styles from "./AppLayout.module.css";
import Footer from "../components/Footer.jsx";
import { Outlet } from "react-router-dom";

function AppLayout() {
  return (
    <div className={styles["app-component"]}>
      <Navigation />
      <Outlet />
      <Footer />
    </div>
  );
}

export default AppLayout;
