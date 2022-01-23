
--Create procedure SelectAllProducts
--as
--BEGIN
--SELECT * FROM Adverts;
--END

--Create proc SelectAllResidentials
--as
--begin
--select * from Residentials
--End

--Create proc SelectResidentialById(@ID int)
--as 
--begin
--select * from Residentials
--where ResidentialId =@Id
--End

--Create Proc CreateResidential(@SellType smallint,@Area float, @Age smallint, @FloorNumber smallint,@Heating smallint,@Balcony bit,@Furnished bit,@AddressId int,@ResidentialType smallint)
--as
--begin
--INSERT INTO Residentials (SellType,Area, Age, FloorNumber,Heating,Balcony,Furnished,AddressId,ResidentialType) VALUES
--(@SellType,@Area,@Age,@FloorNumber,@Heating,@Balcony,@Furnished,@AddressId,@ResidentialType)
--;select CAST(scope_identity() as int);
--end

--Create Proc UpdateResidential(@Id int,@SellType smallint,@Area float, @Age smallint, @FloorNumber smallint,@Heating smallint,@Balcony bit,@Furnished bit,@AddressId int,@ResidentialType smallint)
--as
--begin
--Update Residentials set SellType=@SellType, Area=@Area,Age=@Age,FloorNumber=@FloorNumber,Heating=@Heating,Balcony=@Balcony,Furnished=@Furnished,AddressId=@AddressId,ResidentialType=@ResidentialType where ResidentialId=@Id;
--end

--Create proc DeleteResidentialById( @Id int)
--as
--begin
--Delete from Residentials where ResidentialId =@Id;
--End
--Exec DeleteResidentialById 5015;