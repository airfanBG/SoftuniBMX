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
  // update_client: "/users/", // + id
  // info_client: "/users/", // + id

  // EMPLOYEE
  // update_employee: "/users/", // + id
  // info_employee: "/users/", // + id
  // get_all_employers: "/users?role=worker&role=manager&role=qControl",
  worker_order_queue: "/api/employee_оrder/myOrders",

  // QUALITY_CONTROL
  post_qControl: `/api/employee_order/quality_assurance?orderId=`,

  // MANAGER
  approve_order: `/api/manager/approve_order?orderId=`, // + id
  reject_order: `/api/manager/reject_order?orderId=`, // + id
  del_order: `/api/manager/delete_order?orderId=`, // +id

  // BIKE_SERVICES
  frames: "/api/accountpage/frames",
  compatible_parts: "/api/accountpage/compatible_parts",
  selected_part: "/api/accountpage/selected_part",
  // wheels: "/wheels/",
  // accessories: "/accessories/",
};

// indexPage: "/indexPage",
// // TODO: change to project path
// // get_all_in_progress: "/inProgress/",
// get_all_in_progress: "/production/",
// in_progress: "/production/",
// user_in_progress: "/production?ownerId=",
// GET_ALL_INTENDED: "/",
// // orders: "/orders/",
// orders: "/order_to_be_approved/",

// del_order: "/order_to_be_approved/",
// // del_order: `/api/manager/delete_order?orderId=`, // +id
// // TODO: Uncomment when delete in orderActions

// approve_order: `/approved/`, // + id
// // TODO: Uncomment approved in orderActions
// //approve_order: `/api/manager/approve_order?orderId=`, // + id

// reject_order: `/rejected_orders/`, // + id
// // TODO: Uncomment approved in orderActions
// //reject_order: `/api/manager/reject_order?orderId=`, // + id

// quality_assurance: "/quality_assurance/",
// post_qControl: `/api/employee_оrder/quality_assurance?orderId=`,
