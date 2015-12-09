CREATE TABLE tblSensor(
	PK_ID int primary key AUTO_INCREMENT,
	FK_Area_ID int not null,
	fdDescription varchar(50) not null,
	CONSTRAINT FOREIGN KEY (FK_Area_ID) REFERENCES tblArea (PK_ID) ON DELETE CASCADE ON UPDATE CASCADE
)