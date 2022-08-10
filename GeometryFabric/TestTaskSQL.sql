
SELECT Product.Name as ProductName, Category.Name as CategoryName 
FROM Product
LEFT JOIN ProductToCategory on ProductToCategory.ProductID = Product.ID
LEFT JOIN Category on ProductToCategory.CategoryID = Category.ID