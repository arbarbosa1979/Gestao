USE Gestao
GO
DECLARE @IdGrupo INT= 3

SELECT Permissao.ID, Permissao.Descricao FROM Permissao
INNER JOIN PermissaoGrupoUsuario ON Permissao.ID = PermissaoGrupoUsuario.ID_GrupoUsuario
WHERE ID_GrupoUsuario = @IdGrupo