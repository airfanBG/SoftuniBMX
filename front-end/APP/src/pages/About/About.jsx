import styles from "./About.module.css";

import Navigation from "../../components/navigationsComponents/Navigation.jsx";
import Footer from "../../components/Footer.jsx";
// import Form from "../../components/Form.jsx";

function About() {
  return (
    <div className={styles.compBody}>
      <Navigation />
      <div className={styles.container}>
        <div className={styles.content}>
          <h2 className={styles.heading}>Lorem ipsum dolor sit amet.</h2>
          <p className={styles.textPh}>
            Lorem ipsum dolor sit amet consectetur adipisicing elit. Atque nobis
            porro quos cupiditate iure laboriosam facilis vel corporis provident
            facere alias, accusamus modi nihil eligendi libero repudiandae earum
            ea debitis, et voluptates sed, rem est? Culpa beatae vel impedit,
            minus voluptates doloremque quos vitae ex, deserunt vero animi
            suscipit possimus!
          </p>

          <p className={styles.textPh}>
            Lorem ipsum dolor sit amet, consectetur adipisicing elit.
            Reprehenderit deserunt repudiandae, minima in quam ratione hic ullam
            eligendi consequuntur velit, voluptatem facere esse sit saepe
            placeat numquam praesentium eius sequi tempore. Excepturi alias,
            fugit pariatur blanditiis earum error. Sit, impedit. Eius, in
            reprehenderit praesentium rerum asperiores molestias eos, sed
            assumenda consequatur amet cumque hic rem ab illum, molestiae
            voluptates id voluptatibus incidunt autem doloremque iste esse. Modi
            perferendis minima numquam, eaque molestias labore? Perferendis,
            optio!
          </p>

          <div className={styles.img}>
            <img src="./img/about.webp" alt="" />
          </div>
        </div>
      </div>
      <Footer />
    </div>
  );
}

export default About;
