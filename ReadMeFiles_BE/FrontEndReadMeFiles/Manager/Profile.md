###### [Back to Content](/FrontEndReadMeFiles/README.md)

## Profile page

Приложението дава възможност потребителя сам да сглоби велосипед, като избере, поетапно от възможностите - рамка, колела и аксесоари.
При избиране на страницата CREATE се прави първоначална заявка за зареждане на възможностите за избор на рамка, като основна част на велосипеда.

#### Content

- [Order](/FrontEndReadMeFiles/ClientFiles/Order.md)
- [Front-end](/FrontEndReadMeFiles/README.md)
- [Back-end](/FrontEndReadMeFiles/README.md)
- [Main](/README.md)

### Извиква пълната информация за потребителя от базата с данни. Прави се заявка на адрес:

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

- Когато ролята на потребителя е Служител

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
    "isManager": true/false,
    "id": 7
  }
}
```

````



### [Employee](#employee)

- [Content](#content)

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
````

- От страницата на потребителският си профил, служителя има достъп до редакция на същия. Формата на заявката е описана по-горе.
- Служителите са разделени в различни категории по дейност и длъжност.
- Достъп до страница с текущите поръчки, които предстоят да се извършат в съответната категория - рамка, гуми, аксесоари.
