import styles from "./AddMember.module.css";

import BoardHeader from "../BoardHeader.jsx";

function AddMember() {
  return (
    <section className={styles.board}>
      <BoardHeader />
    </section>
  );
}

export default AddMember;
