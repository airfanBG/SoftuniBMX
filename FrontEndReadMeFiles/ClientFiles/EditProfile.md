###### [Back to Content](/FrontEndReadMeFiles/README.md)

### Промяна на потребителските данни

![Clipboard01](https://github.com/yuchormanski/React-BMX-Project/assets/693307/c5dee1f4-a0fc-4115-9d03-8c3dc9737120)

Има възможност за редактиране на данните, добавяне на допълнителна сума в сметката му . както и избор на снимка от локалната му машина. Допустимите файлово разширения са jpg, jpeg и png.

Редактираната информация се изпраща към базата с данни във формат:

```json
{
  "role": "string",
  "firstName": "string",
  "lastName": "string",
  "balance": number,
  "phone": "string",
  "city": "string",
  "imageUrl": base64,
  "address": {
    "country": "string",
    "district": "string",
    "postCode": "string",
    "block": "string",
    "apartment": "string",
    "street": "",
    "strNumber": "string",
    "floor": number
  }
}
```

- Файла със снимката се изпраща във формат `base64`
