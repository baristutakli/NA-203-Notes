

--Create procedure SelectAdverts
--as
--BEGIN
--select * from Adverts inner join Residentials on Adverts.ResidentialId= Residentials.ResidentialId;
--END

--Create proc GetAdvertResidentialById(@Id int)
--as 
--begin
--select * from Adverts inner join Residentials on Adverts.ResidentialId= Residentials.ResidentialId where AdverticeId =@Id;
--End

--Create Proc CreateAdvertResidential(@PublishDate datetime,@IsActive bit,@Title nvarchar(500),@Explanation nvarchar(1500),@UserId int, @ResidentialId int ,@AdvertType smallint)
--as
--begin
--insert into Adverts (PublishDate,IsActive,Title,Explanation,UserId, ResidentialId,AdvertType) VALUES
--(@PublishDate,@IsActive,@Title,@Explanation,@UserId, @ResidentialId,@AdvertType)
--;select CAST(scope_identity() as int);
--end

--Create Proc UpdateAdvertById(@Id int,@PublishDate datetime,@IsActive bit,@Title nvarchar(500),@Explanation nvarchar(1500),@UserId int, @ResidentialId int ,@AdvertType smallint)
--as
--begin
--Update Adverts set PublishDate=@PublishDate,IsActive=@IsActive,Title=@Title,Explanation=@Explanation,UserId=@UserId, ResidentialId=ResidentialId,AdvertType=@AdvertType
--where AdverticeId=@Id
--;select CAST(scope_identity() as int);
--end

Create proc DeleteAdvertById( @Id int)
as
begin
Delete from Adverts where AdverticeId =@Id;
End
--//Exec GetAdvertResidentialById 1007