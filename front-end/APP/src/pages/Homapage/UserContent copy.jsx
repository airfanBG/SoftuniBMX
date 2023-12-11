import styles from "./UserContent.module.css";

function UserContent() {
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
          <figure className={styles.comment}>
            <div className={`${styles["user"]} ${styles["m-bottom-20"]}`}>
              <img
                src="https://images.unsplash.com/photo-1520813792240-56fc4a3765a7?ixlib=rb-1.2.1&q=80&fm=jpg&crop=faces&fit=crop&h=200&w=200&ixid=eyJhcHBfaWQiOjE3Nzg0fQ"
                alt="user photo"
                className={styles.avatar}
              />
              <div>
                <p className={styles["user-name"]}>Wilma Flintstone</p>
                <p className={styles["post-date"]}>09 Jun 2020</p>
              </div>
            </div>
            <div className={styles["post-content"]}>
              <p>
                <q>
                  Lorem ipsum dolor sit amet consectetur adipisicing elit.
                  Explicabo reiciendis obcaecati repellendus quibusdam nemo cum
                  asperiores ratione, dolor id error. s
                </q>
              </p>
              <div className={styles.likes}>
                <p>
                  <i className="fa-regular fa-thumbs-up likes-fa-icon" />
                  <span>Like</span>
                </p>
                <p>
                  <i className="fa-regular fa-comment likes-fa-icon" />
                  <span>Replay</span>
                </p>
                <p>
                  <i className="fa-regular fa-share-from-square likes-fa-icon" />
                  <span>Share</span>
                </p>
              </div>
            </div>
          </figure>
          <figure className={styles.comment}>
            <div className={`${styles["user"]} ${styles["m-bottom-20"]}`}>
              <img
                src="https://randomuser.me/api/portraits/men/84.jpg"
                alt="user photo"
                className={styles.avatar}
              />
              <div>
                <p className={styles["user-name"]}>Fred Flintstone</p>
                <p className={styles["post-date"]}>23 Oct 2023</p>
              </div>
            </div>
            <div className={styles["post-content"]}>
              <p>
                <q>
                  Lorem ipsum dolor sit amet consectetur adipisicing elit.
                  Explicabo reiciendis obcaecati repellendus quibusdam nemo cum
                  asperiores ratione, dolor id error. s
                </q>
              </p>
              <div className={styles.likes}>
                <p>
                  <i className="fa-regular fa-thumbs-up likes-fa-icon" />
                  <span>Like</span>
                </p>
                <p>
                  <i className="fa-regular fa-comment likes-fa-icon" />
                  <span>Replay</span>
                </p>
                <p>
                  <i className="fa-regular fa-share-from-square likes-fa-icon" />
                  <span>Share</span>
                </p>
              </div>
            </div>
          </figure>
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
