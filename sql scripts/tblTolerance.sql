CREATE TABLE tblTolerance(
	FK_Sensor_ID int foreign key references tblSensor,
	fdName char(4) not null,
	fdMaximum float null,
	fdMinimum float null
)
