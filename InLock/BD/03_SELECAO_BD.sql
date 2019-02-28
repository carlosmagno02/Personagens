--Seleção

--Lista todos os usuários;
SELECT * FROM USUARIOS

--Lista todos os jogos;
SELECT * FROM JOGOS

--Lista todos os estúdios;
SELECT * FROM ESTUDIOS

--Lista todos os jogos e seus respectivos estúdios;
SELECT * FROM JOGOS JOIN ESTUDIOS ON JOGOS.EstudioId = ESTUDIOS.EstudioId

--Busca e traz na lista todos os estúdios, mesmo que eles não contenham nenhum jogo de referência;
SELECT * FROM JOGOS  RIGHT JOIN ESTUDIOS ON JOGOS.EstudioId = ESTUDIOS.EstudioId

--Busca um usuário por email e senha;
SELECT * FROM USUARIOS WHERE Email = 'admin@admin.com' AND Senha = 'admin'

--Busca um jogo por JogoId;
SELECT * FROM JOGOS WHERE JogoId = 2

--Busca um estúdio por EstudioId;
Select * FROM ESTUDIOS WHERE EstudioId = 2
