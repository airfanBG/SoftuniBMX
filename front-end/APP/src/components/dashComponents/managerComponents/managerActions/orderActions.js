import { environment } from "../../../../environments/environment.js";
import { post } from "../../../../util/api.js";

async function approveHandlerAction(id) {
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
async function onSendHandler(id) {
  const sended = await post(`${environment.send_order}${id}`);
  return sended;
}

async function approveRejectedHandlerAction(id) {
  const approved = await post(`${environment.approve_rejected_order}${id}`);
  return approved;
}

export {
  approveHandlerAction,
  approveRejectedHandlerAction,
  onRejectHandler,
  onDeleteHandler,
  onSendHandler,
};
