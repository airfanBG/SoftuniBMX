import { Link } from "react-router-dom";
import styles from "./ModelSelection.module.css";
import { useContext } from "react";
import BikeModel from "./BikeModel.jsx";
import { HomeContext } from "./Home.jsx";

function ModelSelection() {
  const { bikes, top } = useContext(HomeContext);

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
          <Link className={styles.step} to={"app"}>
            <img
              src="./img/frame.png"
              alt="bmx frame"
              className={styles["step-img"]}
            />
            <p>Choose frame</p>
            <span>
              <i className="fa-solid fa-arrow-right-long steps-icon"></i>
            </span>
          </Link>
          <Link className={styles.step} to={"app"}>
            <img
              src="./img/wheels.png"
              alt="bike wheels"
              className={styles["step-img"]}
            />
            <p>Select tyres</p>
            <span>
              <i className="fa-solid fa-arrow-right-long steps-icon"></i>
            </span>
          </Link>
          <Link className={styles.step} to={"app"}>
            <img
              src="./img/parts.png"
              alt="bike parts"
              className={styles["step-img"]}
            />
            <p>Select mechanics</p>
            <span>
              <i className="fa-solid fa-arrow-right-long steps-icon"></i>
            </span>
          </Link>

          <Link to={"app"} className={styles["step-link"]}>
            Start production
          </Link>
        </div>
      </article>
      <p className={styles["secondary-hd"]}>or take one of our offers</p>

      <h3 className={styles["model-selection-hd"]}>Choose model</h3>
      <div
        className={`${styles["bottom-line"]} ${styles["m-bottom-80"]}`}
      ></div>

      <div className={styles.cards}>
        {bikes.length > 0 &&
          bikes.map((x, i) => (
            <BikeModel
              key={x.id}
              imageUrl={x.imageUrl}
              model={x.modelName}
              description={x.description}
              price={x.price}
              top={top}
              id={x.id}
            />
          ))}
      </div>
    </section>
  );
}

export default ModelSelection;
