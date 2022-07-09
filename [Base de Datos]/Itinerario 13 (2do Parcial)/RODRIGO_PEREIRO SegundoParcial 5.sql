SELECT [nombre_libro]
	  
      ,count(e.id_lector) as [Cantidad Lectores]
	 
  FROM [SegundoParcial].[dbo].[libro] as a inner join [SegundoParcial].dbo.autor as b on a.id_autor=b.id_autor 
  
   inner join [SegundoParcial].dbo.prestamo as e on a.id_libro=e.id_libro
   group by  [nombre_libro]
     