

--insert into Pessoa (NOME, IDADE, CPF) values ('Simone', 40, '222.222.222-22');


--insert into Cliente (ID_PESSOA, ESTADO, CIDADE, RUA, NUMERO_RESIDENCIA, CEP) values (2, 'RJ', 'Belford Roxo', 'Rua Nova', 186, '26167-185');

--select Pessoa.ID_PESSOA, Pessoa.NOME,Pessoa.CPF, Cliente.CIDADE,Cliente.ESTADO from Pessoa inner join Cliente on Pessoa.ID_PESSOA = Cliente.ID_PESSOA;

--select * from Pessoa;
--select * from Cliente;


SELECT TOP 1 * FROM [Pessoa] ORDER BY ID_PESSOA DESC