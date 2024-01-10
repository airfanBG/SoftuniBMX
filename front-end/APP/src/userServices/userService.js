import { environment } from "../environments/environment.js";
import { get, put } from "../util/api.js";

async function userInfo(id, role) {
  const result =
    role === "user"
      ? await get(environment.info_client + id)
      : await get(environment.info_employee + id);
  return result;
}

function updateUserData(id, data, role) {
  let result;
  if (role === "user") {
    result = put(environment.update_client, data);
  } else {
    // result = put(environment.update_employee + id, data);
  }
  return result;
}

export { userInfo, updateUserData };
