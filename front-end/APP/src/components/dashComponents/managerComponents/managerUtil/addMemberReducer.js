const initialState = {
  email: "",
  password: "",
  firstName: "",
  lastName: "",
  repass: "",
  userRole: "",
  department: "",
  phoneNumber: "",
  position: "",
  dateOfHire: "",
  isManager: false,
  imageUrl: "",
  error: {
    "firstName/input": "",
    "lastName/input": "",
    "email/input": "",
    "password/input": "",
    "repass/input": "",
  },
};

function reducer(state, action) {
  switch (action.type) {
    case "firstName/input":
      return { ...state, firstName: action.payload };
    case "lastName/input":
      return { ...state, lastName: action.payload };
    case "email/input":
      return { ...state, email: action.payload };
    case "password/input":
      return { ...state, password: action.payload };
    case "repass/input":
      return { ...state, repass: action.payload };
    case "role/select":
      return { ...state, userRole: action.payload };
    case "department/select":
      return { ...state, department: action.payload };
    case "position/select":
      return { ...state, position: action.payload };
    case "date/set":
      return { ...state, dateOfHire: action.payload };
    case "isManager/set":
      return { ...state, isManager: action.payload };
    case "phone/input":
      return { ...state, phoneNumber: action.payload };
    case "error/set":
      return { ...state, error: { ...state.error, [action.payload]: true } };
    case "error/clear":
      return { ...state, error: { ...state.error, [action.payload]: false } };

    default:
      throw new Error("Unknown action type");
  }
}

export { reducer, initialState };
