### Отговор

### `GET /api/manager/orders_in_progress` Връща колекция от JSON обекти със следните пропъртита:
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
GET /api/manager/оrders_in_progress

```

## Response:

```json
	
[
  {
    "orderId": 1,
    "serialNumber": "BID12345678",
    "dateCreated": "2023-12-05 18:49:21.4383734",
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
  },
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