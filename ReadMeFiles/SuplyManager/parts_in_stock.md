[Обратно към ReadMe](/README.md)

### Отговор

### `GET /api/supplys_manager/parts_in_stock?page=1` - Връща колекция от 6 части на страница (при подаване на номер на страница се връщат обектите от подадения номер страница), подредени от най-стара-към най-нова, представляващи JSON обекти със следните пропъртита:
- `totalPartsCount"`: Общ брой на частите в базата.
- `parts"`: Колекция от модели на частите в базата.
- `id"`: Уникален идентификатор на частта в базата.
- `name"`: Наименование на частта.
- `category`: Категория на частта.
- `description"`: Описание на частта.
- `intend"`: Предназначение на частта.
- `imageUrls"`: Колекция от Url-и на снимки на частта.
- `oemNumber"`: Уникален номер на частта.
- `rating"`: Рейтинг на частта.
- `type"`: Номер на типа на частта.
- `quantity"`: Налично количество на склад от частта.
- `salePrice"`: Цена на частта.

### Examples:

## Request:

```
GET /api/supplys_manager/parts_in_stock?page=1
```

## Response:

```json
	
{
  "totalPartsCount": 18,
  "parts": [
    {
      "id": 1,
      "name": "Frame Road",
      "category": "Frame",
      "description": "Best frame in the road!",
      "intend": "For road usage",
      "imageUrls": [
        "https://yuchormanski.free.bg/bikes/frame1.webp"
      ],
      "oemNumber": "oemtest1",
      "rating": 4,
      "type": 1,
      "quantity": 31,
      "salePrice": 100
    },
    {
      "id": 2,
      "name": "Frame Montain",
      "category": "Frame",
      "description": "Best frame in the montain",
      "intend": "For montain usage",
      "imageUrls": [
        "https://yuchormanski.free.bg/bikes/frame2.webp"
      ],
      "oemNumber": "oemtest2",
      "rating": 5,
      "type": 2,
      "quantity": 43,
      "salePrice": 90
    },
    {
      "id": 3,
      "name": "Frame Road woman",
      "category": "Frame",
      "description": "Best frame in the road for womens",
      "intend": "For road usage in women bikes",
      "imageUrls": [
        "https://yuchormanski.free.bg/bikes/frame3.webp"
      ],
      "oemNumber": "oemtest3",
      "rating": 5,
      "type": 3,
      "quantity": 32,
      "salePrice": 80
    },
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
      "quantity": 49,
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
}

```

[Обратно към ReadMe](/README.md)