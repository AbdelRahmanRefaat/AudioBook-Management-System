CREATE DEFINER=`root`@`localhost` FUNCTION `find`(nameof varchar(45)) RETURNS tinyint(1)
BEGIN
declare ansf int default 0;
call proname(nameof, ansf);
if(ansf > 0) then
RETURN 1;
else 
return 0;
end if;
END