CREATE TABLE tblSensorData(
	PK_ID int primary key identity(1,1),
	FK_Sensor_ID int foreign key references tblSensor not null,
	fdTimeStamp datetime not null,
	fdPressure float null,
	fdHumidity float null,
	fdBrightness float null,
	fdTemperature float null
)