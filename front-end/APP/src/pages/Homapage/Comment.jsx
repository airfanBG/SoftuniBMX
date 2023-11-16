import styles from "./Comment.module.css";

function Comment() {
  return (
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
            Lorem ipsum dolor sit amet consectetur adipisicing elit. Explicabo
            reiciendis obcaecati repellendus quibusdam nemo cum asperiores
            ratione, dolor id error. s
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
  );
}

export default Comment;
