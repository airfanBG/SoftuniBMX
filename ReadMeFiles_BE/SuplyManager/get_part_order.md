[Обратно към ReadMe](/README.md)

### Отговор

### `GET /api/suppllys_manager/get_part_order?partOrderId=1` Връща колекция от JSON обекти със следните пропъртита:
- `orderId"`: Уникален идентификатор на поръчката.
- `serialNumber"`: Уникален идентификатор на велосипеда.
- `dateCreated`: Дата и час на създаване на поръчката.
- `dateCreated`: Дата на създаване на поръчката.
- `note`: Бележка към поръчката.
- `id`: Уникален идентификатор на поръчката.
- `partName`: Наименованието на частта.
- `suplierName`: Име на доставчика.
- `quantity`: Количество от поръчаната част.

### Examples:

## Request:

```
GET /api/suppllys_manager/get_part_order?partOrderId=1
```

## Response:

```json
	
{
  "dateCreated": "2023-12-09T12:32:13.0600562",
  "note": "text",
  "id": 1,
  "partName": "Frame Road",
  "suplierName": "X Ltd",
  "quantity": 2
}

```
[Обратно към ReadMe](/README.md)
