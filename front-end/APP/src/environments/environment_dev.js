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
  get_all_in_progress: "/inProgress/",
  GET_ALL_INTENDED: "/",
  indexPage: "/indexPage",
  frames: "/frames/",
  wheels: "/wheels/",
  accessories: "/accessories/",
  selected_part: "/selected_part/",
  orders: "/orders/",
  del_order: "/orders/",
};
