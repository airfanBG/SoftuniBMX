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

  // CLIENT_ORDER
  create_order: "/api/client_order/create",
  orders_in_progress: "/api/client_order/progress?id=", // + id,
  delete_order: "/api/client_order/delete",
  orders_ready: "/api/client_order/get_orders_ready?clientId=", // + id
  orders_archive: "/api/client_order/get_orders_archive?clientId=", // + id
  find_order: "/api/client_order/find?orderId=", // + id
  update_balance: "/api/client/bankUpdate",
  rest_payment: "/api/client_order/payment?",

  // EMPLOYEE
  info_employee: "/api/employee/info?id=", // + id
  worker_order_queue: "/api/employee_order/myOrders?id=",
  worker_order_start: "/api/employee_order/start",
  worker_order_end: "/api/employee_order/end",
  worker_order: "/api/employee_order/",
  worker_times: "/api/manager_statistics?employeeId=",
  worker_get_salary: "/api/employee/get_salary?employeeId=",

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
  rejected_orders_list: "/api/manager/rejected_orders/",
  all_employees: "/api/manager/all_employees",
  finished_orders: "/api/manager/finished_orders",
  send_order: "/api/manager/send_order?orderId=", // +id
  sended_orders: "/api/manager/sended_orders",
  pay_salary: "/api/worker_management/salary",

  //SIUPLY_MANAGER
  parts_in_stock: "/api/supplys_manager/parts_in_stock?page=",
  deleted_orders_list: "/api/manager/deleted_orders?page=",
  suppliers_list: "/api/supplys_manager/supliers",

  // BIKE_SERVICES
  frames: "/api/accountpage/frames",
  compatible_parts: "/api/accountpage/compatible_parts?id=",
  selected_part: "/api/accountpage/selected_part?id=",

  //STORAGE
  add_supplier: "/api/supplys_manager/create_suplier",

  //PART
  find_part: "/api/part/find?partId=", // + id
};
