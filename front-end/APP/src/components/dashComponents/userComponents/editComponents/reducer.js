function reducer(state, action) {
  switch (action.type) {
    case "setFirstName":
      return { ...state, firstName: action.payload };
    case "setLastName":
      return { ...state, lastName: action.payload };
    case "setEmail":
      return { ...state, email: action.payload };
    case "setIban":
      return { ...state, iban: action.payload };
    case "setCity":
      return { ...state, city: action.payload };
    case "setPhone":
      return { ...state, phone: action.payload };
    case "setBalance":
      return { ...state, balance: Number(action.payload) };
    case "setCountry":
      return { ...state, country: action.payload };
    case "setPostCode":
      return { ...state, postCode: action.payload };
    case "setDistrict":
      return { ...state, district: action.payload };
    case "setBlock":
      return { ...state, block: action.payload };
    case "setFloor":
      return { ...state, floor: action.payload };
    case "setApartment":
      return { ...state, apartment: action.payload };
    case "setStreet":
      return { ...state, street: action.payload };
    case "setStrNumber":
      return { ...state, strNumber: action.payload };
    case "setImage":
      return { ...state, imageUrl: action.payload };

    default:
      throw new Error(" Unknown action type");
  }
}

export { reducer };
