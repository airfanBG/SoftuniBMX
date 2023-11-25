import { environment } from "../environments/environment_dev.js";
import { get, put } from "../util/api.js";

function userInfo(id) {
  const result = get(environment.INFO_CLIENT + id);
  return result;
}

function updateUserData(id, data) {
  const result = put(environment.UPDATE_CLIENT + id, data);
  return result;
}

export { userInfo, updateUserData };
