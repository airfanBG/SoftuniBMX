[Обратно към ReadMe](/README.md)

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
- `startDate`: Дата и час на започване на работа по частта.
- `endDate`: Дата и час на завършване на работата по частта.
- `isComplete`: Дали е завършена работата по частта.

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
    "dateCreated": "2023-12-15 10:34:22.3280663",
    "dateFinished": null,
    "orderParts": [
      {
        "partId": 1,
        "description": "test",
        "partName": "Frame OG",
        "partQuantity": 1,
        "partQunatityInStock": 32,
        "startDate": null,
        "endDate": null,
        "isComplete": false
      },
      {
        "partId": 2,
        "description": "test",
        "partName": "Wheel of the YearG",
        "partQuantity": 2,
        "partQunatityInStock": 43,
        "startDate": null,
        "endDate": null,
        "isComplete": false
      },
      {
        "partId": 3,
        "description": "test",
        "partName": "Shift",
        "partQuantity": 2,
        "partQunatityInStock": 32,
        "startDate": null,
        "endDate": null,
        "isComplete": false
      }
    ]
  },
  {
    "orderId": 2,
    "serialNumber": "BID12345679",
    "dateCreated": "2023-12-15 10:34:22.3280672",
    "dateFinished": null,
    "orderParts": [
      {
        "partId": 1,
        "description": "test",
        "partName": "Frame OG",
        "partQuantity": 1,
        "partQunatityInStock": 32,
        "startDate": null,
        "endDate": null,
        "isComplete": false
      },
      {
        "partId": 4,
        "description": "test",
        "partName": "Wheel of the Year for road",
        "partQuantity": 2,
        "partQunatityInStock": 50,
        "startDate": null,
        "endDate": null,
        "isComplete": false
      },
      {
        "partId": 12,
        "description": "test",
        "partName": "Shift",
        "partQuantity": 2,
        "partQunatityInStock": 29,
        "startDate": null,
        "endDate": null,
        "isComplete": false
      }
    ]
  }
]

```

[Обратно към ReadMe](/README.md)