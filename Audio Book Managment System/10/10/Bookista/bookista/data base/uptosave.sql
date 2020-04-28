CREATE DEFINER=`root`@`localhost` PROCEDURE `uptosave`()
BEGIN
update bookista.login
set state = '0';
END