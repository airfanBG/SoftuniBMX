import { useEffect, useReducer } from "react";
import BoardHeader from "../BoardHeader.jsx";
import styles from "./ManagerOrders.module.css";
import Order from "./Order.jsx";
import Paginator from "../../Paginator.jsx";
import { usePagination } from "../../../customHooks/usePaginationArray.js";
import { environment } from "../../../environments/environment.js";
import LoaderWheel from "../../LoaderWheel.jsx";
import { get } from "../../../util/api.js";

const initialState = {
  orders: {},
  dataReceived: [],
  length: 0,
  page: 1,
  rerender: false,
  loading: false,
  itemPerPage: 6,
};

function reducer(state, action) {
  switch (action.type) {
    case "orders/received":
      return { ...state, orders: action.payload };
    case "data/received":
      return {
        ...state,
        dataReceived: action.payload,
        length: action.payload.length,
      };
    case "length/isSet":
      return { ...state, length: action.payload };
    case "page/hasChanged":
      return { ...state, page: action.payload };
    case "toRerender":
      return { ...state, rerender: !state.rerender };
    case "isLoading":
      return { ...state, loading: action.payload };

    default:
      throw new Error("Unknown action type");
  }
}

function ManagerOrders() {
  const [{ orders, length, page, rerender, loading, itemPerPage }, dispatch] =
    useReducer(reducer, initialState);

  useEffect(
    function () {
      dispatch({ type: "isLoading", payload: true });
      const abortController = new AbortController();
      async function getOrdersPagination() {
        const data = await get(environment.pending_orders + page);
        // console.log(data);

        dispatch({ type: "length/isSet", payload: data.totalOrdersCount });
        dispatch({ type: "orders/received", payload: data.orders });
        dispatch({ type: "isLoading", payload: false });
        if (Math.ceil(data.totalOrdersCount / itemPerPage) < page) {
          dispatch({ type: "page/hasChanged", payload: 1 });
        }
      }
      getOrdersPagination();

      return () => abortController.abort();
    },
    [rerender, page, itemPerPage]
  );

  function handlePage(page) {
    dispatch({ type: "page/hasChanged", payload: page });
  }

  function onStatusChange() {
    dispatch({ type: "isLoading", payload: true });
    dispatch({ type: "toRerender" });
    dispatch({ type: "isLoading", payload: false });
    // console.log("re-render");
  }

  return (
    <>
      <h2 className={styles.dashHeading}>Orders in sequence</h2>
      <section className={styles.board}>
        <BoardHeader />
        {loading && <LoaderWheel />}
        {orders && orders.length > 0 && (
          <>
            <div className={styles.orders}>
              {orders.map((order) => (
                <Order
                  key={order.orderId}
                  order={order}
                  onStatusChange={onStatusChange}
                />
              ))}
            </div>
            <Paginator
              page={page}
              pages={length}
              countOnPage={itemPerPage}
              size={24}
              fontSize={1.6}
              // bgColor=""
              // brColor=""
              brRadius={3}
              handlePage={handlePage}
              // selected="red"
            />
          </>
        )}
        {orders.length === 0 && (
          <h2 style={{ margin: "2rem 0" }}>
            There is no orders in this category
          </h2>
        )}
      </section>
    </>
  );
}

export default ManagerOrders;
