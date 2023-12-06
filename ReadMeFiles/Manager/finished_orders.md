### Отговор

### `GET /api/manager/finished_orders` Връща колекция от JSON обекти със следните пропъртита:
- `orderId"`: Уникален идентификатор на поръчката.
- `serialNumber"`: Уникален идентификатор на велосипеда.
- `dateCreated`: Дата и час на създаване на поръчката.
- `dateFinished`: Дата и час на завършване на поръчката.
- `orderParts`: Колекция от поръчаните части.
- `partId`: Уникален идентификатор на частта.
- `description`: Описание на частта.
- `partName`: Наименованието на частта.
- `partQuantity`: Количество на поръчаната част.
- `partQuantityInStock`: Количество на склад от поръчаната част.

### Examples:

## Request:

```
GET /api/manager/finished_orders
```

## Response:

```json
	
[
  {
    "orderId": 1,
    "serialNumber": "BID12345678",
    "dateCreated": "2023-12-05 18:49:21.4383734",
    "dateFinished": "2023-12-05 20:49:21.0000000",
    "orderParts": [
      {
        "partId": 1,
        "description": "test",
        "partName": "Frame OG",
        "partQuantity": 1,
        "partQunatityInStock": 2
      },
      {
        "partId": 2,
        "description": "test",
        "partName": "Wheel of the YearG",
        "partQuantity": 2,
        "partQunatityInStock": 4
      },
      {
        "partId": 3,
        "description": "test",
        "partName": "Shift",
        "partQuantity": 2,
        "partQunatityInStock": 3
      }
    ]
  }
]

```