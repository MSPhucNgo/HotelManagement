﻿select * from ITEM_ROOM
select * from ITEM
select * from PARTNER
select * from PARTNER_TOUR
select * from ROOM
select * from BOOKING_FORM



select distinct I.NAME, IR.AMOUNT
from ITEM I join ITEM_ROOM IR on I.ID_ITEM = IR.ID_ITEM
where IR.ID_ROOM = '1005'

SELECT DISTINCT IR.ID_ROOM,I.ID_ITEM, IR.AMOUNT, I.AMOUNT, I.NAME, I.STORAGE_LOCATION FROM ITEM_ROOM IR JOIN ITEM I ON IR.ID_ITEM = I.ID_ITEM
ORDER BY IR.ID_ROOM ASC 

select distinct IR.ID_ROOM, I.ID_ITEM, I.NAME,IR.AMOUNT, I.TYPE, I.STORAGE_LOCATION, I.CHECKOUT_DATE, I.MANAGER from ITEM I join ITEM_ROOM IR on I.ID_ITEM = IR.ID_ITEM ORDER BY IR.ID_ROOM ASC             
SELECT * FROM ITEM
select distinct IR.ID_ROOM, I.ID_ITEM, I.NAME,IR.AMOUNT, I.TYPE, I.STORAGE_LOCATION, I.CHECKOUT_DATE, I.MANAGER from ITEM I join ITEM_ROOM IR on I.ID_ITEM = IR.ID_ITEM WHERE IR.ID_ROOM = '1002'

select distinct IR.ID_ROOM,I.ID_ITEM, I.NAME, IR.AMOUNT from ITEM I join ITEM_ROOM IR on I.ID_ITEM = IR.ID_ITEM where IR.ID_ROOM = '1005'
select I.NAME from ITEM I join ITEM_ROOM IR on I.ID_ITEM = IR.ID_ITEM where IR.ID_ROOM = '1005'
select IR.AMOUNT from ITEM I join ITEM_ROOM IR on I.ID_ITEM = IR.ID_ITEM where IR.ID_ROOM = '1005'
select I.NAME from ITEM I join ITEM_ROOM IR on I.ID_ITEM = IR.ID_ITEM where IR.ID_ROOM = '1005'
select distinct IR.ID_ROOM,I.NAME, IR.AMOUNT from ITEM I join ITEM_ROOM IR on I.ID_ITEM = IR.ID_ITEM where IR.ID_ROOM = '1005'
select distinct ID_ROOM from ITEM I join ITEM_ROOM IR on I.ID_ITEM = IR.ID_ITEM order by ID_ROOM asc;
select * from ITEM I join ITEM_ROOM IR on I.ID_ITEM = IR.ID_ITEM order by ID_ROOM asc
SELECT * FROM BOOKING_FORM BF where ID_BOOKING = 'BK00680615'
select * from BOOKING_ROOM BR JOIN ROOM R ON BR.ID_ROOM = R.ID_ROOM
select * from ITEM I join ITEM_ROOM IR on I.ID_ITEM = IR.ID_ITEM order by ID_ROOM asc
SELECT * FROM BOOKING_FORM ORDER BY ID_BOOKING ASC
select * from CUSTOMER
--

SELECT BF.*, C.NAME
FROM BOOKING_FORM BF JOIN CUSTOMER C ON BF.CUSTOMER = C.ID_CUSTOMER 
ORDER BY ID_BOOKING ASC

--
select DISTINCT R.TYPE from BOOKING_ROOM BR JOIN ROOM R ON BR.ID_ROOM = R.ID_ROOM

select * from BOOKING_ROOM
SELECT * FROM BOOKING_FORM
select * from ROOM
--

begin 
SELECT BF.*, C.NAME, BR.ID_ROOM, R.TYPE
FROM BOOKING_FORM BF JOIN BOOKING_ROOM BR ON BF.ID_BOOKING = BR.ID_BOOKING 
		 JOIN CUSTOMER C ON BF.CUSTOMER = C.ID_CUSTOMER 
		 JOIN ROOM R ON BR.ID_ROOM = R.ID_ROOM
ORDER BY ID_BOOKING ASC
end
go

-- Tạo bảng mới để lưu thông tin đơn đặt hàng
SELECT BF.*, C.NAME, BR.ID_ROOM, R.TYPE
	--INTO BOOKING_FORM_CUSTOMER_NAME
	FROM BOOKING_FORM BF JOIN BOOKING_ROOM BR ON BF.ID_BOOKING = BR.ID_BOOKING 
			 JOIN CUSTOMER C ON BF.CUSTOMER = C.ID_CUSTOMER 
			 JOIN ROOM R ON BR.ID_ROOM = R.ID_ROOM
	ORDER BY ID_BOOKING ASC
--
SELECT BF.*, C.NAME, BR.ID_ROOM, R.TYPE FROM BOOKING_FORM BF JOIN BOOKING_ROOM BR ON BF.ID_BOOKING = BR.ID_BOOKING JOIN CUSTOMER C ON BF.CUSTOMER = C.ID_CUSTOMER JOIN ROOM R ON BR.ID_ROOM = R.ID_ROOM WHERE BF.STATUS not like N'%hủy' ORDER BY ID_BOOKING ASC
SELECT * FROM BOOKING_FORM WHERE STATUS NOT LIKE N'%hủy' ORDER BY ID_BOOKING ASC

UPDATE BOOKING_FORM
	SET STATUS = N'Đã hủy'
	WHERE ID_BOOKING = 'BK019';