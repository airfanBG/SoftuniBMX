import { Link } from "react-router-dom";
import styles from "./ModelSelection.module.css";

function ModelSelection() {
  return (
    <section className={styles["model-selection"]}>
      <article className={`${styles["custom-bike"]} ${styles["container"]}`}>
        <h2 className={styles["model-selection-hd"]}>
          Be unique! <span className={styles["color-hd"]}>Create</span> your
          custom
        </h2>

        <p className={styles["secondary-hd"]}>
          Is easy as one - two -{" "}
          <span className={styles["main-red"]}>three</span>!
        </p>
        <div className={styles.steps}>
          <div className={styles.step}>
            <img
              src="./img/frame.png"
              alt="bmx frame"
              className={styles["step-img"]}
            />
            <p>Choose frame</p>
            <span>
              <i className="fa-solid fa-arrow-right-long steps-icon"></i>
            </span>
          </div>
          <div className={styles.step}>
            <img
              src="./img/wheels.png"
              alt="bike wheels"
              className={styles["step-img"]}
            />
            <p>Select tyres</p>
            <span>
              <i className="fa-solid fa-arrow-right-long steps-icon"></i>
            </span>
          </div>
          <div className={styles.step}>
            <img
              src="./img/parts.png"
              alt="bike parts"
              className={styles["step-img"]}
            />
            <p>Select mechanics</p>
            <span>
              <i className="fa-solid fa-arrow-right-long steps-icon"></i>
            </span>
          </div>

          <Link to={"create"} className={styles["step-link"]}>
            Start production
          </Link>
        </div>
      </article>
      <p className={styles["secondary-hd"]}>or</p>

      <h3 className={styles["model-selection-hd"]}>Choose model</h3>
      <div
        className={`${styles["bottom-line"]} ${styles["m-bottom-80"]}`}
      ></div>

      <div className={styles.cards}>
        <figure className={styles.card}>
          <img
            src="./img/bike-1.webp"
            alt="Bike alt text"
            className={styles["card-img"]}
          />
          <div className={styles["card-content"]}>
            <h3 className={styles["card-hd"]}>
              Bike type <span>#</span>1
            </h3>
            <p className={styles["card-pf"]}>
              Lorem ipsum dolor sit amet consectetur adipisicing elit. In
              voluptas obcaecati minus deleniti corrupti atque est veniam quidem
              molestias fuga, enim provident quas natus corporis quae. Ut omnis
              modi tenetur qui blanditiis.
            </p>
            <p className={styles["card-pf"]}>
              <Link to={"#"} className={styles["card-link"]}>
                Create bike
              </Link>
            </p>
          </div>
        </figure>

        <figure className={styles.card}>
          <img
            src="./img/bike-2.webp"
            alt="Bike alt text"
            className={styles["card-img"]}
          />
          <div className={styles["card-content"]}>
            <h3 className={styles["card-hd"]}>
              Bike type <span>#</span>2
            </h3>
            <p className={styles["card-pf"]}>
              Lorem ipsum dolor sit amet consectetur adipisicing elit Lorem
              ipsum dolor sit amet consectetur adipisicing elit. Nihil
              accusantium. A nihil porro ullam, incidunt odit nam fuga mollitia
              tempora, qui hic perferendis excepturi quae rerum omnis
            </p>
            <p className={styles["card-pf"]}>
              <Link to={"#"} className={styles["card-link"]}>
                Create bike
              </Link>
            </p>
          </div>
        </figure>

        <figure className={styles.card}>
          <p className={styles.top}>best value</p>
          <img
            src="./img/bike-3.webp"
            alt="Bike alt text"
            className={styles["card-img"]}
          />
          <div className={styles["card-content"]}>
            <h3 className={styles["card-hd"]}>
              Bike type <span>#</span>3
            </h3>
            <p className={styles["card-pf"]}>
              Lorem ipsum dolor sit amet consectetur adipisicing elit. Nam,
              laborum expedita qui dicta nihil delectus voluptatum neque
              dolores, blanditiis saepe vero dignissimos impedit odio obcaecati
              quo sit hic?
            </p>
            <p className={styles["card-pf"]}>
              <Link to={"#"} className={styles["card-link"]}>
                Create bike
              </Link>
            </p>
          </div>
        </figure>
      </div>
    </section>
  );
}

export default ModelSelection;
