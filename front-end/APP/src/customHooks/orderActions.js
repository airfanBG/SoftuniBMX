import { useContext } from "react";
import { getElement, getOrder } from "../bikeServices/service.js";
import { environment } from "../environments/environment_dev.js";
import { del } from "../util/api.js";
import { OrdersContext } from "../context/GlobalUserProvider.jsx";

async function useApproveHandler(id) {
  const { orders, onOrdersChange } = useContext(OrdersContext);
  // const { frame, wheel, accessory, createdAt, count, ownerId, id } = order;

  // const approvedOrder = {
  //   frame,
  //   wheel,
  //   accessory,
  //   frameStartedTime: "",
  //   frameFinishedTime: "",
  //   wheelStartedTime: "",
  //   wheelFinishedTime: "",
  //   accessoryStartedTime: "",
  //   accessoryFinishedTime: "",
  //   count,
  //   createdAt,
  //   id: id,
  //   customerId: ownerId,
  // };

  // console.log(approvedOrder);
  console.log(id);

  // const approve = await del(environment.del_order + id);
  // console.log(approve);
  // onApprove((o) => Object.values((orders) => console.log(x)));
}

function onRejectHandler(id) {
  console.log("In process" + id);
}
function onDeleteHandler(id) {
  console.log("In process" + id);
}

export { useApproveHandler, onRejectHandler, onDeleteHandler };
