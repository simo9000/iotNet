IF object_id(N'dbo.vwSensorRT', 'V') IS NOT NULL
	DROP VIEW dbo.vwSensorRT
GO

CREATE VIEW dbo.vwSensorRT AS
SELECT tblSensor.PK_ID as ID,
	   fdTimeStamp as fdTimeStamp,
	   fdDescription as fdDescription,
	   fdPressure as fdPressure,
	   fdHumidity as fdHumidity,
	   fdBrightness as fdBrightness,
	   fdTemperature as fdTemperature,
	   tblArea.fdName as areaName
FROM tblSensor
	INNER JOIN tblArea
		on tblArea.PK_ID = tblSensor.FK_Area_ID
	LEFT JOIN tblSensorData
		ON tblSensor.PK_ID = tblSensorData.FK_Sensor_ID
WHERE tblSensorData.fdTimeStamp = (Select max(fdTimeStamp) from tblSensorData)