import { Link } from "react-router-dom";
import styles from "./Comment.module.css";

function Comment({ comment }) {
  const userImg = comment.clientImageUrl;

  const onImageError = (e) => {
    e.target.src = "/img/icons8-user-64.png";
  };
  return (
    <figure className={styles.comment}>
      <div className={`${styles["user"]} ${styles["m-bottom-20"]}`}>
        <img
          src={userImg ? userImg : "/img/icons8-user-64.png"}
          alt="user photo"
          className={styles.avatar}
          onError={onImageError}
        />

        <div className={styles.header}>
          <div>
            <p className={styles["user-name"]}>{comment.clientFullName}</p>
            <p className={styles["post-date"]}>
              {comment.dateCreated.replaceAll("/", ".")}
            </p>
          </div>

          <p className={styles.commentedPart}>
            <Link
              to={`/app/part/${comment.partId}`}
              alt="Part, commented by user"
            >
              {comment.partName}
              {/* {comment.partId} */}
            </Link>
          </p>
        </div>
      </div>
      <div className={styles["post-content"]}>
        {/* <p> */}
        <q>{comment.commentDescription}</q>
        <div className={styles.commentOverflow}></div>
        {/* </p> */}
        {/* <div className={styles.likes}>
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
        </div> */}
      </div>
    </figure>
  );
}

export default Comment;
