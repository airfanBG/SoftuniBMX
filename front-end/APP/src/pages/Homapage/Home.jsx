import styles from "./Home.module.css";

import Header from "./Header.jsx";
import ModelSelection from "./ModelSelection.jsx";
import Testimonials from "./Testimonials.jsx";
import Footer from "../../components/Footer.jsx";
import UserContent from "./UserContent.jsx";

function Home() {
  return (
    <>
      <div className={styles["page-background"]}>
        <img src="./img/bg.webp" alt="Extreme sports pool" />
      </div>
      <Header />
      <main>
        <ModelSelection />
        <Testimonials />
        <UserContent />
      </main>
      <Footer />
    </>
  );
}

export default Home;
