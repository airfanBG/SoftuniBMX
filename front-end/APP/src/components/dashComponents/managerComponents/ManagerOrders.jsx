import { useEffect, useReducer } from "react";
import BoardHeader from "../BoardHeader.jsx";
import styles from "./ManagerOrders.module.css";
import Order from "./Order.jsx";
import Paginator from "../../Paginator.jsx";
import { usePagination } from "../../../customHooks/usePaginationArray.js";
import { environment } from "../../../environments/environment.js";
import LoaderWheel from "../../LoaderWheel.jsx";

const initialState = {
  orders: {},
  dataReceived: [],
  length: 0,
  page: 1,
  rerender: false,
  loading: false,
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
    case "page/isChanged":
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
  const [{ orders, dataReceived, length, page, rerender, loading }, dispatch] =
    useReducer(reducer, initialState);

  // useEffect(function () {
  //   const abortController = new AbortController();

  //   async function getOrders() {
  //     const orders = await getOrdersList();
  //     orders.sort((a, b) => a.createdAt - b.createdAt);
  //     setOrders(orders);
  //   }
  //   getOrders();

  //   return () => abortController.abort();
  // }, []);

  // function onOrdersChange(newData) {
  //   setOrders(newData);
  // }

  const path = environment.orders;
  const itemPerPage = 2;

  const data = usePagination(path);
  const dataArray = [];

  useEffect(
    function () {
      dispatch({ type: "isLoading", payload: true });
      const abortController = new AbortController();
      async function getOrdersPagination() {
        const list = await data;
        dispatch({ type: "data/received", payload: list });
        dispatch({ type: "isLoading", payload: false });
      }
      getOrdersPagination();

      return () => abortController.abort();
    },
    [rerender]
  );

  useEffect(
    function () {
      if (dataReceived.length > 0) {
        dispatch({ type: "isLoading", payload: true });

        for (let i = 0; i < dataReceived.length; i += itemPerPage) {
          const chunk = dataReceived.slice(i, i + itemPerPage);
          dataArray.push(chunk);
        }
        dispatch({ type: "orders/received", payload: dataArray[page - 1] });
        dispatch({ type: "isLoading", payload: false });
      }
    },
    [dataReceived, page, rerender]
  );

  function handlePage(page) {
    dispatch({ type: "page/isChanged", payload: page });
  }

  function onStatusChange() {
    dispatch({ type: "isLoading", payload: true });
    dispatch({ type: "toRerender" });
    dispatch({ type: "isLoading", payload: false });
  }

  if (orders.length === 0) return <h2>There is no orders in this category</h2>;
  if (orders.length > 0)
    return (
      <>
        <h2 className={styles.dashHeading}>Orders in sequence</h2>
        <section className={styles.board}>
          <BoardHeader />
          {loading && <LoaderWheel />}
          <div className={styles.orders}>
            {orders.map((order) => (
              <Order
                key={order.id}
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
        </section>
      </>
    );
}

export default ManagerOrders;
