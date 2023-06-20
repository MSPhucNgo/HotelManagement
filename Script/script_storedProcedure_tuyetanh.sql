-- —Screen 1: Services for customer

-- 1. search bằng roomid

use HotelManagement
go

create 
--alter 
proc usp_SearchRoomByID_svs(@roomid char(5)) 
as 
begin transaction
	select bf.ID_BOOKING, br.ID_ROOM, cus.ID_CUSTOMER, cus.NAME, cus.PHONE, bf.ARRIVAL_DATE, bf.DEPARTURE_DATE  from BOOKING_ROOM br join BOOKING_FORM bf on br.ID_BOOKING = bf.ID_BOOKING
		join CUSTOMER cus on bf.CUSTOMER= cus.ID_CUSTOMER 
		where br.ID_ROOM=@roomid
		order by bf.ARRIVAL_DATE 
commit

exec usp_SearchRoomByID_svs '1002';
-- 


go
-- 3. ds các dịch vụ của phòng đó
create 
--alter 
proc usp_getServicesOfRoom_svs(@roomid char(5), @serv nvarchar(100)) 
as 
begin transaction
	select ser.ID_SERVICE, NAME, ser.UNIT, ser.PRICE, ser.STATUS from HOTEL_SERVICE ser join ROOM_SERVICE rser on ser.ID_SERVICE = rser.ID_SERVICE 
	where rser.ID_ROOM=@roomid and ser.NAME like '%' + @serv + '%'
commit

exec usp_getServicesOfRoom_svs '1002', N'';

select * from DISCOUNT_PROMOTION;
select * from DISCOUNT_SERVICE;
select * from HOTEL_SERVICE;
select * from ROOM_SERVICE;
select * from SERVICE_BILL
select * from SERVICE_BILL
--4 . 4. chi tiết service
go

create 
--alter 
proc usp_getDetailOfService_svs(@serviceId char(10)) 
as 
begin transaction
	select ID_SERVICE, Name, DESCRIPTION, PRICE, UNIT, STATUS from HOTEL_SERVICE ser
	where ser.ID_SERVICE=@serviceId
commit


exec usp_getDetailOfService_svs 'SEV0793150'


go

create 
--alter 
proc usp_getDiscountOfService_svs(@serviceId char(10)) 
as 
begin transaction
	select * from DISCOUNT_PROMOTION disc join DISCOUNT_SERVICE disc_ser on disc.ID_DISCOUNT=disc_ser.ID_DISCOUNT
	where disc_ser.ID_SERVICE=@serviceId and disc.START_TIME < GETDATE() and disc.END_TIME > GETDATE()
commit

go

create 
--alter 
proc usp_getAllServices_svs(@nameServ nvarchar(20)) 
as 
begin transaction
	--set @nameServ = @nameServ + '%';
	select * from HOTEL_SERVICE ser
	where ser.NAME like '%' + @nameServ + '%'
commit

exec usp_getAllServices_svs N'';

--
go
create 
--alter 
proc usp_createServiceCoupon_svs(@customer char(5), @name nvarchar(100),@serviceId char(10), @description nvarchar(100), @price int, @amount int, @empid char(5), @total_price int, @usingdate char(30), @discount float, @idbill char(5) ) 
as 
begin transaction
	declare @idserviceBill char(5);
	set @idbill= '12345';
	set @idserviceBill='12345'
	set @
	insert into SERVICE_FORM (ID_SERVICE_FORM, NAME, DESCRIPTION, PRICE, AMOUNT, ID_SERVICE, FORM_CREATOR, CUSTOMER)
	values(@idserviceBill,@name, @description,@price, @amount, @serviceId, null, @customer);

	insert into SERVICE_BILL (ID_SERVICE_BILL, TOTAL_PRICE, USED_DATE, DISCOUNT, ID_SERVICE_FORM, ID_BILL, CUSTOMER) 
	values (@idbill, @total_price, @usingdate, @discount, @idserviceBill, @idbill, @customer)

commit


select * from SERVICE_FORM
select * from SERVICE_BILL
select * from BOOKING_FORM
select * from HOTEL_SERVICE
select * from bill
select * from BOOKING_ROOM
go
create 
--alter 
proc usp__svs() 
as 
begin transaction
	
commit



select * from CUSTOMER

CREATE
-- ALTER
FUNCTION CREATE_IDSERVICE()
RETURNS CHAR(10)
AS
BEGIN
	DECLARE @ID CHAR(10)
	IF(NOT EXISTS (SELECT *
				   FROM HOTEL_SERVICE))
	BEGIN
		SET @ID = 'SEV0000001'
		RETURN @ID
	END
	ELSE
	BEGIN
		SELECT @ID = CAST(CAST(MIN(RIGHT(ID_SERVICE,7)) AS INT) + 1 AS CHAR(10))
		FROM HOTEL_SERVICE
		WHERE (RIGHT(ID_SERVICE,7) + 1) NOT IN (SELECT RIGHT(ID_SERVICE,7) FROM HOTEL_SERVICE)
	END

	DECLARE @TEMP INT = CAST(@ID AS INT)
	DECLARE @COUNT INT = 0

	WHILE(@TEMP >0)
	BEGIN
		SET @TEMP = @TEMP/10
		SET @COUNT = @COUNT + 1
	end
    
	DECLARE @CNT int =0
	WHILE(@CNT <> (7-@COUNT))
	BEGIN
		SET @ID = '0' + @ID
		SET @CNT = @CNT + 1
	END
	SET @ID = 'SEV' + @ID
	RETURN @ID
END
GO