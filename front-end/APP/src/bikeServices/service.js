import { environment } from "../environments/environment_dev.js";
import { get } from "../util/api.js";

async function getFrames() {
  const data = await get(environment.frames);
  return data;
}

// TODO: changed to project route without server filter. Response will return full collection. Must be filtered by criteria
async function getWheels(criteria) {
  console.log(criteria);
  const data = await get(`${environment.wheels}?type=${criteria}`);
  return data;
}
// TODO: changed to project route without server filter. Response will return full collection. Must be filtered by criteria
async function getParts(criteria) {
  const data = await get(`${environment.accessories}?type=${criteria}`);
  return data;
}

async function getOneFrame(id) {
  const data = await get(environment.frames + id);
  return data;
}
async function getOneWheel(id) {
  const data = await get(environment.wheels + id);
  return data;
}

async function getOnePart(id) {
  const data = await get(environment.accessories + id);
  return data;
}

export { getOneFrame, getFrames, getWheels, getOneWheel, getParts, getOnePart };
