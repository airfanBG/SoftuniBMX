[Обратно към ReadMe](/README.md)

### Отговор

### `GET /api/manager/deleted_orders?page=1` - Връща общия брой на изтритите поръчки и колекция от 6 изтрити поръчки на страница (при подаване на номер на страница се връщат обектите от подадения номер страница), подредени от най-стара-към най-нова, представляващи JSON обекти със следните пропъртита:
- `totalOrdersCount"`: Общ брой на изтритите поръчки в базата.
- `orders"`: Колекция от обекти представляващи частите от поръчката.
- `orderId"`: Уникален идентификатор на поръчката.
- `serialNumber"`: Уникален идентификатор на поръчката.
- `dateCreated"`: Дата на създаване на поръчката.
- `dateFinished"`: Дата на завършване на поръчката.
- `dateDeleted`: Дата на изтриване на поръчката.
- `orderParts`: Колекция от поръчаните части.
- `partId`: Уникален идентификатор на частта.
- `description`: Описание на причината за връщане от страна на качествения контрол.
- `oemNumber`: Уникален идентификатор на велосипеда.
- `categoryName`: Категория на частта.
- `partName`: Име на частта.
- `partQuantity`: Количество на поръчаната част.
- `partQunatityInStock`: Количество на поръчаната част в склада.
- `startDate`: Момент на започване на монтажните операции по дадена част.
- `endDate`: Момент на завършване на монтажните операции по дадена част.
- `employeeName`: Име на работника.
- `isComplete`: Булева променлива показваща дали е завършена монтажната операция.

### Examples:

## Request:

```
GET /api/manager/deleted_orders?page=1
```

## Response:

```json
	
{
  "totalOrdersCount": 1,
  "orders": [
    {
      "orderId": 2,
      "serialNumber": "BID12345679",
      "dateCreated": "2023-10-10 10:10:00.0000000",
      "dateFinished": null,
      "dateDeleted": null,
      "orderParts": [
        {
          "partId": 1,
          "description": "test",
          "oemNumber": null,
          "categoryName": null,
          "partName": "Frame OG",
          "partQuantity": 1,
          "partQunatityInStock": 31,
          "startDate": null,
          "endDate": null,
          "employeeName": null,
          "isComplete": false
        },
        {
          "partId": 4,
          "description": "test",
          "oemNumber": null,
          "categoryName": null,
          "partName": "Wheel of the Year for road",
          "partQuantity": 1,
          "partQunatityInStock": 49,
          "startDate": null,
          "endDate": null,
          "employeeName": null,
          "isComplete": false
        },
        {
          "partId": 12,
          "description": "test",
          "oemNumber": null,
          "categoryName": null,
          "partName": "Shift",
          "partQuantity": 1,
          "partQunatityInStock": 28,
          "startDate": null,
          "endDate": null,
          "employeeName": null,
          "isComplete": false
        }
      ]
    }
  ]
}

```

[Обратно към ReadMe](/README.md)