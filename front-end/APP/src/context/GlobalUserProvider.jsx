import { createContext, useEffect, useState } from "react";
import { getOrderData, getUserData } from "../util/util.js";

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
    if (order) setHasOrder(true);
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

export { GlobalUser };
