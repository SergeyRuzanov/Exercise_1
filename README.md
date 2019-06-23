# Входные данные
Во входном файле находится распечатка одного из диалогов по UCM. В первой строке находится сообщение о том, что собеседник Феди вошел с ним в контакт. Оно выглядит так:

ЧЧ:ММ:СС: <Имя> signed on

где ЧЧ:ММ:СС – время, когда собеседник вошел в контакт, <Имя> – имя собеседника, записанное в транслите (английскими буквами). Любое число в отображении времени занимает две цифры, например, 9 часов 43 минуты 5 секунд будет выглядеть как 09:43:05.

В каждой из последующих строк (кроме самой последней строки файла) находится реплика участника диалога. Если каждой реплике присвоить ее порядковый номер (начиная с единицы), то нечетные реплики были произнесены Федей, а четные – его собеседником.

Реплика находится целиком на одной строке и состоит из метки времени, смысловой части и знака препинания конца предложения.

Метка времени имеет вид ЧЧ:ММ:СС:.

Смысловая часть отделена от метки времени пробелом и содержит текст, состоящий из больших или маленьких английских букв, цифр, пробелов, апострофов (заменяют мягкий и твердый знаки в транслите), а также запятых, точек с запятыми и круглых скобок.

Знак препинания – это восклицательный знак, вопросительный знак или точка. Он может быть опущен, в этом случае подразумевается точка.

Пример реплики:

11:22:33: Ya skazal etu frazu.

Последняя строка файла имеет вид

ЧЧ:ММ:СС: <Имя> signed off

где <Имя> – имя все того же собеседника.

Объем входного файла не превышает 20 килобайт. Длина каждой строки не превосходит 250 символов.

# Выходные данные
В выходной файл OUTPUT.TXT выведите для каждой реплики ее же, преобразованную в косвенную речь. Преобразование заключается в следующем. Сначала заключите реплику в двойные кавычки, при этом если она оканчивается на точку, то вместо точки поставьте запятую, иначе оставьте знак препинания без изменений, например:

Zakanchivayu tochkoi. → «Zakanchivayu tochkoi,» Eto voskhititel'no!	→ «Eto voskhititel'no!»

Затем поставьте пробел, три знака «–» (тире) и снова пробел, после чего выведите слово «ѕkazal» и имя собеседника, произнесшего эту реплику. После имени выведите точку. Федя запишется как «Fedya», имя его собеседника можно узнать из первой строки входного файла.
