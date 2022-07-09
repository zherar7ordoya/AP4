SELECT [nombre_libro]
	  ,d.[nombre_categoria]
	 
      ,nombre_autor
    
	  ,c.nombre_editorial
     
  FROM [SegundoParcial].[dbo].[libro] as a inner join [SegundoParcial].dbo.autor as b on a.id_autor=b.id_autor 
  inner join [SegundoParcial].dbo.editorial as c on a.id_editorial=c.id_editorial
  inner join [SegundoParcial].dbo.categoria as d on a.id_categoria=d.id_categoria
  where a.id_libro  in (SELECT distinct [id_libro]
     
  FROM [SegundoParcial].[dbo].[prestamo])