import { environment } from "../environments/environment_dev.js";
import { get } from "../util/api.js";

async function useEmployers() {
  const emp = await get(environment.INFO_EMPLOYEE);
  return emp;
}

export { useEmployers };
