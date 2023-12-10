export const environment = {
  // TODO: fix routes in services
  BASE_URL: "https://localhost:7047",

  indexPage: "/api/home/index",
  register_client: "/api/client/register",
  register_employee: "/api/employee/register",
  post_qControl: `/api/employee_оrder/quality_assurance?orderId=`,
  del_order: `/api/manager/delete_order?orderId=`, // +id
  approve_order: `/api/manager/approve_order?orderId=`, // + id
  reject_order: `/api/manager/reject_order?orderId=`, // + id
};
