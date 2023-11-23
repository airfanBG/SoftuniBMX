import { environment } from "../environments/environment_dev.js";
import { get } from "../util/api.js";

function userInfo(id) {
  const result = get(environment.INFO_CLIENT + id);
  return result;
}

export { userInfo };
