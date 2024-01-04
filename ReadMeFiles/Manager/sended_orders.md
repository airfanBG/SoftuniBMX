[Обратно към ReadMe](/README.md)

### Отговор

### `GET /api/manager/sended_orders` Връща колекция от JSON обекти със следните пропъртита:
- `orderId`: Уникален идентификатор на поръчката.
- `serialNumber`: Уникален идентификатор на велосипеда.
- `saleAmount`: Продажна цена на велосипеда.
- `clientName`: Имена на клиента.
- `clientEmail`: Имейл на клиента.
- `clientPhone`: Телефон на клиента.
- `imageUrl`: Линк към снимка на велосипеда.
- `sendDate`: Дата на изпращане на велосипеда.
- `clientAdress`: Адрес на клиента.


### Examples:

## Request:

```
GET /api/manager/sended_orders
```

## Response:

```json
	
[
  {
    "orderId": 9,
    "serialNumber": "BID12345680",
    "saleAmount": 850,
    "clientName": "Ivan Ivanov",
    "clientEmail": "client@test.bg",
    "clientPhone": "1234567890",
    "imageUrl": "https://yuchormanski.free.bg/bikes/bike-1.webp",
    "sendDate": "03-01-2024",
    "clientAdress": {
      "country": "Bulgaria",
      "postCode": "1000",
      "district": null,
      "block": "20",
      "floor": null,
      "apartment": null,
      "street": "Mladost",
      "strNumber": "1"
    }
  },
  {
    "orderId": 10,
    "serialNumber": "BIDPASQC123",
    "saleAmount": 425,
    "clientName": "Ivan Ivanov",
    "clientEmail": "client@test.bg",
    "clientPhone": "1234567890",
    "imageUrl": "https://yuchormanski.free.bg/bikes/bike-1.webp",
    "sendDate": "03-01-2024",
    "clientAdress": {
      "country": "Bulgaria",
      "postCode": "1000",
      "district": null,
      "block": "20",
      "floor": null,
      "apartment": null,
      "street": "Mladost",
      "strNumber": "1"
    }
  }
]
Response header

```
[Обратно към ReadMe](/README.md)