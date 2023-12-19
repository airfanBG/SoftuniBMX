import styles from "./ManagerRejected.module.css";

import { useContext, useEffect, useReducer, useState } from "react";

import { UserContext } from "../../../context/GlobalUserProvider.jsx";

import BoardHeader from "../BoardHeader.jsx";
import LoaderWheel from "../../LoaderWheel.jsx";
import { get } from "../../../util/api.js";

const initialState = {
  loading: false,
  status: false,
};

function reducer(state, action) {
  switch (action.type) {
    case "loading/action":
      return { ...state, loading: true };
    case "component/rerender":
      return { ...state, status: !state.status };

    default:
      throw new Error("Unknown action type");
  }
}

function ManagerRejected() {
  const { user } = useContext(UserContext);
  const [{ loading, status }, dispatch] = useReducer(reducer, initialState);

  useEffect(function () {
    async function getOrders() {
      const result = await get();
    }
    getOrders();
  }, []);

  function rerender() {
    dispatch({ type: "component/rerender" });
  }

  return (
    <>
      <h2 className={styles.dashHeading}>Selected items</h2>

      <section className={styles.board}>
        <BoardHeader />
        {loading && <LoaderWheel />}
      </section>
    </>
  );
}

export default ManagerRejected;
