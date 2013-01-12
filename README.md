Entity-Framework-5---Fluent-API-Relacionamento-1-para-N
=======================================================

Exemplo do post "Entity Framework 5 - Fluent API Relacionamento 1 para N"
* Crie o banco, BancoBlog
* Execute os script
```
CREATE TABLE [dbo].[Blogs] (
    [Id] INT IDENTITY (1, 1) NOT NULL,
    [Nome] NVARCHAR (200) NULL,
    CONSTRAINT [PK_dbo.Blogs] PRIMARY KEY CLUSTERED ([Id] ASC)
);
```
```
CREATE TABLE [dbo].[Posts] (
    [Id] INT IDENTITY (1, 1) NOT NULL,
    [Titulo] NVARCHAR (200) NULL,
    [Conteudo] NTEXT NULL,
    [BlogId] INT NOT NULL,
    CONSTRAINT [PK_dbo.Posts] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_dbo.Posts_dbo.Blogs_BlogId] FOREIGN KEY ([BlogId]) 
    REFERENCES [dbo].[Blogs] ([Id]) ON DELETE CASCADE
);
```
