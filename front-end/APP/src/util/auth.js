import { get, post } from "./api.js";
import { clearUserData, setUserData } from "./util.js";
import { environment } from "../environments/environment.js";

const endpoints = {
  login: environment.LOGIN,
  register: environment.REGISTER,
  logout: environment.LOGOUT,
};

//TODO Change user object according to project requirements

export async function login(user) {
  const result = await post(endpoints.login, user);
  console.log(result);
  setUserData(result);
  return result;
}

export async function register(user) {
  const result = await post(endpoints.register, user);
  return result;
}

export async function logout() {
  get(endpoints.logout);
  clearUserData();
}
