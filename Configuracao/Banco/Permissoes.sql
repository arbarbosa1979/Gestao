DELETE FROM PermissaoGrupoUsuario
GO
DELETE FROM Permissao
GO

INSERT INTO Permissao(ID, Descricao)VALUES(1, 'Visualizar usu�rio')
INSERT INTO Permissao(ID, Descricao)VALUES(2, 'Cadastrar usu�rio')
INSERT INTO Permissao(ID, Descricao)VALUES(3, 'Alterar usu�rio')
INSERT INTO Permissao(ID, Descricao)VALUES(4, 'Excluir usu�rio')
INSERT INTO Permissao(ID, Descricao)VALUES(5, 'Visualizar grupo de usu�rio')
INSERT INTO Permissao(ID, Descricao)VALUES(6, 'Cadastrar grupo de usu�rio')
INSERT INTO Permissao(ID, Descricao)VALUES(7, 'Alterar grupo de usu�rio')
INSERT INTO Permissao(ID, Descricao)VALUES(8, 'Excluir grupo de usu�rio')
INSERT INTO Permissao(ID, Descricao)VALUES(9, 'Adicionar permiss�o a um grupo de usu�rio')
INSERT INTO Permissao(ID, Descricao)VALUES(10, 'Adicionar grupo de usu�rio a um usu�rio')