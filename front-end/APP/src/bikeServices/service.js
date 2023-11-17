import { dataPath } from "../environments/path.js";
import { get } from "../util/api.js";

async function getFrames() {
  const data = await get(dataPath.frames);
  return data;
}
async function getOneFrame(id) {
  const data = await get(dataPath.frames + id);
  return data;
}

export { getOneFrame, getFrames };
