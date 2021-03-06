ALTER TABLE UsePointItem
ADD [UserId] [int] NULL
ALTER TABLE UsePointItem
ADD [Qty] [Decimal](18, 2) NULL
ALTER TABLE UsePointItem
ADD [StatusPrint] [bit] NULL

ALTER TABLE CustAddress 
ALTER COLUMN ProvinceId int
ALTER TABLE CustAddress 
ALTER COLUMN SubDistrict nvarchar(100)

ALTER TABLE Setting
ALTER COLUMN SettingValue nvarchar(MAX)



ALTER DATABASE A SET ENABLE_BROKER

CREATE QUEUE NameChangeQueue

CREATE SERVICE NameChangeService ON QUEUE NameChangeQueue ([http://schemas.microsoft.com/SQL/Notifications/PostQueryNotification])