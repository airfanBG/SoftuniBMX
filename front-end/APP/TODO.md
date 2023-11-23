# Important

- ENDPOINTS
  - в ORDERS отиват всички поръчки от клиент, за одобрение от мениджър

1.  за всички поръчки, като колекция в ORDERS - GET/orders
2.  за добавяне на поръчка в ORDERS - POST/orders
3.  след одобрение от мениджър от orders отива в production - DELETE/orders:id; POST/production
4.  промяна на данни на потребителя при поръчка - удържат му се 20% - PUT/user:id
5.  за да няма проблем с наименованията на пропъртитата ми пратете response-a от Postman
6.  при селекция от дропдауните има наследственост на последващата селекция. Ще получавам филтрирана колекция или аз ще го правя?

## MANAGER

    [ ] - New Orders
    [ ] - Orders in production
    [ ] - Finished orders
    [ ] - Employees list
            [ ] - employee info ( profile info, category, orders )
            [ ] - add employee form
    [ ] - Statistic

## CLIENT

    [ ] - add orders in profile list
    [ ] - after successful order remove cart icon from navbar

## LOGIN

според ролята се изпраща заявка на разли1ни ендпоийнти
