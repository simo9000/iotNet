/*INSERT INTO tblArea (fdName) values ('testArea')

INSERT INTO tblSensor (FK_Area_ID, fdDescription) values (1, 'Sensor 1')
INSERT INTO tblSensor (FK_Area_ID, fdDescription) values (1, 'Sensor 2')
INSERT INTO tblSensor (FK_Area_ID, fdDescription) values (1, 'Sensor 3')
INSERT INTO tblSensor (FK_Area_ID, fdDescription) values (1, 'Sensor 4')

DECLARE @now datetime
set @now = GETDATE()

INSERT INTO tblSensorData (FK_Sensor_ID, fdTimeStamp, fdPressure, fdHumidity, fdBrightness, fdTemperature)
	Values (1, @now, 14.942, 0.48, 1, 71.5)
INSERT INTO tblSensorData (FK_Sensor_ID, fdTimeStamp, fdPressure, fdHumidity, fdBrightness, fdTemperature)
	Values (2, @now, 14.941, 0.47, 13, 72.3)
INSERT INTO tblSensorData (FK_Sensor_ID, fdTimeStamp, fdPressure, fdHumidity, fdBrightness, fdTemperature)
	Values (3, @now, 14.941, 0.47, 13, 72.3)
INSERT INTO tblSensorData (FK_Sensor_ID, fdTimeStamp, fdPressure, fdHumidity, fdBrightness, fdTemperature)
	Values (4, @now, 14.76, 0.45, 35, 75.3)*/