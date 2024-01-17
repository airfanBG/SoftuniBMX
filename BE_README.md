###### [Back to content](/README.md)

# <b>Bicycle Management eXtreme- BMX</b>

<!-- ### Резюме

Приложението трябва да обслужва завод за производство на велосипеди. Заводът произвежда три основни модела велосипеди, като в зависимост от избора на клиента всеки компонент може да има по няколко разновидности. Всеки един клиент, след избора на основният вид велосипед, може да избира какви модели и марки компоненти свързани с него да добавя. -->

## Сървиси

- DropdownsContentService е сървис, който взима записите на частите от категория рамки от базата и ги връща под формата на колекция от ДТО обекти. Също така на база Id на избрана рамка връща колекция от съвместимите за нея части под формата на колекция от ДТО обекти. При подадено Id има функционалността да вземе от базата и върне цялата налична информация за частта записана под този Id номер под формата на ДТО обект.
- OrderManagerService е сървис, който взима записите на изчакващите одобрение поръчки (pending orders), отказаните поръчки (rejected orders), одобрените и вкарани в производство поръчки (orders_in_progress) и завършените (finished orders) от базата и ги връща под формата на колекция от ДТО обекти. Също така при подадено Id има функционалността да одобри (approve) изчакващите одобрение поръчки (pending orders) и отказаните (rejected orders) или да отхвърли поръчка (reject order).

## Базов (основен) URL

Базовия URL е общ за всички API заявки и е:

- `https://[::1]:7047`

## Крайни точки (APIs):

- AccountPageController дава възсможността да се ползва функционалността на DropdownsContentService.

### [`GET /api/accountpage/frames`](/ReadMeFiles/AccountPage/Frames.md)

### [`GET /api/accountpage/compatible_parts`](/ReadMeFiles/AccountPage/CompatibleParts.md)

### [`GET /api/accountpage/selected_part`](/ReadMeFiles/AccountPage/SelectedPart.md)

- ClientOrderController дава възсможността на потребителя на създава, преглежда и изтрива поръчки, направени от него.

### [`POST /api/client_order/create`](/ReadMeFiles/ClientOrder/Create.md)

### [`POST /api/client_order/progress`](/ReadMeFiles/ClientOrder/Progress.md)

### [`POST /api/client_order/delete`](/ReadMeFiles/ClientOrder/Delete.md)

- ManagerStatisticsController дава възможността да се ползва функционалността на ManagerStatisticsService. 

### [`GET /api/manager_statistics/employee_statistics`](/ReadMeFiles/ManagerStatistics/employee_statistics.md)
### [`GET /api/manager_statistics/order_part_statistics`](/ReadMeFiles/ManagerStatistics/order_part_statistics.md)
### [`GET /api/manager_statistics/employees_full_statistics`](/ReadMeFiles/ManagerStatistics/employees_full_statistics.md)

- OrderManagerController дава възможността да се ползва функционалността на OrderManagerService.

### [`GET /api/manager/pending_orders`](/ReadMeFiles/Manager/pending_orders.md)

### [`GET /api/manager/rejected_orders`](/ReadMeFiles/Manager/rejected_orders.md)

### [`GET /api/manager/orders_in_progress`](/ReadMeFiles/Manager/orders_in_progress.md)

### [`POST /api/manager/delete_order?orderId=`](/ReadMeFiles/Manager/delete_order.md)

### [`POST /api/manager/approve_order?orderId=`](/ReadMeFiles/Manager/approve_order.md)

### [`POST /api/manager/approve_rejected_order?orderId=`](/ReadMeFiles/Manager/approve_rejected_order.md)

### [`POST /api/manager/reject_order?orderId=`](/ReadMeFiles/Manager/reject_order.md)

### [`GET /api/manager/finished_orders`](/ReadMeFiles/Manager/finished_orders.md)

### [`POST /api/manager/send_order?orderId=`](/ReadMeFiles/Manager/send_order.md)

### [`GET /api/manager/sended_orders`](/ReadMeFiles/Manager/sended_orders.md)

- SuplyManagerController дава възможността да се ползва функционалността на SuplyManagerService.

### [`GET /api/supplys_manager/deliveries`](/ReadMeFiles/SuplyManager/deliveries.md)

### [`GET /api/supplys_manager/supliers`](/ReadMeFiles/SuplyManager/supliers.md)

### [`GET /api/supplys_manager/part_orders`](/ReadMeFiles/SuplyManager/part_orders.md)

### [`POST /api/supplys_manager/create_delivery`](/ReadMeFiles/SuplyManager/create_delivery.md)

### [`POST /api/supplys_manager/create_suplier`](/ReadMeFiles/SuplyManager/create_suplier.md)

### [`POST /api/supplys_manager/create_part_order`](/ReadMeFiles/SuplyManager/create_part_order.md)

### [`GET /api/supplys_manager/get_suplier`](/ReadMeFiles/SuplyManager/get_suplier.md)

### [`GET /api/supplys_manager/get_delivery`](/ReadMeFiles/SuplyManager/get_delivery.md)

### [`GET /api/supplys_manager/get_part_order`](/ReadMeFiles/SuplyManager/get_part_order.md)

### [`POST /api/supplys_manager/delete_suplier`](/ReadMeFiles/SuplyManager/delete_suplier.md)

### [`POST /api/supplys_manager/delete_delivery`](/ReadMeFiles/SuplyManager/delete_delivery.md)

### [`POST /api/supplys_manager/delete_part_order`](/ReadMeFiles/SuplyManager/delete_part_order.md)

### [`PUT /api/supplys_manager/edit_delivery`](/ReadMeFiles/SuplyManager/edit_delivery.md)

### [`PUT /api/supplys_manager/edit_suplier`](/ReadMeFiles/SuplyManager/edit_suplier.md)

### [`PUT /api/supplys_manager/edit_part_order`](/ReadMeFiles/SuplyManager/edit_part_order.md)

### [`GET /api/supplys_manager/get_suplier_parts`](/ReadMeFiles/SuplyManager/get_suplier_parts.md)

## Errors

This API uses the following error codes:

- `204 No Content`: The requested resource was empty.
- `404 Bad Request`: The request was malformed or missing required parameters.
- `500 Internal Server Error`: An unexpected error occurred on the server.

#### Markdown template (за пример)

Markdown is a lightweight markup language based on the formatting conventions
that people naturally use in email.
As [John Gruber] writes on the [Markdown site][df1]

> The overriding design goal for Markdown's
> formatting syntax is to make it as readable
> as possible. The idea is that a
> Markdown-formatted document should be
> publishable as-is, as plain text, without
> looking like it's been marked up with tags
> or formatting instructions.

This text you see here is \*actually- written in Markdown! To get a feel
for Markdown's syntax, type some text into the left window and
watch the results in the right.
