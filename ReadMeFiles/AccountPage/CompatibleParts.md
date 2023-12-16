[Обратно към ReadMe](/README.md)

### Отговор

### `GET /api/accountpage/compatible_parts` Връща колекция от JSON обекти със следните пропъртита:
- `id`: Уникален идентификатор на частта.
- `name`: Наименованието на частта.
- `category`: Категория на частта.
- `description`: Описание на частта.
- `intend`: Описание на предназначението на частта.
- `type`: Тип на частта.
- `imageUrls`: лист от imageUrls
- `oemnumber`: Уникален заводски номер на частта.
- `rating`: лист от дадените до момента рейтинги на частта.
- `saleprice`: единична цена на частта.

### Examples:

## Request:

```
GET /api/accountpage/compatible_parts?id=1
```

## Response:

```json
	
[
  {
    "id": 4,
    "name": "Wheel of the Year for road",
    "category": "Wheel",
    "description": "Best wheels ever!",
    "intend": "Best wheels for a road usage",
    "imageUrls": [],
    "oemNumber": "oemtest",
    "rating": 4,
    "type": 1,
    "salePrice": 75
  },
  {
    "id": 7,
    "name": "Shift",
    "category": "Acsessories",
    "description": "Worst shift - have only one!",
    "intend": "Base shift - have only one",
    "imageUrls": [],
    "oemNumber": "oemtest",
    "rating": 6,
    "type": 1,
    "salePrice": 250
  },
  {
    "id": 12,
    "name": "Shift",
    "category": "Acsessories",
    "description": "Cheap standard shift!",
    "intend": "Cheap standard shift for a road usage",
    "imageUrls": [],
    "oemNumber": "oemtest21",
    "rating": 5,
    "type": 1,
    "salePrice": 220
  },
  {
    "id": 14,
    "name": "Budget wheel for road",
    "category": "Wheel",
    "description": "Budget wheel ever!",
    "intend": "Budget wheel for a road usage",
    "imageUrls": [],
    "oemNumber": "oemtest34",
    "rating": 4,
    "type": 1,
    "salePrice": 65
  }
]

```

[Обратно към ReadMe](/README.md)