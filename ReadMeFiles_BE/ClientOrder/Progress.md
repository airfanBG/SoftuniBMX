[Обратно към ReadMe](/README.md)

# `POST /api/client_order/progress`
Екшън, следящ прогреса на поръчките, направени от клиент.

## Request
 Приема параметър - query string.

- `id`: Уникален идентификатор на клиента, направил поръчката.

### Example:

```url
https://localhost:7047/api/ClientOrder/progress?id=17ce735d-6713-4d0a-8fcb-e4a71ee86f6f
```
## Response
Контролера връща колекция от JSON обект със следната структура:

- `id`: Уникален идентификатор на направената поръчка.
- `serialNumber`: Уникален сериен номер на конкретна част.
- `dateCreated`: Дата на създаване на поръчката.
- `orderStates`: Колекция от информация за дадена част, от направената поръчка.
- `partId`: Идентификатор на поръчната част.
- `partType`: Тип на часта.
- `partModel`: Модел на часта.
- `nameOfEmplоyeeProducedThePart`: Име на служите, отговорен за направата й.
- `isProduced`: Проверка, дали часта е изготвена или не.
- `startDate`: Дата и час на започване на работа по частта.
- `endDate`: Дата и час на завършване на работа по частта.
### Example:
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
        "serialNumber": null,
        "employeeId": null,
        "elementProduceTimeInMinutes": null,
        "description": null,
        "partQuantity": 0,
        "startDate": null,
        "endDate": null
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
        "description": null,
        "partQuantity": 0,
        "startDate": null,
        "endDate": null
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
        "description": null,
        "partQuantity": 0,
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
        "serialNumber": null,
        "employeeId": null,
        "elementProduceTimeInMinutes": null,
        "description": null,
        "partQuantity": 0,
        "startDate": null,
        "endDate": null
      },
      {
        "partId": 5,
        "partType": "Wheel",
        "partModel": "Wheel of the Year for montain",
        "nameOfEmplоyeeProducedThePart": "Todor Todorov",
        "isProduced": false,
        "serialNumber": null,
        "employeeId": null,
        "elementProduceTimeInMinutes": null,
        "description": null,
        "partQuantity": 0,
        "startDate": null,
        "endDate": null
      },
      {
        "partId": 11,
        "partType": "Acsessories",
        "partModel": "Road budget Shifts",
        "nameOfEmplоyeeProducedThePart": "Ivan Ivanov",
        "isProduced": false,
        "serialNumber": null,
        "employeeId": null,
        "elementProduceTimeInMinutes": null,
        "description": null,
        "partQuantity": 0,
        "startDate": null,
        "endDate": null
      }
    ]
  },
  {
    "orderId": 4,
    "serialNumber": "BID12345680",
    "dateCreated": "15-12-2023",
    "orderStates": [
      {
        "partId": 1,
        "partType": "Frame",
        "partModel": "Frame Road",
        "nameOfEmplоyeeProducedThePart": " ",
        "isProduced": false,
        "serialNumber": null,
        "employeeId": null,
        "elementProduceTimeInMinutes": null,
        "description": null,
        "partQuantity": 0,
        "startDate": null,
        "endDate": null
      },
      {
        "partId": 5,
        "partType": "Wheel",
        "partModel": "Wheel of the Year for montain",
        "nameOfEmplоyeeProducedThePart": " ",
        "isProduced": false,
        "serialNumber": null,
        "employeeId": null,
        "elementProduceTimeInMinutes": null,
        "description": null,
        "partQuantity": 0,
        "startDate": null,
        "endDate": null
      },
      {
        "partId": 11,
        "partType": "Acsessories",
        "partModel": "Road budget Shifts",
        "nameOfEmplоyeeProducedThePart": " ",
        "isProduced": false,
        "serialNumber": null,
        "employeeId": null,
        "elementProduceTimeInMinutes": null,
        "description": null,
        "partQuantity": 0,
        "startDate": null,
        "endDate": null
      }
    ]
  },
  {
    "orderId": 5,
    "serialNumber": "BID12345680",
    "dateCreated": "15-12-2023",
    "orderStates": [
      {
        "partId": 1,
        "partType": "Frame",
        "partModel": "Frame Road",
        "nameOfEmplоyeeProducedThePart": " ",
        "isProduced": false,
        "serialNumber": null,
        "employeeId": null,
        "elementProduceTimeInMinutes": null,
        "description": null,
        "partQuantity": 0,
        "startDate": null,
        "endDate": null
      },
      {
        "partId": 5,
        "partType": "Wheel",
        "partModel": "Wheel of the Year for montain",
        "nameOfEmplоyeeProducedThePart": " ",
        "isProduced": false,
        "serialNumber": null,
        "employeeId": null,
        "elementProduceTimeInMinutes": null,
        "description": null,
        "partQuantity": 0,
        "startDate": null,
        "endDate": null
      },
      {
        "partId": 11,
        "partType": "Acsessories",
        "partModel": "Road budget Shifts",
        "nameOfEmplоyeeProducedThePart": " ",
        "isProduced": false,
        "serialNumber": null,
        "employeeId": null,
        "elementProduceTimeInMinutes": null,
        "description": null,
        "partQuantity": 0,
        "startDate": null,
        "endDate": null
      }
    ]
  },
  {
    "orderId": 6,
    "serialNumber": "BID12345680",
    "dateCreated": "15-12-2023",
    "orderStates": [
      {
        "partId": 1,
        "partType": "Frame",
        "partModel": "Frame Road",
        "nameOfEmplоyeeProducedThePart": " ",
        "isProduced": false,
        "serialNumber": null,
        "employeeId": null,
        "elementProduceTimeInMinutes": null,
        "description": null,
        "partQuantity": 0,
        "startDate": null,
        "endDate": null
      },
      {
        "partId": 5,
        "partType": "Wheel",
        "partModel": "Wheel of the Year for montain",
        "nameOfEmplоyeeProducedThePart": " ",
        "isProduced": false,
        "serialNumber": null,
        "employeeId": null,
        "elementProduceTimeInMinutes": null,
        "description": null,
        "partQuantity": 0,
        "startDate": null,
        "endDate": null
      },
      {
        "partId": 11,
        "partType": "Acsessories",
        "partModel": "Road budget Shifts",
        "nameOfEmplоyeeProducedThePart": " ",
        "isProduced": false,
        "serialNumber": null,
        "employeeId": null,
        "elementProduceTimeInMinutes": null,
        "description": null,
        "partQuantity": 0,
        "startDate": null,
        "endDate": null
      }
    ]
  },
  {
    "orderId": 7,
    "serialNumber": "BID12345680",
    "dateCreated": "15-12-2023",
    "orderStates": [
      {
        "partId": 1,
        "partType": "Frame",
        "partModel": "Frame Road",
        "nameOfEmplоyeeProducedThePart": " ",
        "isProduced": false,
        "serialNumber": null,
        "employeeId": null,
        "elementProduceTimeInMinutes": null,
        "description": null,
        "partQuantity": 0,
        "startDate": null,
        "endDate": null
      },
      {
        "partId": 5,
        "partType": "Wheel",
        "partModel": "Wheel of the Year for montain",
        "nameOfEmplоyeeProducedThePart": " ",
        "isProduced": false,
        "serialNumber": null,
        "employeeId": null,
        "elementProduceTimeInMinutes": null,
        "description": null,
        "partQuantity": 0,
        "startDate": null,
        "endDate": null
      },
      {
        "partId": 11,
        "partType": "Acsessories",
        "partModel": "Road budget Shifts",
        "nameOfEmplоyeeProducedThePart": " ",
        "isProduced": false,
        "serialNumber": null,
        "employeeId": null,
        "elementProduceTimeInMinutes": null,
        "description": null,
        "partQuantity": 0,
        "startDate": null,
        "endDate": null
      }
    ]
  },
  {
    "orderId": 8,
    "serialNumber": "BID12345680",
    "dateCreated": "15-12-2023",
    "orderStates": [
      {
        "partId": 1,
        "partType": "Frame",
        "partModel": "Frame Road",
        "nameOfEmplоyeeProducedThePart": " ",
        "isProduced": false,
        "serialNumber": null,
        "employeeId": null,
        "elementProduceTimeInMinutes": null,
        "description": null,
        "partQuantity": 0,
        "startDate": null,
        "endDate": null
      },
      {
        "partId": 5,
        "partType": "Wheel",
        "partModel": "Wheel of the Year for montain",
        "nameOfEmplоyeeProducedThePart": " ",
        "isProduced": false,
        "serialNumber": null,
        "employeeId": null,
        "elementProduceTimeInMinutes": null,
        "description": null,
        "partQuantity": 0,
        "startDate": null,
        "endDate": null
      },
      {
        "partId": 11,
        "partType": "Acsessories",
        "partModel": "Road budget Shifts",
        "nameOfEmplоyeeProducedThePart": " ",
        "isProduced": false,
        "serialNumber": null,
        "employeeId": null,
        "elementProduceTimeInMinutes": null,
        "description": null,
        "partQuantity": 0,
        "startDate": null,
        "endDate": null
      }
    ]
  },
  {
    "orderId": 9,
    "serialNumber": "BID12345680",
    "dateCreated": "15-12-2023",
    "orderStates": [
      {
        "partId": 1,
        "partType": "Frame",
        "partModel": "Frame Road",
        "nameOfEmplоyeeProducedThePart": " ",
        "isProduced": false,
        "serialNumber": null,
        "employeeId": null,
        "elementProduceTimeInMinutes": null,
        "description": null,
        "partQuantity": 0,
        "startDate": null,
        "endDate": null
      },
      {
        "partId": 5,
        "partType": "Wheel",
        "partModel": "Wheel of the Year for montain",
        "nameOfEmplоyeeProducedThePart": " ",
        "isProduced": false,
        "serialNumber": null,
        "employeeId": null,
        "elementProduceTimeInMinutes": null,
        "description": null,
        "partQuantity": 0,
        "startDate": null,
        "endDate": null
      },
      {
        "partId": 11,
        "partType": "Acsessories",
        "partModel": "Road budget Shifts",
        "nameOfEmplоyeeProducedThePart": " ",
        "isProduced": false,
        "serialNumber": null,
        "employeeId": null,
        "elementProduceTimeInMinutes": null,
        "description": null,
        "partQuantity": 0,
        "startDate": null,
        "endDate": null
      }
    ]
  }
]
```
[Обратно към ReadMe](/README.md)