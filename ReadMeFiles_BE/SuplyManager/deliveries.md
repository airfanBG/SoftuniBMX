[Обратно към ReadMe](/README.md)

### Отговор

### `GET /api/supplys_manager/deliveries?page=1` Връща колекция от JSON обекти със следните пропъртита:
- `totalDeliveriesCount`: Общ брой на доставките в базата.
- `deliveries`: Колекция от обекти deliveries.
- `partId`: Уникален идентификатор на часта.
- `quantityDelivered`: Доставено количество.
- `note`: Бележка относно поръчката.
- `suplierId`: Идентификационен номер на доставчика.
- `orderParts`: Колекция от поръчаните части.
- `id`: Уникален идентификатор на доставката.
- `partName`: Наименованието на частта.
- `partQuantity`: Количество на поръчаната част.
- `supplierName`: Име на доставчика.
- `dateDelivered`: Дата на доставяне.

### Examples:

## Request:

```
GET /api/supplys_manager/deliveries?page=1
```

## Response:

```json
	
{
  "totalDeliveriesCount": 9,
  "deliveries": [
    {
      "partId": 1,
      "quantityDelivered": 2,
      "note": "text",
      "suplierId": 1,
      "id": 1,
      "partName": null,
      "supplierName": null,
      "dateDelivered": "2023-12-09T12:32:13.0599521"
    },
    {
      "partId": 4,
      "quantityDelivered": 2,
      "note": "text2",
      "suplierId": 2,
      "id": 2,
      "partName": null,
      "supplierName": null,
      "dateDelivered": "2023-12-09T12:32:13.0599524"
    },
    {
      "partId": 7,
      "quantityDelivered": 1,
      "note": "text2",
      "suplierId": 3,
      "id": 3,
      "partName": null,
      "supplierName": null,
      "dateDelivered": "2023-12-09T12:32:13.0599527"
    },
    {
      "partId": 1,
      "quantityDelivered": 4,
      "note": "text4",
      "suplierId": 1,
      "id": 4,
      "partName": null,
      "supplierName": null,
      "dateDelivered": "2023-12-09T12:32:13.059953"
    },
    {
      "partId": 4,
      "quantityDelivered": 4,
      "note": "text5",
      "suplierId": 2,
      "id": 5,
      "partName": null,
      "supplierName": null,
      "dateDelivered": "2023-12-09T12:32:13.0599533"
    },
    {
      "partId": 7,
      "quantityDelivered": 2,
      "note": "text6",
      "suplierId": 3,
      "id": 6,
      "partName": null,
      "supplierName": null,
      "dateDelivered": "2023-12-09T12:32:13.0599535"
    }
  ]
}

```
[Обратно към ReadMe](/README.md)