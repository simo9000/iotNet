CREATE TABLE tblSensorData(
	PK_ID int primary key AUTO_INCREMENT,
	FK_Sensor_ID int not null,
	fdTimeStamp datetime not null,
	fdPressure float null,
	fdHumidity float null,
	fdBrightness float null,
	fdTemperature float null,
	CONSTRAINT FOREIGN KEY (FK_Sensor_ID) REFERENCES tblSensor (PK_ID) ON DELETE CASCADE ON UPDATE CASCADE
)