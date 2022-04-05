USE BikeStore

GO

SELECT
Orders.order_id AS 'Order',
CONVERT(VARCHAR, Orders.order_date, 6) AS 'Date',
Customers.first_name + ', ' + Customers.last_name AS 'Customer',

Products = STUFF(
(
SELECT '|| ' + CONVERT(VARCHAR(10), Items2.quantity) + ' ' + Products.product_name
FROM Order_Items AS Items2
INNER JOIN Products
ON Products.product_id = Items2.product_id
WHERE Items2.order_id = Items1.order_id
FOR XML PATH('')), 1, 2, ''),

FORMAT(SUM((Items1.quantity * Items1.price) - Items1.discount), 'C') AS 'Total'

FROM Orders

INNER JOIN Customers
ON Customers.customer_id = Orders.customer_id

INNER JOIN Order_Items AS Items1
ON  Items1.order_id = Orders.order_id

WHERE Orders.order_date
BETWEEN '2022/01/01' AND '2022/01/31'

GROUP BY
Orders.order_id,
Items1.order_id,
Orders.order_date,
Customers.first_name,
Customers.last_name

ORDER BY
Orders.order_id