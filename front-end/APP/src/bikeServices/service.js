import { dataPath } from "../environments/path.js";
import { get } from "../util/api.js";

async function getFrames() {
  const data = await get(dataPath.FRAMES);
  return data;
}
async function getOneFrames(id) {
  const data = await get(dataPath.FRAMES + id);
  return data;
}

export { getOneFrames, getFrames };
