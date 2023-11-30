import { createContext, useEffect, useState } from "react";
import { clearOrderData, getOrderData, getUserData } from "../util/util.js";
import { getList } from "../bikeServices/service.js";

export const UserContext = createContext();

function GlobalUser({ children }) {
  const [user, setUser] = useState("");
  const [hasOrder, setHasOrder] = useState(false);

  useEffect(function () {
    const data = getUserData();
    if (data) {
      setUser(data);
    }

    const order = getOrderData();
    if (order && user.role === "user") {
      setHasOrder(true);
    } else {
      clearOrderData();
      setHasOrder(false);
    }
  }, []);

  function updateUser(userData) {
    setUser(userData);
  }

  return (
    <UserContext.Provider value={{ user, updateUser, hasOrder, setHasOrder }}>
      {children}
    </UserContext.Provider>
  );
}

export const OrdersContext = createContext();

function OrdersManager({ children }) {
  const [orders, setOrders] = useState({});

  useEffect(function () {
    const abortController = new AbortController();

    async function getOrders() {
      const orders = await getList("orders");
      orders.sort((a, b) => a.createdAt - b.createdAt);
      setOrders(orders);
    }
    getOrders();

    return () => abortController.abort();
  }, []);

  function onOrdersChange(newData) {
    setOrders(newData);
  }

  return (
    <OrdersContext.Provider
      value={{
        orders,
        onOrdersChange,
      }}
    >
      {children}
    </OrdersContext.Provider>
  );
}

export { GlobalUser, OrdersManager };
