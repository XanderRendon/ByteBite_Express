
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
