### Employee - Edit customer information

#### Content

- [Front-end](/FrontEndReadMeFiles/README.md)
- [Back-end](/FrontEndReadMeFiles/README.md)
- [Main](/README.md)

Има възможност за редактиране на данните, добавяне на допълнителна сума в сметката му . както и избор на снимка от локалната му машина. Допустимите файлово разширения са jpeg и png.

Редактираната информация се изпраща към базата с данни на адрес:

### `PUT /users/:id`

във формат:

```json
{
        "imageUrl": base64,
        "role": "worker", // set-by-system
        "email":"name@b-free.com",
        "firstName":"",
        "lastName":"",
        "department":"", // set-by-system
        "phone": "",
        "position": "", // set-by-system
        "dateOfHire": "", // set-by-system
        "isManager": true/false // set-by-system
      }
```

- Файла със снимката се изпраща във формат `base64`
