[Обратно към ReadMe](/README.md)

### Отговор

### `GET /api/supplys_manager/get_suplier` - Връща JSON обект на доставчик на база подаден Id номер:
- `vatNumber`: Номер по ДДС на доставчика.
- `address`: Адрес на доставчика.
- `dateCreated`: Дата и час на създаване на поръчката.
- `orderParts`: Колекция от поръчаните части.
- `id`: Уникален идентификатор на частта.
- `name`: Наименованието на частта.
- `categoryName`: Наименование на категорията на доставчика.
- `contactName`: Име на лицето за контакт.
- `phoneNumeber`: Телефонен номер на лицето за контакт.
- `email`: Имейл на лицето за контакт.

### Examples:

## Request:

```
GET /api/supplys_manager/get_suplier
```

## Response:

```json
	
{
  "vatNumber": "123456789",
  "address": "Sofia, center",
  "orderParts": [],
  "id": 1,
  "name": "X Ltd",
  "categoryName": "Frame",
  "contactName": "Pesh Peshev",
  "phoneNumeber": "1234567890",
  "email": "text@test.bg"
}

```

[Обратно към ReadMe](/README.md)