<h1>Bicycle Management eXtreme- BMX</h1>

### Резюме

Приложението трябва да обслужва завод за производство на велосипеди. Заводът произвежда три основни модела велосипеди, като в зависимост от избора на клиента всеки компонент може да има по няколко разновидности. Всеки един клиент, след избора на основният вид велосипед, може да избира какви модели и марки компоненти свързани с него да добавя.

- <a name="front-end">Front-End</a>
- <a name="back-end">Back-End</a>

## [Front-End](#front-end)

- При стартиране се извежда базова информация за приложението, възможност за избор на някое от предварително създадени модели велосипеди, както и два произволни коментара от потребители, като се прави заявка към сървър.

### Базов (основен) URL

Базовия URL е общ за всички API заявки и е:

- https://localhost:7047

### `GET /api/indexPage`,

### CLient

- Приложението дава възможност потребителя сам да сглоби велосипед , като избере, поетапно от възможностите - рамка, колела и аксесоари.
  При избиране на страницата CREATE се прави първоначална заявка за зареждане на възможностите за избор на рамка, като основна част на велосипеда.

### `GET /api/accountpage/frames`

Отговорът съдържа колекция от всички налични рамки

След зареждане на информацията и селектиране от страна на потребителя се прави отново заявка на база избраната рамка

### `GET /api/accountpage/frames/:id`

Отговор:

```json
[
  {
    "name": "Blaster",
    "oemNumber": "Colony",
    "imageUrls": [],
    "description": "Lorem, ipsum dolor sit amet consectetur adipisicing elit.",
    "rating": 1,
    "salesPrice": 98.99,
    "type": 2,
    "id": 2,
    "intend": "Freestyle"
  }
]
```

Приложението извиква данни от сървъра за зареждане на останалите падащи менюта с части, които са подходящи за селекцията.

Във всеки един момент потребителя може да промени своят избор. Цената на избраните артикули се визуализира в горния десен ъгъл.
След избор и на трите необходими компонента е възможно селекцията да се добави в потребителската кошница, само ако потребителя има регистрация в приложението.

Ако няма оторизирана сесия се препраща към Login/Register страницата.

### `HOST/auth/`

Ако потребителя се е вписал в системата се препраща към "количката"

### `HOST/profile/cart/`

И в двата случая направената селекция се запазва в `Local Storage`

Страницата се презарежда автоматично и извежда подробна информация за всяка една от избраните части.
Първоначална проверка дали има записана информация за селекция от `Local Storage`
Ако има такава се прави заявка заз извеждане на пълната информация за селекцията.

TODO: MISSING ENDPOINT!!!!!

Дава се възможност да се добави допълнително изискване от страна на клиента. Необходимо е да се избере количество на крайния продукт.

Проверява се дали потребителя има необходимата сума за да покрия 20% от общата стойност на поръчката.
Ако няма достатъчно средства се извежда съобщение , което показва това.
Ако има необходимите средства се извършва поръчката и се препраща към неговата профилна страница.

Изпраща се информация за поръчката:

## `POST /orders/`

```json
{
  "frame": {
    "name": "Blaster",
    "OEMNumber": "Colony",
    "imageUrls": [],
    "description": "Lorem, ipsum dolor sit amet consectetur adipisicing elit.",
    "rating": 1,
    "salesPrice": 98.99,
    "type": 2,
    "id": 2
  },
  "wheel": {
    "name": "SUNDAY KNOX V2",
    "OEMNumber": "87394894",
    "imageUrls": [],
    "description": "This complete front wheel allows you to change all your old parts ",
    "rating": 5,
    "salesPrice": 89.45,
    "type": 2,
    "id": 2
  },
  "accessory": {
    "name": "SUNDAY KNOX SPROCKET",
    "OEMNumber": "8739423494",
    "imageUrls": [],
    "description": "Guard sprocket from Sunday.",
    "rating": 2,
    "salesPrice": 33.45,
    "type": 2,
    "id": 7
  },
  "userText": "",
  "count": 1,
  "createdAt": 1700934872505,
  "ownerId": 1,
  "id": 1
}
```

Информацията от `Local Storage` се изтрива.

#### Profile page

- Извиква пълната информация за потребителя от базата с данни.

## `GET /api/client/info/:id`

