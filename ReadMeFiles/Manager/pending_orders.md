### Отговор

### `GET /api/manager/pending_orders?page=1` - Връща общия брой поръчки и колекция от 6 поръчки на страница (при подаване на номер на страница се връщат обектите от подадения номер страница), подредени от най-стара-към най-нова, представляващи JSON обекти със следните пропъртита:
- `orderId"`: Уникален идентификатор на поръчката.
- `serialNumber"`: Уникален идентификатор на велосипеда.
- `dateCreated`: Дата и час на създаване на поръчката.
- `orderParts`: Колекция от поръчаните части.
- `partId`: Уникален идентификатор на частта.
- `description`: Описание на частта.
- `partName`: Наименованието на частта.
- `partQuantity`: Количество на поръчаната част.
- `partQuantityInStock`: Количество на склад от поръчаната част.

### Examples:

## Request:

```
GET /api/manager/pending_orders?page=1
```

## Response:

```json
	
{
  "totalOrdersCount": 7,
  "orders": [
    {
      "orderId": 3,
      "serialNumber": "BID12345680",
      "dateCreated": "2023-12-06 18:21:38.4126365",
      "dateFinished": null,
      "orderParts": [
        {
          "partId": 1,
          "description": "test",
          "partName": "Frame OG",
          "partQuantity": 1,
          "partQunatityInStock": 2
        },
        {
          "partId": 5,
          "description": "test",
          "partName": "Wheel of the Year for montain",
          "partQuantity": 6,
          "partQunatityInStock": 40
        },
        {
          "partId": 11,
          "description": "test",
          "partName": "Road budget Shifts",
          "partQuantity": 4,
          "partQunatityInStock": 21
        }
      ]
    },
    {
      "orderId": 4,
      "serialNumber": "BID12345680",
      "dateCreated": "2023-12-06 18:21:38.4126368",
      "dateFinished": null,
      "orderParts": [
        {
          "partId": 1,
          "description": "test",
          "partName": "Frame OG",
          "partQuantity": 1,
          "partQunatityInStock": 2
        },
        {
          "partId": 5,
          "description": "test",
          "partName": "Wheel of the Year for montain",
          "partQuantity": 6,
          "partQunatityInStock": 40
        },
        {
          "partId": 11,
          "description": "test",
          "partName": "Road budget Shifts",
          "partQuantity": 4,
          "partQunatityInStock": 21
        }
      ]
    },
    {
      "orderId": 5,
      "serialNumber": "BID12345680",
      "dateCreated": "2023-12-06 18:21:38.4126371",
      "dateFinished": null,
      "orderParts": [
        {
          "partId": 1,
          "description": "test",
          "partName": "Frame OG",
          "partQuantity": 1,
          "partQunatityInStock": 2
        },
        {
          "partId": 5,
          "description": "test",
          "partName": "Wheel of the Year for montain",
          "partQuantity": 6,
          "partQunatityInStock": 40
        },
        {
          "partId": 11,
          "description": "test",
          "partName": "Road budget Shifts",
          "partQuantity": 4,
          "partQunatityInStock": 21
        }
      ]
    },
    {
      "orderId": 6,
      "serialNumber": "BID12345680",
      "dateCreated": "2023-12-06 18:21:38.4126375",
      "dateFinished": null,
      "orderParts": [
        {
          "partId": 1,
          "description": "test",
          "partName": "Frame OG",
          "partQuantity": 1,
          "partQunatityInStock": 2
        },
        {
          "partId": 5,
          "description": "test",
          "partName": "Wheel of the Year for montain",
          "partQuantity": 6,
          "partQunatityInStock": 40
        },
        {
          "partId": 11,
          "description": "test",
          "partName": "Road budget Shifts",
          "partQuantity": 4,
          "partQunatityInStock": 21
        }
      ]
    },
    {
      "orderId": 7,
      "serialNumber": "BID12345680",
      "dateCreated": "2023-12-06 18:21:38.4126378",
      "dateFinished": null,
      "orderParts": [
        {
          "partId": 1,
          "description": "test",
          "partName": "Frame OG",
          "partQuantity": 1,
          "partQunatityInStock": 2
        },
        {
          "partId": 5,
          "description": "test",
          "partName": "Wheel of the Year for montain",
          "partQuantity": 6,
          "partQunatityInStock": 40
        },
        {
          "partId": 11,
          "description": "test",
          "partName": "Road budget Shifts",
          "partQuantity": 4,
          "partQunatityInStock": 21
        }
      ]
    },
    {
      "orderId": 8,
      "serialNumber": "BID12345680",
      "dateCreated": "2023-12-06 18:21:38.4126381",
      "dateFinished": null,
      "orderParts": [
        {
          "partId": 1,
          "description": "test",
          "partName": "Frame OG",
          "partQuantity": 1,
          "partQunatityInStock": 2
        },
        {
          "partId": 5,
          "description": "test",
          "partName": "Wheel of the Year for montain",
          "partQuantity": 6,
          "partQunatityInStock": 40
        },
        {
          "partId": 11,
          "description": "test",
          "partName": "Road budget Shifts",
          "partQuantity": 4,
          "partQunatityInStock": 21
        }
      ]
    }
  ]
}

```