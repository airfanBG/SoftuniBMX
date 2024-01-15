import styles from "./PartInfo.module.css";
import { get, post, put } from "../util/api.js";
import BoardHeader from "./dashComponents/BoardHeader.jsx";
import StarsRating from "./StarRating.jsx";
import { useState, useContext, useEffect } from "react";
import { useParams } from "react-router-dom";
import { UserContext } from "../context/GlobalUserProvider.jsx";
import { environment } from "../environments/environment.js";
import Images from "./createComponents/Images.jsx";

function PartInfo() {
  const { id } = useParams(); // id-то на детаила
  const { user } = useContext(UserContext);
  const [userRating, setUserRating] = useState(0); // рейтинга , който оставя потребителя
  const [partRating, setPartRating] = useState(0); // рейтинга на частта
  const [data, setData] = useState({});
  const [comment, setComment] = useState({});
  const [commentExists, setCommentExists] = useState(false);
  const [partOldRating, setPartOldRating] = useState(false);
  const [backgroundEdit, setBackgroundEdit] = useState(false);
  const [backgroundAdd, setBackgroundAdd] = useState(false);
  const [commentUpdated, setCommentUpdated] = useState(false);

  window.scrollTo(0, 0);

  useEffect(() => {
    async function getData(partId) {
      const result = await get(environment.find_part + partId);
      result.images = Array.from(result.images);
      setData(result);
      setPartRating(result.rating);
    }
    getData(id);

    async function getComment() {
      // try {
      //   const result = await get(
      //     environment.find_comment + user.id + `&partId=${id}`
      //   );

      //   if (result) {
      //     setComment({});
      //   } else {
      //     setComment(result);
      //   }
      // } catch {
      //   console.error("error");
      // }
      const result = await get(
        environment.find_comment + user.id + `&partId=${id}`
      );
      const receivedRating = await get(
        environment.get_client_rate + id + "&clientId=" + user.id
      );
      if (result === undefined) return;
      setComment(result);
      setCommentExists(true);
      if (receivedRating === partOldRating) return;
      setPartOldRating(receivedRating);
    }

    getComment();
  }, [id, partOldRating, user.id, commentUpdated]);

  async function addRating(r) {
    let result;

    const obj = {
      clientId: user.id,
      partId: id,
      rating: r,
    };

    if (!partOldRating) {
      result = await post(environment.set_client_rate, obj);
    } else {
      result = await put(environment.update_client_rate, obj);
    }
    setPartOldRating(r);
  }

  async function addComment(commentData) {
    try {
      const result = await post(environment.add_comment, commentData);
      if (result) {
        setCommentUpdated(!commentUpdated);
      }
    } catch (error) {
      console.error("Error adding comment:", error);
    }
  }

  async function editComment(commentData) {
    try {
      const result = await post(environment.edit_comment, commentData);
      if (result) {
        setCommentUpdated(!commentUpdated);
        setComment({});
      }
    } catch (error) {
      console.error("Error adding comment:", error);
    }
  }

  return (
    <>
      <div className={styles.wrapper}>
        <h2 className={styles.dashHeading}>Part information</h2>
        <section className={styles.board}>
          <BoardHeader />
          <div className={styles.partContainer}>
            <div className={styles.left}>
              <h2>{data.name}</h2>
              <Images imgArray={data.images} />
              <div>
                <p>Rate:</p>
                <StarsRating
                  color="#FFA81E"
                  maxRating={5}
                  onSetRating={setUserRating}
                  defaultRating={partRating}
                  submitRating={addRating}
                />
              </div>
            </div>
            <div className={styles.right}>
              <p>
                Description: <span>{data.description}</span>
              </p>
              <p>
                Intend: <span>{data.intend}</span>
              </p>
              <p>
                OEM Number: <span>{data.oemNumber}</span>
              </p>
              <p>
                Type: <span>{data.type}</span>
              </p>
              <p>
                Category: <span>{data.category}</span>
              </p>
              <p>
                Sale Price: <span>{data.salePrice}</span>
              </p>
              <p>Current rating: {partRating.toFixed(1)}</p>
            </div>
          </div>
          <div>
            {commentExists ? (
              <div className={styles.commentContainer}>
                <h3>{comment.title}</h3>
                <p>{comment.description}</p>
                <button
                  className={styles.editCommentButton}
                  onClick={() => setBackgroundEdit(true)}
                >
                  Edit Comment
                </button>
              </div>
            ) : (
              <button
                className={styles.addCommentButton}
                onClick={() => setBackgroundAdd(true)}
              >
                Add Comment
              </button>
            )}
          </div>
          {backgroundAdd && (
            <div className={styles.commentFormContainer}>
              <h3>New Comment</h3>
              <form
                onSubmit={(e) => {
                  e.preventDefault();
                  const commentData = {
                    partId: id,
                    clientId: user.id,
                    title: e.target.commentTitle.value,
                    description: e.target.commentDescription.value,
                  };
                  addComment(commentData);
                  setBackgroundAdd(false);
                }}
              >
                <label htmlFor="commentTitle">Title:</label>
                <input type="text" id="commentTitle" name="commentTitle" />

                <label htmlFor="commentDescription">Description:</label>
                <textarea id="commentDescription" name="commentDescription" />

                <button type="submit" className={styles.submitCommentButton}>
                  Send
                </button>
              </form>
            </div>
          )}
          {backgroundEdit && (
            <div className={styles.commentFormContainer}>
              <h3>Edit Comment</h3>
              <form
                onSubmit={(e) => {
                  e.preventDefault();
                  const commentData = {
                    id: comment.id,
                    partId: id,
                    clientId: user.id,
                    title: e.target.commentTitle.value,
                    description: e.target.commentDescription.value,
                  };
                  editComment(commentData);
                  setBackgroundEdit(false);
                }}
              >
                <label htmlFor="commentTitle">Title:</label>
                <input type="text" id="commentTitle" name="commentTitle" />

                <label htmlFor="commentDescription">Description:</label>
                <textarea id="commentDescription" name="commentDescription" />

                <button type="submit" className={styles.submitCommentButton}>
                  Send
                </button>
              </form>
            </div>
          )}
        </section>
      </div>
    </>
  );
}

export default PartInfo;
