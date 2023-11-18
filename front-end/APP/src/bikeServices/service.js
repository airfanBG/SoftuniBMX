import { dataPath } from "../environments/path.js";
import { get } from "../util/api.js";

async function getFrames() {
  const data = await get(dataPath.frames);
  return data;
}

async function getWheels(criteria) {
  const data = await get(
    `${dataPath.wheels}?where=type%20LIKE%20%22${criteria}%22`
  );
  return data;
}

async function getParts(criteria) {
  const data = await get(
    `${dataPath.parts}?where=type%20LIKE%20%22${criteria}%22`
  );
  return data;
}

async function getOneFrame(id) {
  const data = await get(dataPath.frames + id);
  return data;
}
async function getOneWheel(id) {
  const data = await get(dataPath.wheels + id);
  return data;
}

async function getOnePart(id) {
  const data = await get(dataPath.parts + id);
  return data;
}

export { getOneFrame, getFrames, getWheels, getOneWheel, getParts, getOnePart };
