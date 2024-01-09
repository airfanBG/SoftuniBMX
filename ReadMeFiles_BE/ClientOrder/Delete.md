[Обратно към ReadMe](/README.md)
# `POST /api/client_order/delete`
Екшън, изтриващ съществуваща поръчка, направена от клиент.

## Request
 Приема параметър - query string.

- `userId`: Уникален идентификатор на клиента, направил поръчката.
- `orderId`: Уникален идентификатор на поръчката, която клиентът иска да премахне.

### Example:

```url
https://localhost:7047/api/ClientOrder/delete?userId=99d3ca6f-2067-4316-a5d7-934c93789521&orderId=2
```
[Обратно към ReadMe](/README.md)
