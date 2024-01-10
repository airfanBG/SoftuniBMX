import { get, post } from "./api.js";
import { clearOrderData, clearUserData, setUserData } from "./util.js";
import { environment } from "../environments/environment.js";

//TODO Change user object according to project requirements

export async function login(user) {
  // Clients and Employers has different login paths
  const path =
    user.email.split("@").at(1) === "b-free.com"
      ? environment.login_employee
      : environment.login_client;

  const result = await post(path, user);
  if (!result.token) return;
  if (result.role === "worker" || result.role === "manager") {
    clearOrderData();
  }
  return result;
}

export async function register(user) {
  let result;
  console.log(user);
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
