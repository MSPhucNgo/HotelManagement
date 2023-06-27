select * from ITEM_ROOM
select * from ITEM
select * from PARTNER
select * from PARTNER_TOUR
select * from ROOM
select * from BOOKING_ROOM

-- Liệt kê danh sách vật dụng theo mã phòng
CREATE FUNCTION fu_List_Of_Items_Room 
( @room_id INT )
RETURNS VARCHAR(50)
AS
BEGIN
DECLARE @room_id VARCHAR(50);

select distinct I.NAME, IR.AMOUNT
from ITEM I join ITEM_ROOM IR on I.ID_ITEM = IR.ID_ITEM
where IR.ID_ROOM = '1005'

-- @room_id;
RETURN @room_id;
END;

-- Liệt kê tất cả vật dụng
-- done
SELECT * FROM RESERVATION_ROOM
SELECT * FROM ITEM_ROOM
SELECT * FROM ITEM
select distinct IR.ID_ROOM,I.NAME, IR.AMOUNT from ITEM I join ITEM_ROOM IR on I.ID_ITEM = IR.ID_ITEM where IR.ID_ROOM = '1005'
select I.NAME from ITEM I join ITEM_ROOM IR on I.ID_ITEM = IR.ID_ITEM where IR.ID_ROOM = '1005'
select IR.AMOUNT from ITEM I join ITEM_ROOM IR on I.ID_ITEM = IR.ID_ITEM where IR.ID_ROOM = '1005'
select I.NAME from ITEM I join ITEM_ROOM IR on I.ID_ITEM = IR.ID_ITEM where IR.ID_ROOM = '1005'
select distinct IR.ID_ROOM,I.NAME, IR.AMOUNT from ITEM I join ITEM_ROOM IR on I.ID_ITEM = IR.ID_ITEM where IR.ID_ROOM = '1005'
select distinct ID_ROOM from ITEM I join ITEM_ROOM IR on I.ID_ITEM = IR.ID_ITEM order by ID_ROOM asc;
select * from ITEM I join ITEM_ROOM IR on I.ID_ITEM = IR.ID_ITEM order by ID_ROOM asc
SELECT * FROM BOOKING_FORM BF where ID_BOOKING = 'BK00680615'
select * from BOOKING_ROOM BR JOIN ROOM R ON BR.ID_ROOM = R.ID_ROOM




