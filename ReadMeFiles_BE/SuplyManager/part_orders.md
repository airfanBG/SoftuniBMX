[Обратно към ReadMe](/README.md)

### Отговор

### `GET /api/supplys_manager/part_orders` Връща колекция от JSON обекти със следните пропъртита:
- `id"`: Уникален идентификатор на поръчката. 
- `partName`: Наименование на частта.
- `suplierName`: Наименование на доставчика.
- `quantity`: Поръчано количество.

### Examples:

## Request:

```
GET /api/supplys_manager/part_orders

```

## Response:

```json
	
[
  {
    "id": 1,
    "partName": "Frame Road",
    "suplierName": "X Ltd",
    "quantity": 2
  },
  {
    "id": 2,
    "partName": "Wheel of the Year for road",
    "suplierName": "XX Ltd",
    "quantity": 2
  },
  {
    "id": 3,
    "partName": "Shift",
    "suplierName": "XXX Ltd",
    "quantity": 1
  }
]

```
[Обратно към ReadMe](/README.md)