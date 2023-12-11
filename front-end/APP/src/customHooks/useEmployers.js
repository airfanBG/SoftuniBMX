import { environment } from "../environments/environment_dev.js";
import { get } from "../util/api.js";

async function useEmployers() {
  // const emp = await get(environment.info_emplloyee);
  const emp = await get(environment.get_all_employers);
  return emp;
}
async function getEmployers() {
  // const emp = await get(environment.info_emplloyee);
  const emp = await get(environment.get_all_employers);
  return emp;
}

export { useEmployers, getEmployers };
