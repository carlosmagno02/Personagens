--Sele��o

--Lista todos os usu�rios;
SELECT * FROM USUARIOS

--Lista todos os jogos;
SELECT * FROM JOGOS

--Lista todos os est�dios;
SELECT * FROM ESTUDIOS

--Lista todos os jogos e seus respectivos est�dios;
SELECT * FROM JOGOS JOIN ESTUDIOS ON JOGOS.EstudioId = ESTUDIOS.EstudioId

--Busca e traz na lista todos os est�dios, mesmo que eles n�o contenham nenhum jogo de refer�ncia;
SELECT * FROM JOGOS  RIGHT JOIN ESTUDIOS ON JOGOS.EstudioId = ESTUDIOS.EstudioId

--Busca um usu�rio por email e senha;
SELECT * FROM USUARIOS WHERE Email = 'admin@admin.com' AND Senha = 'admin'

--Busca um jogo por JogoId;
SELECT * FROM JOGOS WHERE JogoId = 2

--Busca um est�dio por EstudioId;
Select * FROM ESTUDIOS WHERE EstudioId = 2
