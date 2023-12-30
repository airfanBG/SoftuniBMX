###### [Back to Content](/FrontEndReadMeFiles/README.md)

## Profile page

![Clipboard01](https://github.com/yuchormanski/React-BMX-Project/assets/693307/62869e15-9d89-418d-8ba4-d9d10f1f524d)

Приложението дава възможност потребителя сам да сглоби велосипед, като избере, поетапно от възможностите - рамка, колела и аксесоари.
При избиране на страницата CREATE се прави първоначална заявка за зареждане на възможностите за избор на рамка, като основна част на велосипеда.

#### Content

- [Order](/FrontEndReadMeFiles/ClientFiles/Order.md)
- [Front-end](/FrontEndReadMeFiles/README.md)
- [Back-end](/FrontEndReadMeFiles/README.md)
- [Main](/README.md)

### Извиква пълната информация за потребителя от базата с данни. Прави се заявка на адрес:

<!-- ## `GET /api/client/info/:id` -->

## GET "/users/:id"

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
  "imageUrl": base64,
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

След успешно влизане в системата се задава полята на потребителя - `user`

От страницата на потребителският си профил, клиентът има достъп до [редакция](/FrontEndReadMeFiles/ClientFiles/EditProfile.md) на същия. Формата на заявката е описана по-горе, както и да промени или качи собствена снимка, като аватар
