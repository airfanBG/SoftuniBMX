export const environment = {
  // TODO: fix routes in services
  BASE_URL: "http://localhost:9000",

  login: "/login",
  register_client: "/api/client/register",
  register_employee: "/api/employee/register",

  update_client: "/users/", // + id
  update_employee: "/users/", // + id
  info_client: "/users/", // + id

  info_employee: "/users/", // + id

  // TODO: for local list load
  get_all_employers: "/users?role=worker&role=manager&role=qControl",

  // TODO: change to project path
  // get_all_in_progress: "/inProgress/",
  get_all_in_progress: "/production/",
  in_progress: "/production/",
  GET_ALL_INTENDED: "/",
  indexPage: "/indexPage",
  frames: "/frames/",
  wheels: "/wheels/",
  accessories: "/accessories/",
  selected_part: "/selected_part/",
  // orders: "/orders/",
  orders: "/order_to_be_approved/",

  del_order: "/order_to_be_approved/",
  // del_order: `/api/manager/delete_order?orderId=`, // +id
  // TODO: Uncomment when delete in orderActions

  approve_order: `/approved/`, // + id
  // TODO: Uncomment approved in orderActions
  //approve_order: `/api/manager/approve_order?orderId=`, // + id
};
