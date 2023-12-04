### Отговор

### `GET /api/manager/orders_in_progress` Връща колекция от JSON обекти със следните пропъртита:
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
GET /api/manager/orders_in_progress
```

## Response:

```json
	
[
  {
    "orderId": 1,
    "serialNumber": "BID12345678",
    "orderParts": [
      {
        "partId": 1,
        "descrioption": "test",
        "partName": "Frame OG",
        "partQuantity": 1,
        "partQunatityInStock": 1
      },
      {
        "partId": 2,
        "descrioption": "test",
        "partName": "Wheel of the YearG",
        "partQuantity": 2,
        "partQunatityInStock": 4
      },
      {
        "partId": 3,
        "descrioption": "test",
        "partName": "Shift",
        "partQuantity": 2,
        "partQunatityInStock": 3
      }
    ]
  },
  {
    "orderId": 2,
    "serialNumber": "BID12345679",
    "orderParts": [
      {
        "partId": 1,
        "descrioption": "test",
        "partName": "Frame OG",
        "partQuantity": 1,
        "partQunatityInStock": 1
      },
      {
        "partId": 4,
        "descrioption": "test",
        "partName": "Wheel of the Year for road",
        "partQuantity": 2,
        "partQunatityInStock": 48
      },
      {
        "partId": 12,
        "descrioption": "test",
        "partName": "Shift",
        "partQuantity": 2,
        "partQunatityInStock": 7
      }
    ]
  }
]

```