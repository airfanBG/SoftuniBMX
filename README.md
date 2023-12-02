<b>Bicycle Management eXtreme- BMX</b>

<h3>Резюме</h3>
Приложението трябва да обслужва завод за производство на велосипеди. Заводът произвежда три основни модела велосипеди, като в зависимост от избора на клиента всеки компонент може да има по няколко разновидности. Всеки един клиент, след избора на основният вид велосипед, може да избира какви модели и марки компоненти свързани с него да добавя.

## Сървиси

- DropdownsContentService е сървис, който взима записите на частите от категория рамки от базата и ги връща под формата на колекция от ДТО обекти. Също така на база Id на избрана рамка връща колекция от съвместимите за нея части под формата на колекция от ДТО обекти. При подадено Id има функционалността да вземе от базата и върне цялата налична информация за частта записана под този Id номер под формата на ДТО обект.
- OrderManagerService е сървис, който взима записите на изчакващите одобрение поръчки (pending orders), отказаните (rejected orders) и завършените (finished orders) от базата и ги връща под формата на колекция от ДТО обекти. Също така при подадено Id има функционалността да одобри (approve) изчакващите одобрение поръчки (pending orders) и отказаните (rejected orders) или да отхвърли поръчка (reject order).

## Базов (основен) URL
Базовия URL е общ за всички API заявки и е:
- https://localhost:7047

## Крайни точки (APIs):
- AccountPageController дава възсможността да се ползва функционалността на DropdownsContentService. 
### `GET /api/accountpage/frames`
### `GET /api/accountpage/compatible_parts`
### `GET /api/accountpage/selected_part`


### Отговор

### `GET /api/accountpage/frames` Връща колекция от JSON обекти със следните пропъртита:
- `id`: Уникален идентификатор на частта.
- `name`: Наименованието на частта.
- `description`: Описание на частта.
- `type`: Тип на частта.

### `GET /api/accountpage/compatible_parts` Връща колекция от JSON обекти със следните пропъртита:
- `id`: Уникален идентификатор на частта.
- `name`: Наименованието на частта.
- `type`: Тип на частта.
- `description`: Описание на частта.
- `intend`: Описание на предназначението на частта.
- `type`: Тип на частта.
- `imageUrls`: лист от imageUrls
- `oemnumber`: Уникален заводски номер на частта.
- `rating`: лист от дадените до момента рейтинги на частта.
- `saleprice`: единична цена на частта.
  
### `GET /api/accountpage/selected_part` Връща JSON обект със следните пропъртита:
- `id`: Уникален идентификатор на частта.
- `name`: Наименованието на частта.
- `type`: Тип на частта.
- `description`: Описание на частта.
- `intend`: Описание на предназначението на частта.
- `type`: Тип на частта.
- `imageUrls`: лист от imageUrls
- `oemnumber`: Уникален заводски номер на частта.
- `rating`: лист от дадените до момента рейтинги на частта.
- `saleprice`: единична цена на частта.
  
### Examples

1. Request:

```
GET /api/accountpage/frames
```

1. Response:

```json
[
  {
    "id": 1,
    "name": "Frame Road",
    "description": "Best frame in the road!",
    "type": 1
  },
  {
    "id": 2,
    "name": "Frame Montain",
    "description": "Best frame in the montain",
    "type": 2
  },
  {
    "id": 3,
    "name": "Frame Road woman",
    "description": "Best frame in the road for womens",
    "type": 3
  }
]

```

2. Request:

```
GET /api/accountpage/compatible_parts?id=1
```

2. Response:

```json
	
Download
[
  {
    "id": 4,
    "name": "Wheel of the Year for road",
    "description": "Best wheels ever!",
    "intend": "Best wheels for a road usage",
    "imageUrls": [],
    "oemNumber": "oemtest",
    "rating": [
      3,
      4
    ],
    "type": 1,
    "salePrice": 75
  },
  {
    "id": 7,
    "name": "Shift",
    "description": "Worst shift - have only one!",
    "intend": "Base shift - have only one",
    "imageUrls": [],
    "oemNumber": "oemtest",
    "rating": [
      5,
      6
    ],
    "type": 1,
    "salePrice": 250
  },
  {
    "id": 12,
    "name": "Shift",
    "description": "Cheap standard shift!",
    "intend": "Cheap standard shift for a road usage",
    "imageUrls": [],
    "oemNumber": "oemtest21",
    "rating": [],
    "type": 1,
    "salePrice": 220
  },
  {
    "id": 14,
    "name": "Budget wheel for road",
    "description": "Budget wheel ever!",
    "intend": "Budget wheel for a road usage",
    "imageUrls": [],
    "oemNumber": "oemtest34",
    "rating": [],
    "type": 1,
    "salePrice": 65
 ]

```

3. Request:

```
GET /api/accountpage/selected_part?id=1
```

3. Response:

