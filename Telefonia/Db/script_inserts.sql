USE telefonia;

INSERT INTO operadoras (nome) VALUE ('Vivo');
INSERT INTO operadoras (nome) VALUE ('Claro');
INSERT INTO operadoras (nome) VALUE ('Oi');
INSERT INTO operadoras (nome) VALUE ('Tim');

INSERT INTO ddd (codigo_ddd) VALUES (21);
INSERT INTO ddd (codigo_ddd) VALUES (11);
INSERT INTO ddd (codigo_ddd) VALUES (22);
INSERT INTO ddd (codigo_ddd) VALUES (15);

INSERT INTO plano (Codigo_Plano, Minutos, Franquia_Internet,Valor,Tipo,Operadora_Id) VALUES (1001, 200, 200, 89.9, 2, 1);
INSERT INTO plano (Codigo_Plano, Minutos, Franquia_Internet,Valor,Tipo,Operadora_Id) VALUES (1002, 300, 200, 99.9, 0, 2);
INSERT INTO plano (Codigo_Plano, Minutos, Franquia_Internet,Valor,Tipo,Operadora_Id) VALUES (1003, 500, 200, 59.9, 1, 2);
INSERT INTO plano (Codigo_Plano, Minutos, Franquia_Internet,Valor,Tipo,Operadora_Id) VALUES (1004, 200, 200, 89.9, 2, 1);

INSERT INTO planoddds (plano_id, ddd_id) VALUE (1,2);
INSERT INTO planoddds (plano_id, ddd_id) VALUE (1,1);
INSERT INTO planoddds (plano_id, ddd_id) VALUE (2,1);
INSERT INTO planoddds (plano_id, ddd_id) VALUE (3,1);
INSERT INTO planoddds (plano_id, ddd_id) VALUE (4,1);
INSERT INTO planoddds (plano_id, ddd_id) VALUE (4,2);
