# <b>Bicycle Management eXtreme- BMX</b>

### Резюме
Приложението трябва да обслужва завод за производство на велосипеди. Заводът произвежда три основни модела велосипеди, като в зависимост от избора на клиента всеки компонент може да има по няколко разновидности. Всеки един клиент, след избора на основният вид велосипед, може да избира какви модели и марки компоненти свързани с него да добавя.

## Сървиси

- DropdownsContentService е сървис, който взима записите на частите от категория рамки от базата и ги връща под формата на колекция от ДТО обекти. Също така на база Id на избрана рамка връща колекция от съвместимите за нея части под формата на колекция от ДТО обекти. При подадено Id има функционалността да вземе от базата и върне цялата налична информация за частта записана под този Id номер под формата на ДТО обект.
- OrderManagerService е сървис, който взима записите на изчакващите одобрение поръчки (pending orders), отказаните (rejected orders) и завършените (finished orders) от базата и ги връща под формата на колекция от ДТО обекти. Също така при подадено Id има функционалността да одобри (approve) изчакващите одобрение поръчки (pending orders) и отказаните (rejected orders) или да отхвърли поръчка (reject order).

## Базов (основен) URL
Базовия URL е общ за всички API заявки и е:
- https://localhost:7047

## Крайни точки (APIs):
- AccountPageController дава възсможността да се ползва функционалността на DropdownsContentService. 

### [`GET /api/accountpage/frames`](/ReadMeFiles/AccountPage/Frames.md)
### [`GET /api/accountpage/compatible_parts`](/ReadMeFiles/AccountPage/CompatibleParts.md)
### [`GET /api/accountpage/selected_part`](/ReadMeFiles/AccountPage/SelectedPart.md)
- ClientOrderController дава възсможността на потребителя на създава, преглежда и изтрива поръчки, направени от него.

### [`POST /api/ClientOrder/create`](/ReadMeFiles/ClientOrder/Create.md)
### [`POST /api/ClientOrder/progress`](/ReadMeFiles/ClientOrder/Progress.md)
### [`POST /api/ClientOrder/delete`](/ReadMeFiles/ClientOrder/Delete.md)


1. Response:

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

2. Request:

```
GET /api/accountpage/compatible_parts?id=1
```

2. Response:

```json
	
Download
[
  {
    "id": 4,
    "name": "Wheel of the Year for road",
    "description": "Best wheels ever!",
    "intend": "Best wheels for a road usage",
    "imageUrls": [],
    "oemNumber": "oemtest",
    "rating": [
      3,
      4
    ],
    "type": 1,
    "salePrice": 75
  },
  {
    "id": 7,
    "name": "Shift",
    "description": "Worst shift - have only one!",
    "intend": "Base shift - have only one",
    "imageUrls": [],
    "oemNumber": "oemtest",
    "rating": [
      5,
      6
    ],
    "type": 1,
    "salePrice": 250
  },
  {
    "id": 12,
    "name": "Shift",
    "description": "Cheap standard shift!",
    "intend": "Cheap standard shift for a road usage",
    "imageUrls": [],
    "oemNumber": "oemtest21",
    "rating": [],
    "type": 1,
    "salePrice": 220
  },
  {
    "id": 14,
    "name": "Budget wheel for road",
    "description": "Budget wheel ever!",
    "intend": "Budget wheel for a road usage",
    "imageUrls": [],
    "oemNumber": "oemtest34",
    "rating": [],
    "type": 1,
    "salePrice": 65
 ]

```

3. Request:

```
GET /api/accountpage/selected_part?id=1
```

3. Response:

```json
{
  "id": 1,
  "name": "Frame Road",
  "description": "Best frame in the road!",
  "intend": "For road usage",
  "imageUrls": [
    "test"
  ],
  "oemNumber": "oemtest",
  "rating": [
    3,
    4,
    5
  ],
  "type": 1,
  "salePrice": 100
}

```
## Errors

This API uses the following error codes:

- `204 No Content`: The requested resource was empty.
- `404 Bad Request`: The request was malformed or missing required parameters.
- `500 Internal Server Error`: An unexpected error occurred on the server.

