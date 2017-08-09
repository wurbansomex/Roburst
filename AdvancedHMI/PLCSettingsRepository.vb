Imports log4net
Imports System.Globalization

''' <summary>
''' Loads settings stored in ini file into PLC on startup and save settings to PLC on shutdown
''' </summary>
''' <remarks></remarks>
Public Class PLCSettingsRepository


    Shared _log As ILog = LogManager.GetLogger(GetType(PLCSettingsRepository))

    ''' <summary>
    ''' Reads PLC settings from the ini file and updates corresponding tags in the PLC
    ''' </summary>
    ''' <param name="plcDriver"></param>
    ''' <remarks></remarks>
    Public Shared Sub LoadPlcSettings(plcDriver As AdvancedHMIDrivers.EthernetIPforCLXCom)

        Try
            PlcDriverUtilities.WritePlcValue("TestSt_BottleDetect", Convert.ToDouble(HmiSettingsResolver.GetSettingValue("PLC", "BottleUnderTestDetectionPressure"), CultureInfo.InvariantCulture), plcDriver)
            PlcDriverUtilities.WritePlcValue("WashDownTimer", Convert.ToDouble(HmiSettingsResolver.GetSettingValue("PLC", "WashDownTimer"), CultureInfo.InvariantCulture), plcDriver)
            PlcDriverUtilities.WritePlcValue("LBVTimeout", Convert.ToDouble(HmiSettingsResolver.GetSettingValue("PLC", "LowBurstValueTimeout"), CultureInfo.InvariantCulture), plcDriver)
            PlcDriverUtilities.WritePlcValue("Conveyor.Parameters.Real[0]", Convert.ToDouble(HmiSettingsResolver.GetSettingValue("PLC", "ConveyorSpeed"), CultureInfo.InvariantCulture), plcDriver)
            PlcDriverUtilities.WritePlcValue("LoadStation.Parameters.Real[0]", Convert.ToDouble(HmiSettingsResolver.GetSettingValue("PLC", "PickUpClampsCloseDelay"), CultureInfo.InvariantCulture), plcDriver)
            PlcDriverUtilities.WritePlcValue("ConveyorDistance", Convert.ToDouble(HmiSettingsResolver.GetSettingValue("PLC", "ConveyorToPickDistance"), CultureInfo.InvariantCulture), plcDriver)
            PlcDriverUtilities.WritePlcValue("Conveyor.Bits[0].0", IIf(Convert.ToBoolean(HmiSettingsResolver.GetSettingValue("PLC", "EnableConveyor")) = True, 1, 0), plcDriver)
            PlcDriverUtilities.WritePlcValue("TestStation.Bits[0].1", IIf(Convert.ToBoolean(HmiSettingsResolver.GetSettingValue("PLC", "UseCulletBin")) = True, 1, 0), plcDriver)
            PlcDriverUtilities.WritePlcValue("PlaceGripOpenHeight", Convert.ToDouble(HmiSettingsResolver.GetSettingValue("PLC", "PlaceGripOpenHeight")), plcDriver)
            PlcDriverUtilities.WritePlcValue("FastFillRate", Convert.ToDouble(HmiSettingsResolver.GetSettingValue("PLC", "FastFillRate"), CultureInfo.InvariantCulture), plcDriver)
            PlcDriverUtilities.WritePlcValue("FineFillRate", Convert.ToDouble(HmiSettingsResolver.GetSettingValue("PLC", "FineFillRate"), CultureInfo.InvariantCulture), plcDriver)
            PlcDriverUtilities.WritePlcValue("FastFineFillRatio", Convert.ToDouble(HmiSettingsResolver.GetSettingValue("PLC", "FastFineFillRatio"), CultureInfo.InvariantCulture), plcDriver)
            PlcDriverUtilities.WritePlcValue("HMI.Manual[1].8", IIf(Convert.ToBoolean(HmiSettingsResolver.GetSettingValue("PLC", "ManualMouldEntryEnabled")) = True, 1, 0), plcDriver)
            PlcDriverUtilities.WritePlcValue("HMI.Manual[1].9", IIf(Convert.ToBoolean(HmiSettingsResolver.GetSettingValue("PLC", "BottleLoadAssist")) = True, 1, 0), plcDriver)
            PlcDriverUtilities.WritePlcValue("RemoteConnectionPort", Convert.ToDouble(HmiSettingsResolver.GetSettingValue("PLC", "RemoteConnectionsPortNumber"), CultureInfo.InvariantCulture), plcDriver)
            PlcDriverUtilities.WritePlcValue("RemoteConnectionIP", HmiSettingsResolver.GetSettingValue("PLC", "RemoteConnectionsIPAddress"), plcDriver)
            PlcDriverUtilities.WritePlcValue("RemoteConnectionTimeout", Convert.ToDouble(HmiSettingsResolver.GetSettingValue("PLC", "RemoteConnectionsTimeOut"), CultureInfo.InvariantCulture), plcDriver)
            PlcDriverUtilities.WritePlcValue("RemoteConnectionEnable", IIf(Convert.ToBoolean(HmiSettingsResolver.GetSettingValue("PLC", "RemoteCommunicationsEnabled")) = True, 1, 0), plcDriver)
            PlcDriverUtilities.WritePlcValue("RemoteConnectionDefaultMouldNumber", Convert.ToDouble(HmiSettingsResolver.GetSettingValue("PLC", "RemoteCommunicationsDefaultMouldNumber"), CultureInfo.InvariantCulture), plcDriver)
            PlcDriverUtilities.WritePlcValue("HMI.Manual[1].10", IIf(Convert.ToBoolean(HmiSettingsResolver.GetSettingValue("PLC", "CoolingUnitFitted")) = True, 1, 0), plcDriver)
            PlcDriverUtilities.WritePlcValue("CleaningLimit", Convert.ToDouble(HmiSettingsResolver.GetSettingValue("PLC", "CleaningLimit")), plcDriver)
            PlcDriverUtilities.WritePlcValue("MaintenanceLimit", Convert.ToDouble(HmiSettingsResolver.GetSettingValue("PLC", "MaintenanceLimit")), plcDriver)
            PlcDriverUtilities.WritePlcValue("RemoteConnectionType", Convert.ToDouble(HmiSettingsResolver.GetSettingValue("PLC", "RemoteConnectionsType")), plcDriver)
            PlcDriverUtilities.WritePlcValue("TestStation.Parameters.Real[1]", Convert.ToDouble(HmiSettingsResolver.GetSettingValue("PLC", "PurgeTime")), plcDriver)
            PlcDriverUtilities.WritePlcValue("SealChangeLimit", Convert.ToDouble(HmiSettingsResolver.GetSettingValue("PLC", "SealChangeLimit")), plcDriver)
            PlcDriverUtilities.WritePlcValue("BottleNotAtGate", Convert.ToDouble(HmiSettingsResolver.GetSettingValue("PLC", "BottleNotAtGate")), plcDriver)
            PlcDriverUtilities.WritePlcValue("PickHeightMax", Convert.ToDouble(HmiSettingsResolver.GetSettingValue("PLC", "PickHeightMax")), plcDriver)
            PlcDriverUtilities.WritePlcValue("BottleCount", Convert.ToDouble(HmiSettingsResolver.GetSettingValue("PLC", "BottleCount")), plcDriver)
            PlcDriverUtilities.WritePlcValue("DisableGate", IIf(Convert.ToBoolean(HmiSettingsResolver.GetSettingValue("PLC", "DisableGate")) = True, 1, 0), plcDriver)
            PlcDriverUtilities.WritePlcValue("ConcentricGrip", IIf(Convert.ToBoolean(HmiSettingsResolver.GetSettingValue("PLC", "ConcentricGrip")) = True, 1, 0), plcDriver)
        Catch ex As Exception
            _log.Error("Error downloading ini settings to plc, " & ex.ToString())
        End Try

    End Sub


    Public Shared Sub SavePlcSettings(plcDriver As AdvancedHMIDrivers.EthernetIPforCLXCom)

        Try

            HmiSettingsResolver.SaveSettingValue("PLC", "BottleUnderTestDetectionPressure", PlcDriverUtilities.ReadPLCValue(Of Integer)("TestSt_BottleDetect", plcDriver))
            HmiSettingsResolver.SaveSettingValue("PLC", "WashDownTimer", PlcDriverUtilities.ReadPLCValue(Of Double)("WashDownTimer", plcDriver))
            HmiSettingsResolver.SaveSettingValue("PLC", "LowBurstValueTimeout", PlcDriverUtilities.ReadPLCValue(Of Double)("LBVTimeout", plcDriver))
            HmiSettingsResolver.SaveSettingValue("PLC", "ConveyorSpeed", PlcDriverUtilities.ReadPLCValue(Of Double)("Conveyor.Parameters.Real[0]", plcDriver))
            HmiSettingsResolver.SaveSettingValue("PLC", "PickUpClampsCloseDelay", PlcDriverUtilities.ReadPLCValue(Of Double)("LoadStation.Parameters.Real[0]", plcDriver))
            HmiSettingsResolver.SaveSettingValue("PLC", "ConveyorToPickDistance", PlcDriverUtilities.ReadPLCValue(Of Double)("ConveyorDistance", plcDriver))
            HmiSettingsResolver.SaveSettingValue("PLC", "EnableConveyor", PlcDriverUtilities.ReadPLCValue(Of Boolean)("Conveyor.Bits[0].0", plcDriver))
            HmiSettingsResolver.SaveSettingValue("PLC", "UseCulletBin", PlcDriverUtilities.ReadPLCValue(Of Boolean)("TestStation.Bits[0].1", plcDriver))
            HmiSettingsResolver.SaveSettingValue("PLC", "PlaceGripOpenHeight", PlcDriverUtilities.ReadPLCValue(Of Double)("PlaceGripOpenHeight", plcDriver))
            HmiSettingsResolver.SaveSettingValue("PLC", "FastFillRate", PlcDriverUtilities.ReadPLCValue(Of Double)("FastFillRate", plcDriver))
            HmiSettingsResolver.SaveSettingValue("PLC", "FineFillRate", PlcDriverUtilities.ReadPLCValue(Of Double)("FineFillRate", plcDriver))
            HmiSettingsResolver.SaveSettingValue("PLC", "FastFineFillRatio", PlcDriverUtilities.ReadPLCValue(Of Double)("FastFineFillRatio", plcDriver))
            HmiSettingsResolver.SaveSettingValue("PLC", "ManualMouldEntryEnabled", PlcDriverUtilities.ReadPLCValue(Of Boolean)("HMI.Manual[1].8", plcDriver))
            HmiSettingsResolver.SaveSettingValue("PLC", "BottleLoadAssist", PlcDriverUtilities.ReadPLCValue(Of Boolean)("HMI.Manual[1].9", plcDriver))
            HmiSettingsResolver.SaveSettingValue("PLC", "RemoteConnectionPort", PlcDriverUtilities.ReadPLCValue(Of Integer)("RemoteConnectionPort", plcDriver))
            HmiSettingsResolver.SaveSettingValue("PLC", "RemoteConnectionsIPAddress", PlcDriverUtilities.ReadPLCValue(Of String)("RemoteConnectionIP", plcDriver))
            HmiSettingsResolver.SaveSettingValue("PLC", "RemoteConnectionsTimeOut", PlcDriverUtilities.ReadPLCValue(Of Integer)("RemoteConnectionTimeout", plcDriver))
            HmiSettingsResolver.SaveSettingValue("PLC", "RemoteCommunicationsEnabled", PlcDriverUtilities.ReadPLCValue(Of Boolean)("RemoteConnectionEnable", plcDriver))
            HmiSettingsResolver.SaveSettingValue("PLC", "RemoteCommunicationsDefaultMouldNumber", PlcDriverUtilities.ReadPLCValue(Of Integer)("RemoteConnectionDefaultMouldNumber", plcDriver))
            HmiSettingsResolver.SaveSettingValue("PLC", "CoolingUnitFitted", PlcDriverUtilities.ReadPLCValue(Of Boolean)("HMI.Manual[1].10", plcDriver))
            HmiSettingsResolver.SaveSettingValue("PLC", "CleaningLimit", PlcDriverUtilities.ReadPLCValue(Of Integer)("CleaningLimit", plcDriver))
            HmiSettingsResolver.SaveSettingValue("PLC", "MaintenanceLimit", PlcDriverUtilities.ReadPLCValue(Of Integer)("MaintenanceLimit", plcDriver))
            HmiSettingsResolver.SaveSettingValue("PLC", "RemoteConnectionsType", PlcDriverUtilities.ReadPLCValue(Of Integer)("RemoteConnectionType", plcDriver))
            HmiSettingsResolver.SaveSettingValue("PLC", "PurgeTime", PlcDriverUtilities.ReadPLCValue(Of Double)("TestStation.Parameters.Real[1]", plcDriver))
            HmiSettingsResolver.SaveSettingValue("PLC", "SealChangeLimit", PlcDriverUtilities.ReadPLCValue(Of Integer)("SealChangeLimit", plcDriver))
            HmiSettingsResolver.SaveSettingValue("PLC", "BottleNotAtGate", PlcDriverUtilities.ReadPLCValue(Of Integer)("BottleNotAtGate", plcDriver))
            HmiSettingsResolver.SaveSettingValue("PLC", "PickHeightMax", PlcDriverUtilities.ReadPLCValue(Of Double)("PickHeightMax", plcDriver))
            HmiSettingsResolver.SaveSettingValue("PLC", "BottleCount", PlcDriverUtilities.ReadPLCValue(Of Integer)("BottleCount", plcDriver))
            HmiSettingsResolver.SaveSettingValue("PLC", "DisableGate", PlcDriverUtilities.ReadPLCValue(Of Boolean)("DisableGate", plcDriver))
            HmiSettingsResolver.SaveSettingValue("PLC", "ConcentricGrip", PlcDriverUtilities.ReadPLCValue(Of Boolean)("ConcentricGrip", plcDriver))

        Catch ex As Exception
            _log.Error("Error saving plc settings to ini file, " & ex.ToString())

        End Try

    End Sub







End Class
