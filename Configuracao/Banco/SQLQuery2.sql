SELECT *FROM UsuarioGrupoUsuario
INNER JOIN USUARIO ON UsuarioGrupoUsuario.ID_Usuario = USUARIO.ID_USUARIO
INNER JOIN GrupoUsuario ON UsuarioGrupoUsuario.ID_GrupoUsuario = GrupoUsuario.ID
INNER JOIN PermissaoGrupoUsuario ON UsuarioGrupoUsuario.ID_GrupoUsuario = PermissaoGrupoUsuario.ID_GrupoUsuario
INNER JOIN Permissao ON PermissaoGrupoUsuario.ID_Permissao = Permissao.ID

DECLARE @IdUsario INT = 12
DECLARE @IdPermissao INT = 3

SELECT TOP 1 1 AS Resultado FROM UsuarioGrupoUsuario
INNER JOIN PermissaoGrupoUsuario ON UsuarioGrupoUsuario.ID_GrupoUsuario = PermissaoGrupoUsuario.ID_GrupoUsuario
WHERE UsuarioGrupoUsuario.ID_Usuario = @IdUsario AND PermissaoGrupoUsuario.ID_Permissao = @IdPermissao

INSERT INTO PermissaoGrupoUsuario VALUES(1, 3)
INSERT INTO PermissaoGrupoUsuario VALUES(2, 2)
INSERT INTO PermissaoGrupoUsuario VALUES(2, 3)
INSERT INTO PermissaoGrupoUsuario VALUES(3, 1)
INSERT INTO PermissaoGrupoUsuario VALUES(3, 2)