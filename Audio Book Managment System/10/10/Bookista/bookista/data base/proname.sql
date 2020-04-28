CREATE DEFINER=`root`@`localhost` PROCEDURE `proname`(in nameof varchar(45), out ans int)
BEGIN
select count(*) into ans
from bookista.collections
where nameof = name;
END