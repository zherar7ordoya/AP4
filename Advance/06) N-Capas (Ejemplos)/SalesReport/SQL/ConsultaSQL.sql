SELECT o.order_id,
       o.order_date,
       c.first_name + ', ' + c.last_name    AS customer,
       products=Stuff((SELECT ' - ' + 'x'
                              + CONVERT(VARCHAR (10), oi2.quantity) + ' '
                              + product_name
                       FROM   order_items oi2
                              INNER JOIN products
                                      ON products.product_id = oi2.product_id
                       WHERE  oi2.order_id = oi1.order_id
                       FOR xml path('')), 1, 2, ''),
       Sum(( quantity * price ) - discount) AS total_amount
FROM   orders o
       INNER JOIN customers c
               ON c.customer_id = o.customer_id
       INNER JOIN order_items oi1
               ON oi1.order_id = o.order_id
WHERE  o.order_date BETWEEN '2019/01/01' AND '2020/12/31'
GROUP  BY o.order_id,
          oi1.order_id,
          o.order_date,
          c.first_name,
          c.last_name
ORDER  BY o.order_id ASC 