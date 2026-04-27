-- 코드를 입력하세요
SELECT user_id,
       nickname,
       price AS total_sales
  FROM used_goods_user a, (SELECT writer_id, SUM(price) AS price
                             FROM used_goods_board
                            WHERE status = 'DONE'
                            GROUP BY writer_id
                           HAVING SUM(price) >= 700000) b
 WHERE a.user_id = b.writer_id
 ORDER By total_sales