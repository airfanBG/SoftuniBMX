import styles from "./Header.module.css";

import Hero from "./Hero.jsx";
import Navigation from "../../components/navigationsComponents/Navigation.jsx";

function Header() {
  return (
    <header className={styles.header}>
      <Navigation />
      <Hero />
    </header>
  );
}

export default Header;
