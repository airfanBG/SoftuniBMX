import { createContext, useContext, useEffect, useReducer } from "react";
import { getUserData } from "../util/util.js";

const AuthContext = createContext();

const initialState = {
  userAuth: null,
  isAuthenticated: false,
};

function reducer(state, action) {
  switch (action.type) {
    case "hasUser":
      return { ...state, userAuth: action.payload, isAuthenticated: true };
    case "login":
      return { ...state, userAuth: action.payload, isAuthenticated: true };
    case "logout":
      return { ...state, userAuth: null, isAuthenticated: false };
    default:
      throw new Error(" Unknown action type");
  }
}

function AuthProvider({ children }) {
  const [{ userAuth, isAuthenticated }, dispatch] = useReducer(
    reducer,
    initialState
  );

  useEffect(function () {
    const user = getUserData();
    if (user) {
      dispatch({ type: "hasUser", payload: user });
    }
  }, []);

  function loginUser(user) {
    // ще го запиша след респонса от сървъра
    dispatch({ type: "login", payload: user });
  }

  function logoutUser() {
    dispatch({ type: "logout" });
  }

  return (
    <AuthContext.Provider
      value={{ userAuth, isAuthenticated, loginUser, logoutUser }}
    >
      {children}
    </AuthContext.Provider>
  );
}

function useAuth() {
  const context = useContext(AuthContext);

  if (context === undefined)
    throw new Error("AuthContext is used outside AuthProvider");

  return context;
}

export { AuthProvider, useAuth };
