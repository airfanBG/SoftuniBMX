[Обратно към ReadMe](/README.md)

### Отговор - Ако няма недостиг на части, а причината е липса на плащане връща празен обект. В случай на недостатъчна наличност на части връща обект със следните пропъртита:

- `partId`: Уникален идентификатор на частта.
- `name`: Име на частта.
- `note`: Поле за попълване на бележка.
- `neededQuantity`: Необходимото количество от дадената част за изпълнение на поръчката.

### `POST /api/manager/reject_order?orderId=1`

### Examples:

## Request:

```
POST /api/manager/reject_order?orderId=1
```

## Response:
```
StatusCode(200)

```json
	
[
  {
    "partId": 5,
    "name": "Wheel of the Year for montain",
    "note": "",
    "neededQuantity": 20
  },
  {
    "partId": 11,
    "name": "Road budget Shifts",
    "note": "",
    "neededQuantity": 19
  }
]

```
[Обратно към ReadMe](/README.md)