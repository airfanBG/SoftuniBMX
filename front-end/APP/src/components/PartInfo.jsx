import styles from "./PartInfo.module.css";

import BoardHeader from "./dashComponents/BoardHeader.jsx";
import StarsRating from "./StarRating.jsx";
import { useState } from "react";
import { useParams } from "react-router-dom";

function PartInfo() {
  const { id } = useParams(); // id-то на детаила
  const [userRating, setUserRating] = useState(0); // рейтинга , който оставя потребителя
  const [partRating, setPartRating] = useState(0); // рейтинга на частта
  window.scrollTo(0, 0);

  return (
    <>
      <div className={styles.wrapper}>
        <h2 className={styles.dashHeading}>Part information</h2>
        <section className={styles.board}>
          <BoardHeader />
          <StarsRating
            color="#FFA81E"
            maxRating={5}
            onSetRating={setUserRating}
            defaultRating={partRating}
          />
          ;
        </section>
      </div>
    </>
  );
}

export default PartInfo;
