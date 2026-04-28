SELECT EXTRACT(YEAR FROM sales_date) AS year, 
       EXTRACT(MONTH FROM sales_date) AS month, 
       COUNT(DISTINCT user_id) AS purchased_users,
       ROUND(COUNT(DISTINCT user_id) / (SELECT COUNT(*) AS cnt
                           FROM user_info 
                          WHERE TO_CHAR(joined, 'YYYY-MM-DD') BETWEEN '2021-01-01' AND '2021-12-31'), 1) AS puchased_ratio
  FROM online_sale
 WHERE user_id IN (SELECT user_id 
                     FROM user_info 
                    WHERE TO_CHAR(joined, 'YYYY-MM-DD') BETWEEN '2021-01-01' AND '2021-12-31')
 GROUP BY EXTRACT(YEAR FROM sales_date), EXTRACT(MONTH FROM sales_date)
 ORDER BY year, month