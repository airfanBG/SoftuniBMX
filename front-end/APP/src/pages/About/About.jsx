import Footer from "../../components/Footer.jsx";
import Navigation from "../../components/Navigation.jsx";
import styles from "./About.module.css";

function About() {
  return (
    <div className={styles.compBody}>
      <Navigation />
      <div className={styles.content}>About content</div>
      <Footer />
    </div>
  );
}

export default About;
