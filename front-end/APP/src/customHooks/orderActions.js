import { environment } from "../environments/environment.js";
import { post } from "../util/api.js";

async function approveHandlerAction(id) {
  // const approved = {};
  // console.log("approved");
  const approved = await post(`${environment.approve_order}${id}`);
  return approved;
}

async function onRejectHandler(id) {
  const rejected = await post(`${environment.reject_order}${id}`);
  return rejected;
}
async function onDeleteHandler(id) {
  const deleted = await post(`${environment.del_order}${id}`);
  return deleted;
}

export { approveHandlerAction, onRejectHandler, onDeleteHandler };
