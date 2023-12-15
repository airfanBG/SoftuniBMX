[Обратно към ReadMe](/README.md)

### Отговор

### `GET /api/accountpage/frames` Връща колекция от JSON обекти със следните пропъртита:
- `id`: Уникален идентификатор на частта.
- `name`: Наименованието на частта.
- `description`: Описание на частта.
- `type`: Тип на частта.

### Examples:

## Request:

```
GET /api/accountpage/frames
```

## Response:

```json
[
  {
    "id": 1,
    "name": "Frame Road",
    "description": "Best frame in the road!",
    "type": 1
  },
  {
    "id": 2,
    "name": "Frame Montain",
    "description": "Best frame in the montain",
    "type": 2
  },
  {
    "id": 3,
    "name": "Frame Road woman",
    "description": "Best frame in the road for womens",
    "type": 3
  }
]

```
[Обратно към ReadMe](/README.md)