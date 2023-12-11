import styles from "./Testimonials.module.css";

function Testimonials() {
  return (
    <section className={styles.testimonials}>
      <div
        className={`${styles["testimonials-content"]} ${styles["container"]}`}
      >
        <h2 className={styles["testimonials-hd"]}>
          Lorem ipsum dolor sit amet.
        </h2>
        <div
          className={`${styles["bottom-line"]} ${styles["m-bottom-50"]}`}
        ></div>
        <p className={styles["testimonials-pf"]}>
          Lorem ipsum dolor sit amet consectetur, adipisicing elit. Laborum
          commodi illo cumque laboriosam reiciendis asperiores iure molestiae
          eligendi rerum molestias in a corrupti, natus nostrum cum quia, et
          impedit ex officiis repudiandae quaerat possimus eius. Ea, magnam
          veniam! Atque consequuntur maxime ratione, deserunt, explicabo iure
          fuga vero commodi molestiae modi pariatur minus dolorem qui doloremque
          sunt. Illo iusto pariatur illum ullam voluptatum placeat expedita sunt
          omnis nisi, dignissimos voluptas facere, quod eaque repellat quidem ex
          fuga repudiandae animi? Sunt, consequatur! Vel distinctio
          necessitatibus molestias amet consequuntur consequatur, aut
          reprehenderit ut quod sequi, porro nemo, vitae in repellendus. Vel
          dignissimos voluptates maiores nemo numquam ea impedit sunt, iure
          libero perspiciatis, ipsa expedita voluptatem error magnam provident
          hic excepturi ad minima dolorum.
        </p>
      </div>
    </section>
  );
}

export default Testimonials;
