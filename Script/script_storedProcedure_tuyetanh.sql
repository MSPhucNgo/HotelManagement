-- —Screen 1: Services for customer

-- 1. search bằng roomid

use HotelManagement
go

create 
--alter 
proc usp_SearchRoomByID_svs(@roomid char(5)) 
as 
begin transaction
	select br.ID_ROOM, cus.NAME, cus.PHONE, bf.ARRIVAL_DATE, bf.DEPARTURE_DATE  from BOOKING_ROOM br join BOOKING_FORM bf on br.ID_BOOKING = bf.ID_BOOKING
		join CUSTOMER cus on bf.CUSTOMER= cus.ID_CUSTOMER 
		where br.ID_ROOM=@roomid
		order by bf.ARRIVAL_DATE 
commit

exec usp_SearchRoomByID_svs '12345';
-- 
select * from HOTEL_SERVICE;
select * from ROOM_SERVICE;

go
-- 3. ds các dịch vụ của phòng đó
create 
--alter 
proc usp_getServicesOfRoom_svs(@roomid char(5)) 
as 
begin transaction
	select ser.NAME, ser.UNIT, ser.PRICE, ser.STATUS from HOTEL_SERVICE ser join ROOM_SERVICE rser on ser.ID_SERVICE = rser.ID_SERVICE 
	where rser.ID_ROOM=@roomid
commit

exec usp_getServicesOfRoom_svs '1002';

select * from DISCOUNT_PROMOTION;
select * from DISCOUNT_SERVICE;

create 
--alter 
proc usp__svs() 
as 
begin transaction
	
commit
