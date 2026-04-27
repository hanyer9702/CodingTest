-- 코드를 입력하세요
SELECT a.animal_id AS animal_id,
       a.name AS name
  FROM animal_ins a, animal_outs b
 WHERE a.animal_id = b.animal_id
   AND a.datetime > b.datetime
 ORDER BY a.datetime