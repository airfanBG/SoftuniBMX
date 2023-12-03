# TOP

BASE_URL: "http://localhost:9000",

## Index page

`GET/ indexPage`: "/indexPage" <!-- ? -->- [Index Page Model](#index-page-model)

## Client

`POST/ register_client`: "/api/client/register" <!-- "/api/client/register" -->- [Register Client Model](#register-client-model)

`POST/ login_client`: "api/client/login" <!-- "/login" --> - [Login Client Model](#login-client-model)

`GET/ info_client`: "/api/client/info?id=1" <!-- "/users/:id" -->

`POST/ logout`: MISSING

`PUT/ update_client`: MISSING +id <!-- "/users/:id" -->

`GET/ orders_client`: MISSING +id - [Order by id client model](#order-by-id-client-model)

`GET/ archive_client`: MISSING

## Employee

`POST/ register_employee`: "/api/employee/register" <!-- "/api/employee/register" -->- [Register employee model](#register-employee-model)

`POST/ login_employee`: "api/employee/login" - [Login Employee Model](#login-employee-model)

`GET/ info_employee`: "/api/employee/info?id=1" <!-- "/users/:id" -->

`POST/ logout`: MISSING

`PUT/ update_employee`: MISSING +id <!-- "/users/:id" -->

`GET/ get_all_employers`: MISSING

## Parts

`GET/ frames`: "/api/accountpage/frames" - [Frames model](#frames-model)

`GET/ wheels`: "/api/accountpage/wheels" <!-- ? -->

`GET/ accessory`: "/api/accountpage/accessory" <!-- ? -->

`GET/ selected_part`: "/api/accountpage/selected_part?id=1" - [Selected part model](#selected-part-model)

`GET/ compatible_parts`: "/api/accountpage/compatible_parts?id=1"

## Manager

`GET/ pending_orders`: "/api/manager/pending_orders" <!-- ? -->

`GET/ in_progress_orders`: MISSING <!-- ? --> +id - [Order by id manager model](#order-by-id-manager-model)

`GET/ rejected_orders`: "/api/manager/rejected_orders"

`POST/ delete_order`: "/api/manager/delete_order?orderId=3"

`POST/ approve_order`: "/api/manager/approve_order?orderId=3"

`POST/ `: "/api/manager/approve_rejected_order?orderId=3" ?

`POST/ reject_order`: "/api/manager/reject_order?orderId=3"

`GET/ finished_orders`: "/api/manager/finished_orders"

`GET/ in-progress`: MISSING

## MODELS

#### Index Page Model

- Back to [TOP](#top)

```json
{
  "userId": "string",
  "userFullName": "string",
  "defaultBikes": [
    {
      "id": 0,
      "modelName": "string",
      "imageUrl": "string",
      "parts": [
        {
          "partId": 0,
          "partName": "string"
        }
      ]
    }
  ],
  "comments": [
    {
      "id": 0,
      "partId": 0,
      "partName": "string",
      "clientId": "string",
      "clientFullName": "string",
      "clientImageUrl": "string",
      "commentDescription": "string",
      "dateCreated": "string"
    }
  ]
}
```

## Auth Model

#### Register Client Model

- Back to [TOP](#top)

```json
{
  "firstName": "Firstname",
  "lastName": "Lastname",
  "email": "email@email.bg",
  "password": "Password1",
  "repass": "Password1",
  "iban": "QWESADAXC456FDGH",
  "balance": 123456789.01,
  "phone": "+3591234567890",
  "city": "Veliko Tarnowo",
  "role": "user",
  "address": {
    "country": "Bulgaria",
    "postCode": "1000",
    "district": "Veliko Tarnowo",
    "block": "10B",
    "floor": 6,
    "apartment": "21",
    "street": "Street",
    "strNumber": "54"
  }
}
```

#### Login Client Model

- Back to [TOP](#top)

```json
{
  "email": "string",
  "password": "string"
}
```

#### Register employee model

- Back to [TOP](#top)

```json
{
  "email": "username + @b-free.com",
  "firstName": "string",
  "lastName": "string",
  "phoneNumber": "string",
  "password": "string",
  "confirmPassword": "string",
  "position": "string",
  "dateOfHire": "string",
  "department": "string",
  "isManeger": true,
  "role": "string"
}
```

#### Login Employee Model

- Back to [TOP](#top)

```json
{
  "email": "string",
  "password": "string"
}
```

## CLient

#### Order by ID client model

- Back to [TOP](#top)

```json
{
  "orderId": 4,
  "serialNumber": "BID28YUOCH0",
  "dateCreated": "15/11/2023",
  "orderStates": [
    {
      "partId": 1,
      "partType": "Frame",
      "partModel": "Frame OG",
      "nameOfEmplоyeeProducedThePart": " ",
      "isProduced": false
    },
    {
      "partId": 2,
      "partType": "Wheel",
      "partModel": "Wheel of the Year",
      "nameOfEmplоyeeProducedThePart": " ",
      "isProduced": false
    },
    {
      "partId": 3,
      "partType": "Shift",
      "partModel": "Shift",
      "nameOfEmplоyeeProducedThePart": " ",
      "isProduced": false
    }
  ]
}
```

## Employee

## Quality Control

## Manager

#### Order by ID manager model

- Back to [TOP](#top)

```json
{
  "orderId": 4,
  "serialNumber": "BID28YUOCH0",
  "dateCreated": "15/11/2023",
  "orderStates": [
    {
      "partId": 1,
      "partType": "Frame",
      "partModel": "Frame OG",
      "nameOfEmplоyeeProducedThePart": " ",
      "isProduced": false
    },
    {
      "partId": 2,
      "partType": "Wheel",
      "partModel": "Wheel of the Year",
      "nameOfEmplоyeeProducedThePart": " ",
      "isProduced": false
    },
    {
      "partId": 3,
      "partType": "Shift",
      "partModel": "Shift",
      "nameOfEmplоyeeProducedThePart": " ",
      "isProduced": false
    }
  ]
}
```

## Parts Model

#### Frames model

- Back to [TOP](#top)

```json
{
  "id": "",
  "name": "",
  "description": "",
  "type": ""
}
```

#### Selected part model

- Back to [TOP](#top)

```json
{
  "id": 1,
  "name": "Frame OG",
  "description": "Best frame in the world!",
  "imageUrls": ["test1", "test2"],
  "oemNumber": "oemtest",
  "rating": 5,
  "type": 1,
  "salePrice": 100.0
}
```
