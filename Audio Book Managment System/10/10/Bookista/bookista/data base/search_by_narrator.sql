CREATE DEFINER=`root`@`localhost` PROCEDURE `search_by_narrator`(in s varchar(450))
BEGIN
select * from bookista.book
 where narrator like concat('%', s , '%');
END