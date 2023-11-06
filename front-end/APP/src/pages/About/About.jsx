import styles from "./About.module.css";

import Navigation from "../../components/Navigation.jsx";
import Footer from "../../components/Footer.jsx";
// import Form from "../../components/Form.jsx";

function About() {
  return (
    <div className={styles.compBody}>
      <Navigation />
      <div className={styles.container}>
        <div className={styles.content}>
          {/* <Form /> */}

          <span>lkjsanldkfjnalsjgfn</span>
        </div>
      </div>
      <Footer />
    </div>
  );
}

export default About;
