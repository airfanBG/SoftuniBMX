[Обратно към ReadMe](/README.md)

### Отговор

### `GET /api/manager_statistics/employees_full_statistic` Връща JSON обект с вложени JSON обекти със следните пропъртита:
- `employeeFullStatistics`: Обект съдържащ общата статистиката за работниците.
- `totalWorkedMinutes`: Общо изработени минути.
- `totalWorkedOrders`: Общо изработени поръчки.
- `proudWorkerName`: Имената на работника (Топ работника) работил най-много с най-малко рекламации.
- `proudWorkerDepartment`: Отдела на работника работил най-много с най-малко рекламации.
- `proudWorkerSubDepartment`: Позицията на работника работил най-много с най-малко рекламации.
- `proudWorkerWorkedOrders`: Изработени поръчки от топ работника.
- `proudWorkerWorkedMinutes`: Изработени минути от топ работника.
- `proudWorkerWorkedImageUrl`: Линк към снимката на топ работника.
- `employeePeriodStatistics`: Обект съдържащ общата статистиката за работниците за избран времеви интервал.
- `totalWorkedMinutes`: Общо изработени минути за избран времеви интервал.
- `totalWorkedOrders`: Общо изработени поръчки за избран времеви интервал.
- `proudWorkerName`: Имената на работника (Топ работника) работил най-много с най-малко рекламации за избран времеви интервал.
- `proudWorkerDepartment`: Отдела на работника работил най-много с най-малко рекламации за избран времеви интервал.
- `proudWorkerSubDepartment`: Позицията на работника работил най-много с най-малко рекламации за избран времеви интервал.
- `proudWorkerWorkedOrders`: Изработени поръчки от топ работника за избран времеви интервал.
- `proudWorkerWorkedMinutes`: Изработени минути от топ работника за избран времеви интервал.
- `proudWorkerWorkedImageUrl`: Линк към снимката на топ работника за избран времеви интервал.

### Examples:

## Request:

```
GET /api/manager_statistics/employees_full_statistic
```

## Response:

```json
	
{
  "employeeFullStatistics": {
    "totalWorkedMinutes": 25,
    "totalWorkedOrders": 3,
    "proudWorkerName": "Marin Marinov",
    "proudWorkerDepartment": "Workshop",
    "proudWorkerSubDepartment": "Frame",
    "proudWorkerWorkedOrders": 3,
    "proudWorkerWorkedMinutes": 25,
    "proudWorkerWorkedImageUrl": "https://localhost:7047/files/profiles/frameworker/2024/1/21003785-a275-4139-ae20-af6a6cf8fea8/3d740d0b-cd96-4400-9227-802b1526e1e3.webp"
  },
  "employeePeriodStatistics": {
    "totalWorkedMinutes": 5,
    "totalWorkedOrders": 1,
    "proudWorkerName": "Marin Marinov",
    "proudWorkerDepartment": "Workshop",
    "proudWorkerSubDepartment": "Frame",
    "proudWorkerWorkedOrders": 1,
    "proudWorkerWorkedMinutes": 5,
    "proudWorkerWorkedImageUrl": "https://localhost:7047/files/profiles/frameworker/2024/1/21003785-a275-4139-ae20-af6a6cf8fea8/3d740d0b-cd96-4400-9227-802b1526e1e3.webp"
  }
}

```
[Обратно към ReadMe](/README.md)