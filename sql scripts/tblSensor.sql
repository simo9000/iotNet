CREATE TABLE tblSensor(
	PK_ID int primary key identity(1,1),
	FK_Area_ID int foreign key references tblArea not null,
	fdDescription varchar(50) not null
)