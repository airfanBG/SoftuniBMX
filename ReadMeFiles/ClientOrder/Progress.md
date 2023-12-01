
# `POST /api/ClientOrder/progress`
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
### Example:
```json
[
    {
        "id": 2,
        "serialNumber": "BIDTLR6WLB1",
        "dateCreated": "01/12/2023",
        "orderStates": [
            {
                "partId": 1,
                "partType": "Frame",
                "partModel": "Frame Road",
                "nameOfEmplоyeeProducedThePart": " ",
                "isProduced": false
            },
            {
                "partId": 3,
                "partType": "Frame",
                "partModel": "Frame Road woman",
                "nameOfEmplоyeeProducedThePart": " ",
                "isProduced": false
            },
            {
                "partId": 4,
                "partType": "Wheel",
                "partModel": "Wheel of the Year for road",
                "nameOfEmplоyeeProducedThePart": " ",
                "isProduced": false
            }
        ]
    }
]
```