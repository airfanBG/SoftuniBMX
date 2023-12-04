### Отговор

### `GET /api/manager/pending_orders` Връща колекция от JSON обекти със следните пропъртита:
- `orderId"`: Уникален идентификатор на поръчката.
- `serialNumber"`: Уникален идентификатор на велосипеда.
- `orderParts`: Колекция от поръчаните части.
- `partId`: Уникален идентификатор на частта.
- `description`: Описание на частта.
- `partName`: Наименованието на частта.
- `partQuantity`: Количество на поръчаната част.
- `partQuantityInStock`: Количество на склад от поръчаната част.

### Examples:

## Request:

```
GET /api/manager/pending_orders
```

## Response:

```json
	
[
  {
    "orderId": 3,
    "serialNumber": "BID12345680",
    "orderParts": [
      {
        "partId": 1,
        "descrioption": "test",
        "partName": "Frame OG",
        "partQuantity": 1,
        "partQunatityInStock": 2
      },
      {
        "partId": 5,
        "descrioption": "test",
        "partName": "Wheel of the Year for montain",
        "partQuantity": 6,
        "partQunatityInStock": 40
      },
      {
        "partId": 11,
        "descrioption": "test",
        "partName": "Road budget Shifts",
        "partQuantity": 4,
        "partQunatityInStock": 21
      }
    ]
  }
]

```