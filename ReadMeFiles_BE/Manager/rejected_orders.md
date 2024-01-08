[Обратно към ReadMe](/README.md)

### Отговор

### `GET /api/manager/rejected_orders` Връща колекция от JSON обекти със следните пропъртита:
- `orderId"`: Уникален идентификатор на поръчката.
- `serialNumber"`: Уникален идентификатор на велосипеда.
- `dateCreated`: Дата и час на създаване на поръчката.
- `orderParts`: Колекция от поръчаните части.
- `partId`: Уникален идентификатор на частта.
- `description`: Описание на частта.
- `partName`: Наименованието на частта.
- `partQuantity`: Количество на поръчаната част.
- `partQuantityInStock`: Количество на склад от поръчаната част.

### Examples:

## Request:

```
GET /api/manager/rejected_orders
```

## Response:

```json
	
[
  {
    "orderId": 2,
    "serialNumber": "BID12345679",
    "dateCreated": "2023-12-05 18:49:21.4383739",
    "orderParts": [
      {
        "partId": 1,
        "description": "test",
        "partName": "Frame OG",
        "partQuantity": 1,
        "partQunatityInStock": 2
      },
      {
        "partId": 4,
        "description": "test",
        "partName": "Wheel of the Year for road",
        "partQuantity": 2,
        "partQunatityInStock": 50
      },
      {
        "partId": 12,
        "description": "test",
        "partName": "Shift",
        "partQuantity": 2,
        "partQunatityInStock": 9
      }
    ]
  }
]

```
[Обратно към ReadMe](/README.md)