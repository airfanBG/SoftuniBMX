###### [Back to Content](/FrontEndReadMeFiles/README.md)

![Clipboard01](https://github.com/yuchormanski/React-BMX-Project/assets/693307/17ff52dd-cc7c-4b19-ab17-51b42371c3b0)

### При поръчка, от страна на клиента се прави заявка на адрес:
#### `GET /frames`

<!-- #### `GET /api/accountpage/frames` -->

Отговорът съдържа колекция от всички налични рамки

След зареждане на информацията и селектиране от страна на потребителя се прави отново заявка на база избраната рамка

### `GET /frames/:id`

<!-- ### `GET /api/accountpage/frames/:id` -->

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

![Clipboard01](https://github.com/yuchormanski/React-BMX-Project/assets/693307/89998311-9bd1-4781-b88e-e2c738f33a28)

И в двата случая направената селекция се запазва в `Local Storage`

Страницата се презарежда автоматично и извежда подробна информация за всяка една от избраните части.
Първоначална проверка дали има записана информация за селекция от `Local Storage`
Ако има такава се прави заявка заз извеждане на пълната информация за селекцията.

<!-- TODO: MISSING ENDPOINT!!!!! -->

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
