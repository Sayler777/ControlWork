# Итоговая контрольная работа по основному блоку

## 1. Опиcание задания

Данная работа необходима для проверки ваших знаний и навыков по итогу прохождения первого блока обучения на программе Разработчик. Мы должны убедится, что базовое знакомство с IT прошло успешно.

Задача алгоритмически не самая сложная, однако для полноценного выполнения проверочной работы необходимо:

1. Создать репозиторий на GitHub
2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы выделяете её в отдельный метод)
3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
4. Написать программу, решающую поставленную задачу
5. Использовать контроль версий в работе над этим небольшим проектом (не должно быть так, что всё залито одним коммитом, как минимум этапы 2, 3, и 4 должны быть расположены в разных коммитах)

Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []

## 2. Описание  программы
Описание работы программы:
1. Начало программы начинается с ввода имеющихся (3) массивов из условия задачи.
2. Полученные массивы проходят проверку через метод CountArr, который ищет элемент массива подходящий под выполнение условий данной задачи, т.е ищет элемент массива из строк, длина которых меньше, либо равна 3 символам. Метод выводит целое число больше 0, который состоит из количества элементов проверяемого массива. (В данной версии программы не реализовано и не тестируется проверка, где метод CountArr дает результат меньше или равна 0)
3. В случае возвращеения методом CountArr целочисленного числа больше 0, дальнейшая операция проходит через метод NewArr. Данный метод создает новый массив длина которого равна вернувшемуся значению метода CountArr. Дальше метод заполняет новый массив строками из старого массива,длинна которых меньше,либо равна 3 символам, после чего выводит заполненый новый массива в консоль и завершает работц программы 

## 3. Результат выполнения контрольной работы
Результат выполнения итоговой контрольной работы по основному блоку:
1. Создан репозиторий на GitHub - https://github.com/Sayler777/ControlWork/pull/2.
2. Нарисовал блок-схему алгоритма.
3. Оформлено текстовое описанием программы.
4. Написана программа, решающую поставленную задачу.
5. Использована контроль версий с занесением различных коммитов
