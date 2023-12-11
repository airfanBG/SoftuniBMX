import styles from "./Hero.module.css";

function Hero() {
  return (
    <section className={styles.hero}>
      <img
        className={styles["hero-img"]}
        src="img/main-background.webp"
        alt="Man doing a trick with BMX"
      />
      <div className={`${styles["hero-text"]} ${styles["container"]}`}>
        <h1 className={styles["hero-hd"]}>Lorem, ipsum dolor.</h1>
        <p className={styles["hero-pf"]}>
          Lorem ipsum dolor sit amet consectetur adipisicing elit. Blanditiis,
          dolor!
        </p>
      </div>
    </section>
  );
}

export default Hero;
