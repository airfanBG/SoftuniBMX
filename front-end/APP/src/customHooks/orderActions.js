import { useContext } from "react";
import { getElement, getOrder } from "../bikeServices/service.js";
import { environment } from "../environments/environment_dev.js";
import { del, post } from "../util/api.js";
import { OrdersContext } from "../context/GlobalUserProvider.jsx";

async function approveHandlerAction(id) {
  // TODO: uncomment approved when in production
  // const approved = await post(`${environment.approve_order}`, { orderId: id });
  console.log("approving order " + id);
  onDeleteHandler(id);
  // return approved;
  return;
}

async function onRejectHandler(id) {
  console.log("In process" + id);
  // const rejected = await post(`${environment.reject_order}`, { orderId: id });
  // return rejected;
}
async function onDeleteHandler(id) {
  // TODO: remove! only for json server
  console.log("deleing order " + id);
  const res = await del(`${environment.del_order}${id}`);

  // TODO: uncomment when in production
  // await post(`${environment.del_order}${id}`);
  // return res;
  return;
}

export { approveHandlerAction, onRejectHandler, onDeleteHandler };
