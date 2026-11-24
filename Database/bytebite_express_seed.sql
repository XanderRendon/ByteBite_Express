
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






