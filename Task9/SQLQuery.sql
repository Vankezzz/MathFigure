CREATE TABLE Categories (
Id INT PRIMARY KEY,
NameOfCategories NVARCHAR(255) NOT NULL
);

INSERT INTO Categories
VALUES
(1, 'Молочный отдел'),
(2, 'Орехи'),
(3, 'То, что вы ищите');

CREATE TABLE Products (
Id INT PRIMARY KEY,
NameOfProducts NVARCHAR(255) NOT NULL
);

INSERT INTO Products
VALUES
(1, 'Творог'),
(2, 'Грецкий орех'),
(3, 'Фисташки'),
(4, '400 кусочков хорошего настроения');


CREATE TABLE ProductCategories (
ProductId INT FOREIGN KEY REFERENCES Products(Id),
CategoryId INT FOREIGN KEY REFERENCES Categories(Id),
PRIMARY KEY (ProductId, CategoryId)
);

INSERT INTO ProductCategories
VALUES
(1, 1),
(2, 2),
(3, 2),
(4, 3);

SELECT NameOfProducts, NameOfCategories
FROM Products P
LEFT JOIN ProductCategories PC
ON P.Id = PC.ProductId
LEFT JOIN Categories C
ON PC.CategoryId = C.Id;
