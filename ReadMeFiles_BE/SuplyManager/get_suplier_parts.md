[Обратно към ReadMe](/README.md)

### Отговор

### `GET /api/supplys_manager/get_suplier_parts` - Връща JSON обект на частите на доставчик на база подаден Id номер:
- `id`: Уникален идентификатор на частта.
- `name`: Наименованието на частта.
- `category`: Категория на частта.
- `description`: Описание на частта.
- `intend`: Предназначение на частта.
- `imageUrls`: Масив от линкове към снимки на частта.
- `oemNumber`: Заводски номер на частта.
- `rating`: Рейтинг на частта.
- `type`: Тип на частта.
- `quantity`: Количество на частта.
- `salePrice`: Продажна цена на частта.


### Examples:

## Request:

```
GET /api/supplys_manager/get_suplier_parts
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
    "imageUrls": [
      "https://yuchormanski.free.bg/bikes/wheel1.webp"
    ],
    "oemNumber": "oemtest4",
    "rating": 4,
    "type": 1,
    "quantity": 50,
    "salePrice": 75
  },
  {
    "id": 5,
    "name": "Wheel of the Year for montain",
    "category": "Wheel",
    "description": "Best wheels for a montain!",
    "intend": "Best wheels for a montain usage",
    "imageUrls": [
      "https://yuchormanski.free.bg/bikes/wheel2.webp"
    ],
    "oemNumber": "oemtest5",
    "rating": 5,
    "type": 2,
    "quantity": 40,
    "salePrice": 85
  },
  {
    "id": 6,
    "name": "Road wheel best seler",
    "category": "Wheel",
    "description": "Best wheels for a road!",
    "intend": "Best seler for a road usage",
    "imageUrls": [
      "https://yuchormanski.free.bg/bikes/wheel3.webp"
    ],
    "oemNumber": "oemtest6",
    "rating": 6,
    "type": 3,
    "quantity": 50,
    "salePrice": 65
  }
]

```

[Обратно към ReadMe](/README.md)