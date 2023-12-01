# <b>Bicycle Management eXtreme- BMX</b>

### Резюме
Приложението трябва да обслужва завод за производство на велосипеди. Заводът произвежда три основни модела велосипеди, като в зависимост от избора на клиента всеки компонент може да има по няколко разновидности. Всеки един клиент, след избора на основният вид велосипед, може да избира какви модели и марки компоненти свързани с него да добавя.

## Сървиси

- DropdownsContentService е сървис, който взима записите на частите от категория рамки от базата и ги връща под формата на колекция от ДТО обекти. Също така на база Id на избрана рамка връща колекция от съвместимите за нея части под формата на колекция от ДТО обекти. При подадено Id има функционалността да вземе от базата и върне цялата налична информация за частта записана под този Id номер под формата на ДТО обект.

## Базов (основен) URL
Базовия URL е общ за всички API заявки и е:
- https://localhost:7047

## Крайни точки (APIs)
- AccountPageController дава възсможността да се ползва функционалността на DropdownsContentService. 

### [`GET /api/accountpage/frames`](/ReadMeFiles/AccountPage/Frames.md)
### [`GET /api/accountpage/compatible_parts`](/ReadMeFiles/AccountPage/CompatibleParts.md)
### [`GET /api/accountpage/selected_part`](/ReadMeFiles/AccountPage/SelectedPart.md)
- ClientOrderController дава възсможността на потребителя на създава, преглежда и изтрива поръчки, направени от него.

### [`POST /api/ClientOrder/create`](/ReadMeFiles/ClientOrder/Create.md)
### [`POST /api/ClientOrder/progress`](/ReadMeFiles/ClientOrder/Progress.md)
### [`POST /api/ClientOrder/delete`](/ReadMeFiles/ClientOrder/Delete.md)



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