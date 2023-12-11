
[Обратно към ReadMe](/README.md)

# `POST /api/employee_оrder/quality_assurance`
Екшън, който потвърждава качеството на дадена поръчка и изпраща към следващ етап.

## Request
 Приема параметър - query string.
- `orderId`: Уникален идентификатор на поръчката, която е одобрена от служител на качественият контрол.

### Example:
```url
https://localhost:7047/api/employee_оrder/quality_assurance?orderId=1
```
## Response
След правилен запис в базата данни, екшънът връща статус код 200.

При грешка връща статус код 400.

[Обратно към ReadMe](/README.md)