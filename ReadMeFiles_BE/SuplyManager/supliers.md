[Обратно към ReadMe](/README.md)

### Отговор

### `GET /api/supplys_manager/supliers` Връща колекция от JSON обекти със следните пропъртита:
- `id`: Идентификационен номер на доставчика.
- `name`: Име на доставчика.
- `categoryName`: Категория на доставчика.
- `contactName`: Име на лицето за контакт на доставчика.
- `phoneNumeber`: Телефонен номер на доставчика.
- `email`: Имейл на доставчика.

### Examples:

## Request:

```
GET /api/supplys_manager/supliers
```

## Response:

```json
	
[
  {
    "id": 1,
    "name": "X Ltd",
    "categoryName": "Frame",
    "contactName": "Pesh Peshev",
    "phoneNumeber": "1234567890",
    "email": "text@test.bg"
  },
  {
    "id": 2,
    "name": "XX Ltd",
    "categoryName": "Wheel",
    "contactName": "Pesho Peshev",
    "phoneNumeber": "1234567899",
    "email": "text2@test.bg"
  },
  {
    "id": 3,
    "name": "XXX Ltd",
    "categoryName": "Acsessories",
    "contactName": "Ivan Peshev",
    "phoneNumeber": "1234567897",
    "email": "text3@test.bg"
  }
]

```
[Обратно към ReadMe](/README.md)