BASE_URL: "http://localhost:9000",

## Index page

`GET indexPage`: "/indexPage" ?

## Client

`POST register_client`: "/api/client/register" <!-- "/api/client/register" -->

`POST login_client`: "api/client/login" <!-- "/login" -->

`GET info_client`: "/api/client/info/:id" <!-- "/users/:id" -->

`POST logout`: MISSING

`PUT update_client`: MISSING +id <!-- "/users/:id" -->

## Employee

`POST register_employee`: "/api/employee/register" <!-- "/api/employee/register" -->

`POST login_employee`: "api/employee/login"

`GET info_employee`: "/api/employee/info/:id" <!-- "/users/:id" -->

`POST logout`: MISSING

`PUT update_employee`: MISSING +id <!-- "/users/:id" -->

`GET get_all_employers`: MISSING

## Parts

`GET frames`: "/api/accountpage/frames"

`GET wheels`: "/api/accountpage/wheels" ?

`GET accessory`: "/api/accountpage/accessory" ?

`GET selected_part`: "/api/accountpage/selected_part?id=1"

`GET compatible_parts`: "/api/accountpage/compatible_parts?id=1"

## Manager

`GET pending_orders`: "/api/manager/pending_orders" ?

`GET rejected_orders`:"/api/manager/rejected_orders"

`POST delete_order`:"/api/manager/delete_order?orderId=3"

`POST approve_order`:"/api/manager/approve_order?orderId=3"

`POST `:"/api/manager/approve_rejected_order?orderId=3" ?

`POST reject_order`:"/api/manager/reject_order?orderId=3"

`GET finished_orders`:"/api/manager/finished_orders"

`GET in-progress`: MISSING
