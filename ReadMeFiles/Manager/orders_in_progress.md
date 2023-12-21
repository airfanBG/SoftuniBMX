[Обратно към ReadMe](/README.md)

### Отговор

### `GET /api/manager/orders_in_progress` Връща колекция от JSON обекти със следните пропъртита:
- `orderId`: Уникален идентификатор на направената поръчка.
- `serialNumber`: Уникален сериен номер на конкретна част.
- `dateCreated`: Дата на създаване на поръчката.
- `orderStates`: Колекция от информация за дадена част, от направената поръчка.
- `partId`: Идентификатор на поръчната част.
- `partType`: Тип на часта.
- `partModel`: Модел на часта.
- `nameOfEmplоyeeProducedThePart`: Име на служите, отговорен за направата й.
- `isProduced`: Проверка, дали часта е изготвена или не.
- `serialNumber`: Уникален номер на часта.
- `partQuantity`: Количество на часта.
- `startDate`: Дата и час на започване на работа по частта.
- `endDate`: Дата и час на завършване на работа по частта.

### Examples:

## Request:

```
GET /api/manager/оrders_in_progress

```

## Response:

```json
	
[
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
        "serialNumber": "oemtest1",
        "employeeId": null,
        "elementProduceTimeInMinutes": null,
        "description": null,
        "partQuantity": 1,
        "startDate": null,
        "endDate": null
      },
      {
        "partId": 4,
        "partType": "Wheel",
        "partModel": "Wheel of the Year for road",
        "nameOfEmplоyeeProducedThePart": "Todor Todorov",
        "isProduced": false,
        "serialNumber": "oemtest4",
        "employeeId": null,
        "elementProduceTimeInMinutes": null,
        "description": null,
        "partQuantity": 2,
        "startDate": null,
        "endDate": null
      },
      {
        "partId": 12,
        "partType": "Acsessories",
        "partModel": "Shift",
        "nameOfEmplоyeeProducedThePart": "Ivan Ivanov",
        "isProduced": false,
        "serialNumber": "oemtest12",
        "employeeId": null,
        "elementProduceTimeInMinutes": null,
        "description": null,
        "partQuantity": 2,
        "startDate": null,
        "endDate": null
      }
    ]
  },
  {
    "orderId": 3,
    "serialNumber": "BID12345680",
    "dateCreated": "15-12-2023",
    "orderStates": [
      {
        "partId": 1,
        "partType": "Frame",
        "partModel": "Frame Road",
        "nameOfEmplоyeeProducedThePart": "Marin Marinov",
        "isProduced": false,
        "serialNumber": "oemtest1",
        "employeeId": null,
        "elementProduceTimeInMinutes": null,
        "description": null,
        "partQuantity": 1,
        "startDate": null,
        "endDate": null
      },
      {
        "partId": 5,
        "partType": "Wheel",
        "partModel": "Wheel of the Year for montain",
        "nameOfEmplоyeeProducedThePart": "Todor Todorov",
        "isProduced": false,
        "serialNumber": "oemtest5",
        "employeeId": null,
        "elementProduceTimeInMinutes": null,
        "description": null,
        "partQuantity": 6,
        "startDate": null,
        "endDate": null
      },
      {
        "partId": 11,
        "partType": "Acsessories",
        "partModel": "Road budget Shifts",
        "nameOfEmplоyeeProducedThePart": "Ivan Ivanov",
        "isProduced": false,
        "serialNumber": "oemtest11",
        "employeeId": null,
        "elementProduceTimeInMinutes": null,
        "description": null,
        "partQuantity": 4,
        "startDate": null,
        "endDate": null
      }
    ]
  }
]

```

[Обратно към ReadMe](/README.md)