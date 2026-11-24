
USE bytebite_express;

INSERT INTO menu_items
(name, category, price, icon_path, stock_qty, is_top_pick, is_available)
VALUES
('Classic Burger', 'Burgers', 30.00, NULL, 50, TRUE, TRUE),
('Cheese Burger', 'Burgers', 40.00, NULL, 40, TRUE, TRUE),
('Chicken Burger', 'Burgers', 45.00, NULL, 35, FALSE, TRUE),
('French Fries', 'Sides', 25.00, NULL, 60, TRUE, TRUE),
('Fried Chicken', 'Meals', 75.00, NULL, 30, TRUE, TRUE),
('Rice Meal', 'Meals', 60.00, NULL, 40, FALSE, TRUE),
('Pepsi', 'Drinks', 15.00, NULL, 100, FALSE, TRUE),
('Iced Tea', 'Drinks', 20.00, NULL, 80, FALSE, TRUE);

-- CHECK INSERTED MENU ITEMS
SELECT * FROM menu_items;




USE bytebite_express;

-- CREATE A TEST ORDER
INSERT INTO orders
(receipt_code, subtotal, tax, total, status)
VALUES
('BBE-0001', 105.00, 0.00, 105.00, 'Pending Counter');

-- ADD ITEMS TO THE ORDER
INSERT INTO order_items
(order_id, menu_item_id, quantity, unit_price)
VALUES
(1, 1, 2, 30.00),
(1, 7, 3, 15.00);

-- VIEW ORDER DETAILS
SELECT
    o.receipt_code,
    o.status,
    m.name AS item_name,
    oi.quantity,
    oi.unit_price,
    (oi.quantity * oi.unit_price) AS line_total,
    o.subtotal,
    o.tax,
    o.total,
    o.created_at
FROM orders o
JOIN order_items oi ON o.id = oi.order_id
JOIN menu_items m ON oi.menu_item_id = m.id
WHERE o.receipt_code = 'BBE-0001';





USE bytebite_express;

-- 1. DISPLAY ALL AVAILABLE MENU ITEMS
SELECT *
FROM menu_items
WHERE is_available = TRUE;

-- 2. DISPLAY MENU BY CATEGORY
SELECT *
FROM menu_items
WHERE category = 'Burgers';

-- 3. SEARCH MENU ITEMS
SELECT *
FROM menu_items
WHERE name LIKE '%Burger%';

-- 4. DISPLAY ALL ORDERS
SELECT *
FROM orders
ORDER BY created_at DESC;

-- 5. DISPLAY A COMPLETE RECEIPT
SELECT
    o.receipt_code,
    m.name AS item_name,
    oi.quantity,
    oi.unit_price,
    oi.quantity * oi.unit_price AS line_total,
    o.subtotal,
    o.tax,
    o.total,
    o.status,
    o.created_at
FROM orders o
JOIN order_items oi ON o.id = oi.order_id
JOIN menu_items m ON oi.menu_item_id = m.id
WHERE o.receipt_code = 'BBE-0001';

-- 6. DISPLAY TOTAL SALES
SELECT
    COUNT(*) AS total_orders,
    SUM(total) AS total_sales
FROM orders;

-- 7. DISPLAY LOW STOCK ITEMS
SELECT name, stock_qty
FROM menu_items
WHERE stock_qty <= 10;
