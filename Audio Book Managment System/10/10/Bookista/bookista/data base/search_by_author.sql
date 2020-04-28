CREATE DEFINER=`root`@`localhost` PROCEDURE `search_by_category`(in s varchar(450))
BEGIN
select * from bookista.book 
where colname like concat('%', s , '%');
END