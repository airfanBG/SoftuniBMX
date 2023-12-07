
[Обратно към ReadMe](/README.md)

# `PUT /api/employee_оrder/quality_assurance`
Екшън, който връща част, която не преминава изискванията към този, който я е изработил.

## Request
 Приема параметър от тялото на заявката в JSON формат със следната структура:

- `orderId`: Уникален идентификатор на поръчката.
- `partId`: Идентификатор на часта, която трябва да се поправи.
- `description`: Описание към работника, какъв е проблема.
### Example:
 Body request:

```json
{
  "orderId": 1,
  "partId": 2,
  "description": "There is a scrach"
}
```
## Response
При валидни данни и успешно записване на записите в базата данни контролера връща JSON обект със следната структура:

- `employeeName`: Името на работникът, който е правил тази част.
- `partName`: Името/модела на часта.
- `description`: Описание към работника, какъв е проблема.
- `serialNumber`: Серийният номер на композицията, в която се намира часта.
### Example:
```json
{
    "employeeName": "Todor Todorov",
    "partName": "Wheel of the YearG",
    "description": "There is a scrach",
    "serialNumber": "BID12345678"
}
```

[Обратно към ReadMe](/README.md)