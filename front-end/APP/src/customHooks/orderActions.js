import { useContext } from "react";
import { getElement, getOrder } from "../bikeServices/service.js";
import { environment } from "../environments/environment_dev.js";
import { del, post } from "../util/api.js";
import { OrdersContext } from "../context/GlobalUserProvider.jsx";

async function approveHandlerAction(id) {
  // TODO: uncomment approved
  const approved = post(`${environment.approve_order}` + id);
  // TODO: remove! only for json server
  await del(`${environment.del_order}${id}`);
  return approved;
}

function onRejectHandler(id) {
  console.log("In process" + id);
}
function onDeleteHandler(id) {
  console.log("In process" + id);
}

export { approveHandlerAction, onRejectHandler, onDeleteHandler };
