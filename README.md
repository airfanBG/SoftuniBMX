# <b>Bicycle Management eXtreme- BMX</b>

![hweader](https://github.com/airfanBG/SoftuniBMX/assets/693307/ca4ea5d2-f7f4-449c-b83c-59e0e1e312e8)

## Резюме

Приложението обслужва пълната функционалност на предприятие за производство на велосипеди, както и неговото менажиране. Заводът произвежда три основни модела велосипеди, като в зависимост от избора на клиента всеки компонент може да има по няколко разновидности.

Приложението дава възможност потребителя сам да сглоби велосипед, като избере, поетапно от възможностите - рамка, колела и аксесоари.
При избиране на страницата CREATE се прави първоначална заявка за зареждане на възможностите за избор на рамка, като основна част на велосипеда.

Приложението покрива всички дейности за потребителския избор и работения процес.

#### 👤 От страна на клиента

- избор на някой от базовите велосипеди или асемблиране на собствен модел от възможните предоставени като избор части.
- Проследяване на поръчката до нейното завършване
- Редактиране на клиентския профил
- Добавяне на средства за изплащане на избрания продукт

#### 🏭 От страна на предприятието

- Изработване на избраната селекция и одобрение от качествен контрол
- Проследяване на работния процес
- Изработване и асемблиране на частите на текущите поръчки в съответните отдели
- Одобрение на продукта, връщане за рекламация на детаил или бракуване
- Добавяне на нови кадри, обслужващи работния процес
- Проследяване на работния процес на служителите, като екип и по отделно
- Начисляване на трудово възнаграждение
- Управление на склад и складова наличност
- Добавяне на нови доставчици
- Извършване на нови поръчки при недостатъчна наличност на части

## ⚙️ Използвани технологии

- Front-end
  - React.js
  - JavaScript
  - HTML/CSS
- Back-end
  - ASP.NET
  - MySQL

### Предварително регистрирани потребители

| EMAIL              | PASSWORD | РОЛЯ               |
| ------------------ | -------- | ------------------ |
| client@test.bg     | 123456   | потребител         |
| marinov@b-free.com | User123! | работник рамки     |
| todorov@b-free.com | User123! | работник колела    |
| marinov@b-free.com | User123! | работник аксесоари |
| ivanov@b-free.com  | User123! | контрол качество   |
| manager@b-free.com | User123! | мениджър           |

## 📃 Съдържание и навигиране в приложението

1. <h4 style='text-decoration:underline'>Стартова страница</h4>

   - [Index Page](/FrontEndReadMeFiles/IndexPage/indexPage.md)

2. <h4 style='text-decoration:underline'>Създаване на профил и влизане в системата</h4>

   - [Регистрация](/FrontEndReadMeFiles/Autentication/Register.md)
   - [Вход](/FrontEndReadMeFiles/Autentication/Login.md)
   - [Забравена парола](/FrontEndReadMeFiles/Autentication/ForgotPassword.md)

3. <h4 style='text-decoration:underline'>Клиент</h4>

   - [Профилна страница](/FrontEndReadMeFiles/ClientFiles/Profile.md)
   - [Редактиране на профил](/FrontEndReadMeFiles/ClientFiles/EditProfile.md)
   - [Банкова информация](/FrontEndReadMeFiles/ClientFiles/Bank.md)
   - [Създаване на поръчка](/FrontEndReadMeFiles/ClientFiles/Order.md)
   - [Потребителска кошница](/FrontEndReadMeFiles/ClientFiles/Cart.md)
   - [Проследяване на поръчка](/FrontEndReadMeFiles/ClientFiles/TrackOrder.md)
   - [Готови поръчки](/FrontEndReadMeFiles/ClientFiles/Ready.md)
   - [Архив](/FrontEndReadMeFiles/ClientFiles/Archive.md)
   - [Коментари и рейтинг](/FrontEndReadMeFiles/ClientFiles/Comments.md)

4. <h4 style='text-decoration:underline'>Служители</h4>

   - [Профилна страница](/FrontEndReadMeFiles/ClientFiles/Profile.md)
   - [Поръчки за отдела](/FrontEndReadMeFiles/Employee/CurrentOrders.md)
   - [Заплати](/FrontEndReadMeFiles/Employee/EmpSalary.md)

5. <h4 style='text-decoration:underline'> Качествен контрол</h4>

   - [Профилна страница](/FrontEndReadMeFiles/ClientFiles/Profile.md)
   - [Одобрение на поръчки](/FrontEndReadMeFiles/QualityControl/Orders.md)

6. <h4 style='text-decoration:underline'>Управител</h4>

   - ! [Нови поръчки](/FrontEndReadMeFiles/Manager/NewOrders.md)
   - ! [В продукция](/FrontEndReadMeFiles/Manager/Production.md)
   - ! [Завършени](/FrontEndReadMeFiles/Manager/ComplitedOrders.md)
   - ! [Изпратени](FrontEndReadMeFiles/Manager/DispatchedOrders.md)
   - ! [Служители](/FrontEndReadMeFiles/Manager/Employers.md)
   - ! [Нов служител](/FrontEndReadMeFiles/Manager/AddEmployee.md)
   - ! [Заплати](/FrontEndReadMeFiles/Manager/)
   - ! [Склад](FrontEndReadMeFiles/Manager/Storage.md)
   - ! [Статистика]()

<!-- 7. <h4 style='text-decoration:underline'>[Крайни точки](/ReadMeFiles_BE)</h4> -->

7. #### <h4 style='text-decoration:underline'>Крайни точки</h4>

- 📍 [Връзка](/BE_README.md) към лист със съдържание и описание на всички API отправни точки , използвани в приложението

8. #### 🔗 [Архитектура](http://yuchormanski.free.bg/bikes/high-level-dependencies.html)

## 👥 Team

<img src="https://cdn-icons-png.flaticon.com/256/174/174857.png" width="15"> - Connect with us on LinkedIn:

- [Daniel Damyanov ]() - Team Leader

- [Nikolay Yuchormanski](www.linkedin.com/in/nikolay-yuchormanski-b34975255) - Front-End

- [Todor Todorov](https://www.linkedin.com/in/тодор-тодоров-178aaa263/) - Back-End

- [Krasimir Iliev](https://www.linkedin.com/in/krasimir-iliev-bb4189238/) - Back-End

- [Georgi Kolev](www.linkedin.com/in/george-kolev-b37005109) - Back-End

### 🤝 Contributing

Ако харесвате нашата работа, моля, подкрепете ни като оставите
<a class="github-button" href="https://github.com/airfanBG/SoftuniBMX" data-color-scheme="no-preference: light; light: light; dark: dark;" data-icon="octicon-star" data-size="large" aria-label="Star airfanBG/SoftuniBMX on GitHub">Звезда⭐</a>.

<!-- If you would like to suppurt us you could do it by giving a  -->
<!-- <a class="github-button" href="https://github.com/airfanBG/SoftuniBMX" data-color-scheme="no-preference: light; light: light; dark: dark;" data-icon="octicon-star" data-size="large" aria-label="Star airfanBG/SoftuniBMX on GitHub">Star ⭐</a>. -->

### 📧 Contact Us

- [Даниел Дамянов]()

- Nikolay Yuchormanski - [yuchormanski@gmail.com](mailto:yuchormanski@gmail.com)

- Todor Todorov - [t.todorov135@gmail.com,](mailto:t.todorov135@gmail.com)

- [Krasimir Iliev]()

- Georgi Kolev - [jorjo7@abv.bg](mailto:jorjo7@abv.bg)

### 📜 Лиценз / License

- <img src="https://flagpedia.net/data/flags/h120/bg.webp" width="20"> - Този проект е лицензиран съгласно MIT лиценз. Вижте [лицензния](https://github.com/airfanBG/SoftuniBMX/tree/develop?tab=License-1-ov-file) файл за подробности.

- <img src="https://flagpedia.net/data/flags/w580/gb.webp" width="20" /> - This project is licensed under the MIT License. See the [LICENSE](https://github.com/airfanBG/SoftuniBMX/tree/develop?tab=License-1-ov-file) file for details.

🌐 Thank you for joining us on this journey to Bike Management eXtreme - BMX! 🌐
