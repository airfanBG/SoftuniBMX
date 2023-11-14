const itemName = "userData";

export const EMAIL_REGEX =
  /^[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?$/;

export const PASS_REGEX = /^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[a-zA-Z]).{6,}$/;

export function getUserData() {
  return JSON.parse(localStorage.getItem(itemName));
}

export function setUserData(data) {
  return localStorage.setItem(itemName, JSON.stringify(data));
}

export function clearUserData() {
  localStorage.removeItem(itemName);
}
