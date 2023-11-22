<b>Bicycle Management eXtreme- BMX</b>

<h3>Резюме</h3>
Приложението трябва да обслужва завод за производство на велосипеди. Заводът произвежда три основни модела велосипеди, като в зависимост от избора на клиента всеки компонент може да има по няколко разновидности. Всеки един клиент, след избора на основният вид велосипед, може да избира какви модели и марки компоненти свързани с него да добавя.

# ROUTES

HOST URL is in environment.js file

    - All routes endpoints are in environment.js file

- Home page fetch request
- - [HOST/indexPage](http://localhost:3030/data/indexPage)
- Data for index page should be changed according to project deployment service

### Create page

- On page load get the all available frames from DB
- - [HOST/data/frames](http://localhost:3030/data/frames)
- On selected frame is made new request
- - [HOST/data/frames/:selected_frame_id](http://localhost:3030/data/frames/:ids)

##### Wheels selection is available after frame selection

- Wheels selection depends on frame model -
  - criteria = 'type[frame.type]'
  - [HOST/data/wheels?where=type=criteria](http://localhost:3030/data/wheels?where=type%20LIKE%20%22${criteria}%22)

##### Parts selection is available after selecting wheel

- Parts selection depends on wheel model -
  - criteria = 'wheelBase[wheelBase]'
  - [HOST/data/parts?where=type=criteria](http://localhost:3030/data/wheels?where=type%20LIKE%20%22${criteria}%22)

### Authorization

User can login in system after successful registration with email and password. The session is stored in browser's Local storage

- path for login is stored in environment.js file
- - [HOST/users/login]()

Registration require First and Last name, valid email, password, IBAN, amount for buying , telephone number and address

- path for registration is stored in environment.js file
- - [HOST/users/register]()

### Order route

[/orders]()
