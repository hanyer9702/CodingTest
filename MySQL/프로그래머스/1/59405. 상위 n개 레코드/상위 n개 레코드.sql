-- 코드를 입력하세요
SELECT name
  FROM ANIMAL_INS
 WHERE datetime = (SELECT MIN(datetime) from ANIMAL_INS);