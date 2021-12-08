USE [master]
GO

CREATE DATABASE StudentDb
ON PRIMARY
( 
    NAME = N'StudentDb', 
    FILENAME = N'C:\db\StudentDb.mdf' , 
    SIZE = 8192KB , 
    MAXSIZE = UNLIMITED, 
    FILEGROWTH = 65536KB 
)
LOG ON 
( 
    NAME = N'StudentDbLog', 
    FILENAME = N'C:\db\StudentDb.ldf' , 
    SIZE = 8192KB , 
    MAXSIZE = 2048GB , 
    FILEGROWTH = 65536KB 
)
GO

CREATE DATABASE PersonDb
ON PRIMARY
( 
    NAME = N'PersonDb', 
    FILENAME = N'C:\db\PersonDb.mdf' , 
    SIZE = 8192KB , 
    MAXSIZE = UNLIMITED, 
    FILEGROWTH = 65536KB 
)
LOG ON 
( 
    NAME = N'PersonDbLog', 
    FILENAME = N'C:\db\PersonDb.ldf' , 
    SIZE = 8192KB , 
    MAXSIZE = 2048GB , 
    FILEGROWTH = 65536KB 
)
GO