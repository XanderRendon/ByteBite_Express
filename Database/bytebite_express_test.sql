
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