### Response

```json
{
  "role": "user",
  "email": "petar@abv.bg",
  "firstName": "Petar",
  "lastName": "Petrov",
  "iban": "QWESADAXC456FDGH",
  "balance": 10000,
  "phone": "+3591234567890",
  "city": "Veliko Tarnovo",
  "imageUrl": "",
  "address": {
    "country": "Bulgaria",
    "district": "Veliko Tarnovo",
    "postCode": "222",
    "block": "4c",
    "apartment": "21",
    "street": "New Street",
    "strNumber": "2",
    "floor": "21"
  },
  "id": 1
}
```

- Има възможност за редактиране на данните, добавяне на допълнителна сума в сметката му . както и избор на снимка от локалната му машина. Допустимите файлово разширения са jpeg и png.

-Редактираната информация се изпраща към базата с данни на адрес:

### `PUT / MISSING ENDPOINT!!!!!!! /:id`

във формат:

### Ако е потребител:

```json
{
  "role": "",
  "email": "",
  "firstName": "",
  "lastName": "",
  "iban": "",
  "balance": "",
  "phone": "",
  "city": "",
  "imageUrl": base64,
  "address": {
    "country": "",
    "district": "",
    "postCode": "",
    "block": "",
    "apartment": "",
    "street": "",
    "strNumber": 1,
    "floor": ""
  }
}
```

### Ако потребителя е служител:

```json
{
        "imageUrl": base64,
        "role": "",
        "email":"",
        "firstName":"",
        "lastName":"",
        "department":"",
        "phone": "",
        "position": "",
        "dateOfHire": "",
        "isManager": true/false
      }


```

- Файла със снимката се изпраща във формат `base64`

### Employee

- Всички служители имат едно и също `domain name` - `@b-free.com`

  - След успешно влизане в системата се определя полята на потребителя на база `role` пропъртито в информацията, получена като отговор от сървъра , във формат:

```json
{
  "accessToken": "",
  "user": {
    "imageUrl": "",
    "repass": "Lea-12",
    "role": "worker",
    "email": "leaorgana@b-free.com",
    "firstName": "Lea",
    "lastName": "Organa",
    "department": "Accessory",
    "phoneNumber": "+359656456456343",
    "position": "Master",
    "dateOfHire": "12/2/2023",
    "isManager": false,
    "id": 7
  }
}
```

- От страницата на потребителският си профил, служителя има достъп до редакция на същия. Формата на заявката е описана по-горе.
- Служителите са разделени в различни категории по дейност и длъжност.
- Достъп до страница с текущите поръчки, които предстоят да се извършат в съответната категория - рамка, гуми, аксесоари.

## [Back-End](#back-end)

### Сървиси

- DropdownsContentService е сървис, който взима записите на частите от категория рамки от базата и ги връща под формата на колекция от ДТО обекти. Също така на база Id на избрана рамка връща колекция от съвместимите за нея части под формата на колекция от ДТО обекти. При подадено Id има функционалността да вземе от базата и върне цялата налична информация за частта записана под този Id номер под формата на ДТО обект.
- OrderManagerService е сървис, който взима записите на изчакващите одобрение поръчки (pending orders), отказаните (rejected orders) и завършените (finished orders) от базата и ги връща под формата на колекция от ДТО обекти. Също така при подадено Id има функционалността да одобри (approve) изчакващите одобрение поръчки (pending orders) и отказаните (rejected orders) или да отхвърли поръчка (reject order).

## Крайни точки (APIs):

- AccountPageController дава възсможността да се ползва функционалността на DropdownsContentService.

### `GET /api/accountpage/frames`

### `GET /api/accountpage/compatible_parts`

### `GET /api/accountpage/selected_part`

### Отговор

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
  "imageUrls": ["test"],
  "oemNumber": "oemtest",
  "rating": [3, 4, 5],
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
  }
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
  "imageUrls": ["test"],
  "oemNumber": "oemtest",
  "rating": [3, 4, 5],
  "type": 1,
  "salePrice": 100
}
```

## Errors

This API uses the following error codes:

- `204 No Content`: The requested resource was empty.
- `404 Bad Request`: The request was malformed or missing required parameters.
- `500 Internal Server Error`: An unexpected error occurred on the server.
