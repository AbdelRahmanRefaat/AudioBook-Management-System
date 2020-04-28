CREATE DEFINER=`root`@`localhost` FUNCTION `lastpro`(book varchar(450)) RETURNS int(11)
BEGIN
declare ans int;
set ans = 0;
select 
     count(*) into ans
from 
     bookista.bookmarks
where 
     book = bookname;
RETURN ans;
END