
USE bytebite_express;

-- 1. REDUCE STOCK AFTER AN ORDER
UPDATE menu_items
SET stock_qty = stock_qty - 2
WHERE id = 1 AND stock_qty >= 2;

UPDATE menu_items
SET stock_qty = stock_qty - 3
WHERE id = 7 AND stock_qty >= 3;

-- 2. UPDATE ORDER STATUS
UPDATE orders
SET status = 'Preparing'
WHERE receipt_code = 'BBE-0001';

-- 3. CHECK UPDATED STOCK
SELECT id, name, stock_qty
FROM menu_items
WHERE id IN (1, 7);

-- 4. CHECK UPDATED ORDER STATUS
SELECT receipt_code, status, total
FROM orders
WHERE receipt_code = 'BBE-0001';
