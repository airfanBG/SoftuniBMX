import { environment } from "../environments/environment_dev.js";
import { get } from "../util/api.js";

async function useEmployers() {
  // const emp = await get(environment.INFO_EMPLOYEE);
  const emp = await get(environment.GET_ALL_EMPLOYERS);
  return emp;
}

export { useEmployers };