```json
{
  "id": 1,
  "name": "Frame Road",
  "description": "Best frame in the road!",
  "intend": "For road usage",
  "imageUrls": [
    "test"
  ],
  "oemNumber": "oemtest",
  "rating": [
    3,
    4,
    5
  ],
  "type": 1,
  "salePrice": 100
}

```
## Errors

This API uses the following error codes:

- `204 No Content`: The requested resource was empty.
- `404 Bad Request`: The request was malformed or missing required parameters.
- `500 Internal Server Error`: An unexpected error occurred on the server.

- OrderManagerController дава възсможността да се ползва функционалността на OrderManagerService. 
### `GET /api/manager/pending_orders`
### `GET /api/manager/rejected_orders`
### `POST /api/manager/delete_order?orderId=3`
### `POST /api/manager/approve_order?orderId=3`
### `POST /api/manager/approve_rejected_order?orderId=3`
### `POST /api/manager/reject_order?orderId=3`
### `GET /api/manager/finished_orders`

### Отговор - До тук!!!

### `GET /api/accountpage/frames` Връща колекция от JSON обекти със следните пропъртита:
- `id`: Уникален идентификатор на частта.
- `name`: Наименованието на частта.
- `description`: Описание на частта.
- `type`: Тип на частта.

### `GET /api/accountpage/compatible_parts` Връща колекция от JSON обекти със следните пропъртита:
- `id`: Уникален идентификатор на частта.
- `name`: Наименованието на частта.
- `type`: Тип на частта.
- `description`: Описание на частта.
- `intend`: Описание на предназначението на частта.
- `type`: Тип на частта.
- `imageUrls`: лист от imageUrls
- `oemnumber`: Уникален заводски номер на частта.
- `rating`: лист от дадените до момента рейтинги на частта.
- `saleprice`: единична цена на частта.
  
### `GET /api/accountpage/selected_part` Връща JSON обект със следните пропъртита:
- `id`: Уникален идентификатор на частта.
- `name`: Наименованието на частта.
- `type`: Тип на частта.
- `description`: Описание на частта.
- `intend`: Описание на предназначението на частта.
- `type`: Тип на частта.
- `imageUrls`: лист от imageUrls
- `oemnumber`: Уникален заводски номер на частта.
- `rating`: лист от дадените до момента рейтинги на частта.
- `saleprice`: единична цена на частта.
  
### Examples

1. Request:

```
GET /api/accountpage/frames
```

1. Response:

```json
[
  {
    "id": 1,
    "name": "Frame Road",
    "description": "Best frame in the road!",
    "type": 1
  },
  {
    "id": 2,
    "name": "Frame Montain",
    "description": "Best frame in the montain",
    "type": 2
  },
  {
    "id": 3,
    "name": "Frame Road woman",
    "description": "Best frame in the road for womens",
    "type": 3
  }
]

```

2. Request:

```
GET /api/accountpage/compatible_parts?id=1
```

2. Response:

```json
	
Download
[
  {
    "id": 4,
    "name": "Wheel of the Year for road",
    "description": "Best wheels ever!",
    "intend": "Best wheels for a road usage",
    "imageUrls": [],
    "oemNumber": "oemtest",
    "rating": [
      3,
      4
    ],
    "type": 1,
    "salePrice": 75
  },
  {
    "id": 7,
    "name": "Shift",
    "description": "Worst shift - have only one!",
    "intend": "Base shift - have only one",
    "imageUrls": [],
    "oemNumber": "oemtest",
    "rating": [
      5,
      6
    ],
    "type": 1,
    "salePrice": 250
  },
  {
    "id": 12,
    "name": "Shift",
    "description": "Cheap standard shift!",
    "intend": "Cheap standard shift for a road usage",
    "imageUrls": [],
    "oemNumber": "oemtest21",
    "rating": [],
    "type": 1,
    "salePrice": 220
  },
  {
    "id": 14,
    "name": "Budget wheel for road",
    "description": "Budget wheel ever!",
    "intend": "Budget wheel for a road usage",
    "imageUrls": [],
    "oemNumber": "oemtest34",
    "rating": [],
    "type": 1,
    "salePrice": 65
 ]

```

3. Request:

```
GET /api/accountpage/selected_part?id=1
```

3. Response:

```json
{
  "id": 1,
  "name": "Frame Road",
  "description": "Best frame in the road!",
  "intend": "For road usage",
  "imageUrls": [
    "test"
  ],
  "oemNumber": "oemtest",
  "rating": [
    3,
    4,
    5
  ],
  "type": 1,
  "salePrice": 100
}

```
## Errors

This API uses the following error codes:

- `204 No Content`: The requested resource was empty.
- `404 Bad Request`: The request was malformed or missing required parameters.
- `500 Internal Server Error`: An unexpected error occurred on the server.


#### Markdown template (за пример)

Markdown is a lightweight markup language based on the formatting conventions
that people naturally use in email.
As [John Gruber] writes on the [Markdown site][df1]

