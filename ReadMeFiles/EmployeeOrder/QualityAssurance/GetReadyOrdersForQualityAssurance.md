
[Обратно към ReadMe](/README.md)

# `GET /api/employee_оrder/quality_assurance`
Екшън, който връща колекция от поръчки, на които всички части са произведени/монтирани.

## Request
 Екшънът, не приема параметри. Изпълнава се съгласно с правомощията, дадени на работника. Рабоникът, трябва да има роля "QualityAssurance" (към мометан така го изписвам, но търпи промяна)
## Response
При валидни данни и успешно записване на записите в базата данни контролера връща JSON обект със следната структура:

- `orderId`: Уникален идентификатор на направената поръчка.
- `serialNumber`: Полето е null.
- `dateCreated`: Дата на създаване на поръчката от страна на клиента.
- `orderStates`: Колекция от информация за определена част от поръчката.
- `partId`: Идентификатор на поръчаната част.
- `partType`: Пипът на поръчаната част.
- `nameOfEmplоyeeProducedThePart`: Името на работника, произвел часта.
- `isProduced`: Проверка, дали частта е готова. 
- `serialNumber`: Сериен номер на продукта, към който е текущата част.
- `employeeId`: Идентификатор на работника.
### Example:
```json
[
    {
        "orderId": 1,
        "serialNumber": null,
        "dateCreated": "05/12/2023 16:12",
        "orderStates": [
            {
                "partId": 1,
                "partType": "Frame",
                "partModel": "Frame OG",
                "nameOfEmplоyeeProducedThePart": "Marin Marinov",
                "isProduced": true,
                "serialNumber": "BID12345678",
                "employeeId": "21003785-a275-4139-ae20-af6a6cf8fea8"
            },
            {
                "partId": 2,
                "partType": "Frame",
                "partModel": "Wheel of the YearG",
                "nameOfEmplоyeeProducedThePart": "Todor Todorov",
                "isProduced": true,
                "serialNumber": "BID12345678",
                "employeeId": "17063948-8fdc-417e-8fb7-2ae6bf572f94"
            },
            {
                "partId": 3,
                "partType": "Frame",
                "partModel": "Shift",
                "nameOfEmplоyeeProducedThePart": "Ivan Ivanov",
                "isProduced": true,
                "serialNumber": "BID12345678",
                "employeeId": "6af8468c-63f1-4bf2-8f88-e24b3f7a8f91"
            }
        ]
    }
]
```

[Обратно към ReadMe](/README.md)