
[Обратно към ReadMe](/README.md)

# `POST /api/employee_оrder/quality_assurance_return`
Екшън, който връща изработената част, която не преминава стандартите, към този, който я е произвел.

## Request
 Приема параметър от тялото на заявката в JSON формат със следната структура:

- `orderId`: Уникален идентификатор на поръчката.
- `serialNumber`: Пропъртито винаги ще е null.
- `dateCreated`: Дата на създаване на поръчката от страна на потребителя.
- `orderStates`: Колекция от частите, съставящи поръчката.
- `partId`: Идентификатор на часта.
- `partType`: Тип на часта.
- `partModel`: Разширено наименование на часта - модел.
- `nameOfEmplоyeeProducedThePart`: Името на работникът, който е изготвил/монтирал часта.
- `isProduced`: Статус за одобрене.
- `serialNumber`: Сериен номер изделието, към което е дадената част.
- `elementProduceTimeInMinutes`: Времето за изработване на часта в минути.
- `description`: Кратко описание от качесвеният контрол, какви са причините за връщане на часта към работника.
### Example:
 Body request:

```json
{
    "orderId": 1,
    "serialNumber": null,
    "dateCreated": "06/12/2023 18:21",
    "orderStates": [
        {
            "partId": 1,
            "partType": "Frame",
            "partModel": "Frame OG",
            "nameOfEmplоyeeProducedThePart": "Marin Marinov",
            "isProduced": false,
            "serialNumber": "BID12345678",
            "employeeId": "21003785-a275-4139-ae20-af6a6cf8fea8",
            "elementProduceTimeInMinutes": 70,
            "description": "do not pass"
        },
        {
            "partId": 2,
            "partType": "Frame",
            "partModel": "Wheel of the YearG",
            "nameOfEmplоyeeProducedThePart": "Todor Todorov",
            "isProduced": false,
            "serialNumber": "BID12345678",
            "employeeId": "17063948-8fdc-417e-8fb7-2ae6bf572f94",
            "elementProduceTimeInMinutes": 28,
            "description": "do not pass second item"
        },
        {
            "partId": 3,
            "partType": "Frame",
            "partModel": "Shift",
            "nameOfEmplоyeeProducedThePart": "Ivan Ivanov",
            "isProduced": true,
            "serialNumber": "BID12345678",
            "employeeId": "6af8468c-63f1-4bf2-8f88-e24b3f7a8f91",
            "elementProduceTimeInMinutes": 14,
            "description": "this pass"
        }
    ]
}
```
## Response
При валидни данни и успешно записване на записите в базата данни контролера връща колекция от JSON обекти със следната структура:

- `employeeName`: Името на работникът, който е правил тази част.
- `partName`: Името/модела на часта.
- `description`: Описание към работника, какъв е проблема.
- `serialNumber`: Серийният номер на композицията, в която се намира часта.
### Example:
```json
[
    {
        "employeeName": "Marin Marinov",
        "partName": "Frame OG",
        "description": "do not pass",
        "serialNumber": "BID12345678"
    },
    {
        "employeeName": "Todor Todorov",
        "partName": "Wheel of the YearG",
        "description": "do not pass second item",
        "serialNumber": "BID12345678"
    }
]
```
> **Забележка:** В горният пример се подават два обекта за преправяне от контрола на качество към съответнире рабоници. Отговорът е релевантен на подадените данни.

[Обратно към ReadMe](/README.md)