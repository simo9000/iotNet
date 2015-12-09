CREATE TABLE tblTolerance(
	FK_Sensor_ID int not null,
	fdName char(4) not null,
	fdMaximum float null,
	fdMinimum float null,
	CONSTRAINT FOREIGN KEY (FK_Sensor_ID) REFERENCES tblSensor (PK_ID) ON DELETE CASCADE ON UPDATE CASCADE
)