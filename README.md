# Итоговая проверочная работа #
Необходимо написать программу, которая из имеющегося массива строк формирует массив из строк, длина которого меньше либо равна 3 символам.

Для решения днаной задачи была составлена блок-схема основной содержательной части:

![Блок-схема основного метода](Блок-схема_основной_части.png)

Поставленная задача была решена с выделением следующих методов:

1. Заполнение исходного массива из строки, введенной пользователем с клавиатуры. В качестве разделителя используется символ пробела или запятая.
2. Распечатывание массива в требуемом виде:
```
[<значение1>, <значение2>, <значение3>]
```
3.  Метод, который считает количество строк в массиве, длина которых не превышает указанное значение.
4. Основной метод, который формирует новый массив, в качестве размера которого используется подсчитанное количество строк указанной длины, и вносит в данный новый массив строки исходного массива, длина которых не превышает указанное значение.

В результате работы программы пользователю требуется ввести с клавиатуры через пробел или запятую произвольный ряд строк, а так же предельное количество символов. Программа выводит на печать исходный массив и новый массив, в который входят только строки, не превышающие предельной длины.
