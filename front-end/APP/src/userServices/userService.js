import { environment } from "../environments/environment_dev.js";
import { get, put } from "../util/api.js";

function userInfo(id) {
  const result = get(environment.info_client + id);
  return result;
}

function updateUserData(id, data) {
  let result;
  if (data.role === "user") {
    result = put(environment.update_client + id, data);
  } else {
    result = put(environment.update_employee + id, data);
  }
  return result;
}

export { userInfo, updateUserData };
