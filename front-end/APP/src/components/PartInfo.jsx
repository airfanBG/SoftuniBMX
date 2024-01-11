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
      try {
        const result = await get(
          environment.find_comment + user.id + `&partId=${id}`
        );

        if (result) {
          setComment({});
        } else {
          setComment(result);
        }
      } catch {
        console.error("error");
      }
    }

    getComment();
  }, [id, user.id]);

  useEffect(() => {
    async function addRating() {
      const result = await get(
        environment.get_client_rate + id + "&clientId=" + user.id
      );
      if (result === false) {
        const obj = {
          clientId: user.id,
          partId: id,
          rating: userRating,
        };
        const r = await post(environment.set_client_rate, obj);
      } else {
        /*const r = await put(environment.update_client_rate, {
          clientId: userId,
          partId: partId,
          rating: userRating,
        });*/
        console.log("put");
      }
    }

    addRating();
  }, [userRating, id, user.id]);

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
              <p>Current rating: {partRating}</p>
            </div>
          </div>
          <div>coment</div>
        </section>
      </div>
    </>
  );
}

export default PartInfo;
