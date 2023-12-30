###### [Back to Content](/FrontEndReadMeFiles/README.md)

## Profile page

Страницата да ва информация за текущият служител, като предоставя възможност за [редакция](/FrontEndReadMeFiles/Employee/EditProfile.md) на профила, включващ и задаване на собствена профилна снимка (аватар)

#### Content

- [Front-end](/FrontEndReadMeFiles/README.md)
- [Back-end](/FrontEndReadMeFiles/README.md)
- [Main](/README.md)

### Извиква пълната информация за потребителя от базата с данни. Прави се заявка на адрес:

## `GET /api/client/info/:id`

### Response

```json
{
  "accessToken": "",
  "user": {
    "imageUrl": "",
    "repass": "Lea-12",
    "role": "worker", // set-by-system
    "email": "leaorgana@b-free.com",
    "firstName": "Lea",
    "lastName": "Organa",
    "department": "Accessory",
    "phoneNumber": "+359656456456343",
    "position": "Master", // set-by-system
    "dateOfHire": "12/2/2023",
    "isManager": true/false,// set-by-system
    "id": 7
  }
}
```

Всички служители имат електронна поща с едно и също domain name - `@b-free.com`

След успешно влизане в системата се определя полята на потребителя на база `role` пропъртито в информацията, получена като отговор от сървъра , във формат:

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
