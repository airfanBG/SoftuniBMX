export const environment = {
  BASE_URL: "https://localhost:7047",

  // AUTH
  login_client: "/api/client/login",
  login_employee: "/api/employee/login",
  register_client: "/api/client/register",
  register_employee: "/api/employee/register",

  // INDEX_PAGE
  indexPage: "/api/home/index",

  // CLIENT
  // update_client: "/users/", // + id
  // info_client: "/users/", // + id

  // EMPLOYEE
  post_qControl: `/api/employee_order/quality_assurance?orderId=`,
  del_order: `/api/manager/delete_order?orderId=`, // +id
  approve_order: `/api/manager/approve_order?orderId=`, // + id
  reject_order: `/api/manager/reject_order?orderId=`, // + id
  // update_employee: "/users/", // + id
  // info_employee: "/users/", // + id
  // get_all_employers: "/users?role=worker&role=manager&role=qControl",

  // QUALITY_CONTROL

  // MANAGER

  // BIKE_SERVICES
  // frames: "/frames/",
  // wheels: "/wheels/",
  // accessories: "/accessories/",
  // selected_part: "/selected_part/",
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
