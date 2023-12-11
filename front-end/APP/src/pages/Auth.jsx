import styles from "./Auth.module.css";

import { Outlet } from "react-router-dom";
import Navigation from "../components/navigationsComponents/Navigation.jsx";
import Footer from "../components/Footer.jsx";

function Auth() {
  return (
    <div>
      <Navigation />
      <Outlet />
      <Footer />
    </div>
  );
}

export default Auth;
