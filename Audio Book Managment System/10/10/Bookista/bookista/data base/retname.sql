CREATE DEFINER=`root`@`localhost` FUNCTION `retname`(statue varchar(2)) RETURNS varchar(45) CHARSET latin1
BEGIN
declare ans varchar(45) default '';
select 
      username into ans
from 
      bookista.login
where 
      state = statue;
RETURN ans;
END