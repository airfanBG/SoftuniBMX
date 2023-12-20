[Обратно към ReadMe](/README.md)

### Отговор

### `GET /api/manager/orders_in_progress` Връща колекция от JSON обекти със следните пропъртита:
- `id`: Уникален идентификатор на направената поръчка.
- `serialNumber`: Уникален сериен номер на конкретна част.
- `dateCreated`: Дата на създаване на поръчката.
- `orderStates`: Колекция от информация за дадена част, от направената поръчка.
- `partId`: Идентификатор на поръчната част.
- `partType`: Тип на часта.
- `partModel`: Модел на часта.
- `nameOfEmplоyeeProducedThePart`: Име на служите, отговорен за направата й.
- `isProduced`: Проверка, дали часта е изготвена или не.

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
    "dateCreated": "15-12-2023",
    "orderStates": [
      {
        "partId": 1,
        "partType": "Frame",
        "partModel": "Frame Road",
        "nameOfEmplоyeeProducedThePart": "Marin Marinov",
        "isProduced": true,
        "serialNumber": null,
        "employeeId": null,
        "elementProduceTimeInMinutes": null,
        "description": null
      },
      {
        "partId": 2,
        "partType": "Frame",
        "partModel": "Frame Montain",
        "nameOfEmplоyeeProducedThePart": "Todor Todorov",
        "isProduced": false,
        "serialNumber": null,
        "employeeId": null,
        "elementProduceTimeInMinutes": null,
        "description": null
      },
      {
        "partId": 3,
        "partType": "Frame",
        "partModel": "Frame Road woman",
        "nameOfEmplоyeeProducedThePart": "Ivan Ivanov",
        "isProduced": false,
        "serialNumber": null,
        "employeeId": null,
        "elementProduceTimeInMinutes": null,
        "description": null
      }
    ]
  },
  {
    "orderId": 2,
    "serialNumber": "BID12345679",
    "dateCreated": "15-12-2023",
    "orderStates": [
      {
        "partId": 1,
        "partType": "Frame",
        "partModel": "Frame Road",
        "nameOfEmplоyeeProducedThePart": "Marin Marinov",
        "isProduced": false,
        "serialNumber": null,
        "employeeId": null,
        "elementProduceTimeInMinutes": null,
        "description": null
      },
      {
        "partId": 4,
        "partType": "Wheel",
        "partModel": "Wheel of the Year for road",
        "nameOfEmplоyeeProducedThePart": "Todor Todorov",
        "isProduced": false,
        "serialNumber": null,
        "employeeId": null,
        "elementProduceTimeInMinutes": null,
        "description": null
      },
      {
        "partId": 12,
        "partType": "Acsessories",
        "partModel": "Shift",
        "nameOfEmplоyeeProducedThePart": "Ivan Ivanov",
        "isProduced": false,
        "serialNumber": null,
        "employeeId": null,
        "elementProduceTimeInMinutes": null,
        "description": null
      }
    ]
  }
]

```

[Обратно към ReadMe](/README.md)