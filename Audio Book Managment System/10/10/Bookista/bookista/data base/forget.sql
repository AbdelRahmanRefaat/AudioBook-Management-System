CREATE DEFINER=`root`@`localhost` FUNCTION `forget`(gmail varchar(450), gend bool) RETURNS varchar(450) CHARSET latin1
BEGIN
declare ans varchar(450) default '';
if(gend = true)
then 
select password into ans
from bookista.login
where gmail = email and Gender = 'male';
else
select password into ans
from bookista.login
where gmail = email and Gender = 'female';
end if;
RETURN ans;
END