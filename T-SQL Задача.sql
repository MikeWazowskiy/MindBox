SELECT Products.name, Category.name 
FROM Products
LEFT FOIN ProdCat 
ON Products.id = ProdCat.products_id
INNER JOIN Category 
ON Category.id = ProdCat.category_id
ORDER BY Products.name