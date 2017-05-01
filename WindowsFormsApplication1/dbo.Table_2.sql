﻿CREATE TABLE [dbo].[PAYMENTS](
[ACC_ID_FROM] [nvarchar](30) NOT NULL, 
[ACC_ID_TO] [nvarchar](30) NOT NULL, 
[PAYMENTS_SUM] [money] NOT NULL, 
[PAYMENTS_ID] [int] IDENTITY(100,5) NOT NULL, 
[TRANSACTION_DATE] [datetime] NULL,
CONSTRAINT [PK_PAYMENTS] PRIMARY KEY ([PAYMENTS_ID]),
CONSTRAINT [FK_PAYMENTS_1] FOREIGN KEY ([ACC_ID_FROM]) 
	REFERENCES [dbo].[ACCOUNTS] (ACCOUNT_ID) ON DELETE CASCADE ON UPDATE CASCADE, 
CONSTRAINT [FK_PAYMENTS_2] FOREIGN KEY ([ACC_ID_TO]) 
	REFERENCES [dbo].[ACCOUNTS] (ACCOUNT_ID) ON DELETE CASCADE ON UPDATE CASCADE
);