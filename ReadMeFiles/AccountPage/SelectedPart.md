[Обратно към ReadMe](/README.md)

### Отговор

### `GET /api/accountpage/selected_part` Връща JSON обект със следните пропъртита:
- `id`: Уникален идентификатор на частта.
- `name`: Наименованието на частта.
- `type`: Тип на частта.
- `category`: Категория на частта.
- `description`: Описание на частта.
- `intend`: Описание на предназначението на частта.
- `imageUrls`: лист от imageUrls
- `oemnumber`: Уникален заводски номер на частта.
- `rating`: лист от дадените до момента рейтинги на частта.
- `saleprice`: единична цена на частта.

### Examples:

## Request:

```
GET /api/accountpage/selected_part?id=1
```

## Response:

```json
	
{
  "id": 1,
  "name": "Frame Road",
  "category": "Frame",
  "description": "Best frame in the road!",
  "intend": "For road usage",
  "imageUrls": [
    "test"
  ],
  "oemNumber": "oemtest",
  "rating": 4,
  "type": 1,
  "salePrice": 100
}

```
[Обратно към ReadMe](/README.md)