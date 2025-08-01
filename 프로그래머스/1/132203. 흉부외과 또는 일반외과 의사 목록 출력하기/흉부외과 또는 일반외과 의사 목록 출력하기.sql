-- MySQL
-- DATE_FORMAT(now(), '%Y-%M-%D') -> 2020-MAY-1st
-- DATE_FORMAT(now(), '%y-%m-%d') -> 20-03-01


SELECT dr_name, dr_id, mcdp_cd, DATE_FORMAT(hire_ymd, '%Y-%m-%d')
FROM DOCTOR
WHERE mcdp_cd = 'CS' OR mcdp_cd = 'GS'
ORDER BY hire_ymd DESC, dr_name;