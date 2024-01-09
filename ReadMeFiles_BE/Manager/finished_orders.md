[Обратно към ReadMe](/README.md)

### Отговор

### `GET /api/manager/finished_orders` Връща колекция от JSON обекти със следните пропъртита:
- `orderId"`: Уникален идентификатор на поръчката.
- `serialNumber"`: Уникален идентификатор на велосипеда.
- `dateCreated`: Дата и час на създаване на поръчката.
- `dateFinished`: Дата и час на завършване на поръчката.
- `totalProductionTime`: Общо времe за производство на велосипеда.
- `saleAmount`: Общо стойност на поръчката.
- `clientName`: Фамилия на клиента.
- `clientEmail`: Имейл на клиента.
- `clientPhone`: Телефонен номер на клиента.
- `orderStates`: Колекция от поръчаните части.
- `partId`: Уникален идентификатор на частта.
- `partType`: Категория на частта.
- `partModel`: Наименование, модел на частта.
- `nameOfEmplоyeeProducedThePart`: Име на работника монтирал частта.
- `isProduced`: Булева променлива показваща дали е завършена монтажната операция.
- `serialNumber`: Уникален идентификатор на частта.
- `employeeId`: Уникален идентификатор на работника.
- `elementProduceTimeInMinutes`: Време за изпълнение на монтажната операция.
- `description`: Описание на причината за връщане от страна на качествения контрол.
- `partQuantity`: Количество на поръчаната част.
- `startDate`: Момент на започване на монтажните операции по дадена част.
- `endDate`: Момент на завършване на монтажните операции по дадена част.

### Examples:

## Request:

```
GET /api/manager/finished_orders
```

## Response:

```json
	
[
  {
    "orderId": 10,
    "serialNumber": "BIDPASQC123",
    "dateCreated": "15-12-2023",
    "dateFinished": "17-12-2023",
    "totalProductionTime": 25,
    "saleAmount": 425,
    "clientName": "Ivanov",
    "clientEmail": "client@test.bg",
    "clientPhone": "1234567890",
    "orderStates": [
      {
        "partId": 1,
        "partType": "Frame",
        "partModel": "Frame OG",
        "nameOfEmplоyeeProducedThePart": "Marin Marinov",
        "isProduced": true,
        "serialNumber": "BIDPASQC123",
        "employeeId": null,
        "elementProduceTimeInMinutes": 5,
        "description": "test",
        "partQuantity": 1,
        "startDate": "2023-12-16 16:48:13.0000000",
        "endDate": "2023-12-16 16:53:13.0000000"
      },
      {
        "partId": 2,
        "partType": "Frame",
        "partModel": "Wheel of the YearG",
        "nameOfEmplоyeeProducedThePart": "Todor Todorov",
        "isProduced": true,
        "serialNumber": "BIDPASQC123",
        "employeeId": null,
        "elementProduceTimeInMinutes": 5,
        "description": "test",
        "partQuantity": 1,
        "startDate": "2023-12-17 09:10:13.0000000",
        "endDate": "2023-12-17 09:15:13.0000000"
      },
      {
        "partId": 3,
        "partType": "Frame",
        "partModel": "Shift",
        "nameOfEmplоyeeProducedThePart": "Ivan Ivanov",
        "isProduced": true,
        "serialNumber": "BIDPASQC123",
        "employeeId": null,
        "elementProduceTimeInMinutes": 15,
        "description": "test",
        "partQuantity": 1,
        "startDate": "2023-12-17 10:15:13.0000000",
        "endDate": "2023-12-17 10:30:13.0000000"
      }
    ]
  }
]

```
[Обратно към ReadMe](/README.md)