> The overriding design goal for Markdown's
> formatting syntax is to make it as readable
> as possible. The idea is that a
> Markdown-formatted document should be
> publishable as-is, as plain text, without
> looking like it's been marked up with tags
> or formatting instructions.

This text you see here is *actually- written in Markdown! To get a feel
for Markdown's syntax, type some text into the left window and
watch the results in the right.

## Tech

Dillinger uses a number of open source projects to work properly:

- [AngularJS] - HTML enhanced for web apps!
- [Ace Editor] - awesome web-based text editor
- [markdown-it] - Markdown parser done right. Fast and easy to extend.
- [Twitter Bootstrap] - great UI boilerplate for modern web apps
- [node.js] - evented I/O for the backend
- [Express] - fast node.js network app framework [@tjholowaychuk]
- [Gulp] - the streaming build system
- [Breakdance](https://breakdance.github.io/breakdance/) - HTML
to Markdown converter
- [jQuery] - duh

And of course Dillinger itself is open source with a [public repository][dill]
 on GitHub.

## Installation

Dillinger requires [Node.js](https://nodejs.org/) v10+ to run.

Install the dependencies and devDependencies and start the server.

```sh
cd dillinger
npm i
node app
```

For production environments...

```sh
npm install --production
NODE_ENV=production node app
```

## Plugins

Dillinger is currently extended with the following plugins.
Instructions on how to use them in your own application are linked below.

| Plugin | README |
| ------ | ------ |
| Dropbox | [plugins/dropbox/README.md][PlDb] |
| GitHub | [plugins/github/README.md][PlGh] |
| Google Drive | [plugins/googledrive/README.md][PlGd] |
| OneDrive | [plugins/onedrive/README.md][PlOd] |
| Medium | [plugins/medium/README.md][PlMe] |
| Google Analytics | [plugins/googleanalytics/README.md][PlGa] |

## Development

Want to contribute? Great!

Dillinger uses Gulp + Webpack for fast developing.
Make a change in your file and instantaneously see your updates!

Open your favorite Terminal and run these commands.

First Tab:

```sh
node app
```

Second Tab:

```sh
gulp watch
```

(optional) Third:

```sh
karma test
```

#### Building for source

For production release:

```sh
gulp build --prod
```

Generating pre-built zip archives for distribution:

```sh
gulp build dist --prod
```

## Docker

Dillinger is very easy to install and deploy in a Docker container.

By default, the Docker will expose port 8080, so change this within the
Dockerfile if necessary. When ready, simply use the Dockerfile to
build the image.

```sh
cd dillinger
docker build -t <youruser>/dillinger:${package.json.version} .
```

This will create the dillinger image and pull in the necessary dependencies.
Be sure to swap out `${package.json.version}` with the actual
version of Dillinger.

Once done, run the Docker image and map the port to whatever you wish on
your host. In this example, we simply map port 8000 of the host to
port 8080 of the Docker (or whatever port was exposed in the Dockerfile):

```sh
docker run -d -p 8000:8080 --restart=always --cap-add=SYS_ADMIN --name=dillinger <youruser>/dillinger:${package.json.version}
```

> Note: `--capt-add=SYS-ADMIN` is required for PDF rendering.

Verify the deployment by navigating to your server address in
your preferred browser.

```sh
127.0.0.1:8000
```

## License

MIT

**Free Software, Hell Yeah!**

[//]: # (These are reference links used in the body of this note and get stripped out when the markdown processor does its job. There is no need to format nicely because it shouldn't be seen. Thanks SO - http://stackoverflow.com/questions/4823468/store-comments-in-markdown-syntax)

   [dill]: <https://github.com/joemccann/dillinger>
   [git-repo-url]: <https://github.com/joemccann/dillinger.git>
   [john gruber]: <http://daringfireball.net>
   [df1]: <http://daringfireball.net/projects/markdown/>
   [markdown-it]: <https://github.com/markdown-it/markdown-it>
   [Ace Editor]: <http://ace.ajax.org>
   [node.js]: <http://nodejs.org>
   [Twitter Bootstrap]: <http://twitter.github.com/bootstrap/>
   [jQuery]: <http://jquery.com>
   [@tjholowaychuk]: <http://twitter.com/tjholowaychuk>
   [express]: <http://expressjs.com>
   [AngularJS]: <http://angularjs.org>
   [Gulp]: <http://gulpjs.com>

   [PlDb]: <https://github.com/joemccann/dillinger/tree/master/plugins/dropbox/README.md>
   [PlGh]: <https://github.com/joemccann/dillinger/tree/master/plugins/github/README.md>
   [PlGd]: <https://github.com/joemccann/dillinger/tree/master/plugins/googledrive/README.md>
   [PlOd]: <https://github.com/joemccann/dillinger/tree/master/plugins/onedrive/README.md>
   [PlMe]: <https://github.com/joemccann/dillinger/tree/master/plugins/medium/README.md>
   [PlGa]: <https://github.com/RahulHP/dillinger/blob/master/plugins/googleanalytics/README.md>
