CREATE TABLE [dbo].[Quest] (
    [Id]        INT           NOT NULL,
    [question]  VARCHAR (MAX) NOT NULL,
    [cAnswer]   VARCHAR (MAX) NOT NULL,
    [wAnswer]   VARCHAR (MAX) NOT NULL,
    [wrAnswer]  VARCHAR (MAX) NOT NULL,
    [wroAnswer] VARCHAR (MAX) NOT NULL,
    [Level] INT NOT NULL, 
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

