select * from ITEM_ROOM
select * from ITEM

-- Liệt kê danh sách vật dụng theo mã phòng
----CREATE FUNCTION fu_List_Of_Items_Room 
----( @room_id INT )
----RETURNS VARCHAR(50)
----AS
----BEGIN
----DECLARE @room_id VARCHAR(50);
----select distinct I.NAME
----from ITEM I join ITEM_ROOM IR on I.ID_ITEM = IR.ID_ITEM
----where IR.ID_ROOM = @room_id;
----RETURN @room_id;
----END;

-- Liệt kê tất cả vật dụng
