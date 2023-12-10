import { getElement, getOrder } from "../../../../bikeServices/service.js";

function onApproveHandler(order) {
  const { frame, wheel, accessory, createdAt, count, ownerId, id } = order;
  const approvedOrder = {
    frame,
    wheel,
    accessory,
    frameStartedTime: "",
    frameFinishedTime: "",
    wheelStartedTime: "",
    wheelFinishedTime: "",
    accessoryStartedTime: "",
    accessoryFinishedTime: "",
    count,
    createdAt,
    id: id,
    customerId: ownerId,
  };

  console.log(approvedOrder);
}

function onRejectHandler(id) {
  console.log("In process" + id);
}
function onDeleteHandler(id) {
  console.log("In process" + id);
}

export { onApproveHandler, onRejectHandler, onDeleteHandler };
