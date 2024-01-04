import { createContext, useContext, useReducer } from "react";

const ErrorContext = createContext();

const initialState = {
  error: false,
  message: "",
};

function reducer(state, action) {
  switch (action.type) {
    case "error/set":
      return { ...state, error: action.payload };
    case "error/message":
      return { ...state, message: action.payload };
    case "error/clear":
      return { ...state, error: false, message: "" };

    default:
      throw new Error("Unknown action type");
  }
}
function ErrorProvider({ children }) {
  const [{ error, message }, dispatch] = useReducer(reducer, initialState);

  function errorHandler(error) {
    console.log("error");
    if (error !== "") {
      dispatch({ type: "error/set", payload: error });
      dispatch({ type: "error/message", payload: true });
    } else if (error === "") {
      dispatch({ type: "error/clear" });
    }
  }

  return (
    <ErrorContext.Provider value={{ error, message, errorHandler }}>
      {children}
    </ErrorContext.Provider>
  );
}

function useError() {
  const context = useContext(ErrorContext);
  if (context === undefined) {
    throw new Error("ErrorContext is used outside of the ErrorContextProvider");
  }
  return context;
}

export { ErrorProvider, useError };
