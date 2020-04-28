CREATE DEFINER=`root`@`localhost` PROCEDURE `push`(in book varchar(450), in sec int(11), in ans varchar(450))
BEGIN
insert into bookista.bookmarks(bookname, time, name)
values(book, sec, ans);
END