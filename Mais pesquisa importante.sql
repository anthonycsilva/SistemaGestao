--SELECT * FROM Produto;
--SELECT * FROM Distribuidora;
--SELECT * FROM Estoque;

--insert into Estoque (ID_PRODUTO,DATA_ENTRADA,UNIDADES,ID_DISTRIBUIDORA) VALUES (1, 31/08/2021 , 50, 1);

--SELECT Produto.ID_PRODUTO, Produto.NOME_PRODUTO,Estoque.DATA_ENTRADA,Estoque.UNIDADES,Produto.PRECO from Produto inner join Estoque on Produto.ID_PRODUTO = Estoque.ID_PRODUTO;

--SELECT Produto.ID_PRODUTO,
--Produto.NOME_PRODUTO,
--Estoque.DATA_ENTRADA,
--Estoque.UNIDADES,
--Produto.PRECO 

--FROM Produto INNER JOIN Estoque 

--ON Produto.ID_PRODUTO = Estoque.ID_PRODUTO

--AND NOME_PRODUTO like '%bat%';

--SELECT Produto.ID_PRODUTO,
--Produto.NOME_PRODUTO,
--Estoque.DATA_ENTRADA,
--Estoque.UNIDADES,
--Produto.PRECO 

--FROM Produto INNER JOIN Estoque 

--ON Produto.ID_PRODUTO = Estoque.ID_PRODUTO

--AND ID_PRODUTO like '%bat%';