
# Практическое задание №8 Mindbox
## Задание:
> Задание:
Напишите на C# библиотеку для поставки внешним клиентам, которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам. 
>Дополнительно к работоспособности оценим:
>* Юнит-тесты
>* Легкость добавления других фигур
>* Вычисление площади фигуры без знания типа фигуры
>* Проверку на то, является ли треугольник прямоугольным


## Инструкция по работе с библиотекой:
1. Проверка работоспособности библиотеки
   * Скачать/стянуть репозиторий
   * Перейти в папку репозитория
   * Запустить проект MathFigure.sln
   * Просмотреть результатов Юнит-тестов (пройдены все)
2. Работа с библиотекой
   * Для ввода в программу круга нужно создать экземпляр класса Circle  и ввести его название (title) и радиус (radius)
     * Класс Circle использует интерфейс ICircle и реализует методы:
       * GetArea() - считает площадь круга с помощью радиуса
       * GetPerimetr() - считает периметр круга с помощью радиуса
    * Для ввода в программу ереугольника нужно создать экземпляр класса Triangle  и ввести его название (title) и длины трех сторон (first,second,third side)
      * Класс Triangle использует интерфейс ITriangle и реализует методы:
        * GetArea() - считает площадь треугольника с помощью 3 сторон
        * GetPerimetr() - считает периметр треугольника с помощью 3 сторон
    * Для ввода в программу любой другой фигуры нужно создать экземпляр класса AnyFigures  и ввести его название (title) и координаты всех вершин ввиде листа из обьектов класса Dots, который состоит из пары координат XY
      * Класс AnyFigures имеет следующие методы:
        * GetArea() - считает площадь по координатам
        * GetPerimetr() - считает периметр по координатам
