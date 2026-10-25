CREATE OR ALTER PROCEDURE SP_UPD_Provider
(
    @ProviderId INT,
    @Name VARCHAR (20),
    @Email VARCHAR (20),
    @Phone VARCHAR (20),
    @Address VARCHAR (50),
    @City VARCHAR (50),
    @State VARCHAR (20),
    @Zip VARCHAR (20),
    @Country VARCHAR (20)
)          
-- TODO 5: O formulario permite editar Name; incluir esse parametro e sua atualizacao no SET.
-- Conferir os tamanhos dos campos com a tabela e SP_ADD_Provider para evitar cortar dados na edicao.
-- TODO 7: Aplicar as procedures criadas/alteradas no SQL Server; salvar o arquivo nao atualiza o banco.
AS BEGIN
    UPDATE Providers
    SET
        Name = COALESCE(@Name, name),
        Email = COALESCE(@Email, email),
        Phone = COALESCE(@Phone, Phone),
        Address = COALESCE(@Address, Address),
        City = COALESCE(@City,City),
        State = COALESCE(@State,State),
        Zip = COALESCE(@Zip,Zip),
        Country = COALESCE(@Country,Country)
    WHERE 
        @ProviderId = ProviderId
END
          
