using System.Drawing;
using System.Dynamic;
using System.Runtime.InteropServices;
using Microsoft.Owin.Security;

namespace Funbit.Ets.Telemetry.Server.Data.Reader
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    internal struct Ets2TelemetryStructure
    {
        const int GeneralStringSize = 64;
        private const int MaxTruckWheelCount = 16;

        public uint time;
        public uint paused;

        // 35 byte padding
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 35)]
        private readonly byte[] padding0;

        public uint ets2_telemetry_plugin_revision;
        public uint ets2_version_major;
        public uint ets2_version_minor;
        public uint game;
        public uint telemetry_version_game_major;
        public uint telemetry_version_game_minor; // scs_values
        public uint timeAbsolute;                 // common_ui

        public uint gearsForward;
        public uint gearsReverse;
        public uint retarderStepCount;
        public uint truckWheelCount;
        public uint selectorCount;
        public uint jobDeadline;
        public uint maxTrailerCount;
        public uint unitCount;                    // config_ui

        public uint shifterSlot;
        public uint retarderBrake;
        public uint lightsAuxFront;
        public uint lightsAuxRoof;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxTruckWheelCount)]
        public uint[] truck_wheelSubstance;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
        public uint[] hshifterPosition;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
        public uint[] hshifterBitmask;            // truck_ui

        public uint jobDeliveredDeliveryTime;     // gameplay_ui;

        // 60 byte padding
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 60)]
        private readonly byte[] padding1;         // buffer_ui

        public int nextRestStop;                  // common_i

        public int gear;
        public int displayedGear;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
        public int hshifterResulting;             // truck_i

        public int jobDeliveredEarnedXp;          // gameplay_i

        // 56 byte padding
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 56)]
        private readonly byte[] padding2;         // buffer_i

        public float localScale;                  // common_f

        public float fuelCapacity;
        public float fuelWarningFactor;
        public float adblueCapacity;
        public float adblueWarningFactor;
        public float airPressureWarningValue;
        public float airPressureEmergencyValue;
        public float oilPressureWarningValue;
        public float waterTemperatureWarningValue;
        public float batteryVoltageWarningValue;
        public float engineRpmMax;
        public float gearDifferential;
        public float cargoMass;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxTruckWheelCount)]
        public float[] truckWheelRadius;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 24)]
        public float[] gearRatiosForward;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public float[] gearRatiosReverse;
        public float unitMass;                    // config_f

        public float speed;
        public float engineRpm;
        public float userSteer;
        public float userThrottle;
        public float userBrake;
        public float userClutch;
        public float gameSteer;
        public float gameThrottle;
        public float gameBrake;
        public float gameClutch;
        public float cruiseControlSpeed;
        public float airPressure;
        public float brakeTemperature;
        public float fuel;
        public float fuelAvgConsumption;
        public float fuelRate;
        public float adblue;
        public float oilPressure;
        public float oilTemperature;
        public float waterTemperature;
        public float batteryVoltage;
        public float lightsDashboard;
        public float wearEngine;
        public float wearTransmission;
        public float wearCabin;
        public float wearChassis;
        public float wearWheels;
        public float truckOdometer;
        public float navigationDistance;
        public float navigationTime;
        public float navigationSpeedLimit;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxTruckWheelCount)]
        public float[] truck_wheelSuspDeflection;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxTruckWheelCount)]
        public float[] truck_wheelVelocity;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxTruckWheelCount)]
        public float[] truck_wheelSteering;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxTruckWheelCount)]
        public float[] truck_wheelRotation;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxTruckWheelCount)]
        public float[] truck_wheelLift;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxTruckWheelCount)]
        public float[] truck_wheelLiftOffset;     // truck_f

        public float jobDeliveredCargoDamage;
        public float jobDeliveredDistanceKm;      // gameplay_f

        public float cargoDamage;                 // job_f

        // 32 byte padding
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
        private readonly byte[] padding3;         // buffer_f

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxTruckWheelCount)]
        public bool[] truckWheelSteerable;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxTruckWheelCount)]
        public bool[] truckWheelSimulated;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxTruckWheelCount)]
        public bool[] truckWheelPowered;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxTruckWheelCount)]
        public bool[] truckWheelLiftable;

        public bool isCargoLoaded;
        public bool specialJob;                   // config_b

        public bool parkBrake;
        public bool motorBrake;
        public bool airPressureWarning;
        public bool airPressureEmergency;
        public bool fuelWarning;
        public bool adblueWarning;
        public bool oilPressureWarning;
        public bool waterTemperatureWarning;
        public bool batteryVoltageWarning;
        public bool electricEnabled;
        public bool engineEnabled;
        public bool wipers;
        public bool blinkerLeftActive;
        public bool blinkerRightActive;
        public bool blinkerLeftOn;
        public bool blinkerRightOn;
        public bool lightsParking;
        public bool lightsBeamLow;
        public bool lightsBeamHigh;
        public bool lightsBeacon;
        public bool lightsBrake;
        public bool lightsReverse;
        public bool cruiseControl;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxTruckWheelCount)]
        public bool[] truckWheelOnGround;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public bool[] shifterToggle;              // truck_b

        public bool jobDelieveredAutoparkUsed;
        public bool jobDeliveredAutoloadUsed;     // gameplay_b

        // 31 byte padding
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 31)]
        private readonly byte[] padding4;         // buffer_b

        public float cabinPositionX;
        public float cabinPositionY;
        public float cabinPositionZ;
        public float headPositionX;
        public float headPositionY;
        public float headPositionZ;
        public float hookPositionX;
        public float hookPositionY;
        public float hookPositionZ;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxTruckWheelCount)]
        public float[] wheelPositionX;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxTruckWheelCount)]
        public float[] wheelPositionY;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxTruckWheelCount)]
        public float[] wheelPositionZ;            // config_fv

        public float lvAccelerationX;
        public float lvAccelerationY;
        public float lvAccelerationZ;
        public float avAccelerationX;
        public float avAccelerationY;
        public float avAccelerationZ;
        public float accelerationX;
        public float accelerationY;
        public float accelerationZ;
        public float aaAccelerationX;
        public float aaAccelerationY;
        public float aaAccelerationZ;
        public float cabinAVX;
        public float cabinAVY;
        public float cabinAVZ;
        public float cabinAAX;
        public float cabinAAY;
        public float cabinAAZ;                    // truck_fv

        // 60 byte padding
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 60)]
        private readonly byte[] padding5;         // buffer_fv

        public float cabinOffsetX;
        public float cabinOffsetY;
        public float cabinOffsetZ;
        public float cabinOffsetRotationX;
        public float cabinOffsetRotationY;
        public float cabinOffsetRotationZ;
        public float headOffsetX;
        public float headOffsetY;
        public float headOffsetZ;
        public float headOffsetRotationX;
        public float headOffsetRotationY;
        public float headOffsetRotationZ;          // truck_fp

        // 152 byte padding
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 152)]
        private readonly byte[] padding6;         // buffer_fp

        public float coordinateX;
        public float coordinateY;
        public float coordinateZ;
        public float rotationX;
        public float rotationY;
        public float rotationZ;

        // 52 byte padding
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 52)]
        private readonly byte[] padding7;         // buffer_dp

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = GeneralStringSize)]
        public byte[] truckMakeId;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = GeneralStringSize)]
        public byte[] truckMake;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = GeneralStringSize)]
        public byte[] truckId;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = GeneralStringSize)]
        public byte[] truckModel;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = GeneralStringSize)]
        public byte[] cargoId;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = GeneralStringSize)]
        public byte[] cargo;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = GeneralStringSize)]
        public byte[] jobCityDestinationId;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = GeneralStringSize)]
        public byte[] jobCityDestination;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = GeneralStringSize)]
        public byte[] jobCompanyDestinationId;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = GeneralStringSize)]
        public byte[] jobCompanyDestination;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = GeneralStringSize)]
        public byte[] jobCitySourceId;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = GeneralStringSize)]
        public byte[] jobCitySource;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = GeneralStringSize)]
        public byte[] jobCompanySourceId;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = GeneralStringSize)]
        public byte[] jobCompanySource;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        public byte[] shifterType;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = GeneralStringSize)]
        public byte[] truckLicensePlate;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = GeneralStringSize)]
        public byte[] truckLicensePlateCountryId;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = GeneralStringSize)]
        public byte[] truckLicensePlateCountry;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
        public byte[] jobMarket;                  // config_s


        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        public byte[] fineOffence;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = GeneralStringSize)]
        public byte[] ferrySourceName;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = GeneralStringSize)]
        public byte[] ferryTargetName;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = GeneralStringSize)]
        public byte[] ferrySourceId;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = GeneralStringSize)]
        public byte[] ferryTargetId;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = GeneralStringSize)]
        public byte[] trainSourceName;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = GeneralStringSize)]
        public byte[] trainTargetName;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = GeneralStringSize)]
        public byte[] trainSourceId;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = GeneralStringSize)]
        public byte[] trainTargetId;              // gameplay_s

        // 36 byte padding
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 36)]
        private readonly byte[] padding8;         // buffer_s

        public ulong jobIncome;                   // config_ull

        // 192 byte padding
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 192)]
        private readonly byte[] padding9;         // buffer_ull

        public long jobCancelledPenalty;
        public long jobDeliveredRevenue;
        public long fineAmount;
        public long tollgatePayAmount;
        public long ferryPayAmount;
        public long trainPayAmount;               // gameplay_ll

        // 52 byte padding
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 52)]
        private readonly byte[] padding10;        // buffer_ll

        public bool trailer_attached;
        public bool jobFinished;
        public bool jobCancelled;
        public bool jobDelivered;
        public bool fined;
        public bool tollgate;
        public bool ferry;
        public bool train;                        // special_b

        // 92 byte padding
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 92)]
        private readonly byte[] padding11;        // buffer_ll

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = GeneralStringSize * 25)]
        public char[,] substances;                // substances (may not even work idk)

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1552)]
        public Ets2TrailerTelemetryStructure[] trailers;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    internal struct Ets2TrailerTelemetryStructure
    {
        const int GeneralStringSize = 64;
        private const int MaxTruckWheelCount = 16;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxTruckWheelCount)]
        public bool[] wheelSteerable;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxTruckWheelCount)]
        public bool[] wheelSimulated;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxTruckWheelCount)]
        public bool[] wheelPowered;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxTruckWheelCount)]
        public bool[] wheelLiftable;              // con_b

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxTruckWheelCount)]
        public bool[] wheelOnGround;
        public bool attached;                     // com_b

        // 3 byte padding
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
        private readonly byte[] padding0;         // buffer_b

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxTruckWheelCount)]
        public uint[] wheelSubstance;             // com_ui
        public uint wheelCount;                   // con_ui

        public float cargoDamage;
        public float wearChassis;
        public float wearWheels;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxTruckWheelCount)]
        public float[] wheelSuspDeflection;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxTruckWheelCount)]
        public float[] wheelVelocity;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxTruckWheelCount)]
        public float[] wheelSteering;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxTruckWheelCount)]
        public float[] wheelRotation;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxTruckWheelCount)]
        public float[] wheelLift;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxTruckWheelCount)]
        public float[] wheelLiftOffset;           // com_f
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxTruckWheelCount)]
        public float[] wheelRadius;               // con_f

        public float linearVelocityX;
        public float linearVelocityY;
        public float linearVelocityZ;
        public float angularVelocityX;
        public float angularVelocityY;
        public float angularVelocityZ;
        public float linearAccelerationX;
        public float linearAccelerationY;
        public float linearAccelerationZ;
        public float angularAccelerationX;
        public float angularAccelerationY;
        public float angularAccelerationZ;        // com_fv
        public float hookPositionX;
        public float hookPositionY;
        public float hookPositionZ;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxTruckWheelCount)]
        public float[] wheelPositionX;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxTruckWheelCount)]
        public float[] wheelPositionY;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxTruckWheelCount)]
        public float[] wheelPositionZ;            // con_fv

        public double worldX;
        public double worldY;
        public double worldZ;
        public double rotationX;
        public double rotationY;
        public double rotationZ;                  // com_dp

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = GeneralStringSize)]
        public byte[] id;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = GeneralStringSize)]
        public byte[] CargoAccessoryId;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = GeneralStringSize)]
        public byte[] bodyType;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = GeneralStringSize)]
        public byte[] brandId;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = GeneralStringSize)]
        public byte[] brand;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = GeneralStringSize)]
        public byte[] name;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = GeneralStringSize)]
        public byte[] chainType;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = GeneralStringSize)]
        public byte[] licensePlate;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = GeneralStringSize)]
        public byte[] licensePlateCountry;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = GeneralStringSize)]
        public byte[] licensePlateCountryId;      // con_s
    }
}