- OrderManagerController дава възсможността да се ползва функционалността на OrderManagerService. 
### `GET /api/manager/pending_orders`
### `GET /api/manager/rejected_orders`
### `POST /api/manager/delete_order?orderId=3`
### `POST /api/manager/approve_order?orderId=3`
### `POST /api/manager/approve_rejected_order?orderId=3`
### `POST /api/manager/reject_order?orderId=3`
### `GET /api/manager/finished_orders`

### Отговор - До тук!!!

### `GET /api/accountpage/frames` Връща колекция от JSON обекти със следните пропъртита:
- `id`: Уникален идентификатор на частта.
- `name`: Наименованието на частта.
- `description`: Описание на частта.
- `type`: Тип на частта.

### `GET /api/accountpage/compatible_parts` Връща колекция от JSON обекти със следните пропъртита:
- `id`: Уникален идентификатор на частта.
- `name`: Наименованието на частта.
- `type`: Тип на частта.
- `description`: Описание на частта.
- `intend`: Описание на предназначението на частта.
- `type`: Тип на частта.
- `imageUrls`: лист от imageUrls
- `oemnumber`: Уникален заводски номер на частта.
- `rating`: лист от дадените до момента рейтинги на частта.
- `saleprice`: единична цена на частта.
  
### `GET /api/accountpage/selected_part` Връща JSON обект със следните пропъртита:
- `id`: Уникален идентификатор на частта.
- `name`: Наименованието на частта.
- `type`: Тип на частта.
- `description`: Описание на частта.
- `intend`: Описание на предназначението на частта.
- `type`: Тип на частта.
- `imageUrls`: лист от imageUrls
- `oemnumber`: Уникален заводски номер на частта.
- `rating`: лист от дадените до момента рейтинги на частта.
- `saleprice`: единична цена на частта.
  
### Examples

1. Request:

```
GET /api/accountpage/frames
```

1. Response:

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

2. Request:

```
GET /api/accountpage/compatible_parts?id=1
```

2. Response:

```json
	
Download
[
  {
    "id": 4,
    "name": "Wheel of the Year for road",
    "description": "Best wheels ever!",
    "intend": "Best wheels for a road usage",
    "imageUrls": [],
    "oemNumber": "oemtest",
    "rating": [
      3,
      4
    ],
    "type": 1,
    "salePrice": 75
  },
  {
    "id": 7,
    "name": "Shift",
    "description": "Worst shift - have only one!",
    "intend": "Base shift - have only one",
    "imageUrls": [],
    "oemNumber": "oemtest",
    "rating": [
      5,
      6
    ],
    "type": 1,
    "salePrice": 250
  },
  {
    "id": 12,
    "name": "Shift",
    "description": "Cheap standard shift!",
    "intend": "Cheap standard shift for a road usage",
    "imageUrls": [],
    "oemNumber": "oemtest21",
    "rating": [],
    "type": 1,
    "salePrice": 220
  },
  {
    "id": 14,
    "name": "Budget wheel for road",
    "description": "Budget wheel ever!",
    "intend": "Budget wheel for a road usage",
    "imageUrls": [],
    "oemNumber": "oemtest34",
    "rating": [],
    "type": 1,
    "salePrice": 65
 ]

```

3. Request:

```
GET /api/accountpage/selected_part?id=1
```

3. Response:

```json
{
  "id": 1,
  "name": "Frame Road",
  "description": "Best frame in the road!",
  "intend": "For road usage",
  "imageUrls": [
    "test"
  ],
  "oemNumber": "oemtest",
  "rating": [
    3,
    4,
    5
  ],
  "type": 1,
  "salePrice": 100
}

## Errors

This API uses the following error codes:

- `204 No Content`: The requested resource was empty.
- `404 Bad Request`: The request was malformed or missing required parameters.
- `500 Internal Server Error`: An unexpected error occurred on the server.


#### Markdown template (за пример)

Markdown is a lightweight markup language based on the formatting conventions
that people naturally use in email.
As [John Gruber] writes on the [Markdown site][df1]

> The overriding design goal for Markdown's
> formatting syntax is to make it as readable
> as possible. The idea is that a
> Markdown-formatted document should be
> publishable as-is, as plain text, without
> looking like it's been marked up with tags
> or formatting instructions.

This text you see here is *actually- written in Markdown! To get a feel
for Markdown's syntax, type some text into the left window and
watch the results in the right.