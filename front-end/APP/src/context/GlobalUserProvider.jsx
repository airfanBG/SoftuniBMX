import { createContext, useEffect, useState } from "react";
import { getUserData } from "../util/util.js";

export const UserContext = createContext();

function GlobalUser({ children }) {
  const [user, setUser] = useState("");

  useEffect(function () {
    const data = getUserData();
    if (data) {
      setUser(data);
    }
  }, []);

  function updateUser(userData) {
    setUser(userData);
  }

  return (
    <UserContext.Provider value={{ user, updateUser }}>
      {children}
    </UserContext.Provider>
  );
}

export { GlobalUser };
