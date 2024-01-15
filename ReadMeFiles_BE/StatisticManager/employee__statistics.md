[Обратно към ReadMe](/README.md)

### Отговор

### `GET /api/manager_statistics/order_part_statistics` Връща JSON обект с вложени JSON обекти със следните пропъртита:
- `orderStatistics`: Обект съдържащ статистиката за поръчките.
- `totalIncome`: Общо приходи от продажби.
- `totalSendedOrdersCount`: Общо изпратени поръчки.
- `incomeForSelectedPeriod`: Приходи за избрания период.
- `sendedOrdersCountForSelectedPeriod`: Общо изпратени поръчки за избрания период.
- `partTotalStatistics`: Статистика за бестселър частта за целия период на дейност.
- `partName`: Наименованието на частта.
- `serialNumber`: Сериен номер на частта.
- `imageUrl`: Линк към снимката на частта.
- `partId`: Уникален идентификатор на частта.
- `partSoldCount`: Продадено количество от частта.
- `partIncome`: Приходи от продажби на частта.
- `partPeriodStatistics`: Статистика за бестселър частта за избран период на дейност.
- `partName`: Наименованието на частта.
- `serialNumber`: Сериен номер на частта.
- `imageUrl`: Линк към снимката на частта.
- `partId`: Уникален идентификатор на частта.
- `partSoldCount`: Продадено количество от частта.
- `partIncome`: Приходи от продажби на частта.

### Examples:

## Request:

```
GET /api/manager_statistics/order_part_statistics
```

## Response:

```json
	
{
  "orderStatistics": {
    "totalIncome": 354.17,
    "totalSendedOrdersCount": 1,
    "incomeForSelectedPeriod": 354.17,
    "sendedOrdersCountForSelectedPeriod": 1
  },
  "partTotalStatistics": {
    "partName": "Frame OG",
    "serialNumber": "BIDPASQC123",
    "imageUrl": "https://yuchormanski.free.bg/bikes/frame1.webp",
    "partId": 1,
    "partSoldCount": 1,
    "partIncome": 100
  },
  "partPeriodStatistics": {
    "partName": "Frame OG",
    "serialNumber": "BIDPASQC123",
    "imageUrl": "https://yuchormanski.free.bg/bikes/frame1.webp",
    "partId": 1,
    "partSoldCount": 1,
    "partIncome": 100
  }
}

```
[Обратно към ReadMe](/README.md)