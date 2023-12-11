import styles from "./QControlOrders.module.css";

import { useEffect, useReducer } from "react";
import LoaderWheel from "../../LoaderWheel.jsx";
import Paginator from "../../Paginator.jsx";
import BoardHeader from "../BoardHeader.jsx";
import { get } from "../../../util/api.js";
import { environment } from "../../../environments/environment_dev.js";
import QControlOrderItem from "./QControlOrderItem.jsx";

const initialState = {
  loading: false,
  orderList: [],
  error: { message: "" },
  page: 1,
  itemPerPage: 1,
  length: "",
  chunkData: [],
  status: true,
};

function reducer(state, action) {
  switch (action.type) {
    case "isLoading":
      return { ...state, loading: action.payload };
    case "hasError":
      return { ...state, message: "" };
    case "orders/hasOrders":
      return { ...state, orderList: action.payload };
    case "setLength":
      return { ...state, length: action.payload };
    case "page/changed":
      return { ...state, page: action.payload };
    case "hasChunk":
      return { ...state, chunkData: action.payload };
    case "rerender":
      return { ...state, status: !state.status };
    default:
      throw new Error("Unknown action type");
  }
}

function QControlOrders() {
  const [
    { loading, orderList, error, page, itemPerPage, length, chunkData, status },
    dispatch,
  ] = useReducer(reducer, initialState);
  const dataArray = [];

  useEffect(
    function () {
      dispatch({ type: "isLoading", payload: true });
      const abortController = new AbortController();
      async function getOrders() {
        const result = await get(environment.quality_assurance);
        if (!result) {
          dispatch({ type: "isLoading", payload: false });
          return dispatch({
            type: "hasError",
            payload: "Something went wrong. Service can not get data!",
          });
        }
        // const finished = result.filter((x) => {
        //   if (
        //     x.orderStates[0].isProduced === true &&
        //     x.orderStates[1].isProduced === true &&
        //     x.orderStates[2].isProduced === true
        //   )
        //     return x;
        // });
        const finished = result.slice();
        for (let i = 0; i < finished.length; i += itemPerPage) {
          const chunk = finished.slice(i, i + itemPerPage);
          dataArray.push(chunk);
        }
        dispatch({ type: "hasChunk", payload: dataArray });
        dispatch({ type: "setLength", payload: finished.length });
      }
      getOrders();

      return () => abortController.abort();
    },
    [status]
  );

  useEffect(
    function () {
      dispatch({ type: "orders/hasOrders", payload: chunkData[page - 1] });
      dispatch({ type: "isLoading", payload: false });
    },
    [chunkData, page]
  );

  function handlePage(page) {
    dispatch({ type: "page/changed", payload: page });
  }

  function reBuild() {
    dispatch({ type: "isLoading", payload: true });
    dispatch({ type: "rerender" });
    dispatch({ type: "isLoading", payload: false });
  }
  return (
    <>
      <h2 className={styles.dashHeading}>Finished Orders</h2>
      <section className={styles.board}>
        <BoardHeader />

        {loading && <LoaderWheel />}
        <div className={styles.orders}>
          {orderList &&
            orderList.map((order) => (
              <QControlOrderItem
                product={order}
                key={order.orderId}
                // onBtnHandler={onBtnHandler}
                orderId={order.id}
                onReBuild={reBuild}
              />
            ))}
        </div>
        <div className={styles.paginator}>
          <Paginator
            page={page}
            pages={length}
            countOnPage={itemPerPage}
            size={24}
            fontSize={1.6}
            // bgColor="red"
            // brColor=""
            brRadius={3}
            handlePage={handlePage}
            // selected="red"
          />
        </div>
      </section>
    </>
  );
}

export default QControlOrders;
