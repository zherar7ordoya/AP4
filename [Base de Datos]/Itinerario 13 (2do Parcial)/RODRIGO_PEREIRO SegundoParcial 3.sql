/****** Script for SelectTopNRows command from SSMS  ******/
SELECT  a.[id_libro]
      ,[nombre_libro]
	  ,d.[nombre_categoria]
	  ,a.id_autor
      ,nombre_autor
      ,a.[id_editorial]
	  ,c.nombre_editorial
      ,e.id_lector
	  ,nombre_lector
	  ,[fecha_devolucion]
  FROM [SegundoParcial].[dbo].[libro] as a inner join [SegundoParcial].dbo.autor as b on a.id_autor=b.id_autor 
  inner join [SegundoParcial].dbo.editorial as c on a.id_editorial=c.id_editorial
  inner join [SegundoParcial].dbo.categoria as d on a.id_categoria=d.id_categoria
   inner join [SegundoParcial].dbo.prestamo as e on a.id_libro=e.id_libro
   inner join [SegundoParcial].dbo.lector as f on e.id_lector=f.id_lector
  