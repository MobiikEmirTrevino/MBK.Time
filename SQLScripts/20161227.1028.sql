 
 
PRINT 'Table timeTask, entity timeTask'
-- GuidCompany
if COLUMNPROPERTY(OBJECT_ID(N'time.timeTask', N'U'),'GuidCompany','ColumnId') is null
begin 
  alter table time.timeTask 
  add GuidCompany uniqueidentifier null 
end
GO
-- CreatedDate
if COLUMNPROPERTY(OBJECT_ID(N'time.timeTask', N'U'),'CreatedDate','ColumnId') is null
begin 
  alter table time.timeTask 
  add CreatedDate DATETIME null 
end
GO
-- UpdatedDate
if COLUMNPROPERTY(OBJECT_ID(N'time.timeTask', N'U'),'UpdatedDate','ColumnId') is null
begin 
  alter table time.timeTask 
  add UpdatedDate DATETIME null 
end
GO
-- CreatedBy
if COLUMNPROPERTY(OBJECT_ID(N'time.timeTask', N'U'),'CreatedBy','ColumnId') is null
begin 
  alter table time.timeTask 
  add CreatedBy uniqueidentifier null 
end
GO
-- UpdatedBy
if COLUMNPROPERTY(OBJECT_ID(N'time.timeTask', N'U'),'UpdatedBy','ColumnId') is null
begin 
  alter table time.timeTask 
  add UpdatedBy uniqueidentifier null 
end
GO

-- Bytes
if COLUMNPROPERTY(OBJECT_ID(N'time.timeTask', N'U'),'Bytes','ColumnId') is null
begin 
  alter table time.timeTask 
  add Bytes [int] null 
end
GO

-- IsDeleted
if COLUMNPROPERTY(OBJECT_ID(N'time.timeTask', N'U'),'IsDeleted','ColumnId') is null
begin 
  alter table time.timeTask 
  add IsDeleted [bit] null DEFAULT ('false') 
end
GO

