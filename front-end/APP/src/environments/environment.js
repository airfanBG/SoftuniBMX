export const environment = {
  BASE_URL: "https://localhost:7047",

  // AUTH
  login_client: "/api/client/login",
  login_employee: "/api/employee/login",
  register_client: "/api/client/register",
  register_employee: "/api/employee/register",
  reset_client: "/api/client/reset?email=", // + user email
  reset_employee: "/api/employee/reset?email=", // + user email,

  // INDEX_PAGE
  indexPage: "/api/home/index",

  // CLIENT
  update_client: "/api/client/edit/", // + id
  info_client: "/api/client/info?id=", // + id
  create_order: "/api/client_order/create",

  // EMPLOYEE
  info_employee: "/api/employee/info?id=", // + id
  worker_order_queue: "/api/employee_order/myOrders?id=",
  worker_order_start: "/api/employee_order/start",
  worker_order_end: "/api/employee_order/end",
  worker_order: "/api/employee_order/",

  // QUALITY_CONTROL
  quality_assurance: "/api/employee_order/quality_assurance",
  pass_qControl: "/api/employee_order/quality_assurance?orderId=",
  return_qControl: "/api/employee_order/quality_assurance_return",

  // MANAGER
  pending_orders: "/api/manager/pending_orders?page=",
  approve_order: "/api/manager/approve_order?orderId=", // + id
  reject_order: "/api/manager/reject_order?orderId=", // + id
  del_order: "/api/manager/delete_order?orderId=", // +id
  in_progress_orders: "/api/manager/orders_in_progress",

  // BIKE_SERVICES
  frames: "/api/accountpage/frames",
  compatible_parts: "/api/accountpage/compatible_parts?id=",
  selected_part: "/api/accountpage/selected_part?id=",
};
