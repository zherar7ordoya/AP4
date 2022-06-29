--AYUDA-MEMORIA:
--Students => Ordenes (Pedidos)
--Courses  => Items   (Productos)

USE PedidosDeInsumosDeOficina

GO

CREATE PROCEDURE ABM_Ordenes_Items
    @Id          INTEGER,
    @OrdenID     INTEGER,
    @ItemId      INTEGER,
    @Cantidad    INTEGER,
    @Instruccion CHAR(6)
AS
BEGIN

    DECLARE @ID_ORDEN int
    DECLARE @ID_ITEM int

    --||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| ALTAS
    --AYUDA-MEMORIA:
    --Students => Ordenes (Pedidos)
    --Courses  => Items   (Productos)

	--NOTA:
	--Sin calibrar. El uso pensado es dar de alta una orden y agregar �tems
	--a una orden. No se han hecho m�s pruebas.

	--Par�metros necesarios: creo que todos.

    IF @Instruccion = 'Insert'
    BEGIN
        INSERT Ordenes (StudentName)
        SELECT DISTINCT @StudentName
        FROM Ordenes
        WHERE NOT EXISTS
        (
            SELECT * 
			FROM Ordenes 
			WHERE OrdenID = @OrdenID
        )

        IF @OrdenID = 0
        BEGIN
            SELECT @ID_ORDEN = SCOPE_IDENTITY()
        END
        ELSE
        BEGIN
            SELECT @ID_ORDEN = @OrdenID
        END

        INSERT Items (CourseName)
        SELECT DISTINCT @CourseName
        FROM Items
        WHERE NOT EXISTS
        (
            SELECT * 
			FROM Items 
			WHERE ItemID = @ItemID
        )

        IF @ItemID = 0
        BEGIN
            SELECT @ID_ITEM = SCOPE_IDENTITY()
        END
        ELSE
        BEGIN
            SELECT @ID_ITEM = @ItemID
        END

        INSERT INTO Ordenes_Items
        VALUES (@ID_ORDEN, @ID_ITEM)
    END




    --||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| BAJAS
    --AYUDA-MEMORIA:
    --Students => Ordenes (Pedidos)
    --Courses  => Items   (Productos)

	--USO: 
	--Las tablas son de �rdenes y sus �tems.
	--Si deseo borrar la �rden completa, proveo su ID.
	--POR EL MOMENTO, ES TODA LA OPERACI�N QUE SE HAR�.

	--EN UN FUTURO, SE PODR�A AJUSTAR PARA QUE:
	--Si no deseo borrar la �rden, Id = 0
	--Si deseo borrar un �tem de la orden, proveo su ID.
	--Si no deseo borrar un �tem, Id = 0

	--Par�metros necesarios: ID de la �rden.

    IF @Instruccion = 'Delete'
    BEGIN
        DELETE FROM Ordenes
        WHERE OrdenID = @OrdenID
    END




    --|||||||||||||||||||||||||||||||||||||||||||||||||||||||||| MODIFICACIONES
    --AYUDA-MEMORIA:
    --Students => Ordenes (Pedidos)
    --Courses  => Items   (Productos)

    --NOTA:
	--Update, por el momento, pienso que solo puede ser utilizado
	--para cambiar, por ejemplo, la cantidad de art�culos pedida.

	--Par�metros necesarios: ID del �tem.

	IF @Instruccion = 'Update'
    BEGIN
        UPDATE Items
        SET CourseName = @CourseName
        WHERE ItemID = @ItemID
    END



    --|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| LISTADOS
	--Por el momento (incluso creo que esta secci�n es un "huevo de pascua")
	--la operaci�n de listado implica a los �tems de una �rden.
	--Par�metros necesarios: ID de la �rden.
	
	IF @Instruccion = 'Select'
    BEGIN
        SELECT Legajo,
               Fecha,
			   Estado,
			   Nombre,
			   Descripcion,
			   PrecioUnitario
        FROM Items
            JOIN Ordenes_Items 
			ON Ordenes_Items.ItemID  = Items.ItemID
            JOIN Ordenes
			ON Ordenes_Items.OrdenID = Ordenes.OrdenID
        WHERE Ordenes.OrdenID = @OrdenID
    END



END