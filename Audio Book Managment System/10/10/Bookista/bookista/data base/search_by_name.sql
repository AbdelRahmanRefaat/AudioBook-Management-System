CREATE DEFINER=`root`@`localhost` PROCEDURE `search_by_name`(in s varchar(450))
BEGIN
select * from bookista.book
 where bookname like concat('%', s , '%');
END