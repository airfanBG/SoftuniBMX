import { get, post } from "./api.js";
import { clearOrderData, clearUserData, setUserData } from "./util.js";
import { environment } from "../environments/environment.js";

//TODO Change user object according to project requirements

//TODO: different endpoints for user and employee!!!!

export async function login(user) {
  const result = await post(environment.login, user);
  if (!result.accessToken) return;
  if (result.user.role === "worker" || result.user.role === "manager")
    clearOrderData();
  // setUserData(result);
  return result;
}

export async function register(user) {
  let result;
  if (user.email.includes("@b-free.com")) {
    result = await post(environment.register_employee, user);
  } else {
    result = await post(environment.register_client, user);
  }
  return result;
}

export async function logout() {
  // TODO: разбери се с Краси какво ще става тук!!!
  // get(environment.logout);
  clearUserData();
}
