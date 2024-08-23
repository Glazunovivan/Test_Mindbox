
/*============ Продукты ==============*/
CREATE TABLE products
( 
    _id  UNIQUEIDENTIFIER NOT NULL DEFAULT NEWID(), 
    _name NVARCHAR(200) NOT NULL,
    PRIMARY KEY (_id) 
); 

INSERT INTO products (_id, _name) VALUES ('c8c2ab91-352f-4e13-951d-565858166beb', 'Eggs Selyanochka'); 
INSERT INTO products (_id, _name) VALUES ('9362fb6b-604b-4c64-96bf-3162b5bef5a7', 'Bread Kazdyi Den');
INSERT INTO products (_id, _name) VALUES ('ef210684-b308-4647-bab5-6069ddd3d15d', 'Water Aqua Meneralle');
INSERT INTO products (_id, _name) VALUES ('7f738c4f-1be9-4d6b-b2a5-7ae91e516a34', 'Milk Domik v Derevne');

/*============ Категории ==============*/
CREATE TABLE categories
(
    _id UNIQUEIDENTIFIER NOT NULL DEFAULT NEWID(),
    _name NVARCHAR(200) NOT NULL,
    PRIMARY KEY (_id) 
);

INSERT INTO categories (_id, _name) VALUES ('6f51e862-9884-42d6-a914-a88a97c2335a', 'Egg'); 
INSERT INTO categories (_id, _name) VALUES ('d643f681-4f85-40fd-9db6-e76aee20019d', 'Bread');
INSERT INTO categories (_id, _name) VALUES ('3d3f2700-5dc9-48c1-a1b2-964b55b17f82', 'Drinks');
INSERT INTO categories (_id, _name) VALUES ('f5db70ed-8a07-4f26-9513-d26381056945', 'Dairy');

/*====== "Многие ко многим"===========*/
CREATE TABLE rx_products_categories
(
    _id_product  UNIQUEIDENTIFIER NOT NULL REFERENCES products (_id),
    _id_category UNIQUEIDENTIFIER NOT NULL REFERENCES categories (_id)
)

INSERT INTO rx_products_categories (_id_product, _id_category) VALUES ('c8c2ab91-352f-4e13-951d-565858166beb', '6f51e862-9884-42d6-a914-a88a97c2335a');
INSERT INTO rx_products_categories (_id_product, _id_category) VALUES ('7f738c4f-1be9-4d6b-b2a5-7ae91e516a34', '3d3f2700-5dc9-48c1-a1b2-964b55b17f82');
INSERT INTO rx_products_categories (_id_product, _id_category) VALUES ('7f738c4f-1be9-4d6b-b2a5-7ae91e516a34', 'f5db70ed-8a07-4f26-9513-d26381056945');


/*======= Варианты реализации ========*/
--#1
SELECT products._name AS [Название продукта], 
       categories._name AS [Название категории]
FROM products
LEFT JOIN rx_products_categories ON products._id = rx_products_categories._id_product
LEFT JOIN categories ON categories._id = rx_products_categories._id_category

--#2
SELECT products._name AS [Название продукта],
	   categories._name AS [Название категории]
FROM products
OUTER APPLY (SELECT categories._name
             FROM rx_products_categories
             INNER JOIN categories ON categories._id = rx_products_categories._id_category
             WHERE rx_products_categories._id_product = products._id) AS categories 

--#3
SELECT products._name AS [Название продукта],
       categories._name AS [Название категории]
FROM rx_products_categories
FULL JOIN products ON products._id = rx_products_categories._id_product
LEFT JOIN categories ON categories._id = rx_products_categories._id_category