import { useContext } from "react";
import Comment from "./Comment.jsx";
import styles from "./UserContent.module.css";
import { HomeContext } from "./Home.jsx";

function UserContent() {
  const { comments } = useContext(HomeContext);

  return (
    <section className={styles["user-content"]}>
      <header className={styles["user-content-hd"]}>
        <h2 className={`${styles["user-hd"]} ${styles["m-bottom-30"]}`}>
          Lorem ipsum dolor, sit amet consectetur adipisicing.
        </h2>
        <div className={`${styles["bottom-line"]} ${styles["m-bottom-50"]}`} />
      </header>
      <div
        className={`${styles["comments-and-gallery"]} ${styles["container"]}`}
      >
        <div className={styles.comments}>
          {comments.map((c) => (
            <Comment comment={c} key={c.id} />
          ))}
        </div>

        <div className={styles.gallery}>
          <img
            src="./img/gal/1.webp"
            alt="image alternative text"
            className={styles["gal-img"]}
          />
          <img
            src="./img/gal/2.webp"
            alt="image alternative text"
            className={styles["gal-img"]}
          />
          <img
            src="./img/gal/3.webp"
            alt="image alternative text"
            className={styles["gal-img"]}
          />
          <img
            src="./img/gal/4.webp"
            alt="image alternative text"
            className={styles["gal-img"]}
          />
          <img
            src="./img/gal/5.webp"
            alt="image alternative text"
            className={styles["gal-img"]}
          />
          <img
            src="./img/gal/6.webp"
            alt="image alternative text"
            className={styles["gal-img"]}
          />
          <img
            src="./img/gal/7.webp"
            alt="image alternative text"
            className={styles["gal-img"]}
          />
          <img
            src="./img/gal/8.webp"
            alt="image alternative text"
            className={styles["gal-img"]}
          />
          <img
            src="./img/gal/9.webp"
            alt="image alternative text"
            className={styles["gal-img"]}
          />
        </div>
      </div>
    </section>
  );
}

export default UserContent;
