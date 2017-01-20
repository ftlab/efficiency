namespace Efficiency.Samples.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class CmiorDb : DbContext
    {
        public CmiorDb()
            : base("name=CmiorDb")
        {
        }

        public virtual DbSet<ControlRequest> ControlRequest { get; set; }
        public virtual DbSet<ControlRequestTypes> ControlRequestTypes { get; set; }
        public virtual DbSet<DecisionCmior> DecisionCmior { get; set; }
        public virtual DbSet<FPDecision> FPDecision { get; set; }
        public virtual DbSet<PostControlReason> PostControlReason { get; set; }
        public virtual DbSet<PostResult> PostResult { get; set; }
        public virtual DbSet<Resemblance> Resemblance { get; set; }
        public virtual DbSet<Resemblance_CheckErrorsQueue> Resemblance_CheckErrorsQueue { get; set; }
        public virtual DbSet<Resemblance_CheckQueue> Resemblance_CheckQueue { get; set; }
        public virtual DbSet<Resemblance_ETResult> Resemblance_ETResult { get; set; }
        public virtual DbSet<Resemblance_Forpost2Result> Resemblance_Forpost2Result { get; set; }
        public virtual DbSet<Resemblance_OUListResult> Resemblance_OUListResult { get; set; }
        public virtual DbSet<ResemblanceType> ResemblanceType { get; set; }
        public virtual DbSet<Reveal> Reveal { get; set; }
        public virtual DbSet<RevealExport> RevealExport { get; set; }
        public virtual DbSet<C__RefactorLog> C__RefactorLog { get; set; }
        public virtual DbSet<ActionGroup> ActionGroup { get; set; }
        public virtual DbSet<ActionType> ActionType { get; set; }
        public virtual DbSet<AddedMake> AddedMake { get; set; }
        public virtual DbSet<AdditionalInfo> AdditionalInfo { get; set; }
        public virtual DbSet<AdditionalInfoType> AdditionalInfoType { get; set; }
        public virtual DbSet<AdditionalJob> AdditionalJob { get; set; }
        public virtual DbSet<ADP_AdministrativeCase> ADP_AdministrativeCase { get; set; }
        public virtual DbSet<ADP_AdministrativeIntringement> ADP_AdministrativeIntringement { get; set; }
        public virtual DbSet<ADP_AdministrativeIntringementEdit> ADP_AdministrativeIntringementEdit { get; set; }
        public virtual DbSet<ADP_Fine> ADP_Fine { get; set; }
        public virtual DbSet<ADP_IntringementStatus> ADP_IntringementStatus { get; set; }
        public virtual DbSet<ADP_Law> ADP_Law { get; set; }
        public virtual DbSet<ADP_LawClause> ADP_LawClause { get; set; }
        public virtual DbSet<ADP_LegalDocument> ADP_LegalDocument { get; set; }
        public virtual DbSet<ADP_PriorLawClauseIntringement> ADP_PriorLawClauseIntringement { get; set; }
        public virtual DbSet<ADP_PunishmentType> ADP_PunishmentType { get; set; }
        public virtual DbSet<ADP_Resolution> ADP_Resolution { get; set; }
        public virtual DbSet<ADP_ResolutionType> ADP_ResolutionType { get; set; }
        public virtual DbSet<AirplaneBorderCrossing> AirplaneBorderCrossing { get; set; }
        public virtual DbSet<AirplaneRegistration> AirplaneRegistration { get; set; }
        public virtual DbSet<ARM> ARM { get; set; }
        public virtual DbSet<ArrivalStation> ArrivalStation { get; set; }
        public virtual DbSet<ArrivalStationClass> ArrivalStationClass { get; set; }
        public virtual DbSet<ArrivalStationType> ArrivalStationType { get; set; }
        public virtual DbSet<Bio_ChipSignCheck> Bio_ChipSignCheck { get; set; }
        public virtual DbSet<Bio_Data> Bio_Data { get; set; }
        public virtual DbSet<Bio_DataFormat> Bio_DataFormat { get; set; }
        public virtual DbSet<Bio_DataType> Bio_DataType { get; set; }
        public virtual DbSet<BorderCrossing> BorderCrossing { get; set; }
        public virtual DbSet<BorderRouting> BorderRouting { get; set; }
        public virtual DbSet<CarBorderCrossing> CarBorderCrossing { get; set; }
        public virtual DbSet<CarRegistration> CarRegistration { get; set; }
        public virtual DbSet<Carrier> Carrier { get; set; }
        public virtual DbSet<CarrierDecision> CarrierDecision { get; set; }
        public virtual DbSet<CarrierDecisionFilter> CarrierDecisionFilter { get; set; }
        public virtual DbSet<CarrierModel> CarrierModel { get; set; }
        public virtual DbSet<CarrierPark> CarrierPark { get; set; }
        public virtual DbSet<CarrierRegistration> CarrierRegistration { get; set; }
        public virtual DbSet<CarrierType> CarrierType { get; set; }
        public virtual DbSet<CBorderCrossing> CBorderCrossing { get; set; }
        public virtual DbSet<CBorderCrossingType> CBorderCrossingType { get; set; }
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<CityAttribute> CityAttribute { get; set; }
        public virtual DbSet<CityAttributeType> CityAttributeType { get; set; }
        public virtual DbSet<Color> Color { get; set; }
        public virtual DbSet<Committee> Committee { get; set; }
        public virtual DbSet<CommitteeMan> CommitteeMan { get; set; }
        public virtual DbSet<CommitteeStatus> CommitteeStatus { get; set; }
        public virtual DbSet<CommitteeType> CommitteeType { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<CountryAttribute> CountryAttribute { get; set; }
        public virtual DbSet<CountryAttributeType> CountryAttributeType { get; set; }
        public virtual DbSet<CountryGroup> CountryGroup { get; set; }
        public virtual DbSet<CountryLanguage> CountryLanguage { get; set; }
        public virtual DbSet<CountryToCountryGroup> CountryToCountryGroup { get; set; }
        public virtual DbSet<Crew> Crew { get; set; }
        public virtual DbSet<CrewType> CrewType { get; set; }
        public virtual DbSet<CrossingLabel> CrossingLabel { get; set; }
        public virtual DbSet<Decision> Decision { get; set; }
        public virtual DbSet<Deportation> Deportation { get; set; }
        public virtual DbSet<DepthControl> DepthControl { get; set; }
        public virtual DbSet<Deregistration> Deregistration { get; set; }
        public virtual DbSet<DeregistrationReason> DeregistrationReason { get; set; }
        public virtual DbSet<DocumentCategory> DocumentCategory { get; set; }
        public virtual DbSet<DocumentFault> DocumentFault { get; set; }
        public virtual DbSet<DocumentStatus> DocumentStatus { get; set; }
        public virtual DbSet<DomainType> DomainType { get; set; }
        public virtual DbSet<FaultType> FaultType { get; set; }
        public virtual DbSet<Filtration> Filtration { get; set; }
        public virtual DbSet<FirstAidPost> FirstAidPost { get; set; }
        public virtual DbSet<FirstAidPostType> FirstAidPostType { get; set; }
        public virtual DbSet<Flight> Flight { get; set; }
        public virtual DbSet<FlightMode> FlightMode { get; set; }
        public virtual DbSet<FlightType> FlightType { get; set; }
        public virtual DbSet<FMS_CardOperation> FMS_CardOperation { get; set; }
        public virtual DbSet<FMS_CardOperationType> FMS_CardOperationType { get; set; }
        public virtual DbSet<FMS_MigrationCard> FMS_MigrationCard { get; set; }
        public virtual DbSet<FMS_MigrationPurpose> FMS_MigrationPurpose { get; set; }
        public virtual DbSet<FMS_StayCountry> FMS_StayCountry { get; set; }
        public virtual DbSet<ForgedDetectionType> ForgedDetectionType { get; set; }
        public virtual DbSet<Host> Host { get; set; }
        public virtual DbSet<HostImage> HostImage { get; set; }
        public virtual DbSet<Hotel> Hotel { get; set; }
        public virtual DbSet<I_EGISOTB_AviaPlanPassenger> I_EGISOTB_AviaPlanPassenger { get; set; }
        public virtual DbSet<I_FOREPOST2_FACT> I_FOREPOST2_FACT { get; set; }
        public virtual DbSet<IdentifyDocument> IdentifyDocument { get; set; }
        public virtual DbSet<IdentifyDocumentEdit> IdentifyDocumentEdit { get; set; }
        public virtual DbSet<ImageObject> ImageObject { get; set; }
        public virtual DbSet<Inscribe> Inscribe { get; set; }
        public virtual DbSet<InscribeLanguage> InscribeLanguage { get; set; }
        public virtual DbSet<InvOrganization> InvOrganization { get; set; }
        public virtual DbSet<InvOrganizationCountry> InvOrganizationCountry { get; set; }
        public virtual DbSet<KaskadXmlQueue> KaskadXmlQueue { get; set; }
        public virtual DbSet<LadingType> LadingType { get; set; }
        public virtual DbSet<Language> Language { get; set; }
        public virtual DbSet<ModelCategory> ModelCategory { get; set; }
        public virtual DbSet<ModelType> ModelType { get; set; }
        public virtual DbSet<observer_Picture> observer_Picture { get; set; }
        public virtual DbSet<OnLineCheck> OnLineCheck { get; set; }
        public virtual DbSet<Operation> Operation { get; set; }
        public virtual DbSet<OperationType> OperationType { get; set; }
        public virtual DbSet<OrgStatus> OrgStatus { get; set; }
        public virtual DbSet<OU_List> OU_List { get; set; }
        public virtual DbSet<PassengerType> PassengerType { get; set; }
        public virtual DbSet<PassengerTypeChange> PassengerTypeChange { get; set; }
        public virtual DbSet<Patient> Patient { get; set; }
        public virtual DbSet<PersonStatus> PersonStatus { get; set; }
        public virtual DbSet<Photo> Photo { get; set; }
        public virtual DbSet<Position> Position { get; set; }
        public virtual DbSet<Preaudit> Preaudit { get; set; }
        public virtual DbSet<PresentDocument> PresentDocument { get; set; }
        public virtual DbSet<Profession> Profession { get; set; }
        public virtual DbSet<Purpose> Purpose { get; set; }
        public virtual DbSet<PurposeGroup> PurposeGroup { get; set; }
        public virtual DbSet<Rank> Rank { get; set; }
        public virtual DbSet<RCarrierPassenger> RCarrierPassenger { get; set; }
        public virtual DbSet<RCarrierPassengerType> RCarrierPassengerType { get; set; }
        public virtual DbSet<Region> Region { get; set; }
        public virtual DbSet<RegistrationType> RegistrationType { get; set; }
        public virtual DbSet<Sanction> Sanction { get; set; }
        public virtual DbSet<SanctionInitiator> SanctionInitiator { get; set; }
        public virtual DbSet<SanctionType> SanctionType { get; set; }
        public virtual DbSet<Settlement> Settlement { get; set; }
        public virtual DbSet<ShipBorderCrossing> ShipBorderCrossing { get; set; }
        public virtual DbSet<ShipRegistration> ShipRegistration { get; set; }
        public virtual DbSet<SpecialControl> SpecialControl { get; set; }
        public virtual DbSet<SpokenLanguage> SpokenLanguage { get; set; }
        public virtual DbSet<ST_TimeShear> ST_TimeShear { get; set; }
        public virtual DbSet<Stat> Stat { get; set; }
        public virtual DbSet<StateInstitute> StateInstitute { get; set; }
        public virtual DbSet<StatObject> StatObject { get; set; }
        public virtual DbSet<StatType> StatType { get; set; }
        public virtual DbSet<StatTypeObject> StatTypeObject { get; set; }
        public virtual DbSet<Subdivision> Subdivision { get; set; }
        public virtual DbSet<SuspectFaultType> SuspectFaultType { get; set; }
        public virtual DbSet<TelegramDict> TelegramDict { get; set; }
        public virtual DbSet<TelegramDictValue> TelegramDictValue { get; set; }
        public virtual DbSet<Track> Track { get; set; }
        public virtual DbSet<TrainBorderCrossing> TrainBorderCrossing { get; set; }
        public virtual DbSet<TrainRegistration> TrainRegistration { get; set; }
        public virtual DbSet<TranMorph> TranMorph { get; set; }
        public virtual DbSet<TranscriptionAlgorithm> TranscriptionAlgorithm { get; set; }
        public virtual DbSet<Transfert> Transfert { get; set; }
        public virtual DbSet<Transit> Transit { get; set; }
        public virtual DbSet<TransitCategory> TransitCategory { get; set; }
        public virtual DbSet<TransitCategoryChange> TransitCategoryChange { get; set; }
        public virtual DbSet<TransitHotel> TransitHotel { get; set; }
        public virtual DbSet<TransportCompany> TransportCompany { get; set; }
        public virtual DbSet<Underenumeration> Underenumeration { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<UserAction> UserAction { get; set; }
        public virtual DbSet<UserInfo> UserInfo { get; set; }
        public virtual DbSet<Visa> Visa { get; set; }
        public virtual DbSet<VisaClass> VisaClass { get; set; }
        public virtual DbSet<VisaInscribe> VisaInscribe { get; set; }
        public virtual DbSet<VisaRepetition> VisaRepetition { get; set; }
        public virtual DbSet<VisaType> VisaType { get; set; }
        public virtual DbSet<XUserList> XUserList { get; set; }
        public virtual DbSet<XUserType> XUserType { get; set; }
        public virtual DbSet<XUserTypeList> XUserTypeList { get; set; }
        public virtual DbSet<ActivityMode> ActivityMode { get; set; }
        public virtual DbSet<Airline> Airline { get; set; }
        public virtual DbSet<AirlineCode> AirlineCode { get; set; }
        public virtual DbSet<AirlineCodeType> AirlineCodeType { get; set; }
        public virtual DbSet<AirportSector> AirportSector { get; set; }
        public virtual DbSet<Arm1> Arm1 { get; set; }
        public virtual DbSet<ArmHierarchy> ArmHierarchy { get; set; }
        public virtual DbSet<ArmPtk> ArmPtk { get; set; }
        public virtual DbSet<ArmType> ArmType { get; set; }
        public virtual DbSet<Cabin> Cabin { get; set; }
        public virtual DbSet<CarrierParkingArea> CarrierParkingArea { get; set; }
        public virtual DbSet<ChiefType> ChiefType { get; set; }
        public virtual DbSet<ControlledPersonLocation> ControlledPersonLocation { get; set; }
        public virtual DbSet<CountryCode> CountryCode { get; set; }
        public virtual DbSet<CountryCodeType> CountryCodeType { get; set; }
        public virtual DbSet<CountryLanguage1> CountryLanguage1 { get; set; }
        public virtual DbSet<DepartmentGroup> DepartmentGroup { get; set; }
        public virtual DbSet<DepartmentJob> DepartmentJob { get; set; }
        public virtual DbSet<DepartmentStaff> DepartmentStaff { get; set; }
        public virtual DbSet<DepartmentTargets> DepartmentTargets { get; set; }
        public virtual DbSet<DepartmentWorkSchedule> DepartmentWorkSchedule { get; set; }
        public virtual DbSet<Direction> Direction { get; set; }
        public virtual DbSet<DutyRoutes> DutyRoutes { get; set; }
        public virtual DbSet<DutyType> DutyType { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<EmployeeActivityType> EmployeeActivityType { get; set; }
        public virtual DbSet<EmployeeCard> EmployeeCard { get; set; }
        public virtual DbSet<EmployeeCompatibilityList> EmployeeCompatibilityList { get; set; }
        public virtual DbSet<EmployeeDepartmentGroup> EmployeeDepartmentGroup { get; set; }
        public virtual DbSet<EmployeeDepartmentJob> EmployeeDepartmentJob { get; set; }
        public virtual DbSet<EmployeeKaskadUser> EmployeeKaskadUser { get; set; }
        public virtual DbSet<EmployeeOrganizationalStructure> EmployeeOrganizationalStructure { get; set; }
        public virtual DbSet<EmployeeOverProcessing> EmployeeOverProcessing { get; set; }
        public virtual DbSet<EmployeeWorkPermitSchedule> EmployeeWorkPermitSchedule { get; set; }
        public virtual DbSet<FlightInspectionJournalStatus> FlightInspectionJournalStatus { get; set; }
        public virtual DbSet<FlightStatus> FlightStatus { get; set; }
        public virtual DbSet<Location> Location { get; set; }
        public virtual DbSet<LocationRoute> LocationRoute { get; set; }
        public virtual DbSet<LocationRoute_Arm> LocationRoute_Arm { get; set; }
        public virtual DbSet<LocationRoute_CarrierParkingArea> LocationRoute_CarrierParkingArea { get; set; }
        public virtual DbSet<LocationRoute_MapObjects> LocationRoute_MapObjects { get; set; }
        public virtual DbSet<LocationSector> LocationSector { get; set; }
        public virtual DbSet<MapObjects> MapObjects { get; set; }
        public virtual DbSet<MapObjects_Arm> MapObjects_Arm { get; set; }
        public virtual DbSet<MapObjects_Arm_Camera> MapObjects_Arm_Camera { get; set; }
        public virtual DbSet<MapObjects_Cabin> MapObjects_Cabin { get; set; }
        public virtual DbSet<MapObjects_Camera> MapObjects_Camera { get; set; }
        public virtual DbSet<MapObjects_Sector> MapObjects_Sector { get; set; }
        public virtual DbSet<MapObjectTypes> MapObjectTypes { get; set; }
        public virtual DbSet<Maps> Maps { get; set; }
        public virtual DbSet<MilitaryRank> MilitaryRank { get; set; }
        public virtual DbSet<OrganizationalStructure> OrganizationalStructure { get; set; }
        public virtual DbSet<OrganizationalStructureChief> OrganizationalStructureChief { get; set; }
        public virtual DbSet<OrganizationalStructureType> OrganizationalStructureType { get; set; }
        public virtual DbSet<PlanType> PlanType { get; set; }
        public virtual DbSet<ReportTemplate> ReportTemplate { get; set; }
        public virtual DbSet<ReportType> ReportType { get; set; }
        public virtual DbSet<Sector> Sector { get; set; }
        public virtual DbSet<Sex> Sex { get; set; }
        public virtual DbSet<WorkingCalendar> WorkingCalendar { get; set; }
        public virtual DbSet<WorkingDayType> WorkingDayType { get; set; }
        public virtual DbSet<WorkPermitType> WorkPermitType { get; set; }
        public virtual DbSet<WorkScheduleType> WorkScheduleType { get; set; }
        public virtual DbSet<Flight1> Flight1 { get; set; }
        public virtual DbSet<FlightInspectionJournal> FlightInspectionJournal { get; set; }
        public virtual DbSet<FlightTransitionLinks> FlightTransitionLinks { get; set; }
        public virtual DbSet<Emergency> Emergency { get; set; }
        public virtual DbSet<EmergencySector> EmergencySector { get; set; }
        public virtual DbSet<FixedGroupLanguage> FixedGroupLanguage { get; set; }
        public virtual DbSet<LanguageGroup> LanguageGroup { get; set; }
        public virtual DbSet<LanguageGroupCabin> LanguageGroupCabin { get; set; }
        public virtual DbSet<LanguageGroupCabinPreset> LanguageGroupCabinPreset { get; set; }
        public virtual DbSet<ValidGroupLanguage> ValidGroupLanguage { get; set; }
        public virtual DbSet<LastProhod> LastProhod { get; set; }
        public virtual DbSet<Obj_CAM> Obj_CAM { get; set; }
        public virtual DbSet<Obj_Person> Obj_Person { get; set; }
        public virtual DbSet<Obj_PNET3_NC32K> Obj_PNET3_NC32K { get; set; }
        public virtual DbSet<ObjType> ObjType { get; set; }
        public virtual DbSet<ObjTypeEvent> ObjTypeEvent { get; set; }
        public virtual DbSet<Protocol> Protocol { get; set; }
        public virtual DbSet<RequestVideoFile> RequestVideoFile { get; set; }
        public virtual DbSet<Authorization> Authorization { get; set; }
        public virtual DbSet<ChangeDirection> ChangeDirection { get; set; }
        public virtual DbSet<ChangeMode> ChangeMode { get; set; }
        public virtual DbSet<Control> Control { get; set; }
        public virtual DbSet<DocumentScan> DocumentScan { get; set; }
        public virtual DbSet<DocumentScanType> DocumentScanType { get; set; }
        public virtual DbSet<Errors> Errors { get; set; }
        public virtual DbSet<FIO> FIO { get; set; }
        public virtual DbSet<Lock> Lock { get; set; }
        public virtual DbSet<Message> Message { get; set; }
        public virtual DbSet<PakLogFile> PakLogFile { get; set; }
        public virtual DbSet<Passenger> Passenger { get; set; }
        public virtual DbSet<Reading> Reading { get; set; }
        public virtual DbSet<ReadMRZ> ReadMRZ { get; set; }
        public virtual DbSet<ReadRFID> ReadRFID { get; set; }
        public virtual DbSet<Registration> Registration { get; set; }
        public virtual DbSet<SPNDepthControl> SPNDepthControl { get; set; }
        public virtual DbSet<Starting> Starting { get; set; }
        public virtual DbSet<OU_List_Deleted> OU_List_Deleted { get; set; }
        public virtual DbSet<ArmConfig> ArmConfig { get; set; }
        public virtual DbSet<ArmModule> ArmModule { get; set; }
        public virtual DbSet<ArmType_Dashboard_Configuration> ArmType_Dashboard_Configuration { get; set; }
        public virtual DbSet<Dashboard_Configuration> Dashboard_Configuration { get; set; }
        public virtual DbSet<Dashboard_Control> Dashboard_Control { get; set; }
        public virtual DbSet<Dashboard_Display> Dashboard_Display { get; set; }
        public virtual DbSet<Dashboard_Display_Collection> Dashboard_Display_Collection { get; set; }
        public virtual DbSet<Dashboard_Form> Dashboard_Form { get; set; }
        public virtual DbSet<DeploymentHistory> DeploymentHistory { get; set; }
        public virtual DbSet<Numeric> Numeric { get; set; }
        public virtual DbSet<Setting1> Setting1 { get; set; }
        public virtual DbSet<SmallNumeric> SmallNumeric { get; set; }
        public virtual DbSet<Statistic_Control> Statistic_Control { get; set; }
        public virtual DbSet<Statistic_Control_Group> Statistic_Control_Group { get; set; }
        public virtual DbSet<BorderProtectionPlan> BorderProtectionPlan { get; set; }
        public virtual DbSet<BorderProtectionScheduleDetail> BorderProtectionScheduleDetail { get; set; }
        public virtual DbSet<BorderProtectionScheduleHeader> BorderProtectionScheduleHeader { get; set; }
        public virtual DbSet<BorderProtectionScheduleReserve> BorderProtectionScheduleReserve { get; set; }
        public virtual DbSet<BorderProtectionScheduleSector> BorderProtectionScheduleSector { get; set; }
        public virtual DbSet<BorderProtectionScheduleSectorDefaults> BorderProtectionScheduleSectorDefaults { get; set; }
        public virtual DbSet<BorderProtectionScheduleTargets> BorderProtectionScheduleTargets { get; set; }
        public virtual DbSet<EgisOTB_Data> EgisOTB_Data { get; set; }
        public virtual DbSet<I_EGISOTB_Flight> I_EGISOTB_Flight { get; set; }
        public virtual DbSet<I_EGISOTB_Passenger> I_EGISOTB_Passenger { get; set; }
        public virtual DbSet<Passenger1> Passenger1 { get; set; }
        public virtual DbSet<Passenger_FIO_RUS> Passenger_FIO_RUS { get; set; }
        public virtual DbSet<PassengerFile> PassengerFile { get; set; }
        public virtual DbSet<PassengerFile_Passenger> PassengerFile_Passenger { get; set; }
        public virtual DbSet<PassengerFileType> PassengerFileType { get; set; }
        public virtual DbSet<PassengerFileTypeExt> PassengerFileTypeExt { get; set; }
        public virtual DbSet<PassengerJournal> PassengerJournal { get; set; }
        public virtual DbSet<PassengerOperationType> PassengerOperationType { get; set; }
        public virtual DbSet<ExportParameters> ExportParameters { get; set; }
        public virtual DbSet<BorderProtectionScheduleChronometry> BorderProtectionScheduleChronometry { get; set; }
        public virtual DbSet<BorderProtectionScheduleReinforcement> BorderProtectionScheduleReinforcement { get; set; }
        public virtual DbSet<ControlledPerson> ControlledPerson { get; set; }
        public virtual DbSet<ControlledPersonOfficerHistory> ControlledPersonOfficerHistory { get; set; }
        public virtual DbSet<ControlledPersonStatus> ControlledPersonStatus { get; set; }
        public virtual DbSet<InspectionCommittee> InspectionCommittee { get; set; }
        public virtual DbSet<InspectionCommitteeMembers> InspectionCommitteeMembers { get; set; }
        public virtual DbSet<RegimeActivity> RegimeActivity { get; set; }
        public virtual DbSet<ReinforcementStatus> ReinforcementStatus { get; set; }
        public virtual DbSet<Address> Address { get; set; }
        public virtual DbSet<ArmGroup> ArmGroup { get; set; }
        public virtual DbSet<InformJournal> InformJournal { get; set; }
        public virtual DbSet<InformJournalRecipient> InformJournalRecipient { get; set; }
        public virtual DbSet<PresentationControl> PresentationControl { get; set; }
        public virtual DbSet<PresentationControlRecipient> PresentationControlRecipient { get; set; }
        public virtual DbSet<Queue> Queue { get; set; }
        public virtual DbSet<agr_ArmSession> agr_ArmSession { get; set; }
        public virtual DbSet<agr_ArmSessionHistory> agr_ArmSessionHistory { get; set; }
        public virtual DbSet<agr_UserSession> agr_UserSession { get; set; }
        public virtual DbSet<arg_RegistrationEndReg> arg_RegistrationEndReg { get; set; }
        public virtual DbSet<AttachmentType> AttachmentType { get; set; }
        public virtual DbSet<CabinState> CabinState { get; set; }
        public virtual DbSet<CustomEventProperties> CustomEventProperties { get; set; }
        public virtual DbSet<Employee__Statistic_Control> Employee__Statistic_Control { get; set; }
        public virtual DbSet<Employee_ReportGroup> Employee_ReportGroup { get; set; }
        public virtual DbSet<EmployeeSession> EmployeeSession { get; set; }
        public virtual DbSet<EventGroup> EventGroup { get; set; }
        public virtual DbSet<EventLog> EventLog { get; set; }
        public virtual DbSet<EventLogRaw> EventLogRaw { get; set; }
        public virtual DbSet<EventPhotoAttachments> EventPhotoAttachments { get; set; }
        public virtual DbSet<EventPriority> EventPriority { get; set; }
        public virtual DbSet<EventPTKLogAttachment> EventPTKLogAttachment { get; set; }
        public virtual DbSet<EventRawType> EventRawType { get; set; }
        public virtual DbSet<EventType> EventType { get; set; }
        public virtual DbSet<EventVideoAttachment> EventVideoAttachment { get; set; }
        public virtual DbSet<MapObjectState> MapObjectState { get; set; }
        public virtual DbSet<MapObjectStateType> MapObjectStateType { get; set; }
        public virtual DbSet<SC_JobError> SC_JobError { get; set; }
        public virtual DbSet<SC_JobHistory> SC_JobHistory { get; set; }
        public virtual DbSet<IM_ArriveDeparture> IM_ArriveDeparture { get; set; }
        public virtual DbSet<IM_ArriveNotDeparture> IM_ArriveNotDeparture { get; set; }
        public virtual DbSet<IM_NotArriveDeparture> IM_NotArriveDeparture { get; set; }
        public virtual DbSet<IM_Prepared> IM_Prepared { get; set; }
        public virtual DbSet<Setting> Setting { get; set; }
        public virtual DbSet<Sequence1000> Sequence1000 { get; set; }
        public virtual DbSet<agr_RegistrationStartReg> agr_RegistrationStartReg { get; set; }
        public virtual DbSet<EventRawType__EventType> EventRawType__EventType { get; set; }
        public virtual DbSet<MapObjectStateEndTime> MapObjectStateEndTime { get; set; }
        public virtual DbSet<MapObjectStateEventLogEndTime> MapObjectStateEventLogEndTime { get; set; }
        public virtual DbSet<BorderCrossingHistory> BorderCrossingHistory { get; set; }
        public virtual DbSet<BorderCrossingHistoryLight> BorderCrossingHistoryLight { get; set; }
        public virtual DbSet<ILBorderCrossing> ILBorderCrossing { get; set; }
        public virtual DbSet<ILPassangerEventArg> ILPassangerEventArg { get; set; }
        public virtual DbSet<ILPassportRead> ILPassportRead { get; set; }
        public virtual DbSet<ILPersonControl> ILPersonControl { get; set; }
        public virtual DbSet<ILPersonRegistration> ILPersonRegistration { get; set; }
        public virtual DbSet<V_Forpost2MQT> V_Forpost2MQT { get; set; }
        public virtual DbSet<V_ForpostErrors> V_ForpostErrors { get; set; }
        public virtual DbSet<V_ForpostJournal> V_ForpostJournal { get; set; }
        public virtual DbSet<V_ForpostMQT> V_ForpostMQT { get; set; }
        public virtual DbSet<V_FoundPerson> V_FoundPerson { get; set; }
        public virtual DbSet<V_PossibleAliens> V_PossibleAliens { get; set; }
        public virtual DbSet<V_Resemblance_OU> V_Resemblance_OU { get; set; }
        public virtual DbSet<V_RevealExport> V_RevealExport { get; set; }
        public virtual DbSet<V_SearchPerson> V_SearchPerson { get; set; }
        public virtual DbSet<V_WorkScheduleAliens> V_WorkScheduleAliens { get; set; }
        public virtual DbSet<spk_VPassengerMaterialized> spk_VPassengerMaterialized { get; set; }
        public virtual DbSet<v_cmOperatorStat> v_cmOperatorStat { get; set; }
        public virtual DbSet<VUserInfo_UI> VUserInfo_UI { get; set; }
        public virtual DbSet<v_ARM> v_ARM { get; set; }
        public virtual DbSet<v_Flight> v_Flight { get; set; }
        public virtual DbSet<v_GroupLanguageFixed> v_GroupLanguageFixed { get; set; }
        public virtual DbSet<v_GroupLanguageStatistic> v_GroupLanguageStatistic { get; set; }
        public virtual DbSet<v_LanguageGroupCabin> v_LanguageGroupCabin { get; set; }
        public virtual DbSet<v_Control> v_Control { get; set; }
        public virtual DbSet<v_FIO> v_FIO { get; set; }
        public virtual DbSet<v_Registration> v_Registration { get; set; }
        public virtual DbSet<V_OU_List_History> V_OU_List_History { get; set; }
        public virtual DbSet<OperatorStatistics> OperatorStatistics { get; set; }
        public virtual DbSet<v_Passenger_FIO_RUS> v_Passenger_FIO_RUS { get; set; }
        public virtual DbSet<v_Authorization> v_Authorization { get; set; }
        public virtual DbSet<v_KaskadControlledPerson> v_KaskadControlledPerson { get; set; }
        public virtual DbSet<v_KaskadFlight> v_KaskadFlight { get; set; }
        public virtual DbSet<v_PassangerStats> v_PassangerStats { get; set; }
        public virtual DbSet<v_ResultControlLastChrono> v_ResultControlLastChrono { get; set; }
        public virtual DbSet<v_ResultControlLastChronoFull> v_ResultControlLastChronoFull { get; set; }
        public virtual DbSet<v_ResultsControlAll> v_ResultsControlAll { get; set; }
        public virtual DbSet<v_ResultsControlCabin> v_ResultsControlCabin { get; set; }
        public virtual DbSet<v_ResultsControlEmployeeList> v_ResultsControlEmployeeList { get; set; }
        public virtual DbSet<v_ResultsControlLocation> v_ResultsControlLocation { get; set; }
        public virtual DbSet<v_ResultsControlNoInfo> v_ResultsControlNoInfo { get; set; }
        public virtual DbSet<v_ResultsControlReinforcements> v_ResultsControlReinforcements { get; set; }
        public virtual DbSet<v_ResultsControlUnaccounted> v_ResultsControlUnaccounted { get; set; }
        public virtual DbSet<v_ArmGroup> v_ArmGroup { get; set; }
        public virtual DbSet<v_EventLog> v_EventLog { get; set; }
        public virtual DbSet<v_EventVideoAttachment> v_EventVideoAttachment { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ControlRequest>()
                .Property(e => e.Operator)
                .IsUnicode(false);

            modelBuilder.Entity<ControlRequest>()
                .Property(e => e.Comment)
                .IsUnicode(false);

            modelBuilder.Entity<ControlRequest>()
                .Property(e => e.RevertComment)
                .IsUnicode(false);

            modelBuilder.Entity<ControlRequest>()
                .HasMany(e => e.PostResult)
                .WithRequired(e => e.ControlRequest)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ControlRequestTypes>()
                .Property(e => e.ControlRequestTypeName)
                .IsUnicode(false);

            modelBuilder.Entity<ControlRequestTypes>()
                .HasMany(e => e.ControlRequest)
                .WithRequired(e => e.ControlRequestTypes)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DecisionCmior>()
                .Property(e => e.DecisionName)
                .IsUnicode(false);

            modelBuilder.Entity<DecisionCmior>()
                .HasMany(e => e.ControlRequest)
                .WithRequired(e => e.DecisionCmior)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FPDecision>()
                .Property(e => e.DecisionName)
                .IsUnicode(false);

            modelBuilder.Entity<FPDecision>()
                .HasMany(e => e.Resemblance)
                .WithRequired(e => e.FPDecision)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PostControlReason>()
                .Property(e => e.Reason)
                .IsUnicode(false);

            modelBuilder.Entity<PostControlReason>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<PostResult>()
                .Property(e => e.OU_List_Hash)
                .IsFixedLength();

            modelBuilder.Entity<Resemblance>()
                .Property(e => e.NameInList)
                .IsUnicode(false);

            modelBuilder.Entity<Resemblance>()
                .Property(e => e.Note)
                .IsUnicode(false);

            modelBuilder.Entity<Resemblance>()
                .Property(e => e.Checked)
                .IsUnicode(false);

            modelBuilder.Entity<Resemblance>()
                .Property(e => e.PlanPassenger_FIORUS)
                .IsUnicode(false);

            modelBuilder.Entity<Resemblance>()
                .Property(e => e.PlanPassenger_Citizenship)
                .IsUnicode(false);

            modelBuilder.Entity<Resemblance>()
                .HasMany(e => e.Resemblance_ETResult)
                .WithRequired(e => e.Resemblance)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Resemblance>()
                .HasMany(e => e.Resemblance_Forpost2Result)
                .WithRequired(e => e.Resemblance)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Resemblance>()
                .HasMany(e => e.Resemblance_OUListResult)
                .WithRequired(e => e.Resemblance)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Resemblance>()
                .HasMany(e => e.Reveal)
                .WithRequired(e => e.Resemblance)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Resemblance_ETResult>()
                .Property(e => e.Note)
                .IsUnicode(false);

            modelBuilder.Entity<Resemblance_ETResult>()
                .Property(e => e.Checked)
                .IsUnicode(false);

            modelBuilder.Entity<ResemblanceType>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Reveal>()
                .Property(e => e.Comment)
                .IsUnicode(false);

            modelBuilder.Entity<Reveal>()
                .Property(e => e.Operator)
                .IsUnicode(false);

            modelBuilder.Entity<Reveal>()
                .Property(e => e.Job)
                .IsUnicode(false);

            modelBuilder.Entity<Reveal>()
                .HasMany(e => e.Resemblance_ETResult)
                .WithRequired(e => e.Reveal)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RevealExport>()
                .Property(e => e.Operator)
                .IsUnicode(false);

            modelBuilder.Entity<RevealExport>()
                .Property(e => e.FileName)
                .IsUnicode(false);

            modelBuilder.Entity<RevealExport>()
                .Property(e => e.Job)
                .IsUnicode(false);

            modelBuilder.Entity<ActionGroup>()
                .Property(e => e.ActionGroupID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<ActionGroup>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<ActionGroup>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<ActionType>()
                .Property(e => e.ActionGroupID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<ActionType>()
                .Property(e => e.ActionTypeID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<ActionType>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<ActionType>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<ActionType>()
                .Property(e => e.DescString1)
                .IsUnicode(false);

            modelBuilder.Entity<ActionType>()
                .Property(e => e.DescString2)
                .IsUnicode(false);

            modelBuilder.Entity<ActionType>()
                .Property(e => e.DescString3)
                .IsUnicode(false);

            modelBuilder.Entity<ActionType>()
                .Property(e => e.DescNumber1)
                .IsUnicode(false);

            modelBuilder.Entity<ActionType>()
                .Property(e => e.DescNumber2)
                .IsUnicode(false);

            modelBuilder.Entity<ActionType>()
                .Property(e => e.DescNumber3)
                .IsUnicode(false);

            modelBuilder.Entity<ActionType>()
                .Property(e => e.DescDate1)
                .IsUnicode(false);

            modelBuilder.Entity<ActionType>()
                .Property(e => e.DescDate2)
                .IsUnicode(false);

            modelBuilder.Entity<ActionType>()
                .Property(e => e.DescDate3)
                .IsUnicode(false);

            modelBuilder.Entity<ActionType>()
                .Property(e => e.DescString4)
                .IsUnicode(false);

            modelBuilder.Entity<ActionType>()
                .Property(e => e.DescString5)
                .IsUnicode(false);

            modelBuilder.Entity<ActionType>()
                .Property(e => e.DescString6)
                .IsUnicode(false);

            modelBuilder.Entity<ActionType>()
                .Property(e => e.DescString7)
                .IsUnicode(false);

            modelBuilder.Entity<ActionType>()
                .Property(e => e.DescString8)
                .IsUnicode(false);

            modelBuilder.Entity<ActionType>()
                .Property(e => e.DescNumber4)
                .IsUnicode(false);

            modelBuilder.Entity<ActionType>()
                .Property(e => e.DescNumber5)
                .IsUnicode(false);

            modelBuilder.Entity<AddedMake>()
                .Property(e => e.AddedMakeID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<AddedMake>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<AddedMake>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<AddedMake>()
                .Property(e => e.DeleteFlag)
                .HasPrecision(1, 0);

            modelBuilder.Entity<AddedMake>()
                .Property(e => e.ReadOnly)
                .HasPrecision(1, 0);

            modelBuilder.Entity<AdditionalInfo>()
                .Property(e => e.BorderCrossingID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<AdditionalInfo>()
                .Property(e => e.AdditionalInfoTypeID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<AdditionalInfo>()
                .Property(e => e.DestinationCountryID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<AdditionalInfo>()
                .Property(e => e.ArbitraryInfo)
                .IsUnicode(false);

            modelBuilder.Entity<AdditionalInfo>()
                .Property(e => e.PRCityName)
                .IsUnicode(false);

            modelBuilder.Entity<AdditionalInfo>()
                .Property(e => e.VaucherInfo)
                .IsUnicode(false);

            modelBuilder.Entity<AdditionalInfoType>()
                .Property(e => e.AdditionalInfoTypeID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<AdditionalInfoType>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<AdditionalInfoType>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<AdditionalJob>()
                .Property(e => e.AdditionalJobID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<AdditionalJob>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<AdditionalJob>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<AdditionalJob>()
                .Property(e => e.DeleteFlag)
                .HasPrecision(1, 0);

            modelBuilder.Entity<AdditionalJob>()
                .Property(e => e.ReadOnly)
                .HasPrecision(1, 0);

            modelBuilder.Entity<ADP_AdministrativeCase>()
                .Property(e => e.AdministrativeCaseID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<ADP_AdministrativeCase>()
                .Property(e => e.InitiatorID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<ADP_AdministrativeCase>()
                .Property(e => e.Number)
                .IsUnicode(false);

            modelBuilder.Entity<ADP_AdministrativeCase>()
                .Property(e => e.SheetNumber)
                .HasPrecision(35, 0);

            modelBuilder.Entity<ADP_AdministrativeCase>()
                .Property(e => e.CaseStartLegalDocumentID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<ADP_AdministrativeCase>()
                .Property(e => e.Appeals)
                .IsUnicode(false);

            modelBuilder.Entity<ADP_AdministrativeCase>()
                .Property(e => e.DistraintNumber)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ADP_AdministrativeCase>()
                .Property(e => e.BorderCrossingID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<ADP_AdministrativeCase>()
                .Property(e => e.AdministrativeIntringementID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<ADP_AdministrativeCase>()
                .Property(e => e.QualificationLawID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<ADP_AdministrativeCase>()
                .Property(e => e.QualificationLawClauseID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<ADP_AdministrativeIntringement>()
                .Property(e => e.PriorQualificationClauseID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<ADP_AdministrativeIntringement>()
                .Property(e => e.BorderCrossingID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<ADP_AdministrativeIntringement>()
                .Property(e => e.AdministrativeIntringementID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<ADP_AdministrativeIntringement>()
                .Property(e => e.IntrigementFacts)
                .IsUnicode(false);

            modelBuilder.Entity<ADP_AdministrativeIntringement>()
                .Property(e => e.PriorQualificationLawID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<ADP_AdministrativeIntringement>()
                .Property(e => e.IntringementStatusID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<ADP_AdministrativeIntringement>()
                .Property(e => e.PriorQualificationPart)
                .HasPrecision(35, 0);

            modelBuilder.Entity<ADP_AdministrativeIntringement>()
                .Property(e => e.PriorQualificationParagraph)
                .HasPrecision(35, 0);

            modelBuilder.Entity<ADP_AdministrativeIntringement>()
                .Property(e => e.PriorQualificationPoint)
                .HasPrecision(35, 0);

            modelBuilder.Entity<ADP_AdministrativeIntringement>()
                .Property(e => e.SourceOperationID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<ADP_AdministrativeIntringementEdit>()
                .Property(e => e.AdministrativeIntringementID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<ADP_AdministrativeIntringementEdit>()
                .Property(e => e.BorderCrossingID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<ADP_AdministrativeIntringementEdit>()
                .Property(e => e.OperationID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<ADP_Fine>()
                .Property(e => e.TicketNumber)
                .IsUnicode(false);

            modelBuilder.Entity<ADP_Fine>()
                .Property(e => e.AdministrativeCaseID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<ADP_Fine>()
                .Property(e => e.Amount)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ADP_IntringementStatus>()
                .Property(e => e.IntringementStatusID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<ADP_IntringementStatus>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<ADP_IntringementStatus>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<ADP_Law>()
                .Property(e => e.LawID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<ADP_Law>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<ADP_Law>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<ADP_Law>()
                .Property(e => e.DeleteFlag)
                .HasPrecision(1, 0);

            modelBuilder.Entity<ADP_Law>()
                .Property(e => e.ReadOnly)
                .HasPrecision(1, 0);

            modelBuilder.Entity<ADP_LawClause>()
                .Property(e => e.LawClauseID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<ADP_LawClause>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<ADP_LawClause>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<ADP_LawClause>()
                .Property(e => e.LawID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<ADP_LawClause>()
                .Property(e => e.DeleteFlag)
                .HasPrecision(1, 0);

            modelBuilder.Entity<ADP_LawClause>()
                .Property(e => e.ReadOnly)
                .HasPrecision(1, 0);

            modelBuilder.Entity<ADP_LegalDocument>()
                .Property(e => e.LegalDocumentID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<ADP_LegalDocument>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<ADP_LegalDocument>()
                .Property(e => e.Decription)
                .IsUnicode(false);

            modelBuilder.Entity<ADP_PriorLawClauseIntringement>()
                .Property(e => e.LawClauseID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<ADP_PriorLawClauseIntringement>()
                .Property(e => e.BorderCrossingID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<ADP_PriorLawClauseIntringement>()
                .Property(e => e.LawID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<ADP_PriorLawClauseIntringement>()
                .Property(e => e.AdministrativeIntringementID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<ADP_PriorLawClauseIntringement>()
                .Property(e => e.Part)
                .HasPrecision(35, 0);

            modelBuilder.Entity<ADP_PriorLawClauseIntringement>()
                .Property(e => e.Paragraph)
                .HasPrecision(35, 0);

            modelBuilder.Entity<ADP_PriorLawClauseIntringement>()
                .Property(e => e.Point)
                .HasPrecision(35, 0);

            modelBuilder.Entity<ADP_PunishmentType>()
                .Property(e => e.PunishmentTypeID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<ADP_PunishmentType>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<ADP_PunishmentType>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<ADP_Resolution>()
                .Property(e => e.AdministrativeCaseID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<ADP_Resolution>()
                .Property(e => e.ResolutionTypeID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<ADP_Resolution>()
                .Property(e => e.LawID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<ADP_Resolution>()
                .Property(e => e.LawClauseID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<ADP_Resolution>()
                .Property(e => e.Part)
                .HasPrecision(35, 0);

            modelBuilder.Entity<ADP_Resolution>()
                .Property(e => e.PunishmentTypeID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<ADP_Resolution>()
                .Property(e => e.Paragraph)
                .HasPrecision(35, 0);

            modelBuilder.Entity<ADP_Resolution>()
                .Property(e => e.Point)
                .HasPrecision(35, 0);

            modelBuilder.Entity<ADP_ResolutionType>()
                .Property(e => e.ResolutionTypeID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<ADP_ResolutionType>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<ADP_ResolutionType>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<AirplaneBorderCrossing>()
                .Property(e => e.ArrivalStationID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<AirplaneBorderCrossing>()
                .Property(e => e.BorderRoutingID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<AirplaneBorderCrossing>()
                .Property(e => e.CarrierTypeID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<AirplaneBorderCrossing>()
                .Property(e => e.CarrierBCID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<AirplaneBorderCrossing>()
                .Property(e => e.PassengerNumber)
                .HasPrecision(35, 0);

            modelBuilder.Entity<AirplaneBorderCrossing>()
                .Property(e => e.VIPNumber)
                .HasPrecision(35, 0);

            modelBuilder.Entity<AirplaneBorderCrossing>()
                .Property(e => e.DIPNumber)
                .HasPrecision(35, 0);

            modelBuilder.Entity<AirplaneBorderCrossing>()
                .Property(e => e.PatientNumber)
                .HasPrecision(35, 0);

            modelBuilder.Entity<AirplaneBorderCrossing>()
                .Property(e => e.CrewNumber)
                .HasPrecision(35, 0);

            modelBuilder.Entity<AirplaneBorderCrossing>()
                .Property(e => e.Notes)
                .IsUnicode(false);

            modelBuilder.Entity<AirplaneBorderCrossing>()
                .Property(e => e.CommitteeTypeID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<AirplaneBorderCrossing>()
                .Property(e => e.CommitteeID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<AirplaneRegistration>()
                .Property(e => e.ArrivalStationID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<AirplaneRegistration>()
                .Property(e => e.BorderRoutingID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<AirplaneRegistration>()
                .Property(e => e.CarrierTypeID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<AirplaneRegistration>()
                .Property(e => e.CarrierBCID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<AirplaneRegistration>()
                .Property(e => e.CarrierRegistrationID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<ARM>()
                .Property(e => e.ARMID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<ARM>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<ARM>()
                .Property(e => e.FriendlyName)
                .IsUnicode(false);

            modelBuilder.Entity<ARM>()
                .Property(e => e.Notes)
                .IsUnicode(false);

            modelBuilder.Entity<ARM>()
                .Property(e => e.ARMLogin)
                .IsUnicode(false);

            modelBuilder.Entity<ARM>()
                .Property(e => e.ARMPassword)
                .IsUnicode(false);

            modelBuilder.Entity<ARM>()
                .Property(e => e.UnusedFlag)
                .HasPrecision(1, 0);

            modelBuilder.Entity<ARM>()
                .Property(e => e.AutonomyFlag)
                .HasPrecision(1, 0);

            modelBuilder.Entity<ARM>()
                .Property(e => e.AirplaneFlag)
                .HasPrecision(1, 0);

            modelBuilder.Entity<ARM>()
                .Property(e => e.CarFlag)
                .HasPrecision(1, 0);

            modelBuilder.Entity<ARM>()
                .Property(e => e.ShipFlag)
                .HasPrecision(1, 0);

            modelBuilder.Entity<ARM>()
                .Property(e => e.TrainFlag)
                .HasPrecision(1, 0);

            modelBuilder.Entity<ARM>()
                .Property(e => e.FootFlag)
                .HasPrecision(1, 0);

            modelBuilder.Entity<ARM>()
                .Property(e => e.CenterFlag)
                .HasPrecision(1, 0);

            modelBuilder.Entity<ArrivalStation>()
                .Property(e => e.ArrivalStationID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<ArrivalStation>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<ArrivalStation>()
                .Property(e => e.CurrentStationFlag)
                .HasPrecision(1, 0);

            modelBuilder.Entity<ArrivalStation>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<ArrivalStation>()
                .Property(e => e.AirplaneFlag)
                .HasPrecision(1, 0);

            modelBuilder.Entity<ArrivalStation>()
                .Property(e => e.CarFlag)
                .HasPrecision(1, 0);

            modelBuilder.Entity<ArrivalStation>()
                .Property(e => e.ShipFlag)
                .HasPrecision(1, 0);

            modelBuilder.Entity<ArrivalStation>()
                .Property(e => e.TrainFlag)
                .HasPrecision(1, 0);

            modelBuilder.Entity<ArrivalStation>()
                .Property(e => e.RegionCod)
                .IsUnicode(false);

            modelBuilder.Entity<ArrivalStation>()
                .Property(e => e.UnitCod)
                .IsUnicode(false);

            modelBuilder.Entity<ArrivalStation>()
                .Property(e => e.StationCod)
                .IsUnicode(false);

            modelBuilder.Entity<ArrivalStation>()
                .Property(e => e.StationLabel)
                .IsUnicode(false);

            modelBuilder.Entity<ArrivalStation>()
                .Property(e => e.ArrivalStationTypeID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<ArrivalStation>()
                .Property(e => e.FootFlag)
                .HasPrecision(1, 0);

            modelBuilder.Entity<ArrivalStation>()
                .Property(e => e.ParentArrivalStationID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<ArrivalStation>()
                .Property(e => e.ArrivalStationClassID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<ArrivalStation>()
                .Property(e => e.DeleteFlag)
                .HasPrecision(1, 0);

            modelBuilder.Entity<ArrivalStationClass>()
                .Property(e => e.ArrivalStationClassID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<ArrivalStationClass>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<ArrivalStationClass>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<ArrivalStationType>()
                .Property(e => e.ArrivalStationTypeID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<ArrivalStationType>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<ArrivalStationType>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Bio_ChipSignCheck>()
                .Property(e => e.BorderCrossingID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<Bio_ChipSignCheck>()
                .Property(e => e.OperationID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<Bio_ChipSignCheck>()
                .Property(e => e.EFSODPresent)
                .HasPrecision(1, 0);

            modelBuilder.Entity<Bio_ChipSignCheck>()
                .Property(e => e.ECIHashEqual)
                .HasPrecision(1, 0);

            modelBuilder.Entity<Bio_ChipSignCheck>()
                .Property(e => e.SignedAttributeSignValid)
                .HasPrecision(1, 0);

            modelBuilder.Entity<Bio_ChipSignCheck>()
                .Property(e => e.DG1HashEqual)
                .HasPrecision(1, 0);

            modelBuilder.Entity<Bio_ChipSignCheck>()
                .Property(e => e.DG2HashEqual)
                .HasPrecision(1, 0);

            modelBuilder.Entity<Bio_ChipSignCheck>()
                .Property(e => e.DG3HashEqual)
                .HasPrecision(1, 0);

            modelBuilder.Entity<Bio_ChipSignCheck>()
                .Property(e => e.DG4HashEqual)
                .HasPrecision(1, 0);

            modelBuilder.Entity<Bio_ChipSignCheck>()
                .Property(e => e.DG5HashEqual)
                .HasPrecision(1, 0);

            modelBuilder.Entity<Bio_ChipSignCheck>()
                .Property(e => e.DG6HashEqual)
                .HasPrecision(1, 0);

            modelBuilder.Entity<Bio_ChipSignCheck>()
                .Property(e => e.DG7HashEqual)
                .HasPrecision(1, 0);

            modelBuilder.Entity<Bio_ChipSignCheck>()
                .Property(e => e.DG8HashEqual)
                .HasPrecision(1, 0);

            modelBuilder.Entity<Bio_ChipSignCheck>()
                .Property(e => e.DG9HashEqual)
                .HasPrecision(1, 0);

            modelBuilder.Entity<Bio_ChipSignCheck>()
                .Property(e => e.DG10HashEqual)
                .HasPrecision(1, 0);

            modelBuilder.Entity<Bio_ChipSignCheck>()
                .Property(e => e.DG11HashEqual)
                .HasPrecision(1, 0);

            modelBuilder.Entity<Bio_ChipSignCheck>()
                .Property(e => e.DG12HashEqual)
                .HasPrecision(1, 0);

            modelBuilder.Entity<Bio_ChipSignCheck>()
                .Property(e => e.DG13HashEqual)
                .HasPrecision(1, 0);

            modelBuilder.Entity<Bio_ChipSignCheck>()
                .Property(e => e.DG14HashEqual)
                .HasPrecision(1, 0);

            modelBuilder.Entity<Bio_ChipSignCheck>()
                .Property(e => e.DG15HashEqual)
                .HasPrecision(1, 0);

            modelBuilder.Entity<Bio_ChipSignCheck>()
                .Property(e => e.DG16HashEqual)
                .HasPrecision(1, 0);

            modelBuilder.Entity<Bio_ChipSignCheck>()
                .Property(e => e.PassportValid)
                .HasPrecision(1, 0);

            modelBuilder.Entity<Bio_ChipSignCheck>()
                .Property(e => e.ErrorMessage)
                .IsUnicode(false);

            modelBuilder.Entity<Bio_Data>()
                .Property(e => e.IdentifyDocumentID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<Bio_Data>()
                .Property(e => e.InscribeID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<Bio_Data>()
                .Property(e => e.DataTypeID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<Bio_Data>()
                .Property(e => e.DataFormatID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<Bio_Data>()
                .Property(e => e.TextData)
                .IsUnicode(false);

            modelBuilder.Entity<Bio_Data>()
                .Property(e => e.StringData)
                .IsUnicode(false);

            modelBuilder.Entity<Bio_Data>()
                .Property(e => e.NumberData)
                .HasPrecision(35, 0);

            modelBuilder.Entity<Bio_DataFormat>()
                .Property(e => e.DataTypeID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<Bio_DataFormat>()
                .Property(e => e.DataFormatID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<Bio_DataFormat>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Bio_DataFormat>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Bio_DataFormat>()
                .Property(e => e.DomainTypeID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<Bio_DataType>()
                .Property(e => e.DataTypeID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<Bio_DataType>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Bio_DataType>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<BorderCrossing>()
                .Property(e => e.BorderCrossingID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<BorderCrossing>()
                .Property(e => e.ArrivalStationID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<BorderCrossing>()
                .Property(e => e.CrossingLabelID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<BorderCrossing>()
                .Property(e => e.BorderRoutingID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<BorderCrossing>()
                .Property(e => e.FlightID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<BorderCrossing>()
                .Property(e => e.CrossingOperationID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<BorderCrossing>()
                .Property(e => e.PassengerTypeID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<BorderCrossing>()
                .Property(e => e.PurposeID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<BorderCrossing>()
                .Property(e => e.DecisionID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<BorderCrossing>()
                .Property(e => e.TicketNumber)
                .IsUnicode(false);

            modelBuilder.Entity<BorderCrossing>()
                .Property(e => e.CheckIN)
                .HasPrecision(1, 0);

            modelBuilder.Entity<BorderCrossing>()
                .Property(e => e.C_Post)
                .IsUnicode(false);

            modelBuilder.Entity<BorderCrossing>()
                .Property(e => e.AddedMakeID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<BorderCrossing>()
                .Property(e => e.InOutArrivalStationID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<BorderCrossing>()
                .Property(e => e.TouristOrgAccount)
                .IsUnicode(false);

            modelBuilder.Entity<BorderCrossing>()
                .Property(e => e.MigrationCardID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<BorderCrossing>()
                .Property(e => e.StayCountryID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<BorderCrossing>()
                .Property(e => e.StayRegionID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<BorderCrossing>()
                .Property(e => e.StayAddress)
                .IsUnicode(false);

            modelBuilder.Entity<BorderCrossing>()
                .Property(e => e.ProfessionID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<BorderCrossing>()
                .Property(e => e.InvitationOrganization)
                .IsUnicode(false);

            modelBuilder.Entity<BorderCrossing>()
                .Property(e => e.InvOrganizationAddress)
                .IsUnicode(false);

            modelBuilder.Entity<BorderRouting>()
                .Property(e => e.BorderRoutingID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<BorderRouting>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<BorderRouting>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<CarBorderCrossing>()
                .Property(e => e.ArrivalStationID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<CarBorderCrossing>()
                .Property(e => e.BorderRoutingID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<CarBorderCrossing>()
                .Property(e => e.CarrierTypeID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<CarBorderCrossing>()
                .Property(e => e.CarrierBCID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<CarBorderCrossing>()
                .Property(e => e.LadingTypeID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<CarBorderCrossing>()
                .Property(e => e.Route)
                .IsUnicode(false);

            modelBuilder.Entity<CarBorderCrossing>()
                .Property(e => e.TrailerRegisterNumber)
                .IsUnicode(false);

            modelBuilder.Entity<CarBorderCrossing>()
                .Property(e => e.Notes)
                .IsUnicode(false);

            modelBuilder.Entity<CarRegistration>()
                .Property(e => e.ArrivalStationID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<CarRegistration>()
                .Property(e => e.BorderRoutingID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<CarRegistration>()
                .Property(e => e.CarrierTypeID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<CarRegistration>()
                .Property(e => e.CarrierBCID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<CarRegistration>()
                .Property(e => e.CarrierRegistrationID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<Carrier>()
                .Property(e => e.CarrierTypeID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<Carrier>()
                .Property(e => e.CarrierID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<Carrier>()
                .Property(e => e.ColorID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<Carrier>()
                .Property(e => e.TransportCompanyID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<Carrier>()
                .Property(e => e.CountryID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<Carrier>()
                .Property(e => e.CityID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<Carrier>()
                .Property(e => e.RegisterNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Carrier>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Carrier>()
                .Property(e => e.FlagCountryID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<Carrier>()
                .Property(e => e.Tonnage)
                .HasPrecision(35, 0);

            modelBuilder.Entity<Carrier>()
                .Property(e => e.PhotoID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<CarrierDecision>()
                .Property(e => e.CarrierDecisionID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<CarrierDecision>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<CarrierDecision>()
                .Property(e => e.FinalFlag)
                .HasPrecision(1, 0);

            modelBuilder.Entity<CarrierDecision>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<CarrierDecisionFilter>()
                .Property(e => e.CarrierTypeID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<CarrierDecisionFilter>()
                .Property(e => e.RegistrationTypeID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<CarrierDecisionFilter>()
                .Property(e => e.CarrierDecisionID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<CarrierModel>()
                .Property(e => e.CarrierTypeID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<CarrierModel>()
                .Property(e => e.CarrierID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<CarrierModel>()
                .Property(e => e.ModelTypeID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<CarrierModel>()
                .Property(e => e.ModelCategoryID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<CarrierPark>()
                .Property(e => e.ArrivalStationID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<CarrierPark>()
                .Property(e => e.CarrierParkID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<CarrierPark>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<CarrierPark>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<CarrierPark>()
                .Property(e => e.DeleteFlag)
                .HasPrecision(1, 0);

            modelBuilder.Entity<CarrierPark>()
                .Property(e => e.ReadOnly)
                .HasPrecision(1, 0);

            modelBuilder.Entity<CarrierRegistration>()
                .Property(e => e.ArrivalStationID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<CarrierRegistration>()
                .Property(e => e.BorderRoutingID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<CarrierRegistration>()
                .Property(e => e.CarrierTypeID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<CarrierRegistration>()
                .Property(e => e.CarrierBCID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<CarrierRegistration>()
                .Property(e => e.CarrierRegistrationID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<CarrierRegistration>()
                .Property(e => e.RegistrationTypeID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<CarrierRegistration>()
                .Property(e => e.CarrierDecisionID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<CarrierRegistration>()
                .Property(e => e.UserInfoID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<CarrierRegistration>()
                .Property(e => e.ARMID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<CarrierRegistration>()
                .Property(e => e.ComputerName)
                .IsUnicode(false);

            modelBuilder.Entity<CarrierType>()
                .Property(e => e.CarrierTypeID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<CarrierType>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<CarrierType>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<CBorderCrossing>()
                .Property(e => e.ArrivalStationID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<CBorderCrossing>()
                .Property(e => e.BorderRoutingID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<CBorderCrossing>()
                .Property(e => e.CarrierTypeID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<CBorderCrossing>()
                .Property(e => e.CarrierBCID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<CBorderCrossing>()
                .Property(e => e.FlightID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<CBorderCrossing>()
                .Property(e => e.CarrierID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<CBorderCrossing>()
                .Property(e => e.CBorderCrossingTypeID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<CBorderCrossing>()
                .Property(e => e.BoundBorderRoutingID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<CBorderCrossing>()
                .Property(e => e.BoundCarrierBCID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<CBorderCrossing>()
                .Property(e => e.CarrierDecisionID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<CBorderCrossing>()
                .Property(e => e.TransportCompanyID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<CBorderCrossing>()
                .Property(e => e.CheckIN)
                .HasPrecision(1, 0);

            modelBuilder.Entity<CBorderCrossingType>()
                .Property(e => e.CBorderCrossingTypeID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<CBorderCrossingType>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<CBorderCrossingType>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<City>()
                .Property(e => e.CountryID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<City>()
                .Property(e => e.CityID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<City>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<City>()
                .Property(e => e.DeleteFlag)
                .HasPrecision(1, 0);

            modelBuilder.Entity<City>()
                .Property(e => e.ReadOnly)
                .HasPrecision(1, 0);

            modelBuilder.Entity<CityAttribute>()
                .Property(e => e.CountryID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<CityAttribute>()
                .Property(e => e.CityID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<CityAttribute>()
                .Property(e => e.CityAttributeTypeID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<CityAttribute>()
                .Property(e => e.CityAttributeID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<CityAttribute>()
                .Property(e => e.AirportCod)
                .IsUnicode(false);

            modelBuilder.Entity<CityAttribute>()
                .Property(e => e.ICAOCod)
                .IsUnicode(false);

            modelBuilder.Entity<CityAttributeType>()
                .Property(e => e.CityAttributeTypeID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<CityAttributeType>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<CityAttributeType>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Color>()
                .Property(e => e.ColorID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<Color>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Color>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Color>()
                .Property(e => e.DeleteFlag)
                .HasPrecision(1, 0);

            modelBuilder.Entity<Color>()
                .Property(e => e.ReadOnly)
                .HasPrecision(1, 0);

            modelBuilder.Entity<Committee>()
                .Property(e => e.CommitteeTypeID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<Committee>()
                .Property(e => e.CommitteeID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<CommitteeMan>()
                .Property(e => e.CommitteeTypeID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<CommitteeMan>()
                .Property(e => e.CommitteeID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<CommitteeMan>()
                .Property(e => e.CommitteeManID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<CommitteeMan>()
                .Property(e => e.CommitteeStatusID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<CommitteeMan>()
                .Property(e => e.XUserTypeID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<CommitteeMan>()
                .Property(e => e.XUserListID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<CommitteeMan>()
                .Property(e => e.UserInfoID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<CommitteeStatus>()
                .Property(e => e.CommitteeTypeID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<CommitteeStatus>()
                .Property(e => e.CommitteeStatusID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<CommitteeStatus>()
                .Property(e => e.UserInfoFlag)
                .HasPrecision(1, 0);

            modelBuilder.Entity<CommitteeStatus>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<CommitteeStatus>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<CommitteeType>()
                .Property(e => e.CommitteeTypeID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<CommitteeType>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<CommitteeType>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Country>()
                .Property(e => e.CountryID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<Country>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Country>()
                .Property(e => e.ICAOCod)
                .IsUnicode(false);

            modelBuilder.Entity<Country>()
                .Property(e => e.EmigrantFlag)
                .HasPrecision(1, 0);

            modelBuilder.Entity<Country>()
                .Property(e => e.DeleteFlag)
                .HasPrecision(1, 0);

            modelBuilder.Entity<Country>()
                .Property(e => e.ShortName)
                .IsUnicode(false);

            modelBuilder.Entity<Country>()
                .Property(e => e.ReadOnly)
                .HasPrecision(1, 0);

            modelBuilder.Entity<Country>()
                .Property(e => e.MigrationCardFlag)
                .HasPrecision(1, 0);

            modelBuilder.Entity<CountryAttribute>()
                .Property(e => e.CountryID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<CountryAttribute>()
                .Property(e => e.DocumentCategoryID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<CountryAttribute>()
                .Property(e => e.CountryAttributeTypeID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<CountryAttribute>()
                .Property(e => e.DocumentICAOCod)
                .IsUnicode(false);

            modelBuilder.Entity<CountryAttribute>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<CountryAttribute>()
                .Property(e => e.DocumentNumberMask)
                .IsUnicode(false);

            modelBuilder.Entity<CountryAttribute>()
                .Property(e => e.ValidityAge)
                .IsUnicode(false);

            modelBuilder.Entity<CountryAttributeType>()
                .Property(e => e.CountryAttributeTypeID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<CountryAttributeType>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<CountryAttributeType>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<CountryGroup>()
                .Property(e => e.CountryGroupID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<CountryGroup>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<CountryGroup>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<CountryGroup>()
                .Property(e => e.ParentCountryGroupID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<CountryLanguage>()
                .Property(e => e.CountryID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<CountryLanguage>()
                .Property(e => e.LanguageID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<CountryToCountryGroup>()
                .Property(e => e.CountryGroupID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<CountryToCountryGroup>()
                .Property(e => e.CountryID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<CountryToCountryGroup>()
                .Property(e => e.ReadOnly)
                .HasPrecision(1, 0);

            modelBuilder.Entity<Crew>()
                .Property(e => e.BorderCrossingID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<Crew>()
                .Property(e => e.CarrierTypeID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<Crew>()
                .Property(e => e.CrewTypeID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<CrewType>()
                .Property(e => e.CarrierTypeID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<CrewType>()
                .Property(e => e.CrewTypeID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<CrewType>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<CrewType>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<CrewType>()
                .Property(e => e.DeleteFlag)
                .HasPrecision(1, 0);

            modelBuilder.Entity<CrewType>()
                .Property(e => e.ReadOnly)
                .HasPrecision(1, 0);

            modelBuilder.Entity<CrossingLabel>()
                .Property(e => e.CrossingLabelID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<CrossingLabel>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<CrossingLabel>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<CrossingLabel>()
                .Property(e => e.DeleteFlag)
                .HasPrecision(1, 0);

            modelBuilder.Entity<CrossingLabel>()
                .Property(e => e.TaskFlag)
                .HasPrecision(1, 0);

            modelBuilder.Entity<CrossingLabel>()
                .Property(e => e.ReadOnly)
                .HasPrecision(1, 0);

            modelBuilder.Entity<CrossingLabel>()
                .Property(e => e.InFlag)
                .HasPrecision(1, 0);

            modelBuilder.Entity<CrossingLabel>()
                .Property(e => e.OutFlag)
                .HasPrecision(1, 0);

            modelBuilder.Entity<Decision>()
                .Property(e => e.DecisionID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<Decision>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Decision>()
                .Property(e => e.FinalFlag)
                .HasPrecision(1, 0);

            modelBuilder.Entity<Decision>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Deportation>()
                .Property(e => e.BorderCrossingID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<Deportation>()
                .Property(e => e.OperationID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<Deportation>()
                .Property(e => e.ReportedID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<Deportation>()
                .Property(e => e.DeportationStationID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<Deportation>()
                .Property(e => e.DeportationFlight)
                .IsUnicode(false);

            modelBuilder.Entity<Deportation>()
                .Property(e => e.RealDeportationFlag)
                .HasPrecision(1, 0);

            modelBuilder.Entity<Deportation>()
                .Property(e => e.RealDeportationStationID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<Deportation>()
                .Property(e => e.RealDeportationFlight)
                .IsUnicode(false);

            modelBuilder.Entity<Deportation>()
                .Property(e => e.Notes)
                .IsUnicode(false);

            modelBuilder.Entity<DepthControl>()
                .Property(e => e.BorderCrossingID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<DepthControl>()
                .Property(e => e.OperationID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<DepthControl>()
                .Property(e => e.DecisionID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<DepthControl>()
                .Property(e => e.FaultTypeID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<DepthControl>()
                .Property(e => e.ReportedID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<DepthControl>()
                .Property(e => e.Reason)
                .IsUnicode(false);

            modelBuilder.Entity<DepthControl>()
                .Property(e => e.DecisionMakingUserID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<DepthControl>()
                .Property(e => e.Notes)
                .IsUnicode(false);

            modelBuilder.Entity<DepthControl>()
                .Property(e => e.BookRecordNumber)
                .IsUnicode(false);

            modelBuilder.Entity<DepthControl>()
                .Property(e => e.CommitteeTypeID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<DepthControl>()
                .Property(e => e.CommitteeID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<DepthControl>()
                .Property(e => e.FaultAdditional)
                .IsUnicode(false);

            modelBuilder.Entity<Deregistration>()
                .Property(e => e.BorderCrossingID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<Deregistration>()
                .Property(e => e.OperationID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<Deregistration>()
                .Property(e => e.DeregistrationReasonID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<Deregistration>()
                .Property(e => e.Notes)
                .IsUnicode(false);

            modelBuilder.Entity<DeregistrationReason>()
                .Property(e => e.DeregistrationReasonID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<DeregistrationReason>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<DeregistrationReason>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<DeregistrationReason>()
                .Property(e => e.DeleteFlag)
                .HasPrecision(1, 0);

            modelBuilder.Entity<DeregistrationReason>()
                .Property(e => e.ReadOnly)
                .HasPrecision(1, 0);

            modelBuilder.Entity<DocumentCategory>()
                .Property(e => e.DocumentCategoryID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<DocumentCategory>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<DocumentCategory>()
                .Property(e => e.ICAOCod)
                .IsUnicode(false);

            modelBuilder.Entity<DocumentCategory>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<DocumentCategory>()
                .Property(e => e.DeleteFlag)
                .HasPrecision(1, 0);

            modelBuilder.Entity<DocumentCategory>()
                .Property(e => e.ReadOnly)
                .HasPrecision(1, 0);

            modelBuilder.Entity<DocumentFault>()
                .Property(e => e.BorderCrossingID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<DocumentFault>()
                .Property(e => e.OperationID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<DocumentFault>()
                .Property(e => e.DocumentFaultID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<DocumentFault>()
                .Property(e => e.FaultTypeID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<DocumentFault>()
                .Property(e => e.ForgedDetectionTypeID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<DocumentFault>()
                .Property(e => e.RevealUserID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<DocumentFault>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<DocumentFault>()
                .Property(e => e.StampArrivalStationID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<DocumentFault>()
                .Property(e => e.StampNumber)
                .IsUnicode(false);

            modelBuilder.Entity<DocumentStatus>()
                .Property(e => e.DocumentStatusID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<DocumentStatus>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<DocumentStatus>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<DomainType>()
                .Property(e => e.DomainTypeID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<DomainType>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<DomainType>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<FaultType>()
                .Property(e => e.FaultTypeID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<FaultType>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<FaultType>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<FaultType>()
                .Property(e => e.ParentFaultTypeID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<Filtration>()
                .Property(e => e.BorderCrossingID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<Filtration>()
                .Property(e => e.OperationID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<Filtration>()
                .Property(e => e.Notes)
                .IsUnicode(false);

            modelBuilder.Entity<Filtration>()
                .Property(e => e.DecisionID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<Filtration>()
                .Property(e => e.CommitteeTypeID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<Filtration>()
                .Property(e => e.CommitteeID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<Filtration>()
                .Property(e => e.AdditionalDocumentData)
                .IsUnicode(false);

            modelBuilder.Entity<Filtration>()
                .Property(e => e.FlightOut)
                .IsUnicode(false);

            modelBuilder.Entity<Filtration>()
                .Property(e => e.RouteOut)
                .IsUnicode(false);

            modelBuilder.Entity<FirstAidPost>()
                .Property(e => e.BorderCrossingID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<FirstAidPost>()
                .Property(e => e.FirstAidPostTypeID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<FirstAidPostType>()
                .Property(e => e.FirstAidPostTypeID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<FirstAidPostType>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<FirstAidPostType>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<FirstAidPostType>()
                .Property(e => e.DeleteFlag)
                .HasPrecision(1, 0);

            modelBuilder.Entity<FirstAidPostType>()
                .Property(e => e.ReadOnly)
                .HasPrecision(1, 0);

            modelBuilder.Entity<Flight>()
                .Property(e => e.ArrivalStationID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<Flight>()
                .Property(e => e.BorderRoutingID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<Flight>()
                .Property(e => e.FlightID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<Flight>()
                .Property(e => e.FlightTypeID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<Flight>()
                .Property(e => e.CarrierTypeID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<Flight>()
                .Property(e => e.CarrierBCID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<Flight>()
                .Property(e => e.CarrierParkID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<Flight>()
                .Property(e => e.TransportCompanyID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<Flight>()
                .Property(e => e.FlightNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Flight>()
                .Property(e => e.FlightModeID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<FlightMode>()
                .Property(e => e.FlightModeID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<FlightMode>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<FlightMode>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<FlightType>()
                .Property(e => e.FlightTypeID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<FlightType>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<FlightType>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<FMS_CardOperation>()
                .Property(e => e.MigrationCardID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<FMS_CardOperation>()
                .Property(e => e.CardOperationID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<FMS_CardOperation>()
                .Property(e => e.CardOperationTypeID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<FMS_CardOperation>()
                .Property(e => e.ComputerName)
                .IsUnicode(false);

            modelBuilder.Entity<FMS_CardOperation>()
                .Property(e => e.ARMID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<FMS_CardOperation>()
                .Property(e => e.UserInfoID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<FMS_CardOperationType>()
                .Property(e => e.CardOperationTypeID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<FMS_CardOperationType>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<FMS_CardOperationType>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<FMS_MigrationCard>()
                .Property(e => e.MigrationCardID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<FMS_MigrationCard>()
                .Property(e => e.Cod)
                .IsUnicode(false);

            modelBuilder.Entity<FMS_MigrationCard>()
                .Property(e => e.Number)
                .IsUnicode(false);

            modelBuilder.Entity<FMS_MigrationCard>()
                .Property(e => e.Family)
                .IsUnicode(false);

            modelBuilder.Entity<FMS_MigrationCard>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<FMS_MigrationCard>()
                .Property(e => e.Patronymic)
                .IsUnicode(false);

            modelBuilder.Entity<FMS_MigrationCard>()
                .Property(e => e.FamilyLatin)
                .IsUnicode(false);

            modelBuilder.Entity<FMS_MigrationCard>()
                .Property(e => e.NameLatin)
                .IsUnicode(false);

            modelBuilder.Entity<FMS_MigrationCard>()
                .Property(e => e.PatronymicLatin)
                .IsUnicode(false);

            modelBuilder.Entity<FMS_MigrationCard>()
                .Property(e => e.Sex)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<FMS_MigrationCard>()
                .Property(e => e.DocumentCod)
                .IsUnicode(false);

            modelBuilder.Entity<FMS_MigrationCard>()
                .Property(e => e.DocumentNumber)
                .IsUnicode(false);

            modelBuilder.Entity<FMS_MigrationCard>()
                .Property(e => e.NationalityID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<FMS_MigrationCard>()
                .Property(e => e.MigrationPurposeID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<FMS_MigrationCard>()
                .Property(e => e.VisaCod)
                .IsUnicode(false);

            modelBuilder.Entity<FMS_MigrationCard>()
                .Property(e => e.VisaNumber)
                .IsUnicode(false);

            modelBuilder.Entity<FMS_MigrationCard>()
                .Property(e => e.InvitationOrganizationCountryID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<FMS_MigrationCard>()
                .Property(e => e.InvitationOrganizationAddress)
                .IsUnicode(false);

            modelBuilder.Entity<FMS_MigrationCard>()
                .Property(e => e.InvitationOrganization)
                .IsUnicode(false);

            modelBuilder.Entity<FMS_MigrationCard>()
                .Property(e => e.InvitationNumber)
                .IsUnicode(false);

            modelBuilder.Entity<FMS_MigrationCard>()
                .Property(e => e.StayCountryID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<FMS_MigrationCard>()
                .Property(e => e.StayAddress)
                .IsUnicode(false);

            modelBuilder.Entity<FMS_MigrationCard>()
                .Property(e => e.FBirthdate)
                .HasPrecision(1, 0);

            modelBuilder.Entity<FMS_MigrationCard>()
                .Property(e => e.StayRegionID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<FMS_MigrationPurpose>()
                .Property(e => e.MigrationPurposeID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<FMS_MigrationPurpose>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<FMS_MigrationPurpose>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<FMS_StayCountry>()
                .Property(e => e.CountryID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<ForgedDetectionType>()
                .Property(e => e.ForgedDetectionTypeID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<ForgedDetectionType>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<ForgedDetectionType>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<ForgedDetectionType>()
                .Property(e => e.DeleteFlag)
                .HasPrecision(1, 0);

            modelBuilder.Entity<ForgedDetectionType>()
                .Property(e => e.ReadOnly)
                .HasPrecision(1, 0);

            modelBuilder.Entity<Host>()
                .Property(e => e.BorderCrossingID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<Host>()
                .Property(e => e.HostID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<Host>()
                .Property(e => e.Family)
                .IsUnicode(false);

            modelBuilder.Entity<Host>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Host>()
                .Property(e => e.DocumentCod)
                .IsUnicode(false);

            modelBuilder.Entity<Host>()
                .Property(e => e.DocumentNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Host>()
                .Property(e => e.DocumentIssueOrganization)
                .IsUnicode(false);

            modelBuilder.Entity<HostImage>()
                .Property(e => e.HostID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<HostImage>()
                .Property(e => e.BorderCrossingID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<HostImage>()
                .Property(e => e.HostImageID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<HostImage>()
                .Property(e => e.Notes)
                .IsUnicode(false);

            modelBuilder.Entity<HostImage>()
                .Property(e => e.ImageObjectID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<Hotel>()
                .Property(e => e.HotelID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<Hotel>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Hotel>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<Hotel>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<Hotel>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Hotel>()
                .Property(e => e.DeleteFlag)
                .HasPrecision(1, 0);

            modelBuilder.Entity<Hotel>()
                .Property(e => e.ReadOnly)
                .HasPrecision(1, 0);

            modelBuilder.Entity<I_EGISOTB_AviaPlanPassenger>()
                .Property(e => e.RowVers)
                .IsFixedLength();

            modelBuilder.Entity<I_EGISOTB_AviaPlanPassenger>()
                .Property(e => e.DomainKey)
                .IsFixedLength();

            modelBuilder.Entity<I_EGISOTB_AviaPlanPassenger>()
                .Property(e => e.Hash)
                .IsFixedLength();

            modelBuilder.Entity<I_FOREPOST2_FACT>()
                .Property(e => e.Key)
                .IsFixedLength();

            modelBuilder.Entity<I_FOREPOST2_FACT>()
                .Property(e => e.DomainKey)
                .IsFixedLength();

            modelBuilder.Entity<I_FOREPOST2_FACT>()
                .Property(e => e.Hash)
                .IsFixedLength();

            modelBuilder.Entity<IdentifyDocument>()
                .Property(e => e.IdentifyDocumentID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<IdentifyDocument>()
                .Property(e => e.DocumentCategoryID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<IdentifyDocument>()
                .Property(e => e.CountryID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<IdentifyDocument>()
                .Property(e => e.RegisterCod)
                .IsUnicode(false);

            modelBuilder.Entity<IdentifyDocument>()
                .Property(e => e.RegisterNumber)
                .IsUnicode(false);

            modelBuilder.Entity<IdentifyDocument>()
                .Property(e => e.IssueOrganization)
                .IsUnicode(false);

            modelBuilder.Entity<IdentifyDocument>()
                .Property(e => e.DocumentStatusID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<IdentifyDocument>()
                .Property(e => e.BlankNumber)
                .IsUnicode(false);

            modelBuilder.Entity<IdentifyDocument>()
                .Property(e => e.NumericRegisterNumber)
                .HasPrecision(18, 0);

            modelBuilder.Entity<IdentifyDocument>()
                .Property(e => e.StateInstituteID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<IdentifyDocumentEdit>()
                .Property(e => e.BorderCrossingID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<IdentifyDocumentEdit>()
                .Property(e => e.OperationID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<ImageObject>()
                .Property(e => e.ImageObjectID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<Inscribe>()
                .Property(e => e.IdentifyDocumentID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<Inscribe>()
                .Property(e => e.InscribeID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<Inscribe>()
                .Property(e => e.NationalityID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<Inscribe>()
                .Property(e => e.Family)
                .IsUnicode(false);

            modelBuilder.Entity<Inscribe>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Inscribe>()
                .Property(e => e.FamilyLatin)
                .IsUnicode(false);

            modelBuilder.Entity<Inscribe>()
                .Property(e => e.NameLatin)
                .IsUnicode(false);

            modelBuilder.Entity<Inscribe>()
                .Property(e => e.FBirthday)
                .HasPrecision(1, 0);

            modelBuilder.Entity<Inscribe>()
                .Property(e => e.Sex)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Inscribe>()
                .Property(e => e.PermanentResidenceID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<Inscribe>()
                .Property(e => e.PersonStatusID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<Inscribe>()
                .Property(e => e.PhotoID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<InscribeLanguage>()
                .Property(e => e.IdentifyDocumentID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<InscribeLanguage>()
                .Property(e => e.InscribeID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<InscribeLanguage>()
                .Property(e => e.SpokenLanguageID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<InvOrganization>()
                .Property(e => e.InvOrganizationID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<InvOrganization>()
                .Property(e => e.AdditionalJobID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<InvOrganization>()
                .Property(e => e.OrgStatusID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<InvOrganization>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<InvOrganization>()
                .Property(e => e.RegistrationNumber)
                .IsUnicode(false);

            modelBuilder.Entity<InvOrganization>()
                .Property(e => e.RegistrationOrg)
                .IsUnicode(false);

            modelBuilder.Entity<InvOrganization>()
                .Property(e => e.Zip)
                .IsUnicode(false);

            modelBuilder.Entity<InvOrganization>()
                .Property(e => e.Region)
                .IsUnicode(false);

            modelBuilder.Entity<InvOrganization>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<InvOrganization>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<InvOrganization>()
                .Property(e => e.Fax)
                .IsUnicode(false);

            modelBuilder.Entity<InvOrganization>()
                .Property(e => e.FIO)
                .IsUnicode(false);

            modelBuilder.Entity<InvOrganization>()
                .Property(e => e.LeaderPost)
                .IsUnicode(false);

            modelBuilder.Entity<InvOrganization>()
                .Property(e => e.Executor)
                .IsUnicode(false);

            modelBuilder.Entity<InvOrganization>()
                .Property(e => e.FIO2)
                .IsUnicode(false);

            modelBuilder.Entity<InvOrganization>()
                .Property(e => e.PostAddress)
                .IsUnicode(false);

            modelBuilder.Entity<InvOrganization>()
                .Property(e => e.GNI)
                .IsUnicode(false);

            modelBuilder.Entity<InvOrganization>()
                .Property(e => e.JobFlag)
                .HasPrecision(1, 0);

            modelBuilder.Entity<InvOrganization>()
                .Property(e => e.Notes)
                .IsUnicode(false);

            modelBuilder.Entity<InvOrganizationCountry>()
                .Property(e => e.InvOrganizationID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<InvOrganizationCountry>()
                .Property(e => e.CountryID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<LadingType>()
                .Property(e => e.LadingTypeID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<LadingType>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<LadingType>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<LadingType>()
                .Property(e => e.DeleteFlag)
                .HasPrecision(1, 0);

            modelBuilder.Entity<LadingType>()
                .Property(e => e.ReadOnly)
                .HasPrecision(1, 0);

            modelBuilder.Entity<Language>()
                .Property(e => e.LanguageID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<Language>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Language>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Language>()
                .Property(e => e.TranscriptionAlgorithmID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<Language>()
                .Property(e => e.LanguageCod)
                .IsUnicode(false);

            modelBuilder.Entity<ModelCategory>()
                .Property(e => e.CarrierTypeID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<ModelCategory>()
                .Property(e => e.ModelTypeID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<ModelCategory>()
                .Property(e => e.ModelCategoryID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<ModelCategory>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<ModelCategory>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<ModelCategory>()
                .Property(e => e.DeleteFlag)
                .HasPrecision(1, 0);

            modelBuilder.Entity<ModelCategory>()
                .Property(e => e.ParentModelCategoryID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<ModelCategory>()
                .Property(e => e.ReadOnly)
                .HasPrecision(1, 0);

            modelBuilder.Entity<ModelType>()
                .Property(e => e.CarrierTypeID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<ModelType>()
                .Property(e => e.ModelTypeID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<ModelType>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<ModelType>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<observer_Picture>()
                .Property(e => e.BorderCrossingID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<observer_Picture>()
                .Property(e => e.OperationID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<observer_Picture>()
                .Property(e => e.PictureID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<OnLineCheck>()
                .Property(e => e.BorderCrossingID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<OnLineCheck>()
                .Property(e => e.OperationID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<OnLineCheck>()
                .Property(e => e.OnLineCheckID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<OnLineCheck>()
                .Property(e => e.Family)
                .IsUnicode(false);

            modelBuilder.Entity<OnLineCheck>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Operation>()
                .Property(e => e.BorderCrossingID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<Operation>()
                .Property(e => e.OperationID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<Operation>()
                .Property(e => e.OperationTypeID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<Operation>()
                .Property(e => e.UserInfoID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<Operation>()
                .Property(e => e.ARMID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<Operation>()
                .Property(e => e.ComputerName)
                .IsUnicode(false);

            modelBuilder.Entity<Operation>()
                .Property(e => e.CheckIN)
                .HasPrecision(1, 0);

            modelBuilder.Entity<Operation>()
                .Property(e => e.SubdivisionID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<Operation>()
                .Property(e => e.StampNumber)
                .IsUnicode(false);

            modelBuilder.Entity<OperationType>()
                .Property(e => e.OperationTypeID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<OperationType>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<OperationType>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<OrgStatus>()
                .Property(e => e.OrgStatusID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<OrgStatus>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<OrgStatus>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<OrgStatus>()
                .Property(e => e.DeleteFlag)
                .HasPrecision(1, 0);

            modelBuilder.Entity<OrgStatus>()
                .Property(e => e.ReadOnly)
                .HasPrecision(1, 0);

            modelBuilder.Entity<OU_List>()
                .Property(e => e.FIO)
                .IsUnicode(false);

            modelBuilder.Entity<OU_List>()
                .Property(e => e.BirthDate)
                .IsUnicode(false);

            modelBuilder.Entity<OU_List>()
                .Property(e => e.Country)
                .IsUnicode(false);

            modelBuilder.Entity<OU_List>()
                .Property(e => e.Sex)
                .IsUnicode(false);

            modelBuilder.Entity<OU_List>()
                .Property(e => e.Job)
                .IsUnicode(false);

            modelBuilder.Entity<OU_List>()
                .Property(e => e.Note)
                .IsUnicode(false);

            modelBuilder.Entity<OU_List>()
                .Property(e => e.Oper)
                .HasPrecision(35, 0);

            modelBuilder.Entity<OU_List>()
                .Property(e => e.Comment)
                .IsUnicode(false);

            modelBuilder.Entity<OU_List>()
                .Property(e => e.Ndb)
                .HasPrecision(35, 0);

            modelBuilder.Entity<OU_List>()
                .Property(e => e.HashKey)
                .IsFixedLength();

            modelBuilder.Entity<PassengerType>()
                .Property(e => e.PassengerTypeID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<PassengerType>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<PassengerType>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<PassengerTypeChange>()
                .Property(e => e.BorderCrossingID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<PassengerTypeChange>()
                .Property(e => e.OperationID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<PassengerTypeChange>()
                .Property(e => e.SourcePassengerTypeID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<PassengerTypeChange>()
                .Property(e => e.DestinationPassengerTypeID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<PassengerTypeChange>()
                .Property(e => e.Reason)
                .IsUnicode(false);

            modelBuilder.Entity<Patient>()
                .Property(e => e.BorderCrossingID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<Patient>()
                .Property(e => e.PatientFlag)
                .HasPrecision(1, 0);

            modelBuilder.Entity<Patient>()
                .Property(e => e.DespatchedPurpose)
                .IsUnicode(false);

            modelBuilder.Entity<Patient>()
                .Property(e => e.Hospital)
                .IsUnicode(false);

            modelBuilder.Entity<Patient>()
                .Property(e => e.HospitalDivision)
                .IsUnicode(false);

            modelBuilder.Entity<Patient>()
                .Property(e => e.HospitalPhone)
                .IsUnicode(false);

            modelBuilder.Entity<Patient>()
                .Property(e => e.CardNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Patient>()
                .Property(e => e.TransferHospital)
                .IsUnicode(false);

            modelBuilder.Entity<Patient>()
                .Property(e => e.TransferDivision)
                .IsUnicode(false);

            modelBuilder.Entity<Patient>()
                .Property(e => e.TransferHospitalPhone)
                .IsUnicode(false);

            modelBuilder.Entity<PersonStatus>()
                .Property(e => e.PersonStatusID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<PersonStatus>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<PersonStatus>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Photo>()
                .Property(e => e.BorderCrossingID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<Photo>()
                .Property(e => e.OperationID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<Photo>()
                .Property(e => e.PhotoID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<Photo>()
                .Property(e => e.ImageObjectID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<Photo>()
                .Property(e => e.Notes)
                .IsUnicode(false);

            modelBuilder.Entity<Position>()
                .Property(e => e.PositionID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<Position>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Position>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Position>()
                .Property(e => e.DeleteFlag)
                .HasPrecision(1, 0);

            modelBuilder.Entity<Position>()
                .Property(e => e.ReadOnly)
                .HasPrecision(1, 0);

            modelBuilder.Entity<Preaudit>()
                .Property(e => e.BorderCrossingID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<Preaudit>()
                .Property(e => e.OperationID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<Preaudit>()
                .Property(e => e.DecisionID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<Preaudit>()
                .Property(e => e.SuspectFaultTypeID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<Preaudit>()
                .Property(e => e.SuspectFaultNotes)
                .IsUnicode(false);

            modelBuilder.Entity<PresentDocument>()
                .Property(e => e.BorderCrossingID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<PresentDocument>()
                .Property(e => e.IdentifyDocumentID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<PresentDocument>()
                .Property(e => e.InscribeID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<PresentDocument>()
                .Property(e => e.VisaID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<PresentDocument>()
                .Property(e => e.VisaInscribeID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<Profession>()
                .Property(e => e.ProfessionID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<Profession>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Profession>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Profession>()
                .Property(e => e.DeleteFlag)
                .HasPrecision(1, 0);

            modelBuilder.Entity<Profession>()
                .Property(e => e.ReadOnly)
                .HasPrecision(1, 0);

            modelBuilder.Entity<Purpose>()
                .Property(e => e.PurposeID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<Purpose>()
                .Property(e => e.PurposeGroupID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<Purpose>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Purpose>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Purpose>()
                .Property(e => e.MigrationPurposeID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<PurposeGroup>()
                .Property(e => e.PurposeGroupID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<PurposeGroup>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<PurposeGroup>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Rank>()
                .Property(e => e.RankID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<Rank>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Rank>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Rank>()
                .Property(e => e.DeleteFlag)
                .HasPrecision(1, 0);

            modelBuilder.Entity<Rank>()
                .Property(e => e.ReadOnly)
                .HasPrecision(1, 0);

            modelBuilder.Entity<RCarrierPassenger>()
                .Property(e => e.RCarrierPassengerTypeID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<RCarrierPassenger>()
                .Property(e => e.BorderCrossingID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<RCarrierPassenger>()
                .Property(e => e.ArrivalStationID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<RCarrierPassenger>()
                .Property(e => e.BorderRoutingID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<RCarrierPassenger>()
                .Property(e => e.CarrierTypeID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<RCarrierPassenger>()
                .Property(e => e.CarrierBCID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<RCarrierPassengerType>()
                .Property(e => e.RCarrierPassengerTypeID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<RCarrierPassengerType>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<RCarrierPassengerType>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Region>()
                .Property(e => e.CountryID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<Region>()
                .Property(e => e.RegionID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<Region>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Region>()
                .Property(e => e.FMSCod)
                .IsUnicode(false);

            modelBuilder.Entity<Region>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Region>()
                .Property(e => e.DeleteFlag)
                .HasPrecision(1, 0);

            modelBuilder.Entity<Region>()
                .Property(e => e.ReadOnly)
                .HasPrecision(1, 0);

            modelBuilder.Entity<RegistrationType>()
                .Property(e => e.CarrierTypeID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<RegistrationType>()
                .Property(e => e.RegistrationTypeID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<RegistrationType>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<RegistrationType>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Sanction>()
                .Property(e => e.BorderCrossingID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<Sanction>()
                .Property(e => e.OperationID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<Sanction>()
                .Property(e => e.SourceOperationID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<Sanction>()
                .Property(e => e.SanctionTypeID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<Sanction>()
                .Property(e => e.Amount)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Sanction>()
                .Property(e => e.ReportedID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<Sanction>()
                .Property(e => e.Notes)
                .IsUnicode(false);

            modelBuilder.Entity<Sanction>()
                .Property(e => e.Reason)
                .IsUnicode(false);

            modelBuilder.Entity<Sanction>()
                .Property(e => e.Facts)
                .IsUnicode(false);

            modelBuilder.Entity<Sanction>()
                .Property(e => e.WhichSend)
                .IsUnicode(false);

            modelBuilder.Entity<Sanction>()
                .Property(e => e.SendDocumentNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Sanction>()
                .Property(e => e.SanctionInitiatorID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<SanctionInitiator>()
                .Property(e => e.SanctionInitiatorID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<SanctionInitiator>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<SanctionInitiator>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<SanctionType>()
                .Property(e => e.SanctionTypeID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<SanctionType>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<SanctionType>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Settlement>()
                .Property(e => e.CountryID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<Settlement>()
                .Property(e => e.RegionID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<Settlement>()
                .Property(e => e.SettlementID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<Settlement>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Settlement>()
                .Property(e => e.DeleteFlag)
                .HasPrecision(1, 0);

            modelBuilder.Entity<Settlement>()
                .Property(e => e.ReadOnly)
                .HasPrecision(1, 0);

            modelBuilder.Entity<ShipBorderCrossing>()
                .Property(e => e.ArrivalStationID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<ShipBorderCrossing>()
                .Property(e => e.BorderRoutingID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<ShipBorderCrossing>()
                .Property(e => e.CarrierTypeID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<ShipBorderCrossing>()
                .Property(e => e.CarrierBCID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<ShipBorderCrossing>()
                .Property(e => e.LadingTypeID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<ShipBorderCrossing>()
                .Property(e => e.Captain)
                .IsUnicode(false);

            modelBuilder.Entity<ShipBorderCrossing>()
                .Property(e => e.Pilot)
                .IsUnicode(false);

            modelBuilder.Entity<ShipBorderCrossing>()
                .Property(e => e.Notes)
                .IsUnicode(false);

            modelBuilder.Entity<ShipBorderCrossing>()
                .Property(e => e.Visitor)
                .IsUnicode(false);

            modelBuilder.Entity<ShipBorderCrossing>()
                .Property(e => e.CommitteeTypeID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<ShipBorderCrossing>()
                .Property(e => e.CommitteeID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<ShipBorderCrossing>()
                .Property(e => e.CrewInspection)
                .IsUnicode(false);

            modelBuilder.Entity<ShipBorderCrossing>()
                .Property(e => e.FrontierInspection)
                .IsUnicode(false);

            modelBuilder.Entity<ShipBorderCrossing>()
                .Property(e => e.RequestClaim)
                .IsUnicode(false);

            modelBuilder.Entity<ShipBorderCrossing>()
                .Property(e => e.PassCod)
                .IsUnicode(false);

            modelBuilder.Entity<ShipRegistration>()
                .Property(e => e.ArrivalStationID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<ShipRegistration>()
                .Property(e => e.BorderRoutingID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<ShipRegistration>()
                .Property(e => e.CarrierTypeID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<ShipRegistration>()
                .Property(e => e.CarrierBCID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<ShipRegistration>()
                .Property(e => e.CarrierRegistrationID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<SpecialControl>()
                .Property(e => e.BorderCrossingID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<SpecialControl>()
                .Property(e => e.OperationID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<SpecialControl>()
                .Property(e => e.DocumentStatusID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<SpecialControl>()
                .Property(e => e.CommitteeTypeID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<SpecialControl>()
                .Property(e => e.CommitteeID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<SpecialControl>()
                .Property(e => e.ForgedDetectionTypeID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<SpecialControl>()
                .Property(e => e.DecisionID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<SpecialControl>()
                .Property(e => e.FaultTypeID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<SpecialControl>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<SpecialControl>()
                .Property(e => e.IdentifyDocumentID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<SpecialControl>()
                .Property(e => e.InscribeID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<SpecialControl>()
                .Property(e => e.VisaFlag)
                .HasPrecision(1, 0);

            modelBuilder.Entity<SpecialControl>()
                .Property(e => e.ReportedID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<SpecialControl>()
                .Property(e => e.DecisionMakingUserID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<SpecialControl>()
                .Property(e => e.Notes)
                .IsUnicode(false);

            modelBuilder.Entity<SpecialControl>()
                .Property(e => e.BookRecordNumber)
                .IsUnicode(false);

            modelBuilder.Entity<SpecialControl>()
                .Property(e => e.FaultAdditional)
                .IsUnicode(false);

            modelBuilder.Entity<SpokenLanguage>()
                .Property(e => e.SpokenLanguageID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<SpokenLanguage>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<SpokenLanguage>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<SpokenLanguage>()
                .Property(e => e.ReadOnly)
                .HasPrecision(1, 0);

            modelBuilder.Entity<SpokenLanguage>()
                .Property(e => e.DeleteFlag)
                .HasPrecision(1, 0);

            modelBuilder.Entity<ST_TimeShear>()
                .Property(e => e.TimeShearID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<ST_TimeShear>()
                .Property(e => e.Year)
                .HasPrecision(35, 0);

            modelBuilder.Entity<ST_TimeShear>()
                .Property(e => e.ReportYear)
                .HasPrecision(35, 0);

            modelBuilder.Entity<ST_TimeShear>()
                .Property(e => e.Halfyear)
                .HasPrecision(35, 0);

            modelBuilder.Entity<ST_TimeShear>()
                .Property(e => e.ReportHalfyear)
                .HasPrecision(35, 0);

            modelBuilder.Entity<ST_TimeShear>()
                .Property(e => e.Quarter)
                .HasPrecision(35, 0);

            modelBuilder.Entity<ST_TimeShear>()
                .Property(e => e.ReportQuarter)
                .HasPrecision(35, 0);

            modelBuilder.Entity<ST_TimeShear>()
                .Property(e => e.Month)
                .HasPrecision(35, 0);

            modelBuilder.Entity<ST_TimeShear>()
                .Property(e => e.ReportMonth)
                .HasPrecision(35, 0);

            modelBuilder.Entity<ST_TimeShear>()
                .Property(e => e.Day)
                .HasPrecision(35, 0);

            modelBuilder.Entity<Stat>()
                .Property(e => e.BorderCrossingID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<Stat>()
                .Property(e => e.OperationID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<Stat>()
                .Property(e => e.StatTypeID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<Stat>()
                .Property(e => e.StatObjectID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<Stat>()
                .Property(e => e.StatString1)
                .IsUnicode(false);

            modelBuilder.Entity<Stat>()
                .Property(e => e.StatString2)
                .IsUnicode(false);

            modelBuilder.Entity<Stat>()
                .Property(e => e.StatString3)
                .IsUnicode(false);

            modelBuilder.Entity<Stat>()
                .Property(e => e.StatNumber1)
                .HasPrecision(35, 0);

            modelBuilder.Entity<Stat>()
                .Property(e => e.StatNumber2)
                .HasPrecision(35, 0);

            modelBuilder.Entity<Stat>()
                .Property(e => e.StatNumber3)
                .HasPrecision(35, 0);

            modelBuilder.Entity<StateInstitute>()
                .Property(e => e.StateInstituteID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<StateInstitute>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<StateInstitute>()
                .Property(e => e.ParentStateInstituteID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<StateInstitute>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<StateInstitute>()
                .Property(e => e.DeleteFlag)
                .HasPrecision(1, 0);

            modelBuilder.Entity<StateInstitute>()
                .Property(e => e.ReadOnly)
                .HasPrecision(1, 0);

            modelBuilder.Entity<StatObject>()
                .Property(e => e.StatObjectID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<StatObject>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<StatObject>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<StatType>()
                .Property(e => e.StatTypeID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<StatType>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<StatType>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<StatType>()
                .Property(e => e.DescStatString1)
                .IsUnicode(false);

            modelBuilder.Entity<StatType>()
                .Property(e => e.DescStatString2)
                .IsUnicode(false);

            modelBuilder.Entity<StatType>()
                .Property(e => e.DescStatString3)
                .IsUnicode(false);

            modelBuilder.Entity<StatType>()
                .Property(e => e.DescStatNumber1)
                .IsUnicode(false);

            modelBuilder.Entity<StatType>()
                .Property(e => e.DescStatNumber2)
                .IsUnicode(false);

            modelBuilder.Entity<StatType>()
                .Property(e => e.DescStatNumber3)
                .IsUnicode(false);

            modelBuilder.Entity<StatType>()
                .Property(e => e.DescStatDate1)
                .IsUnicode(false);

            modelBuilder.Entity<StatType>()
                .Property(e => e.DescStatDate2)
                .IsUnicode(false);

            modelBuilder.Entity<StatType>()
                .Property(e => e.DescStatDate3)
                .IsUnicode(false);

            modelBuilder.Entity<StatTypeObject>()
                .Property(e => e.StatTypeID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<StatTypeObject>()
                .Property(e => e.StatObjectID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<StatTypeObject>()
                .Property(e => e.EnabledFlag)
                .HasPrecision(1, 0);

            modelBuilder.Entity<Subdivision>()
                .Property(e => e.SubdivisionID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<Subdivision>()
                .Property(e => e.ArrivalStationID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<Subdivision>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Subdivision>()
                .Property(e => e.ParentSubdivisionID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<Subdivision>()
                .Property(e => e.ChiefID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<Subdivision>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Subdivision>()
                .Property(e => e.DeleteFlag)
                .HasPrecision(1, 0);

            modelBuilder.Entity<Subdivision>()
                .Property(e => e.ReadOnly)
                .HasPrecision(1, 0);

            modelBuilder.Entity<SuspectFaultType>()
                .Property(e => e.SuspectFaultTypeID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<SuspectFaultType>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<SuspectFaultType>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<SuspectFaultType>()
                .Property(e => e.DeleteFlag)
                .HasPrecision(1, 0);

            modelBuilder.Entity<SuspectFaultType>()
                .Property(e => e.ReadOnly)
                .HasPrecision(1, 0);

            modelBuilder.Entity<TelegramDict>()
                .Property(e => e.TelegramDictID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<TelegramDict>()
                .Property(e => e.TelegramDictName)
                .IsUnicode(false);

            modelBuilder.Entity<TelegramDict>()
                .Property(e => e.PAKDictName)
                .IsUnicode(false);

            modelBuilder.Entity<TelegramDict>()
                .Property(e => e.EqualityClause)
                .IsUnicode(false);

            modelBuilder.Entity<TelegramDict>()
                .Property(e => e.DescNumberValue1)
                .IsUnicode(false);

            modelBuilder.Entity<TelegramDict>()
                .Property(e => e.DescNumberValue2)
                .IsUnicode(false);

            modelBuilder.Entity<TelegramDict>()
                .Property(e => e.DescNumberValue3)
                .IsUnicode(false);

            modelBuilder.Entity<TelegramDict>()
                .Property(e => e.DescStringValue1)
                .IsUnicode(false);

            modelBuilder.Entity<TelegramDict>()
                .Property(e => e.DescStringValue2)
                .IsUnicode(false);

            modelBuilder.Entity<TelegramDict>()
                .Property(e => e.DescStringValue3)
                .IsUnicode(false);

            modelBuilder.Entity<TelegramDict>()
                .Property(e => e.DescDateValue1)
                .IsUnicode(false);

            modelBuilder.Entity<TelegramDict>()
                .Property(e => e.DescDateValue2)
                .IsUnicode(false);

            modelBuilder.Entity<TelegramDict>()
                .Property(e => e.DescDateValue3)
                .IsUnicode(false);

            modelBuilder.Entity<TelegramDictValue>()
                .Property(e => e.TelegramDictID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<TelegramDictValue>()
                .Property(e => e.TelegramDictValueID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<TelegramDictValue>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<TelegramDictValue>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<TelegramDictValue>()
                .Property(e => e.NumberValue1)
                .HasPrecision(35, 0);

            modelBuilder.Entity<TelegramDictValue>()
                .Property(e => e.NumberValue2)
                .HasPrecision(35, 0);

            modelBuilder.Entity<TelegramDictValue>()
                .Property(e => e.NumberValue3)
                .HasPrecision(35, 0);

            modelBuilder.Entity<TelegramDictValue>()
                .Property(e => e.StringValue1)
                .IsUnicode(false);

            modelBuilder.Entity<TelegramDictValue>()
                .Property(e => e.StringValue2)
                .IsUnicode(false);

            modelBuilder.Entity<TelegramDictValue>()
                .Property(e => e.StringValue3)
                .IsUnicode(false);

            modelBuilder.Entity<Track>()
                .Property(e => e.ArrivalStationID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<Track>()
                .Property(e => e.BorderRoutingID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<Track>()
                .Property(e => e.FlightID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<Track>()
                .Property(e => e.Position)
                .HasPrecision(35, 0);

            modelBuilder.Entity<Track>()
                .Property(e => e.CountryID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<Track>()
                .Property(e => e.CityID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<TrainBorderCrossing>()
                .Property(e => e.ArrivalStationID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<TrainBorderCrossing>()
                .Property(e => e.BorderRoutingID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<TrainBorderCrossing>()
                .Property(e => e.CarrierTypeID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<TrainBorderCrossing>()
                .Property(e => e.CarrierBCID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<TrainRegistration>()
                .Property(e => e.ArrivalStationID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<TrainRegistration>()
                .Property(e => e.BorderRoutingID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<TrainRegistration>()
                .Property(e => e.CarrierTypeID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<TrainRegistration>()
                .Property(e => e.CarrierBCID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<TrainRegistration>()
                .Property(e => e.CarrierRegistrationID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<TranMorph>()
                .Property(e => e.Lng)
                .IsUnicode(false);

            modelBuilder.Entity<TranMorph>()
                .Property(e => e.Lat)
                .IsUnicode(false);

            modelBuilder.Entity<TranMorph>()
                .Property(e => e.Rus)
                .IsUnicode(false);

            modelBuilder.Entity<TranscriptionAlgorithm>()
                .Property(e => e.TranscriptionAlgorithmID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<TranscriptionAlgorithm>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<TranscriptionAlgorithm>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Transfert>()
                .Property(e => e.BorderCrossingID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<Transfert>()
                .Property(e => e.ArrivalStationOutID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<Transfert>()
                .Property(e => e.FlightOut)
                .IsUnicode(false);

            modelBuilder.Entity<Transfert>()
                .Property(e => e.RouteOut)
                .IsUnicode(false);

            modelBuilder.Entity<Transfert>()
                .Property(e => e.RealOutFlag)
                .HasPrecision(1, 0);

            modelBuilder.Entity<Transfert>()
                .Property(e => e.RealFlightOut)
                .IsUnicode(false);

            modelBuilder.Entity<Transfert>()
                .Property(e => e.RealRouteOut)
                .IsUnicode(false);

            modelBuilder.Entity<Transfert>()
                .Property(e => e.RealArrivalStationOutID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<Transit>()
                .Property(e => e.BorderCrossingID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<Transit>()
                .Property(e => e.ArrivalStationOutID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<Transit>()
                .Property(e => e.FlightOut)
                .IsUnicode(false);

            modelBuilder.Entity<Transit>()
                .Property(e => e.RouteOut)
                .IsUnicode(false);

            modelBuilder.Entity<Transit>()
                .Property(e => e.RealOutFlag)
                .HasPrecision(1, 0);

            modelBuilder.Entity<Transit>()
                .Property(e => e.RealArrivalStationOutID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<Transit>()
                .Property(e => e.RealFlightOut)
                .IsUnicode(false);

            modelBuilder.Entity<Transit>()
                .Property(e => e.RealRouteOut)
                .IsUnicode(false);

            modelBuilder.Entity<Transit>()
                .Property(e => e.TransitCategoryID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<TransitCategory>()
                .Property(e => e.TransitCategoryID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<TransitCategory>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<TransitCategory>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<TransitCategoryChange>()
                .Property(e => e.BorderCrossingID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<TransitCategoryChange>()
                .Property(e => e.OperationID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<TransitCategoryChange>()
                .Property(e => e.SourceTransitCategoryID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<TransitCategoryChange>()
                .Property(e => e.DestinationTransitCategoryID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<TransitCategoryChange>()
                .Property(e => e.Reason)
                .IsUnicode(false);

            modelBuilder.Entity<TransitHotel>()
                .Property(e => e.BorderCrossingID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<TransitHotel>()
                .Property(e => e.HotelID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<TransportCompany>()
                .Property(e => e.CarrierTypeID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<TransportCompany>()
                .Property(e => e.TransportCompanyID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<TransportCompany>()
                .Property(e => e.OwnerID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<TransportCompany>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<TransportCompany>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<TransportCompany>()
                .Property(e => e.DeleteFlag)
                .HasPrecision(1, 0);

            modelBuilder.Entity<TransportCompany>()
                .Property(e => e.ReadOnly)
                .HasPrecision(1, 0);

            modelBuilder.Entity<Underenumeration>()
                .Property(e => e.BorderCrossingID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<Underenumeration>()
                .Property(e => e.OperationID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<Underenumeration>()
                .Property(e => e.DecisionID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<Underenumeration>()
                .Property(e => e.SuspectFaultTypeID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<Underenumeration>()
                .Property(e => e.SuspectFaultNotes)
                .IsUnicode(false);

            modelBuilder.Entity<Underenumeration>()
                .Property(e => e.ArchivePhotoID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<Underenumeration>()
                .Property(e => e.DocumentPhotoID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<User>()
                .Property(e => e.Family)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Contour)
                .IsUnicode(false);

            modelBuilder.Entity<UserAction>()
                .Property(e => e.UserActionID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<UserAction>()
                .Property(e => e.ActionGroupID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<UserAction>()
                .Property(e => e.ActionTypeID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<UserAction>()
                .Property(e => e.ComputerName)
                .IsUnicode(false);

            modelBuilder.Entity<UserAction>()
                .Property(e => e.ARMID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<UserAction>()
                .Property(e => e.UserInfoID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<UserAction>()
                .Property(e => e.ModuleID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<UserAction>()
                .Property(e => e.BorderCrossingID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<UserAction>()
                .Property(e => e.OperationID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<UserAction>()
                .Property(e => e.String1)
                .IsUnicode(false);

            modelBuilder.Entity<UserAction>()
                .Property(e => e.String2)
                .IsUnicode(false);

            modelBuilder.Entity<UserAction>()
                .Property(e => e.String3)
                .IsUnicode(false);

            modelBuilder.Entity<UserAction>()
                .Property(e => e.Number1)
                .HasPrecision(35, 0);

            modelBuilder.Entity<UserAction>()
                .Property(e => e.Number2)
                .HasPrecision(35, 0);

            modelBuilder.Entity<UserAction>()
                .Property(e => e.Number3)
                .HasPrecision(35, 0);

            modelBuilder.Entity<UserAction>()
                .Property(e => e.String4)
                .IsUnicode(false);

            modelBuilder.Entity<UserAction>()
                .Property(e => e.String5)
                .IsUnicode(false);

            modelBuilder.Entity<UserAction>()
                .Property(e => e.String6)
                .IsUnicode(false);

            modelBuilder.Entity<UserAction>()
                .Property(e => e.String7)
                .IsUnicode(false);

            modelBuilder.Entity<UserAction>()
                .Property(e => e.String8)
                .IsUnicode(false);

            modelBuilder.Entity<UserAction>()
                .Property(e => e.ArrivalStationID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<UserAction>()
                .Property(e => e.Number5)
                .HasPrecision(35, 0);

            modelBuilder.Entity<UserAction>()
                .Property(e => e.Number4)
                .HasPrecision(35, 0);

            modelBuilder.Entity<UserInfo>()
                .Property(e => e.UserInfoID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<UserInfo>()
                .Property(e => e.StatusID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<UserInfo>()
                .Property(e => e.LoginName)
                .IsUnicode(false);

            modelBuilder.Entity<UserInfo>()
                .Property(e => e.Family)
                .IsUnicode(false);

            modelBuilder.Entity<UserInfo>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<UserInfo>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<UserInfo>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<UserInfo>()
                .Property(e => e.SubdivisionID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<UserInfo>()
                .Property(e => e.PositionID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<UserInfo>()
                .Property(e => e.RankID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<UserInfo>()
                .Property(e => e.StampNumber)
                .IsUnicode(false);

            modelBuilder.Entity<UserInfo>()
                .Property(e => e.Notes)
                .IsUnicode(false);

            modelBuilder.Entity<UserInfo>()
                .Property(e => e.TestUserFlag)
                .HasPrecision(1, 0);

            modelBuilder.Entity<UserInfo>()
                .Property(e => e.SecurityAdmin)
                .HasPrecision(1, 0);

            modelBuilder.Entity<UserInfo>()
                .Property(e => e.DeleteFlag)
                .HasPrecision(1, 0);

            modelBuilder.Entity<UserInfo>()
                .Property(e => e.ReadOnly)
                .HasPrecision(1, 0);

            modelBuilder.Entity<UserInfo>()
                .Property(e => e.Sex)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<UserInfo>()
                .Property(e => e.PasswordHash)
                .IsUnicode(false);

            modelBuilder.Entity<Visa>()
                .Property(e => e.VisaID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<Visa>()
                .Property(e => e.VisaCod)
                .IsUnicode(false);

            modelBuilder.Entity<Visa>()
                .Property(e => e.VisaNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Visa>()
                .Property(e => e.RegisterCod)
                .IsUnicode(false);

            modelBuilder.Entity<Visa>()
                .Property(e => e.RegisterNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Visa>()
                .Property(e => e.VisaTypeID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<Visa>()
                .Property(e => e.DocumentCod)
                .IsUnicode(false);

            modelBuilder.Entity<Visa>()
                .Property(e => e.DocumentNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Visa>()
                .Property(e => e.VisaRepetitionID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<Visa>()
                .Property(e => e.PurposeID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<Visa>()
                .Property(e => e.IssueOrganization)
                .IsUnicode(false);

            modelBuilder.Entity<Visa>()
                .Property(e => e.InvitationOrganization)
                .IsUnicode(false);

            modelBuilder.Entity<Visa>()
                .Property(e => e.InvitationNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Visa>()
                .Property(e => e.Route)
                .IsUnicode(false);

            modelBuilder.Entity<Visa>()
                .Property(e => e.DocumentStatusID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<Visa>()
                .Property(e => e.NumericRegisterNumber)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Visa>()
                .Property(e => e.NumericDocumentNumber)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Visa>()
                .Property(e => e.VisaClassID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<Visa>()
                .Property(e => e.OfficialFamily)
                .IsUnicode(false);

            modelBuilder.Entity<Visa>()
                .Property(e => e.DecisionNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Visa>()
                .Property(e => e.Cod)
                .IsUnicode(false);

            modelBuilder.Entity<Visa>()
                .Property(e => e.Number)
                .IsUnicode(false);

            modelBuilder.Entity<Visa>()
                .Property(e => e.BlankCod)
                .IsUnicode(false);

            modelBuilder.Entity<Visa>()
                .Property(e => e.BlankNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Visa>()
                .Property(e => e.StateInstituteID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<VisaClass>()
                .Property(e => e.VisaClassID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<VisaClass>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<VisaClass>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<VisaInscribe>()
                .Property(e => e.VisaID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<VisaInscribe>()
                .Property(e => e.VisaInscribeID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<VisaInscribe>()
                .Property(e => e.NationalityID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<VisaInscribe>()
                .Property(e => e.Family)
                .IsUnicode(false);

            modelBuilder.Entity<VisaInscribe>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<VisaInscribe>()
                .Property(e => e.FBirthday)
                .HasPrecision(1, 0);

            modelBuilder.Entity<VisaInscribe>()
                .Property(e => e.Sex)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<VisaInscribe>()
                .Property(e => e.PlaceOfBirth)
                .IsUnicode(false);

            modelBuilder.Entity<VisaRepetition>()
                .Property(e => e.VisaRepetitionID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<VisaRepetition>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<VisaRepetition>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<VisaRepetition>()
                .Property(e => e.DeleteFlag)
                .HasPrecision(1, 0);

            modelBuilder.Entity<VisaRepetition>()
                .Property(e => e.ReadOnly)
                .HasPrecision(1, 0);

            modelBuilder.Entity<VisaType>()
                .Property(e => e.VisaTypeID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<VisaType>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<VisaType>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<VisaType>()
                .Property(e => e.DeleteFlag)
                .HasPrecision(1, 0);

            modelBuilder.Entity<VisaType>()
                .Property(e => e.ReadOnly)
                .HasPrecision(1, 0);

            modelBuilder.Entity<XUserList>()
                .Property(e => e.XUserListID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<XUserList>()
                .Property(e => e.Family)
                .IsUnicode(false);

            modelBuilder.Entity<XUserList>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<XUserList>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<XUserList>()
                .Property(e => e.DeleteFlag)
                .HasPrecision(1, 0);

            modelBuilder.Entity<XUserList>()
                .Property(e => e.ReadOnly)
                .HasPrecision(1, 0);

            modelBuilder.Entity<XUserList>()
                .Property(e => e.Sex)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<XUserType>()
                .Property(e => e.CommitteeTypeID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<XUserType>()
                .Property(e => e.CommitteeStatusID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<XUserType>()
                .Property(e => e.XUserTypeID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<XUserType>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<XUserType>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<XUserType>()
                .Property(e => e.DeleteFlag)
                .HasPrecision(1, 0);

            modelBuilder.Entity<XUserType>()
                .Property(e => e.ReadOnly)
                .HasPrecision(1, 0);

            modelBuilder.Entity<XUserTypeList>()
                .Property(e => e.CommitteeTypeID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<XUserTypeList>()
                .Property(e => e.CommitteeStatusID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<XUserTypeList>()
                .Property(e => e.XUserTypeID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<XUserTypeList>()
                .Property(e => e.XUserListID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<XUserTypeList>()
                .Property(e => e.DeleteFlag)
                .HasPrecision(1, 0);

            modelBuilder.Entity<XUserTypeList>()
                .Property(e => e.ReadOnly)
                .HasPrecision(1, 0);

            modelBuilder.Entity<ActivityMode>()
                .HasMany(e => e.RegimeActivity)
                .WithRequired(e => e.ActivityMode)
                .HasForeignKey(e => e.ActivityModeTypeID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Airline>()
                .Property(e => e.NameIATA)
                .IsUnicode(false);

            modelBuilder.Entity<Airline>()
                .Property(e => e.NameRUS)
                .IsUnicode(false);

            modelBuilder.Entity<Airline>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Airline>()
                .Property(e => e.ContactEmail)
                .IsUnicode(false);

            modelBuilder.Entity<Airline>()
                .HasMany(e => e.FlightTransitionLinks)
                .WithRequired(e => e.Airline)
                .HasForeignKey(e => e.AirlineID_1)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Airline>()
                .HasMany(e => e.FlightTransitionLinks1)
                .WithRequired(e => e.Airline1)
                .HasForeignKey(e => e.AirlineID_2)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Airline>()
                .HasMany(e => e.Flight1)
                .WithRequired(e => e.Airline)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AirlineCode>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<AirlineCodeType>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<AirlineCodeType>()
                .HasMany(e => e.AirlineCode)
                .WithRequired(e => e.AirlineCodeType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AirportSector>()
                .Property(e => e.AirportName)
                .IsUnicode(false);

            modelBuilder.Entity<AirportSector>()
                .Property(e => e.Probability)
                .HasPrecision(5, 4);

            modelBuilder.Entity<Arm1>()
                .HasMany(e => e.agr_ArmSession)
                .WithOptional(e => e.Arm1)
                .HasForeignKey(e => e.ArmId);

            modelBuilder.Entity<Arm1>()
                .HasMany(e => e.agr_ArmSessionHistory)
                .WithOptional(e => e.Arm1)
                .HasForeignKey(e => e.ArmId);

            modelBuilder.Entity<Arm1>()
                .HasMany(e => e.MapObjects_Arm)
                .WithRequired(e => e.Arm1)
                .HasForeignKey(e => e.ArmId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Arm1>()
                .HasMany(e => e.ArmHierarchy)
                .WithRequired(e => e.Arm1)
                .HasForeignKey(e => e.ChildArmId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Arm1>()
                .HasMany(e => e.ArmHierarchy1)
                .WithRequired(e => e.Arm11)
                .HasForeignKey(e => e.ParentArmId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Arm1>()
                .HasOptional(e => e.ArmPtk)
                .WithRequired(e => e.Arm1);

            modelBuilder.Entity<Arm1>()
                .HasMany(e => e.LocationRoute_Arm)
                .WithRequired(e => e.Arm1)
                .HasForeignKey(e => e.ArmId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Arm1>()
                .HasMany(e => e.arg_RegistrationEndReg)
                .WithRequired(e => e.Arm1)
                .HasForeignKey(e => e.ArmId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Arm1>()
                .HasMany(e => e.agr_RegistrationStartReg)
                .WithRequired(e => e.Arm1)
                .HasForeignKey(e => e.ArmID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Arm1>()
                .HasMany(e => e.Starting)
                .WithOptional(e => e.Arm1)
                .HasForeignKey(e => e.ArmID);

            modelBuilder.Entity<Arm1>()
                .HasMany(e => e.ArmConfig)
                .WithMany(e => e.Arm1)
                .Map(m => m.ToTable("Arm_ArmConfig", "param").MapLeftKey("ArmId").MapRightKey("ArmConfigId"));

            modelBuilder.Entity<ArmPtk>()
                .HasMany(e => e.Cabin)
                .WithOptional(e => e.ArmPtk)
                .HasForeignKey(e => e.LeftArmId);

            modelBuilder.Entity<ArmPtk>()
                .HasMany(e => e.Cabin1)
                .WithOptional(e => e.ArmPtk1)
                .HasForeignKey(e => e.RightArmId);

            modelBuilder.Entity<ArmType>()
                .HasMany(e => e.Arm1)
                .WithRequired(e => e.ArmType)
                .HasForeignKey(e => e.TypeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ArmType>()
                .HasMany(e => e.ArmType_Dashboard_Configuration)
                .WithRequired(e => e.ArmType)
                .HasForeignKey(e => e.ArmType_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Cabin>()
                .Property(e => e.CabinNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Cabin>()
                .HasMany(e => e.MapObjects_Cabin)
                .WithRequired(e => e.Cabin)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Cabin>()
                .HasMany(e => e.CabinState)
                .WithRequired(e => e.Cabin)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Cabin>()
                .HasMany(e => e.LanguageGroupCabin)
                .WithRequired(e => e.Cabin)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CarrierParkingArea>()
                .HasMany(e => e.LocationRoute_CarrierParkingArea)
                .WithRequired(e => e.CarrierParkingArea)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ChiefType>()
                .HasMany(e => e.OrganizationalStructureChief)
                .WithRequired(e => e.ChiefType)
                .HasForeignKey(e => e.TypeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ControlledPersonLocation>()
                .HasMany(e => e.ControlledPerson)
                .WithOptional(e => e.ControlledPersonLocation)
                .HasForeignKey(e => e.PersonLocationID);

            modelBuilder.Entity<CountryCode>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<CountryCode>()
                .Property(e => e.ICAOCod)
                .IsUnicode(false);

            modelBuilder.Entity<CountryCodeType>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<CountryCodeType>()
                .HasMany(e => e.CountryCode)
                .WithRequired(e => e.CountryCodeType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DepartmentGroup>()
                .HasMany(e => e.BorderProtectionScheduleDetail)
                .WithOptional(e => e.DepartmentGroup)
                .HasForeignKey(e => e.DeparmtentGroupId);

            modelBuilder.Entity<DepartmentGroup>()
                .HasMany(e => e.EmployeeDepartmentGroup)
                .WithRequired(e => e.DepartmentGroup)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DepartmentJob>()
                .Property(e => e.RestrictedSex)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DepartmentJob>()
                .HasMany(e => e.BorderProtectionScheduleReserve)
                .WithRequired(e => e.DepartmentJob)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DepartmentJob>()
                .HasMany(e => e.BorderProtectionScheduleTargets)
                .WithRequired(e => e.DepartmentJob)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DepartmentJob>()
                .HasMany(e => e.DepartmentTargets)
                .WithRequired(e => e.DepartmentJob)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DepartmentJob>()
                .HasMany(e => e.EmployeeDepartmentJob)
                .WithRequired(e => e.DepartmentJob)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DepartmentWorkSchedule>()
                .HasMany(e => e.BorderProtectionScheduleHeader)
                .WithRequired(e => e.DepartmentWorkSchedule)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DepartmentWorkSchedule>()
                .HasMany(e => e.OrganizationalStructure2)
                .WithOptional(e => e.DepartmentWorkSchedule2)
                .HasForeignKey(e => e.WorkScheduleTypeId);

            modelBuilder.Entity<Direction>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Direction>()
                .HasMany(e => e.Flight1)
                .WithRequired(e => e.Direction)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Direction>()
                .HasMany(e => e.Sector)
                .WithRequired(e => e.Direction)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DutyType>()
                .HasMany(e => e.DutyRoutes)
                .WithRequired(e => e.DutyType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.PermissibleWorkTimeFrom)
                .HasPrecision(0);

            modelBuilder.Entity<Employee>()
                .Property(e => e.PermissibleWorkTimeTo)
                .HasPrecision(0);

            modelBuilder.Entity<Employee>()
                .Property(e => e.LunchPlanedTimeDay)
                .HasPrecision(0);

            modelBuilder.Entity<Employee>()
                .Property(e => e.LunchPlanedTimeNight)
                .HasPrecision(0);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Sex)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.EmployeeKaskadUser)
                .WithRequired(e => e.Employee)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.BorderProtectionScheduleChronometry)
                .WithRequired(e => e.Employee)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.BorderProtectionScheduleDetail)
                .WithRequired(e => e.Employee)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.BorderProtectionScheduleReinforcement)
                .WithRequired(e => e.Employee)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.ControlledPerson)
                .WithOptional(e => e.Employee)
                .HasForeignKey(e => e.ResponsibleOfficerID);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.ControlledPersonOfficerHistory)
                .WithRequired(e => e.Employee)
                .HasForeignKey(e => e.AppointedResponsibleOfficerId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.ControlledPersonOfficerHistory1)
                .WithRequired(e => e.Employee1)
                .HasForeignKey(e => e.ChangedEmployeeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.CustomEventProperties)
                .WithRequired(e => e.Employee)
                .HasForeignKey(e => e.AuthorId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.Employee_ReportGroup)
                .WithRequired(e => e.Employee)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.Employee__Statistic_Control)
                .WithRequired(e => e.Employee)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.EmployeeCard)
                .WithRequired(e => e.Employee)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.EmployeeCompatibilityList)
                .WithRequired(e => e.Employee)
                .HasForeignKey(e => e.EmployeeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.EmployeeCompatibilityList1)
                .WithRequired(e => e.Employee1)
                .HasForeignKey(e => e.ToEmployeeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.EmployeeDepartmentGroup)
                .WithRequired(e => e.Employee)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.EmployeeDepartmentJob)
                .WithRequired(e => e.Employee)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.EmployeeOrganizationalStructure)
                .WithRequired(e => e.Employee)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.EmployeeOverProcessing)
                .WithRequired(e => e.Employee)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.EmployeeWorkPermitSchedule)
                .WithRequired(e => e.Employee)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.EventLog)
                .WithOptional(e => e.Employee)
                .HasForeignKey(e => e.EmployeeID);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.EventPhotoAttachments)
                .WithRequired(e => e.Employee)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.EventPTKLogAttachment)
                .WithRequired(e => e.Employee)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.EventVideoAttachment)
                .WithRequired(e => e.Employee)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.OrganizationalStructureChief)
                .WithRequired(e => e.Employee)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.EventLog1)
                .WithMany(e => e.Employee1)
                .Map(m => m.ToTable("EventEmployee", "stat").MapLeftKey("EmployeeId").MapRightKey("EventId"));

            modelBuilder.Entity<EmployeeKaskadUser>()
                .Property(e => e.UserInfoId)
                .HasPrecision(35, 0);

            modelBuilder.Entity<FlightInspectionJournalStatus>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<FlightInspectionJournalStatus>()
                .HasMany(e => e.FlightInspectionJournal)
                .WithRequired(e => e.FlightInspectionJournalStatus)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FlightStatus>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<FlightStatus>()
                .HasMany(e => e.Flight1)
                .WithRequired(e => e.FlightStatus)
                .HasForeignKey(e => e.StatusID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Location>()
                .HasMany(e => e.BorderProtectionScheduleChronometry)
                .WithRequired(e => e.Location)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Location>()
                .HasMany(e => e.LocationRoute)
                .WithRequired(e => e.Location)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Location>()
                .HasMany(e => e.LocationSector)
                .WithRequired(e => e.Location)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LocationRoute>()
                .HasMany(e => e.DutyRoutes)
                .WithRequired(e => e.LocationRoute)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LocationRoute>()
                .HasMany(e => e.LocationRoute_Arm)
                .WithRequired(e => e.LocationRoute)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LocationRoute>()
                .HasMany(e => e.LocationRoute_CarrierParkingArea)
                .WithRequired(e => e.LocationRoute)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LocationRoute>()
                .HasMany(e => e.LocationRoute_MapObjects)
                .WithRequired(e => e.LocationRoute)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MapObjects>()
                .HasMany(e => e.LocationRoute_MapObjects)
                .WithRequired(e => e.MapObjects)
                .HasForeignKey(e => e.MapObjectId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MapObjects>()
                .HasMany(e => e.MapObjects_Camera)
                .WithRequired(e => e.MapObjects)
                .HasForeignKey(e => e.MapObjectId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MapObjects>()
                .HasMany(e => e.MapObjects_Camera1)
                .WithRequired(e => e.MapObjects1)
                .HasForeignKey(e => e.MapObjectId_Camera)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MapObjects>()
                .HasMany(e => e.MapObjects_Arm)
                .WithRequired(e => e.MapObjects)
                .HasForeignKey(e => e.MapObjectId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MapObjects>()
                .HasMany(e => e.MapObjects_Cabin)
                .WithRequired(e => e.MapObjects)
                .HasForeignKey(e => e.MapObjectId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MapObjects>()
                .HasMany(e => e.MapObjects_Sector)
                .WithRequired(e => e.MapObjects)
                .HasForeignKey(e => e.MapObjectId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MapObjects>()
                .HasMany(e => e.EventLog)
                .WithOptional(e => e.MapObjects)
                .HasForeignKey(e => e.MapObjectID);

            modelBuilder.Entity<MapObjects>()
                .HasMany(e => e.EventLogRaw)
                .WithOptional(e => e.MapObjects)
                .HasForeignKey(e => e.MapObjectID);

            modelBuilder.Entity<MapObjects>()
                .HasMany(e => e.EventVideoAttachment)
                .WithRequired(e => e.MapObjects)
                .HasForeignKey(e => e.MapObjectId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MapObjects>()
                .HasMany(e => e.MapObjectState)
                .WithRequired(e => e.MapObjects)
                .HasForeignKey(e => e.MapObjectID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MapObjects>()
                .HasMany(e => e.MapObjectStateEndTime)
                .WithRequired(e => e.MapObjects)
                .HasForeignKey(e => e.MapObjectID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MapObjects>()
                .HasMany(e => e.MapObjectStateEventLogEndTime)
                .WithRequired(e => e.MapObjects)
                .HasForeignKey(e => e.MapObjectID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MapObjectTypes>()
                .HasMany(e => e.MapObjects)
                .WithRequired(e => e.MapObjectTypes)
                .HasForeignKey(e => e.ObjectTypeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrganizationalStructure>()
                .HasMany(e => e.DepartmentGroup)
                .WithRequired(e => e.OrganizationalStructure)
                .HasForeignKey(e => e.DepartmentId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrganizationalStructure>()
                .HasMany(e => e.DepartmentJob)
                .WithRequired(e => e.OrganizationalStructure)
                .HasForeignKey(e => e.DepartmentId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrganizationalStructure>()
                .HasMany(e => e.DepartmentStaff)
                .WithRequired(e => e.OrganizationalStructure)
                .HasForeignKey(e => e.DepartmentId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrganizationalStructure>()
                .HasMany(e => e.DepartmentTargets)
                .WithRequired(e => e.OrganizationalStructure)
                .HasForeignKey(e => e.DepartmentId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrganizationalStructure>()
                .HasMany(e => e.DepartmentWorkSchedule)
                .WithOptional(e => e.OrganizationalStructure)
                .HasForeignKey(e => e.SubDepartmentId);

            modelBuilder.Entity<OrganizationalStructure>()
                .HasMany(e => e.DepartmentWorkSchedule1)
                .WithRequired(e => e.OrganizationalStructure1)
                .HasForeignKey(e => e.DepartmentId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrganizationalStructure>()
                .HasMany(e => e.EmployeeOrganizationalStructure)
                .WithOptional(e => e.OrganizationalStructure)
                .HasForeignKey(e => e.ArrivalStationId);

            modelBuilder.Entity<OrganizationalStructure>()
                .HasMany(e => e.EmployeeOrganizationalStructure1)
                .WithOptional(e => e.OrganizationalStructure1)
                .HasForeignKey(e => e.BrigadeId);

            modelBuilder.Entity<OrganizationalStructure>()
                .HasMany(e => e.EmployeeOrganizationalStructure2)
                .WithOptional(e => e.OrganizationalStructure2)
                .HasForeignKey(e => e.DepartmentId);

            modelBuilder.Entity<OrganizationalStructure>()
                .HasMany(e => e.EmployeeOrganizationalStructure3)
                .WithOptional(e => e.OrganizationalStructure3)
                .HasForeignKey(e => e.GangId);

            modelBuilder.Entity<OrganizationalStructure>()
                .HasMany(e => e.BorderProtectionPlan)
                .WithRequired(e => e.OrganizationalStructure)
                .HasForeignKey(e => e.DepartmentId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrganizationalStructure>()
                .HasMany(e => e.BorderProtectionScheduleHeader)
                .WithRequired(e => e.OrganizationalStructure)
                .HasForeignKey(e => e.DepartmentId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrganizationalStructure>()
                .HasMany(e => e.OrganizationalStructure1)
                .WithOptional(e => e.OrganizationalStructure2)
                .HasForeignKey(e => e.ParentId);

            modelBuilder.Entity<OrganizationalStructure>()
                .HasMany(e => e.OrganizationalStructureChief)
                .WithRequired(e => e.OrganizationalStructure)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrganizationalStructure>()
                .HasMany(e => e.ReportTemplate)
                .WithOptional(e => e.OrganizationalStructure)
                .HasForeignKey(e => e.DepartmentId);

            modelBuilder.Entity<OrganizationalStructureType>()
                .HasMany(e => e.OrganizationalStructure)
                .WithRequired(e => e.OrganizationalStructureType)
                .HasForeignKey(e => e.TypeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PlanType>()
                .HasMany(e => e.BorderProtectionPlan)
                .WithRequired(e => e.PlanType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PlanType>()
                .HasMany(e => e.BorderProtectionScheduleSectorDefaults)
                .WithRequired(e => e.PlanType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ReportType>()
                .HasMany(e => e.ReportTemplate)
                .WithOptional(e => e.ReportType)
                .HasForeignKey(e => e.TypeId);

            modelBuilder.Entity<Sector>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Sector>()
                .HasMany(e => e.AirportSector)
                .WithRequired(e => e.Sector)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Sector>()
                .HasMany(e => e.ArmPtk)
                .WithRequired(e => e.Sector)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Sector>()
                .HasMany(e => e.Cabin)
                .WithRequired(e => e.Sector)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Sector>()
                .HasMany(e => e.LocationRoute)
                .WithRequired(e => e.Sector)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Sector>()
                .HasMany(e => e.LocationSector)
                .WithRequired(e => e.Sector)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Sector>()
                .HasMany(e => e.MapObjects_Sector)
                .WithRequired(e => e.Sector)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Sector>()
                .HasMany(e => e.BorderProtectionScheduleReinforcement)
                .WithOptional(e => e.Sector)
                .HasForeignKey(e => e.SectorIdFrom);

            modelBuilder.Entity<Sector>()
                .HasMany(e => e.BorderProtectionScheduleReinforcement1)
                .WithOptional(e => e.Sector1)
                .HasForeignKey(e => e.SectorIdTo);

            modelBuilder.Entity<Sector>()
                .HasMany(e => e.BorderProtectionScheduleSector)
                .WithRequired(e => e.Sector)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Sector>()
                .HasMany(e => e.BorderProtectionScheduleSectorDefaults)
                .WithRequired(e => e.Sector)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Sector>()
                .HasMany(e => e.EmergencySector)
                .WithRequired(e => e.Sector)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Sector>()
                .HasMany(e => e.RegimeActivity)
                .WithRequired(e => e.Sector)
                .HasForeignKey(e => e.LocationID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Sector>()
                .HasMany(e => e.arg_RegistrationEndReg)
                .WithRequired(e => e.Sector)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Sex>()
                .Property(e => e.Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Sex>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<WorkingDayType>()
                .HasMany(e => e.WorkingCalendar)
                .WithRequired(e => e.WorkingDayType)
                .HasForeignKey(e => e.DayTypeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WorkPermitType>()
                .HasMany(e => e.EmployeeWorkPermitSchedule)
                .WithRequired(e => e.WorkPermitType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WorkScheduleType>()
                .HasMany(e => e.WorkingCalendar)
                .WithRequired(e => e.WorkScheduleType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Flight1>()
                .Property(e => e.FlightNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Flight1>()
                .Property(e => e.Airport)
                .IsUnicode(false);

            modelBuilder.Entity<Flight1>()
                .Property(e => e.acType)
                .IsUnicode(false);

            modelBuilder.Entity<Flight1>()
                .Property(e => e.flId)
                .IsUnicode(false);

            modelBuilder.Entity<Flight1>()
                .Property(e => e.AgentType)
                .IsUnicode(false);

            modelBuilder.Entity<Flight1>()
                .Property(e => e.EstimateParkingArea)
                .IsUnicode(false);

            modelBuilder.Entity<Flight1>()
                .Property(e => e.ActualParkingArea)
                .IsUnicode(false);

            modelBuilder.Entity<Flight1>()
                .Property(e => e.ReasonDelay)
                .IsUnicode(false);

            modelBuilder.Entity<Flight1>()
                .Property(e => e.Sections)
                .IsUnicode(false);

            modelBuilder.Entity<Flight1>()
                .Property(e => e.RegistrationCode)
                .IsUnicode(false);

            modelBuilder.Entity<Flight1>()
                .Property(e => e.TravelTime)
                .HasPrecision(0);

            modelBuilder.Entity<Flight1>()
                .HasMany(e => e.FlightInspectionJournal)
                .WithRequired(e => e.Flight1)
                .HasForeignKey(e => e.FlightID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Flight1>()
                .HasMany(e => e.FlightInspectionJournal1)
                .WithOptional(e => e.Flight11)
                .HasForeignKey(e => e.TransitFlightID);

            modelBuilder.Entity<Flight1>()
                .HasMany(e => e.Passenger1)
                .WithRequired(e => e.Flight1)
                .HasForeignKey(e => e.FlightID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FlightInspectionJournal>()
                .Property(e => e.FlightModeId)
                .HasPrecision(35, 0);

            modelBuilder.Entity<FlightInspectionJournal>()
                .Property(e => e.FlightTypeId)
                .HasPrecision(35, 0);

            modelBuilder.Entity<FlightInspectionJournal>()
                .Property(e => e.CarrierDecisionID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<FlightInspectionJournal>()
                .HasMany(e => e.FlightInspectionJournal1)
                .WithOptional(e => e.FlightInspectionJournal2)
                .HasForeignKey(e => e.ParentID);

            modelBuilder.Entity<FlightTransitionLinks>()
                .Property(e => e.FlightNumber_1)
                .IsUnicode(false);

            modelBuilder.Entity<FlightTransitionLinks>()
                .Property(e => e.FlightNumber_2)
                .IsUnicode(false);

            modelBuilder.Entity<Emergency>()
                .HasMany(e => e.EmergencySector)
                .WithRequired(e => e.Emergency)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LanguageGroup>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<LanguageGroup>()
                .HasMany(e => e.FixedGroupLanguage)
                .WithRequired(e => e.LanguageGroup)
                .HasForeignKey(e => e.GroupId);

            modelBuilder.Entity<LanguageGroup>()
                .HasMany(e => e.ValidGroupLanguage)
                .WithRequired(e => e.LanguageGroup)
                .HasForeignKey(e => e.GroupId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LanguageGroupCabinPreset>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<LastProhod>()
                .Property(e => e.CardID)
                .IsUnicode(false);

            modelBuilder.Entity<LastProhod>()
                .Property(e => e.ObjectID)
                .IsUnicode(false);

            modelBuilder.Entity<Obj_CAM>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<Obj_CAM>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Obj_Person>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<Obj_Person>()
                .Property(e => e.FIO)
                .IsUnicode(false);

            modelBuilder.Entity<Obj_PNET3_NC32K>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<Obj_PNET3_NC32K>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<ObjType>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<ObjType>()
                .Property(e => e.Group)
                .IsUnicode(false);

            modelBuilder.Entity<ObjType>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<ObjType>()
                .HasMany(e => e.ObjType1)
                .WithOptional(e => e.ObjType2)
                .HasForeignKey(e => e.ParentID);

            modelBuilder.Entity<ObjType>()
                .HasMany(e => e.ObjTypeEvent)
                .WithRequired(e => e.ObjType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ObjTypeEvent>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<ObjTypeEvent>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<ObjTypeEvent>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<ObjTypeEvent>()
                .Property(e => e.Params)
                .IsUnicode(false);

            modelBuilder.Entity<Protocol>()
                .Property(e => e.ObjType)
                .IsUnicode(false);

            modelBuilder.Entity<Protocol>()
                .Property(e => e.Event)
                .IsUnicode(false);

            modelBuilder.Entity<Protocol>()
                .Property(e => e.ObjectID)
                .IsUnicode(false);

            modelBuilder.Entity<Protocol>()
                .Property(e => e.RegionID)
                .IsUnicode(false);

            modelBuilder.Entity<Protocol>()
                .Property(e => e.Owner)
                .IsUnicode(false);

            modelBuilder.Entity<Protocol>()
                .Property(e => e.MessageType)
                .IsUnicode(false);

            modelBuilder.Entity<Protocol>()
                .Property(e => e.Param0)
                .IsUnicode(false);

            modelBuilder.Entity<Protocol>()
                .Property(e => e.Param1)
                .IsUnicode(false);

            modelBuilder.Entity<Protocol>()
                .Property(e => e.Param2)
                .IsUnicode(false);

            modelBuilder.Entity<Protocol>()
                .Property(e => e.Param3)
                .IsUnicode(false);

            modelBuilder.Entity<Protocol>()
                .HasMany(e => e.EventLog)
                .WithOptional(e => e.Protocol)
                .HasForeignKey(e => e.KSBEventID);

            modelBuilder.Entity<Protocol>()
                .HasMany(e => e.EventLogRaw)
                .WithOptional(e => e.Protocol)
                .HasForeignKey(e => e.KSBEventID);

            modelBuilder.Entity<RequestVideoFile>()
                .Property(e => e.CamID)
                .IsUnicode(false);

            modelBuilder.Entity<RequestVideoFile>()
                .Property(e => e.FileName)
                .IsUnicode(false);

            modelBuilder.Entity<RequestVideoFile>()
                .Property(e => e.Comment)
                .IsUnicode(false);

            modelBuilder.Entity<Authorization>()
                .Property(e => e.UserLogin)
                .IsUnicode(false);

            modelBuilder.Entity<Authorization>()
                .HasMany(e => e.SPNDepthControl)
                .WithRequired(e => e.Authorization)
                .HasForeignKey(e => e.Authorization_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Authorization>()
                .HasMany(e => e.ChangeDirection)
                .WithRequired(e => e.Authorization)
                .HasForeignKey(e => e.Authorization_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Authorization>()
                .HasMany(e => e.ChangeMode)
                .WithRequired(e => e.Authorization)
                .HasForeignKey(e => e.Authorization_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Authorization>()
                .HasMany(e => e.Lock)
                .WithRequired(e => e.Authorization)
                .HasForeignKey(e => e.Authorization_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Authorization>()
                .HasMany(e => e.Message)
                .WithRequired(e => e.Authorization)
                .HasForeignKey(e => e.Authorization_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Authorization>()
                .HasMany(e => e.Registration)
                .WithRequired(e => e.Authorization)
                .HasForeignKey(e => e.Authorization_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Control>()
                .Property(e => e.Sex)
                .IsUnicode(false);

            modelBuilder.Entity<Control>()
                .Property(e => e.FligthNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Control>()
                .Property(e => e.DocumNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Control>()
                .Property(e => e.NationalityCode)
                .IsUnicode(false);

            modelBuilder.Entity<Control>()
                .Property(e => e.TypeDocument)
                .IsUnicode(false);

            modelBuilder.Entity<Control>()
                .Property(e => e.Nationality)
                .IsUnicode(false);

            modelBuilder.Entity<Control>()
                .Property(e => e.Location)
                .IsUnicode(false);

            modelBuilder.Entity<Control>()
                .Property(e => e.AddInfo)
                .IsUnicode(false);

            modelBuilder.Entity<Control>()
                .Property(e => e.FioLatin)
                .IsUnicode(false);

            modelBuilder.Entity<Control>()
                .Property(e => e.FioRus)
                .IsUnicode(false);

            modelBuilder.Entity<Control>()
                .Property(e => e.WarnDescription)
                .IsUnicode(false);

            modelBuilder.Entity<Control>()
                .Property(e => e.CrossingLabelID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<DocumentScan>()
                .Property(e => e.CMIORFileName)
                .IsUnicode(false);

            modelBuilder.Entity<DocumentScanType>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<DocumentScanType>()
                .HasMany(e => e.DocumentScan)
                .WithRequired(e => e.DocumentScanType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Errors>()
                .Property(e => e.ErrorText)
                .IsUnicode(false);

            modelBuilder.Entity<FIO>()
                .Property(e => e.DocumentCategory)
                .IsUnicode(false);

            modelBuilder.Entity<FIO>()
                .Property(e => e.Sex)
                .IsUnicode(false);

            modelBuilder.Entity<FIO>()
                .Property(e => e.DocumentNumber)
                .IsUnicode(false);

            modelBuilder.Entity<FIO>()
                .Property(e => e.NationalIssue)
                .IsUnicode(false);

            modelBuilder.Entity<FIO>()
                .Property(e => e.IssuingStateCode)
                .IsUnicode(false);

            modelBuilder.Entity<FIO>()
                .Property(e => e.LangCode)
                .IsUnicode(false);

            modelBuilder.Entity<FIO>()
                .Property(e => e.Surname)
                .IsUnicode(false);

            modelBuilder.Entity<FIO>()
                .Property(e => e.Surname_RUS)
                .IsUnicode(false);

            modelBuilder.Entity<FIO>()
                .Property(e => e.GivenName)
                .IsUnicode(false);

            modelBuilder.Entity<FIO>()
                .Property(e => e.GivenName_RUS)
                .IsUnicode(false);

            modelBuilder.Entity<Lock>()
                .Property(e => e.CompName)
                .IsUnicode(false);

            modelBuilder.Entity<Lock>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<Message>()
                .Property(e => e.Message1)
                .IsUnicode(false);

            modelBuilder.Entity<PakLogFile>()
                .Property(e => e.PTKFileName)
                .IsUnicode(false);

            modelBuilder.Entity<PakLogFile>()
                .Property(e => e.CMIORFileName)
                .IsUnicode(false);

            modelBuilder.Entity<Passenger>()
                .Property(e => e.BorderCrossing_ID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<Passenger>()
                .HasMany(e => e.EventLog)
                .WithOptional(e => e.Passenger)
                .HasForeignKey(e => e.PassengerID);

            modelBuilder.Entity<Reading>()
                .Property(e => e.National)
                .IsUnicode(false);

            modelBuilder.Entity<Reading>()
                .Property(e => e.Country)
                .IsUnicode(false);

            modelBuilder.Entity<Reading>()
                .Property(e => e.DocumentName)
                .IsUnicode(false);

            modelBuilder.Entity<Reading>()
                .Property(e => e.ArchivePath)
                .IsUnicode(false);

            modelBuilder.Entity<Reading>()
                .HasMany(e => e.DocumentScan)
                .WithRequired(e => e.Reading)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Reading>()
                .HasMany(e => e.ReadMRZ)
                .WithRequired(e => e.Reading)
                .HasForeignKey(e => e.Reading_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Reading>()
                .HasMany(e => e.ReadRFID)
                .WithRequired(e => e.Reading)
                .HasForeignKey(e => e.Reading_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ReadMRZ>()
                .Property(e => e.DocumentCategory)
                .IsUnicode(false);

            modelBuilder.Entity<ReadMRZ>()
                .Property(e => e.Sex)
                .IsUnicode(false);

            modelBuilder.Entity<ReadMRZ>()
                .Property(e => e.DocumentNumber)
                .IsUnicode(false);

            modelBuilder.Entity<ReadMRZ>()
                .Property(e => e.NationalIssue)
                .IsUnicode(false);

            modelBuilder.Entity<ReadMRZ>()
                .Property(e => e.IssuingStateCode)
                .IsUnicode(false);

            modelBuilder.Entity<ReadMRZ>()
                .Property(e => e.Surname)
                .IsUnicode(false);

            modelBuilder.Entity<ReadMRZ>()
                .Property(e => e.Surname_RUS)
                .IsUnicode(false);

            modelBuilder.Entity<ReadMRZ>()
                .Property(e => e.GivenName)
                .IsUnicode(false);

            modelBuilder.Entity<ReadMRZ>()
                .Property(e => e.GivenName_RUS)
                .IsUnicode(false);

            modelBuilder.Entity<ReadRFID>()
                .Property(e => e.Sex)
                .IsUnicode(false);

            modelBuilder.Entity<ReadRFID>()
                .Property(e => e.NationalityCode)
                .IsUnicode(false);

            modelBuilder.Entity<ReadRFID>()
                .Property(e => e.IssuingStateCode)
                .IsUnicode(false);

            modelBuilder.Entity<ReadRFID>()
                .Property(e => e.MRZ_Type)
                .IsUnicode(false);

            modelBuilder.Entity<ReadRFID>()
                .Property(e => e.DocumentClassCode)
                .IsUnicode(false);

            modelBuilder.Entity<ReadRFID>()
                .Property(e => e.DocumentNumber)
                .IsUnicode(false);

            modelBuilder.Entity<ReadRFID>()
                .Property(e => e.Surname)
                .IsUnicode(false);

            modelBuilder.Entity<ReadRFID>()
                .Property(e => e.GivenNames)
                .IsUnicode(false);

            modelBuilder.Entity<ReadRFID>()
                .Property(e => e.MRZ_Strings)
                .IsUnicode(false);

            modelBuilder.Entity<ReadRFID>()
                .Property(e => e.SurnameGivenNames)
                .IsUnicode(false);

            modelBuilder.Entity<Registration>()
                .Property(e => e.CitizenShip)
                .HasPrecision(35, 0);

            modelBuilder.Entity<Registration>()
                .Property(e => e.DocumentCategoryID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<Registration>()
                .Property(e => e.Sex)
                .IsUnicode(false);

            modelBuilder.Entity<Registration>()
                .Property(e => e.DocumentNumberCode)
                .IsUnicode(false);

            modelBuilder.Entity<Registration>()
                .Property(e => e.DocumentNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Registration>()
                .Property(e => e.Mode)
                .IsUnicode(false);

            modelBuilder.Entity<Registration>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<Registration>()
                .Property(e => e.Direction)
                .IsUnicode(false);

            modelBuilder.Entity<Registration>()
                .Property(e => e.Surname)
                .IsUnicode(false);

            modelBuilder.Entity<Registration>()
                .Property(e => e.GivenName)
                .IsUnicode(false);

            modelBuilder.Entity<Registration>()
                .Property(e => e.SurnameLatin)
                .IsUnicode(false);

            modelBuilder.Entity<Registration>()
                .Property(e => e.GivenNameLatin)
                .IsUnicode(false);

            modelBuilder.Entity<Registration>()
                .Property(e => e.CallSeniorReason)
                .IsUnicode(false);

            modelBuilder.Entity<Registration>()
                .Property(e => e.Note)
                .IsUnicode(false);

            modelBuilder.Entity<Registration>()
                .Property(e => e.NumDocError)
                .IsUnicode(false);

            modelBuilder.Entity<Registration>()
                .HasMany(e => e.Control)
                .WithRequired(e => e.Registration)
                .HasForeignKey(e => e.Registration_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Registration>()
                .HasMany(e => e.FIO)
                .WithRequired(e => e.Registration)
                .HasForeignKey(e => e.Registration_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Registration>()
                .HasMany(e => e.Passenger)
                .WithOptional(e => e.Registration)
                .HasForeignKey(e => e.Registration_ID);

            modelBuilder.Entity<Registration>()
                .HasMany(e => e.Reading)
                .WithRequired(e => e.Registration)
                .HasForeignKey(e => e.Registration_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SPNDepthControl>()
                .Property(e => e.ComputerName)
                .IsUnicode(false);

            modelBuilder.Entity<SPNDepthControl>()
                .Property(e => e.FaultAdditional)
                .IsUnicode(false);

            modelBuilder.Entity<SPNDepthControl>()
                .Property(e => e.Reason)
                .IsUnicode(false);

            modelBuilder.Entity<SPNDepthControl>()
                .Property(e => e.Notes)
                .IsUnicode(false);

            modelBuilder.Entity<Starting>()
                .Property(e => e.SizeMem)
                .IsUnicode(false);

            modelBuilder.Entity<Starting>()
                .Property(e => e.FreeMem)
                .IsUnicode(false);

            modelBuilder.Entity<Starting>()
                .Property(e => e.NameComp)
                .IsUnicode(false);

            modelBuilder.Entity<Starting>()
                .Property(e => e.NameUser)
                .IsUnicode(false);

            modelBuilder.Entity<Starting>()
                .Property(e => e.FolderRun)
                .IsUnicode(false);

            modelBuilder.Entity<Starting>()
                .Property(e => e.FolderWork)
                .IsUnicode(false);

            modelBuilder.Entity<Starting>()
                .Property(e => e.Mode)
                .IsUnicode(false);

            modelBuilder.Entity<Starting>()
                .HasMany(e => e.Authorization)
                .WithRequired(e => e.Starting)
                .HasForeignKey(e => e.Starting_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Starting>()
                .HasMany(e => e.Errors)
                .WithRequired(e => e.Starting)
                .HasForeignKey(e => e.Starting_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Starting>()
                .HasMany(e => e.PakLogFile)
                .WithRequired(e => e.Starting)
                .HasForeignKey(e => e.Starting_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OU_List_Deleted>()
                .Property(e => e.HashKey)
                .IsFixedLength();

            modelBuilder.Entity<OU_List_Deleted>()
                .Property(e => e.FIO)
                .IsUnicode(false);

            modelBuilder.Entity<OU_List_Deleted>()
                .Property(e => e.BirthDate)
                .IsUnicode(false);

            modelBuilder.Entity<OU_List_Deleted>()
                .Property(e => e.Country)
                .IsUnicode(false);

            modelBuilder.Entity<OU_List_Deleted>()
                .Property(e => e.Sex)
                .IsUnicode(false);

            modelBuilder.Entity<OU_List_Deleted>()
                .Property(e => e.Job)
                .IsUnicode(false);

            modelBuilder.Entity<OU_List_Deleted>()
                .Property(e => e.Note)
                .IsUnicode(false);

            modelBuilder.Entity<OU_List_Deleted>()
                .Property(e => e.Oper)
                .HasPrecision(35, 0);

            modelBuilder.Entity<OU_List_Deleted>()
                .Property(e => e.Comment)
                .IsUnicode(false);

            modelBuilder.Entity<OU_List_Deleted>()
                .Property(e => e.Ndb)
                .HasPrecision(35, 0);

            modelBuilder.Entity<ArmConfig>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<ArmModule>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<ArmModule>()
                .Property(e => e.AssemblyName)
                .IsUnicode(false);

            modelBuilder.Entity<ArmModule>()
                .HasMany(e => e.ArmConfig)
                .WithMany(e => e.ArmModule)
                .Map(m => m.ToTable("ArmConfig_Module", "param").MapLeftKey("ArmModuleId").MapRightKey("ArmConfigId"));

            modelBuilder.Entity<Dashboard_Configuration>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Dashboard_Configuration>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Dashboard_Configuration>()
                .HasMany(e => e.ArmType_Dashboard_Configuration)
                .WithRequired(e => e.Dashboard_Configuration)
                .HasForeignKey(e => e.Dashboard_Configuration_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Dashboard_Configuration>()
                .HasMany(e => e.Dashboard_Form)
                .WithRequired(e => e.Dashboard_Configuration)
                .HasForeignKey(e => e.Dashboard_Configuration_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Dashboard_Configuration>()
                .HasMany(e => e.Employee)
                .WithMany(e => e.Dashboard_Configuration)
                .Map(m => m.ToTable("Employee_Dashboard_Configuration", "param").MapRightKey("Employee_ID"));

            modelBuilder.Entity<Dashboard_Display>()
                .HasMany(e => e.Dashboard_Form)
                .WithMany(e => e.Dashboard_Display)
                .Map(m => m.ToTable("Dashboard_Form_Display", "param").MapLeftKey("Display_ID").MapRightKey("Form_ID"));

            modelBuilder.Entity<Dashboard_Display_Collection>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Dashboard_Display_Collection>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Dashboard_Display_Collection>()
                .HasMany(e => e.Dashboard_Configuration)
                .WithOptional(e => e.Dashboard_Display_Collection)
                .HasForeignKey(e => e.Dashboard_Display_Collection_ID);

            modelBuilder.Entity<Dashboard_Display_Collection>()
                .HasMany(e => e.Dashboard_Display)
                .WithRequired(e => e.Dashboard_Display_Collection)
                .HasForeignKey(e => e.Dashboard_Display_Collection_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Dashboard_Form>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Dashboard_Form>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Dashboard_Form>()
                .HasMany(e => e.Dashboard_Control)
                .WithOptional(e => e.Dashboard_Form)
                .HasForeignKey(e => e.Dashboard_Form_ID);

            modelBuilder.Entity<Setting1>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<Setting1>()
                .Property(e => e.DataType)
                .IsUnicode(false);

            modelBuilder.Entity<Setting1>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Statistic_Control>()
                .Property(e => e.ControlType)
                .IsUnicode(false);

            modelBuilder.Entity<Statistic_Control>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Statistic_Control>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Statistic_Control>()
                .HasMany(e => e.Dashboard_Control)
                .WithOptional(e => e.Statistic_Control)
                .HasForeignKey(e => e.Statistic_Control_ID);

            modelBuilder.Entity<Statistic_Control>()
                .HasMany(e => e.Employee__Statistic_Control)
                .WithRequired(e => e.Statistic_Control)
                .HasForeignKey(e => e.Statistic_Control_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Statistic_Control_Group>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Statistic_Control_Group>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Statistic_Control_Group>()
                .HasMany(e => e.Statistic_Control)
                .WithRequired(e => e.Statistic_Control_Group)
                .HasForeignKey(e => e.Group_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Statistic_Control_Group>()
                .HasMany(e => e.Statistic_Control_Group1)
                .WithOptional(e => e.Statistic_Control_Group2)
                .HasForeignKey(e => e.Parent_Group_ID);

            modelBuilder.Entity<BorderProtectionPlan>()
                .HasMany(e => e.BorderProtectionScheduleHeader)
                .WithOptional(e => e.BorderProtectionPlan)
                .HasForeignKey(e => e.PlanId);

            modelBuilder.Entity<BorderProtectionScheduleHeader>()
                .HasMany(e => e.BorderProtectionScheduleDetail)
                .WithRequired(e => e.BorderProtectionScheduleHeader)
                .HasForeignKey(e => e.HeaderId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BorderProtectionScheduleHeader>()
                .HasMany(e => e.BorderProtectionScheduleChronometry)
                .WithOptional(e => e.BorderProtectionScheduleHeader)
                .HasForeignKey(e => e.HeaderId);

            modelBuilder.Entity<BorderProtectionScheduleHeader>()
                .HasMany(e => e.BorderProtectionScheduleReinforcement)
                .WithRequired(e => e.BorderProtectionScheduleHeader)
                .HasForeignKey(e => e.HeaderIdFrom)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BorderProtectionScheduleHeader>()
                .HasMany(e => e.BorderProtectionScheduleReinforcement1)
                .WithOptional(e => e.BorderProtectionScheduleHeader1)
                .HasForeignKey(e => e.HeaderIdTo);

            modelBuilder.Entity<BorderProtectionScheduleHeader>()
                .HasMany(e => e.BorderProtectionScheduleReserve)
                .WithRequired(e => e.BorderProtectionScheduleHeader)
                .HasForeignKey(e => e.HeaderId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BorderProtectionScheduleHeader>()
                .HasMany(e => e.BorderProtectionScheduleSector)
                .WithRequired(e => e.BorderProtectionScheduleHeader)
                .HasForeignKey(e => e.HeaderId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BorderProtectionScheduleHeader>()
                .HasMany(e => e.BorderProtectionScheduleTargets)
                .WithRequired(e => e.BorderProtectionScheduleHeader)
                .HasForeignKey(e => e.HeaderId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EgisOTB_Data>()
                .Property(e => e.FlightNumber)
                .IsUnicode(false);

            modelBuilder.Entity<EgisOTB_Data>()
                .Property(e => e.AirportDeparture)
                .IsUnicode(false);

            modelBuilder.Entity<EgisOTB_Data>()
                .Property(e => e.OperationType)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<EgisOTB_Data>()
                .Property(e => e.DocumentType)
                .IsUnicode(false);

            modelBuilder.Entity<EgisOTB_Data>()
                .Property(e => e.CountryIssue)
                .IsUnicode(false);

            modelBuilder.Entity<EgisOTB_Data>()
                .Property(e => e.DocumentNumber)
                .IsUnicode(false);

            modelBuilder.Entity<EgisOTB_Data>()
                .Property(e => e.NationalIssue)
                .IsUnicode(false);

            modelBuilder.Entity<EgisOTB_Data>()
                .Property(e => e.FIO)
                .IsUnicode(false);

            modelBuilder.Entity<EgisOTB_Data>()
                .Property(e => e.Sex)
                .IsUnicode(false);

            modelBuilder.Entity<EgisOTB_Data>()
                .Property(e => e.Locator)
                .IsUnicode(false);

            modelBuilder.Entity<I_EGISOTB_Flight>()
                .Property(e => e.FlightNumber)
                .IsUnicode(false);

            modelBuilder.Entity<I_EGISOTB_Flight>()
                .Property(e => e.AirportDeparture)
                .IsUnicode(false);

            modelBuilder.Entity<I_EGISOTB_Flight>()
                .HasMany(e => e.I_EGISOTB_Passenger)
                .WithRequired(e => e.I_EGISOTB_Flight)
                .HasForeignKey(e => e.FlightID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<I_EGISOTB_Passenger>()
                .Property(e => e.CountryIssue)
                .IsUnicode(false);

            modelBuilder.Entity<I_EGISOTB_Passenger>()
                .Property(e => e.Sex)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<I_EGISOTB_Passenger>()
                .Property(e => e.FIOPassenger)
                .IsUnicode(false);

            modelBuilder.Entity<I_EGISOTB_Passenger>()
                .Property(e => e.Error)
                .IsUnicode(false);

            modelBuilder.Entity<Passenger1>()
                .Property(e => e.DocumentType)
                .IsUnicode(false);

            modelBuilder.Entity<Passenger1>()
                .Property(e => e.CountryIssue)
                .IsUnicode(false);

            modelBuilder.Entity<Passenger1>()
                .Property(e => e.DocumentNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Passenger1>()
                .Property(e => e.NationalIssue)
                .IsUnicode(false);

            modelBuilder.Entity<Passenger1>()
                .Property(e => e.Sex)
                .IsUnicode(false);

            modelBuilder.Entity<Passenger1>()
                .Property(e => e.FIOPassenger)
                .IsUnicode(false);

            modelBuilder.Entity<Passenger1>()
                .Property(e => e.Locator)
                .IsUnicode(false);

            modelBuilder.Entity<Passenger1>()
                .HasMany(e => e.PassengerFile_Passenger)
                .WithRequired(e => e.Passenger1)
                .HasForeignKey(e => e.PassengerID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Passenger1>()
                .HasMany(e => e.Passenger_FIO_RUS)
                .WithRequired(e => e.Passenger1)
                .HasForeignKey(e => e.PassengerID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Passenger_FIO_RUS>()
                .Property(e => e.LangCode)
                .IsUnicode(false);

            modelBuilder.Entity<Passenger_FIO_RUS>()
                .Property(e => e.FIO)
                .IsUnicode(false);

            modelBuilder.Entity<PassengerFile>()
                .Property(e => e.FileName)
                .IsUnicode(false);

            modelBuilder.Entity<PassengerFile>()
                .HasMany(e => e.PassengerFile_Passenger)
                .WithRequired(e => e.PassengerFile)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PassengerFile>()
                .HasMany(e => e.PassengerJournal)
                .WithRequired(e => e.PassengerFile)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PassengerFileType>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<PassengerFileType>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<PassengerFileType>()
                .HasMany(e => e.PassengerFile)
                .WithOptional(e => e.PassengerFileType)
                .HasForeignKey(e => e.TypeID);

            modelBuilder.Entity<PassengerFileType>()
                .HasMany(e => e.PassengerFileTypeExt)
                .WithRequired(e => e.PassengerFileType)
                .HasForeignKey(e => e.FileTypeID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PassengerFileTypeExt>()
                .Property(e => e.Ext)
                .IsUnicode(false);

            modelBuilder.Entity<PassengerJournal>()
                .Property(e => e.OperationType)
                .IsUnicode(false);

            modelBuilder.Entity<PassengerJournal>()
                .Property(e => e.DocumentType)
                .IsUnicode(false);

            modelBuilder.Entity<PassengerJournal>()
                .Property(e => e.CountryIssue)
                .IsUnicode(false);

            modelBuilder.Entity<PassengerJournal>()
                .Property(e => e.DocumentNumber)
                .IsUnicode(false);

            modelBuilder.Entity<PassengerJournal>()
                .Property(e => e.NationalIssue)
                .IsUnicode(false);

            modelBuilder.Entity<PassengerJournal>()
                .Property(e => e.Sex)
                .IsUnicode(false);

            modelBuilder.Entity<PassengerJournal>()
                .Property(e => e.FIOPassenger)
                .IsUnicode(false);

            modelBuilder.Entity<PassengerJournal>()
                .Property(e => e.FlightNumberIATA)
                .IsUnicode(false);

            modelBuilder.Entity<PassengerJournal>()
                .Property(e => e.AirportDeparture)
                .IsUnicode(false);

            modelBuilder.Entity<PassengerJournal>()
                .Property(e => e.Locator)
                .IsUnicode(false);

            modelBuilder.Entity<PassengerOperationType>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<PassengerOperationType>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<PassengerOperationType>()
                .HasMany(e => e.PassengerFile_Passenger)
                .WithRequired(e => e.PassengerOperationType)
                .HasForeignKey(e => e.OperationTypeID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ExportParameters>()
                .Property(e => e.Job)
                .IsUnicode(false);

            modelBuilder.Entity<ExportParameters>()
                .Property(e => e.Ndb)
                .HasPrecision(35, 0);

            modelBuilder.Entity<BorderProtectionScheduleChronometry>()
                .Property(e => e.Note)
                .IsUnicode(false);

            modelBuilder.Entity<ControlledPerson>()
                .HasMany(e => e.ControlledPersonOfficerHistory)
                .WithRequired(e => e.ControlledPerson)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ControlledPersonOfficerHistory>()
                .Property(e => e.ChangedDateTime)
                .HasPrecision(2);

            modelBuilder.Entity<InspectionCommittee>()
                .Property(e => e.CommitteeTypeID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<InspectionCommittee>()
                .HasMany(e => e.InspectionCommitteeMembers)
                .WithRequired(e => e.InspectionCommittee)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<InspectionCommitteeMembers>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<InspectionCommitteeMembers>()
                .Property(e => e.UserInfoID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<InspectionCommitteeMembers>()
                .Property(e => e.XUserTypeID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<InspectionCommitteeMembers>()
                .Property(e => e.XUserListID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<InspectionCommitteeMembers>()
                .Property(e => e.CommitteeStatusID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<ReinforcementStatus>()
                .HasMany(e => e.BorderProtectionScheduleReinforcement)
                .WithRequired(e => e.ReinforcementStatus)
                .HasForeignKey(e => e.Status)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Address>()
                .Property(e => e.Address1)
                .IsUnicode(false);

            modelBuilder.Entity<ArmGroup>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<ArmGroup>()
                .HasMany(e => e.Arm1)
                .WithMany(e => e.ArmGroup)
                .Map(m => m.ToTable("ArmGroup__Arm").MapLeftKey("ArmGroupID").MapRightKey("ArmId"));

            modelBuilder.Entity<InformJournal>()
                .Property(e => e.SenderName)
                .IsUnicode(false);

            modelBuilder.Entity<InformJournal>()
                .Property(e => e.NotificationType)
                .IsUnicode(false);

            modelBuilder.Entity<InformJournal>()
                .Property(e => e.Message)
                .IsUnicode(false);

            modelBuilder.Entity<InformJournalRecipient>()
                .Property(e => e.ArmName)
                .IsUnicode(false);

            modelBuilder.Entity<PresentationControl>()
                .Property(e => e.State)
                .IsUnicode(false);

            modelBuilder.Entity<PresentationControl>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<PresentationControl>()
                .Property(e => e.FileName)
                .IsUnicode(false);

            modelBuilder.Entity<PresentationControlRecipient>()
                .Property(e => e.ArmName)
                .IsUnicode(false);

            modelBuilder.Entity<Queue>()
                .Property(e => e.NotificationType)
                .IsUnicode(false);

            modelBuilder.Entity<Queue>()
                .Property(e => e.SenderName)
                .IsUnicode(false);

            modelBuilder.Entity<Queue>()
                .HasMany(e => e.Address)
                .WithRequired(e => e.Queue)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<agr_ArmSession>()
                .Property(e => e.ArmName)
                .IsUnicode(false);

            modelBuilder.Entity<agr_ArmSession>()
                .Property(e => e.FamilyName)
                .IsUnicode(false);

            modelBuilder.Entity<agr_ArmSession>()
                .Property(e => e.KaskadLoginName)
                .IsUnicode(false);

            modelBuilder.Entity<agr_ArmSession>()
                .Property(e => e.WindowsLoginName)
                .IsUnicode(false);

            modelBuilder.Entity<agr_ArmSession>()
                .Property(e => e.ТуреPing)
                .IsUnicode(false);

            modelBuilder.Entity<agr_ArmSessionHistory>()
                .Property(e => e.ArmName)
                .IsUnicode(false);

            modelBuilder.Entity<agr_ArmSessionHistory>()
                .Property(e => e.FamilyName)
                .IsUnicode(false);

            modelBuilder.Entity<agr_ArmSessionHistory>()
                .Property(e => e.KaskadLoginName)
                .IsUnicode(false);

            modelBuilder.Entity<agr_ArmSessionHistory>()
                .Property(e => e.WindowsLoginName)
                .IsUnicode(false);

            modelBuilder.Entity<agr_UserSession>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<AttachmentType>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<AttachmentType>()
                .HasMany(e => e.EventPhotoAttachments)
                .WithRequired(e => e.AttachmentType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AttachmentType>()
                .HasMany(e => e.EventVideoAttachment)
                .WithRequired(e => e.AttachmentType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AttachmentType>()
                .HasMany(e => e.EventPTKLogAttachment)
                .WithRequired(e => e.AttachmentType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CustomEventProperties>()
                .Property(e => e.CustomEventName)
                .IsUnicode(false);

            modelBuilder.Entity<CustomEventProperties>()
                .Property(e => e.Comment)
                .IsUnicode(false);

            modelBuilder.Entity<Employee_ReportGroup>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Employee_ReportGroup>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Employee_ReportGroup>()
                .HasMany(e => e.Employee_ReportGroup1)
                .WithOptional(e => e.Employee_ReportGroup2)
                .HasForeignKey(e => e.ParentID);

            modelBuilder.Entity<EventGroup>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<EventGroup>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<EventGroup>()
                .HasMany(e => e.EventRawType)
                .WithRequired(e => e.EventGroup)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EventGroup>()
                .HasMany(e => e.EventType)
                .WithRequired(e => e.EventGroup)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EventLog>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<EventLog>()
                .HasMany(e => e.CustomEventProperties)
                .WithRequired(e => e.EventLog)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EventLog>()
                .HasMany(e => e.EventPhotoAttachments)
                .WithRequired(e => e.EventLog)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EventLog>()
                .HasMany(e => e.EventPTKLogAttachment)
                .WithRequired(e => e.EventLog)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EventLog>()
                .HasMany(e => e.EventVideoAttachment)
                .WithRequired(e => e.EventLog)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EventLog>()
                .HasMany(e => e.Protocol1)
                .WithMany(e => e.EventLog1)
                .Map(m => m.ToTable("EventKSBEvent", "stat").MapLeftKey("EventId").MapRightKey("KsbEventId"));

            modelBuilder.Entity<EventLog>()
                .HasMany(e => e.EventLogRaw)
                .WithMany(e => e.EventLog)
                .Map(m => m.ToTable("EventLogRaw_EventLog", "stat").MapLeftKey("EventLogId").MapRightKey("EventLogRawID"));

            modelBuilder.Entity<EventLog>()
                .HasMany(e => e.MapObjects1)
                .WithMany(e => e.EventLog1)
                .Map(m => m.ToTable("EventMapObject", "stat").MapLeftKey("EventId").MapRightKey("MapObjectId"));

            modelBuilder.Entity<EventLog>()
                .HasMany(e => e.Passenger1)
                .WithMany(e => e.EventLog1)
                .Map(m => m.ToTable("EventPassenger", "stat").MapLeftKey("EventId").MapRightKey("PassengerId"));

            modelBuilder.Entity<EventPriority>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<EventPriority>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<EventPriority>()
                .HasMany(e => e.EventLog)
                .WithRequired(e => e.EventPriority)
                .HasForeignKey(e => e.PriorityId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EventPriority>()
                .HasMany(e => e.EventLogRaw)
                .WithRequired(e => e.EventPriority)
                .HasForeignKey(e => e.PriorityID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EventPriority>()
                .HasMany(e => e.EventRawType)
                .WithRequired(e => e.EventPriority)
                .HasForeignKey(e => e.DefaultPriorityID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EventPriority>()
                .HasMany(e => e.EventType)
                .WithRequired(e => e.EventPriority)
                .HasForeignKey(e => e.DefaultPriorityID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EventRawType>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<EventRawType>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<EventRawType>()
                .HasMany(e => e.ActivityMode)
                .WithOptional(e => e.EventRawType)
                .HasForeignKey(e => e.StartEventRawTypeId);

            modelBuilder.Entity<EventRawType>()
                .HasMany(e => e.ActivityMode1)
                .WithOptional(e => e.EventRawType1)
                .HasForeignKey(e => e.StopEventRawTypeId);

            modelBuilder.Entity<EventRawType>()
                .HasMany(e => e.EventLogRaw)
                .WithRequired(e => e.EventRawType)
                .HasForeignKey(e => e.EventTypeID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EventRawType>()
                .HasOptional(e => e.EventRawType__EventType)
                .WithRequired(e => e.EventRawType);

            modelBuilder.Entity<EventType>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<EventType>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<EventType>()
                .HasMany(e => e.EventLog)
                .WithRequired(e => e.EventType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MapObjectStateType>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<MapObjectStateType>()
                .HasMany(e => e.MapObjectState)
                .WithRequired(e => e.MapObjectStateType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MapObjectStateType>()
                .HasMany(e => e.MapObjectStateEndTime)
                .WithRequired(e => e.MapObjectStateType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MapObjectStateType>()
                .HasMany(e => e.MapObjectStateEventLogEndTime)
                .WithRequired(e => e.MapObjectStateType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SC_JobError>()
                .Property(e => e.Message)
                .IsUnicode(false);

            modelBuilder.Entity<SC_JobHistory>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<SC_JobHistory>()
                .HasMany(e => e.SC_JobError)
                .WithRequired(e => e.SC_JobHistory)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IM_ArriveDeparture>()
                .Property(e => e.ArrivalStationID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<IM_ArriveDeparture>()
                .Property(e => e.ArrivalStationName)
                .IsUnicode(false);

            modelBuilder.Entity<IM_ArriveDeparture>()
                .Property(e => e.BorderCrossingID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<IM_ArriveDeparture>()
                .Property(e => e.NationalityID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<IM_ArriveDeparture>()
                .Property(e => e.NationalityName)
                .IsUnicode(false);

            modelBuilder.Entity<IM_ArriveDeparture>()
                .Property(e => e.Family)
                .IsUnicode(false);

            modelBuilder.Entity<IM_ArriveDeparture>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<IM_ArriveDeparture>()
                .Property(e => e.DocumentCategoryName)
                .IsUnicode(false);

            modelBuilder.Entity<IM_ArriveDeparture>()
                .Property(e => e.DocumentRegisterCod)
                .IsUnicode(false);

            modelBuilder.Entity<IM_ArriveDeparture>()
                .Property(e => e.DocumentRegisterNumber)
                .IsUnicode(false);

            modelBuilder.Entity<IM_ArriveDeparture>()
                .Property(e => e.VisaTypeName)
                .IsUnicode(false);

            modelBuilder.Entity<IM_ArriveDeparture>()
                .Property(e => e.VisaCod)
                .IsUnicode(false);

            modelBuilder.Entity<IM_ArriveDeparture>()
                .Property(e => e.VisaNumber)
                .IsUnicode(false);

            modelBuilder.Entity<IM_ArriveDeparture>()
                .Property(e => e.VisaRegisterCod)
                .IsUnicode(false);

            modelBuilder.Entity<IM_ArriveDeparture>()
                .Property(e => e.VisaRegisterNumber)
                .IsUnicode(false);

            modelBuilder.Entity<IM_ArriveDeparture>()
                .Property(e => e.PurposeID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<IM_ArriveDeparture>()
                .Property(e => e.PurposeName)
                .IsUnicode(false);

            modelBuilder.Entity<IM_ArriveDeparture>()
                .Property(e => e.InvitationOrganization)
                .IsUnicode(false);

            modelBuilder.Entity<IM_ArriveDeparture>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<IM_ArriveNotDeparture>()
                .Property(e => e.ArrivalStationID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<IM_ArriveNotDeparture>()
                .Property(e => e.ArrivalStationName)
                .IsUnicode(false);

            modelBuilder.Entity<IM_ArriveNotDeparture>()
                .Property(e => e.BorderCrossingID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<IM_ArriveNotDeparture>()
                .Property(e => e.NationalityID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<IM_ArriveNotDeparture>()
                .Property(e => e.NationalityName)
                .IsUnicode(false);

            modelBuilder.Entity<IM_ArriveNotDeparture>()
                .Property(e => e.Family)
                .IsUnicode(false);

            modelBuilder.Entity<IM_ArriveNotDeparture>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<IM_ArriveNotDeparture>()
                .Property(e => e.DocumentCategoryName)
                .IsUnicode(false);

            modelBuilder.Entity<IM_ArriveNotDeparture>()
                .Property(e => e.DocumentRegisterCod)
                .IsUnicode(false);

            modelBuilder.Entity<IM_ArriveNotDeparture>()
                .Property(e => e.DocumentRegisterNumber)
                .IsUnicode(false);

            modelBuilder.Entity<IM_ArriveNotDeparture>()
                .Property(e => e.VisaTypeName)
                .IsUnicode(false);

            modelBuilder.Entity<IM_ArriveNotDeparture>()
                .Property(e => e.VisaCod)
                .IsUnicode(false);

            modelBuilder.Entity<IM_ArriveNotDeparture>()
                .Property(e => e.VisaNumber)
                .IsUnicode(false);

            modelBuilder.Entity<IM_ArriveNotDeparture>()
                .Property(e => e.VisaRegisterCod)
                .IsUnicode(false);

            modelBuilder.Entity<IM_ArriveNotDeparture>()
                .Property(e => e.VisaRegisterNumber)
                .IsUnicode(false);

            modelBuilder.Entity<IM_ArriveNotDeparture>()
                .Property(e => e.PurposeID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<IM_ArriveNotDeparture>()
                .Property(e => e.PurposeName)
                .IsUnicode(false);

            modelBuilder.Entity<IM_ArriveNotDeparture>()
                .Property(e => e.InvitationOrganization)
                .IsUnicode(false);

            modelBuilder.Entity<IM_ArriveNotDeparture>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<IM_NotArriveDeparture>()
                .Property(e => e.ArrivalStationID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<IM_NotArriveDeparture>()
                .Property(e => e.ArrivalStationName)
                .IsUnicode(false);

            modelBuilder.Entity<IM_NotArriveDeparture>()
                .Property(e => e.BorderCrossingID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<IM_NotArriveDeparture>()
                .Property(e => e.NationalityID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<IM_NotArriveDeparture>()
                .Property(e => e.NationalityName)
                .IsUnicode(false);

            modelBuilder.Entity<IM_NotArriveDeparture>()
                .Property(e => e.Family)
                .IsUnicode(false);

            modelBuilder.Entity<IM_NotArriveDeparture>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<IM_NotArriveDeparture>()
                .Property(e => e.DocumentCategoryName)
                .IsUnicode(false);

            modelBuilder.Entity<IM_NotArriveDeparture>()
                .Property(e => e.DocumentRegisterCod)
                .IsUnicode(false);

            modelBuilder.Entity<IM_NotArriveDeparture>()
                .Property(e => e.DocumentRegisterNumber)
                .IsUnicode(false);

            modelBuilder.Entity<IM_NotArriveDeparture>()
                .Property(e => e.VisaTypeName)
                .IsUnicode(false);

            modelBuilder.Entity<IM_NotArriveDeparture>()
                .Property(e => e.VisaCod)
                .IsUnicode(false);

            modelBuilder.Entity<IM_NotArriveDeparture>()
                .Property(e => e.VisaNumber)
                .IsUnicode(false);

            modelBuilder.Entity<IM_NotArriveDeparture>()
                .Property(e => e.VisaRegisterCod)
                .IsUnicode(false);

            modelBuilder.Entity<IM_NotArriveDeparture>()
                .Property(e => e.VisaRegisterNumber)
                .IsUnicode(false);

            modelBuilder.Entity<IM_NotArriveDeparture>()
                .Property(e => e.PurposeID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<IM_NotArriveDeparture>()
                .Property(e => e.PurposeName)
                .IsUnicode(false);

            modelBuilder.Entity<IM_NotArriveDeparture>()
                .Property(e => e.InvitationOrganization)
                .IsUnicode(false);

            modelBuilder.Entity<IM_NotArriveDeparture>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<IM_Prepared>()
                .Property(e => e.TimeShearID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<IM_Prepared>()
                .Property(e => e.ArrivalStationID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<IM_Prepared>()
                .Property(e => e.ArrivalStationName)
                .IsUnicode(false);

            modelBuilder.Entity<IM_Prepared>()
                .Property(e => e.BorderCrossingID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<IM_Prepared>()
                .Property(e => e.IdentifyDocumentID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<IM_Prepared>()
                .Property(e => e.InscribeID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<IM_Prepared>()
                .Property(e => e.BorderRoutingID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<IM_Prepared>()
                .Property(e => e.NationalityID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<IM_Prepared>()
                .Property(e => e.NationalityName)
                .IsUnicode(false);

            modelBuilder.Entity<IM_Prepared>()
                .Property(e => e.DocumentCategoryName)
                .IsUnicode(false);

            modelBuilder.Entity<IM_Prepared>()
                .Property(e => e.DocumentRegisterCod)
                .IsUnicode(false);

            modelBuilder.Entity<IM_Prepared>()
                .Property(e => e.DocumentRegisterNumber)
                .IsUnicode(false);

            modelBuilder.Entity<IM_Prepared>()
                .Property(e => e.VisaCod)
                .IsUnicode(false);

            modelBuilder.Entity<IM_Prepared>()
                .Property(e => e.VisaNumber)
                .IsUnicode(false);

            modelBuilder.Entity<IM_Prepared>()
                .Property(e => e.VisaRegisterCod)
                .IsUnicode(false);

            modelBuilder.Entity<IM_Prepared>()
                .Property(e => e.VisaRegisterNumber)
                .IsUnicode(false);

            modelBuilder.Entity<IM_Prepared>()
                .Property(e => e.Family)
                .IsUnicode(false);

            modelBuilder.Entity<IM_Prepared>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<IM_Prepared>()
                .Property(e => e.FBirthday)
                .HasPrecision(1, 0);

            modelBuilder.Entity<IM_Prepared>()
                .Property(e => e.Sex)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<IM_Prepared>()
                .Property(e => e.VisaTypeName)
                .IsUnicode(false);

            modelBuilder.Entity<IM_Prepared>()
                .Property(e => e.BorderRoutingName)
                .IsUnicode(false);

            modelBuilder.Entity<IM_Prepared>()
                .Property(e => e.InvitationOrganization)
                .IsUnicode(false);

            modelBuilder.Entity<IM_Prepared>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<IM_Prepared>()
                .Property(e => e.PurposeID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<IM_Prepared>()
                .Property(e => e.PurposeName)
                .IsUnicode(false);

            modelBuilder.Entity<Setting>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<BorderCrossingHistory>()
                .Property(e => e.Arm)
                .IsUnicode(false);

            modelBuilder.Entity<BorderCrossingHistory>()
                .Property(e => e.DocumentBlankNumber)
                .IsUnicode(false);

            modelBuilder.Entity<BorderCrossingHistory>()
                .Property(e => e.DocumentIssueOrganization)
                .IsUnicode(false);

            modelBuilder.Entity<BorderCrossingHistory>()
                .Property(e => e.DocumentNumber)
                .IsUnicode(false);

            modelBuilder.Entity<BorderCrossingHistory>()
                .Property(e => e.DocumentSeria)
                .IsUnicode(false);

            modelBuilder.Entity<BorderCrossingHistory>()
                .Property(e => e.FamilyLat)
                .IsUnicode(false);

            modelBuilder.Entity<BorderCrossingHistory>()
                .Property(e => e.FamilyRus)
                .IsUnicode(false);

            modelBuilder.Entity<BorderCrossingHistory>()
                .Property(e => e.FlightNumber)
                .IsUnicode(false);

            modelBuilder.Entity<BorderCrossingHistory>()
                .Property(e => e.NameLat)
                .IsUnicode(false);

            modelBuilder.Entity<BorderCrossingHistory>()
                .Property(e => e.NameRus)
                .IsUnicode(false);

            modelBuilder.Entity<BorderCrossingHistory>()
                .Property(e => e.OperatorPC)
                .IsUnicode(false);

            modelBuilder.Entity<BorderCrossingHistory>()
                .Property(e => e.Sex)
                .IsUnicode(false);

            modelBuilder.Entity<BorderCrossingHistoryLight>()
                .Property(e => e.Arm)
                .IsUnicode(false);

            modelBuilder.Entity<BorderCrossingHistoryLight>()
                .Property(e => e.FamilyLat)
                .IsUnicode(false);

            modelBuilder.Entity<BorderCrossingHistoryLight>()
                .Property(e => e.FamilyRus)
                .IsUnicode(false);

            modelBuilder.Entity<BorderCrossingHistoryLight>()
                .Property(e => e.FlightNumber)
                .IsUnicode(false);

            modelBuilder.Entity<BorderCrossingHistoryLight>()
                .Property(e => e.NameLat)
                .IsUnicode(false);

            modelBuilder.Entity<BorderCrossingHistoryLight>()
                .Property(e => e.NameRus)
                .IsUnicode(false);

            modelBuilder.Entity<BorderCrossingHistoryLight>()
                .Property(e => e.OperatorPC)
                .IsUnicode(false);

            modelBuilder.Entity<BorderCrossingHistoryLight>()
                .Property(e => e.Sex)
                .IsUnicode(false);

            modelBuilder.Entity<ILBorderCrossing>()
                .Property(e => e.ArrivalStation)
                .IsUnicode(false);

            modelBuilder.Entity<ILBorderCrossing>()
                .Property(e => e.Arm)
                .IsUnicode(false);

            modelBuilder.Entity<ILBorderCrossing>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<ILBorderCrossing>()
                .Property(e => e.Comment)
                .IsUnicode(false);

            modelBuilder.Entity<ILBorderCrossing>()
                .Property(e => e.DocumentNumber)
                .IsUnicode(false);

            modelBuilder.Entity<ILBorderCrossing>()
                .Property(e => e.FioLat)
                .IsUnicode(false);

            modelBuilder.Entity<ILBorderCrossing>()
                .Property(e => e.FioRus)
                .IsUnicode(false);

            modelBuilder.Entity<ILBorderCrossing>()
                .Property(e => e.Flight)
                .IsUnicode(false);

            modelBuilder.Entity<ILBorderCrossing>()
                .Property(e => e.Operator)
                .IsUnicode(false);

            modelBuilder.Entity<ILBorderCrossing>()
                .Property(e => e.OperatorPC)
                .IsUnicode(false);

            modelBuilder.Entity<ILBorderCrossing>()
                .Property(e => e.Sex)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ILBorderCrossing>()
                .Property(e => e.StatusOpk)
                .IsUnicode(false);

            modelBuilder.Entity<ILPassportRead>()
                .Property(e => e.ArrivalStation)
                .IsUnicode(false);

            modelBuilder.Entity<ILPassportRead>()
                .Property(e => e.Arm)
                .IsUnicode(false);

            modelBuilder.Entity<ILPassportRead>()
                .Property(e => e.Citizenship)
                .IsUnicode(false);

            modelBuilder.Entity<ILPassportRead>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<ILPassportRead>()
                .Property(e => e.Comment)
                .IsUnicode(false);

            modelBuilder.Entity<ILPassportRead>()
                .Property(e => e.DocumentCategoryIcao)
                .IsUnicode(false);

            modelBuilder.Entity<ILPassportRead>()
                .Property(e => e.DocumentNumber)
                .IsUnicode(false);

            modelBuilder.Entity<ILPassportRead>()
                .Property(e => e.FioLat)
                .IsUnicode(false);

            modelBuilder.Entity<ILPassportRead>()
                .Property(e => e.FioRus)
                .IsUnicode(false);

            modelBuilder.Entity<ILPassportRead>()
                .Property(e => e.Flight)
                .IsUnicode(false);

            modelBuilder.Entity<ILPassportRead>()
                .Property(e => e.Operator)
                .IsUnicode(false);

            modelBuilder.Entity<ILPassportRead>()
                .Property(e => e.OperatorPC)
                .IsUnicode(false);

            modelBuilder.Entity<ILPassportRead>()
                .Property(e => e.Sex)
                .IsUnicode(false);

            modelBuilder.Entity<ILPassportRead>()
                .Property(e => e.StatusOpk)
                .IsUnicode(false);

            modelBuilder.Entity<ILPersonControl>()
                .Property(e => e.ArrivalStation)
                .IsUnicode(false);

            modelBuilder.Entity<ILPersonControl>()
                .Property(e => e.Arm)
                .IsUnicode(false);

            modelBuilder.Entity<ILPersonControl>()
                .Property(e => e.Citizenship)
                .IsUnicode(false);

            modelBuilder.Entity<ILPersonControl>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<ILPersonControl>()
                .Property(e => e.Comment)
                .IsUnicode(false);

            modelBuilder.Entity<ILPersonControl>()
                .Property(e => e.DocumentCategoryIcao)
                .IsUnicode(false);

            modelBuilder.Entity<ILPersonControl>()
                .Property(e => e.DocumentNumber)
                .IsUnicode(false);

            modelBuilder.Entity<ILPersonControl>()
                .Property(e => e.FioLat)
                .IsUnicode(false);

            modelBuilder.Entity<ILPersonControl>()
                .Property(e => e.FioRus)
                .IsUnicode(false);

            modelBuilder.Entity<ILPersonControl>()
                .Property(e => e.Flight)
                .IsUnicode(false);

            modelBuilder.Entity<ILPersonControl>()
                .Property(e => e.Operator)
                .IsUnicode(false);

            modelBuilder.Entity<ILPersonControl>()
                .Property(e => e.OperatorPC)
                .IsUnicode(false);

            modelBuilder.Entity<ILPersonControl>()
                .Property(e => e.Sex)
                .IsUnicode(false);

            modelBuilder.Entity<ILPersonControl>()
                .Property(e => e.StatusOpk)
                .IsUnicode(false);

            modelBuilder.Entity<ILPersonRegistration>()
                .Property(e => e.ArrivalStation)
                .IsUnicode(false);

            modelBuilder.Entity<ILPersonRegistration>()
                .Property(e => e.Arm)
                .IsUnicode(false);

            modelBuilder.Entity<ILPersonRegistration>()
                .Property(e => e.Citizenship)
                .IsUnicode(false);

            modelBuilder.Entity<ILPersonRegistration>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<ILPersonRegistration>()
                .Property(e => e.Comment)
                .IsUnicode(false);

            modelBuilder.Entity<ILPersonRegistration>()
                .Property(e => e.DocumentCategoryIcao)
                .IsUnicode(false);

            modelBuilder.Entity<ILPersonRegistration>()
                .Property(e => e.DocumentNumber)
                .IsUnicode(false);

            modelBuilder.Entity<ILPersonRegistration>()
                .Property(e => e.FioLat)
                .IsUnicode(false);

            modelBuilder.Entity<ILPersonRegistration>()
                .Property(e => e.FioRus)
                .IsUnicode(false);

            modelBuilder.Entity<ILPersonRegistration>()
                .Property(e => e.Flight)
                .IsUnicode(false);

            modelBuilder.Entity<ILPersonRegistration>()
                .Property(e => e.Operator)
                .IsUnicode(false);

            modelBuilder.Entity<ILPersonRegistration>()
                .Property(e => e.OperatorPC)
                .IsUnicode(false);

            modelBuilder.Entity<ILPersonRegistration>()
                .Property(e => e.Sex)
                .IsUnicode(false);

            modelBuilder.Entity<ILPersonRegistration>()
                .Property(e => e.StatusOpk)
                .IsUnicode(false);

            modelBuilder.Entity<V_Forpost2MQT>()
                .Property(e => e.Sex)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<V_Forpost2MQT>()
                .Property(e => e.Litera)
                .IsUnicode(false);

            modelBuilder.Entity<V_ForpostErrors>()
                .Property(e => e.FIORus)
                .IsUnicode(false);

            modelBuilder.Entity<V_ForpostErrors>()
                .Property(e => e.FIOLat)
                .IsUnicode(false);

            modelBuilder.Entity<V_ForpostErrors>()
                .Property(e => e.NationalIssue)
                .IsUnicode(false);

            modelBuilder.Entity<V_ForpostErrors>()
                .Property(e => e.Document)
                .IsUnicode(false);

            modelBuilder.Entity<V_ForpostErrors>()
                .Property(e => e.Airline)
                .IsUnicode(false);

            modelBuilder.Entity<V_ForpostErrors>()
                .Property(e => e.FlightNumber)
                .IsUnicode(false);

            modelBuilder.Entity<V_ForpostErrors>()
                .Property(e => e.Airport)
                .IsUnicode(false);

            modelBuilder.Entity<V_ForpostJournal>()
                .Property(e => e.FileTypeName)
                .IsUnicode(false);

            modelBuilder.Entity<V_ForpostJournal>()
                .Property(e => e.FileName)
                .IsUnicode(false);

            modelBuilder.Entity<V_ForpostMQT>()
                .Property(e => e.FioRus)
                .IsUnicode(false);

            modelBuilder.Entity<V_ForpostMQT>()
                .Property(e => e.FioLat)
                .IsUnicode(false);

            modelBuilder.Entity<V_ForpostMQT>()
                .Property(e => e.CitizenshipIcao)
                .IsUnicode(false);

            modelBuilder.Entity<V_ForpostMQT>()
                .Property(e => e.Sex)
                .IsUnicode(false);

            modelBuilder.Entity<V_FoundPerson>()
                .Property(e => e.FIOPassenger_RUS)
                .IsUnicode(false);

            modelBuilder.Entity<V_FoundPerson>()
                .Property(e => e.FIOPassenger)
                .IsUnicode(false);

            modelBuilder.Entity<V_FoundPerson>()
                .Property(e => e.Airline)
                .IsUnicode(false);

            modelBuilder.Entity<V_FoundPerson>()
                .Property(e => e.Checked)
                .IsUnicode(false);

            modelBuilder.Entity<V_FoundPerson>()
                .Property(e => e.FlightNumber)
                .IsUnicode(false);

            modelBuilder.Entity<V_FoundPerson>()
                .Property(e => e.Note)
                .IsUnicode(false);

            modelBuilder.Entity<V_FoundPerson>()
                .Property(e => e.Citizenship)
                .IsUnicode(false);

            modelBuilder.Entity<V_FoundPerson>()
                .Property(e => e.Document)
                .IsUnicode(false);

            modelBuilder.Entity<V_FoundPerson>()
                .Property(e => e.AirportDepartureCode)
                .IsUnicode(false);

            modelBuilder.Entity<V_PossibleAliens>()
                .Property(e => e.FioRus)
                .IsUnicode(false);

            modelBuilder.Entity<V_PossibleAliens>()
                .Property(e => e.FioLat)
                .IsUnicode(false);

            modelBuilder.Entity<V_PossibleAliens>()
                .Property(e => e.CitizenshipIcao)
                .IsUnicode(false);

            modelBuilder.Entity<V_PossibleAliens>()
                .Property(e => e.Sex)
                .IsUnicode(false);

            modelBuilder.Entity<V_PossibleAliens>()
                .Property(e => e.Note)
                .IsUnicode(false);

            modelBuilder.Entity<V_PossibleAliens>()
                .Property(e => e.Checked)
                .IsUnicode(false);

            modelBuilder.Entity<V_Resemblance_OU>()
                .Property(e => e.FIO)
                .IsUnicode(false);

            modelBuilder.Entity<V_Resemblance_OU>()
                .Property(e => e.BirthDate)
                .IsUnicode(false);

            modelBuilder.Entity<V_Resemblance_OU>()
                .Property(e => e.Sex)
                .IsUnicode(false);

            modelBuilder.Entity<V_Resemblance_OU>()
                .Property(e => e.Job)
                .IsUnicode(false);

            modelBuilder.Entity<V_Resemblance_OU>()
                .Property(e => e.Comment)
                .IsUnicode(false);

            modelBuilder.Entity<V_Resemblance_OU>()
                .Property(e => e.Country)
                .IsUnicode(false);

            modelBuilder.Entity<V_RevealExport>()
                .Property(e => e.Airline)
                .IsUnicode(false);

            modelBuilder.Entity<V_RevealExport>()
                .Property(e => e.ContactEmail)
                .IsUnicode(false);

            modelBuilder.Entity<V_RevealExport>()
                .Property(e => e.Operator)
                .IsUnicode(false);

            modelBuilder.Entity<V_RevealExport>()
                .Property(e => e.Job)
                .IsUnicode(false);

            modelBuilder.Entity<V_SearchPerson>()
                .Property(e => e.CitizenshipIcao)
                .IsUnicode(false);

            modelBuilder.Entity<V_SearchPerson>()
                .Property(e => e.Sex)
                .IsUnicode(false);

            modelBuilder.Entity<V_SearchPerson>()
                .Property(e => e.Fio)
                .IsUnicode(false);

            modelBuilder.Entity<V_WorkScheduleAliens>()
                .Property(e => e.PlanPassenger_FIORUS)
                .IsUnicode(false);

            modelBuilder.Entity<V_WorkScheduleAliens>()
                .Property(e => e.PlanPassenger_Citizenship)
                .IsUnicode(false);

            modelBuilder.Entity<V_WorkScheduleAliens>()
                .Property(e => e.Checked)
                .IsUnicode(false);

            modelBuilder.Entity<V_WorkScheduleAliens>()
                .Property(e => e.Enemy_PlanPassenger_FIORUS)
                .IsUnicode(false);

            modelBuilder.Entity<V_WorkScheduleAliens>()
                .Property(e => e.Enemy_PlanPassenger_Citizenship)
                .IsUnicode(false);

            modelBuilder.Entity<V_WorkScheduleAliens>()
                .Property(e => e.FlightNumberIATA)
                .IsUnicode(false);

            modelBuilder.Entity<spk_VPassengerMaterialized>()
                .Property(e => e.IdentifyDocumentID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<spk_VPassengerMaterialized>()
                .Property(e => e.RegisterCod)
                .IsUnicode(false);

            modelBuilder.Entity<spk_VPassengerMaterialized>()
                .Property(e => e.RegisterNumber)
                .IsUnicode(false);

            modelBuilder.Entity<spk_VPassengerMaterialized>()
                .Property(e => e.NumericRegisterNumber)
                .HasPrecision(18, 0);

            modelBuilder.Entity<spk_VPassengerMaterialized>()
                .Property(e => e.DocumentCategoryID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<spk_VPassengerMaterialized>()
                .Property(e => e.InscribeID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<spk_VPassengerMaterialized>()
                .Property(e => e.Family)
                .IsUnicode(false);

            modelBuilder.Entity<spk_VPassengerMaterialized>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<spk_VPassengerMaterialized>()
                .Property(e => e.FamilyLatin)
                .IsUnicode(false);

            modelBuilder.Entity<spk_VPassengerMaterialized>()
                .Property(e => e.NameLatin)
                .IsUnicode(false);

            modelBuilder.Entity<spk_VPassengerMaterialized>()
                .Property(e => e.NationalityID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<spk_VPassengerMaterialized>()
                .Property(e => e.FBirthday)
                .HasPrecision(1, 0);

            modelBuilder.Entity<spk_VPassengerMaterialized>()
                .Property(e => e.Sex)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<spk_VPassengerMaterialized>()
                .Property(e => e.BorderCrossingID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<spk_VPassengerMaterialized>()
                .Property(e => e.CrossingLabelID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<spk_VPassengerMaterialized>()
                .Property(e => e.AddedMakeID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<spk_VPassengerMaterialized>()
                .Property(e => e.ArrivalStationID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<spk_VPassengerMaterialized>()
                .Property(e => e.PassengerTypeID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<spk_VPassengerMaterialized>()
                .Property(e => e.BorderRoutingID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<spk_VPassengerMaterialized>()
                .Property(e => e.DecisionID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<spk_VPassengerMaterialized>()
                .Property(e => e.OperationID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<spk_VPassengerMaterialized>()
                .Property(e => e.UserInfoID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<spk_VPassengerMaterialized>()
                .Property(e => e.PurposeID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<spk_VPassengerMaterialized>()
                .Property(e => e.FlightID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<v_cmOperatorStat>()
                .Property(e => e.BorderCrossingID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<v_cmOperatorStat>()
                .Property(e => e.UserInfoID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<v_cmOperatorStat>()
                .Property(e => e.ComputerName)
                .IsUnicode(false);

            modelBuilder.Entity<v_cmOperatorStat>()
                .Property(e => e.LoginName)
                .IsUnicode(false);

            modelBuilder.Entity<VUserInfo_UI>()
                .Property(e => e.Id)
                .HasPrecision(35, 0);

            modelBuilder.Entity<VUserInfo_UI>()
                .Property(e => e.LoginName)
                .IsUnicode(false);

            modelBuilder.Entity<VUserInfo_UI>()
                .Property(e => e.Family)
                .IsUnicode(false);

            modelBuilder.Entity<VUserInfo_UI>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<VUserInfo_UI>()
                .Property(e => e.StampNumber)
                .IsUnicode(false);

            modelBuilder.Entity<VUserInfo_UI>()
                .Property(e => e.Subdivision)
                .IsUnicode(false);

            modelBuilder.Entity<VUserInfo_UI>()
                .Property(e => e.Position)
                .IsUnicode(false);

            modelBuilder.Entity<VUserInfo_UI>()
                .Property(e => e.Rank)
                .IsUnicode(false);

            modelBuilder.Entity<v_ARM>()
                .Property(e => e.EmployeeFullName)
                .IsUnicode(false);

            modelBuilder.Entity<v_Flight>()
                .Property(e => e.FlightNumber)
                .IsUnicode(false);

            modelBuilder.Entity<v_Flight>()
                .Property(e => e.FlightNumberIATA)
                .IsUnicode(false);

            modelBuilder.Entity<v_Flight>()
                .Property(e => e.FlightNumberINT)
                .IsUnicode(false);

            modelBuilder.Entity<v_Flight>()
                .Property(e => e.Airport)
                .IsUnicode(false);

            modelBuilder.Entity<v_Flight>()
                .Property(e => e.acType)
                .IsUnicode(false);

            modelBuilder.Entity<v_Flight>()
                .Property(e => e.flId)
                .IsUnicode(false);

            modelBuilder.Entity<v_GroupLanguageFixed>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<v_GroupLanguageStatistic>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<v_LanguageGroupCabin>()
                .Property(e => e.CabinNumber)
                .IsUnicode(false);

            modelBuilder.Entity<v_Control>()
                .Property(e => e.Direction)
                .IsUnicode(false);

            modelBuilder.Entity<v_Control>()
                .Property(e => e.Sex)
                .IsUnicode(false);

            modelBuilder.Entity<v_Control>()
                .Property(e => e.Citizenship)
                .IsUnicode(false);

            modelBuilder.Entity<v_Control>()
                .Property(e => e.FligthNumber)
                .IsUnicode(false);

            modelBuilder.Entity<v_Control>()
                .Property(e => e.FIO_RUS)
                .IsUnicode(false);

            modelBuilder.Entity<v_Control>()
                .Property(e => e.FIO)
                .IsUnicode(false);

            modelBuilder.Entity<v_Control>()
                .Property(e => e.DocumNumber)
                .IsUnicode(false);

            modelBuilder.Entity<v_Control>()
                .Property(e => e.DocumentCategory)
                .IsUnicode(false);

            modelBuilder.Entity<v_Control>()
                .Property(e => e.TypeDocument)
                .IsUnicode(false);

            modelBuilder.Entity<v_Control>()
                .Property(e => e.CrossingLabelID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<v_FIO>()
                .Property(e => e.Direction)
                .IsUnicode(false);

            modelBuilder.Entity<v_FIO>()
                .Property(e => e.Sex)
                .IsUnicode(false);

            modelBuilder.Entity<v_FIO>()
                .Property(e => e.Citizenship)
                .IsUnicode(false);

            modelBuilder.Entity<v_FIO>()
                .Property(e => e.DocumentNumber)
                .IsUnicode(false);

            modelBuilder.Entity<v_FIO>()
                .Property(e => e.DocumentCategory)
                .IsUnicode(false);

            modelBuilder.Entity<v_FIO>()
                .Property(e => e.FIO)
                .IsUnicode(false);

            modelBuilder.Entity<v_FIO>()
                .Property(e => e.FIO_RUS)
                .IsUnicode(false);

            modelBuilder.Entity<v_FIO>()
                .Property(e => e.CrossingLabelID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<v_Registration>()
                .Property(e => e.BorderCrossing_ID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<v_Registration>()
                .Property(e => e.Arm)
                .IsUnicode(false);

            modelBuilder.Entity<v_Registration>()
                .Property(e => e.OperatorPC)
                .IsUnicode(false);

            modelBuilder.Entity<v_Registration>()
                .Property(e => e.Direction)
                .IsUnicode(false);

            modelBuilder.Entity<v_Registration>()
                .Property(e => e.FIO_RUS)
                .IsUnicode(false);

            modelBuilder.Entity<v_Registration>()
                .Property(e => e.FIO)
                .IsUnicode(false);

            modelBuilder.Entity<v_Registration>()
                .Property(e => e.Sex)
                .IsUnicode(false);

            modelBuilder.Entity<v_Registration>()
                .Property(e => e.DocumentNumber)
                .IsUnicode(false);

            modelBuilder.Entity<v_Registration>()
                .Property(e => e.Citizenship)
                .IsUnicode(false);

            modelBuilder.Entity<v_Registration>()
                .Property(e => e.DocumentCategory)
                .IsUnicode(false);

            modelBuilder.Entity<v_Registration>()
                .Property(e => e.CrossingLabelID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<V_OU_List_History>()
                .Property(e => e.HashKey)
                .IsFixedLength();

            modelBuilder.Entity<V_OU_List_History>()
                .Property(e => e.FIO)
                .IsUnicode(false);

            modelBuilder.Entity<V_OU_List_History>()
                .Property(e => e.BirthDate)
                .IsUnicode(false);

            modelBuilder.Entity<V_OU_List_History>()
                .Property(e => e.Country)
                .IsUnicode(false);

            modelBuilder.Entity<V_OU_List_History>()
                .Property(e => e.Sex)
                .IsUnicode(false);

            modelBuilder.Entity<V_OU_List_History>()
                .Property(e => e.Job)
                .IsUnicode(false);

            modelBuilder.Entity<V_OU_List_History>()
                .Property(e => e.Note)
                .IsUnicode(false);

            modelBuilder.Entity<V_OU_List_History>()
                .Property(e => e.Oper)
                .HasPrecision(35, 0);

            modelBuilder.Entity<V_OU_List_History>()
                .Property(e => e.Comment)
                .IsUnicode(false);

            modelBuilder.Entity<V_OU_List_History>()
                .Property(e => e.Ndb)
                .HasPrecision(35, 0);

            modelBuilder.Entity<OperatorStatistics>()
                .Property(e => e.UserLogin)
                .IsUnicode(false);

            modelBuilder.Entity<OperatorStatistics>()
                .Property(e => e.BorderCrossing_ID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<v_Passenger_FIO_RUS>()
                .Property(e => e.Sex)
                .IsUnicode(false);

            modelBuilder.Entity<v_Passenger_FIO_RUS>()
                .Property(e => e.FIO)
                .IsUnicode(false);

            modelBuilder.Entity<v_Passenger_FIO_RUS>()
                .Property(e => e.LangCode)
                .IsUnicode(false);

            modelBuilder.Entity<v_Passenger_FIO_RUS>()
                .Property(e => e.FIO_RUS)
                .IsUnicode(false);

            modelBuilder.Entity<v_Authorization>()
                .Property(e => e.UserLogin)
                .IsUnicode(false);

            modelBuilder.Entity<v_Authorization>()
                .Property(e => e.NameComp)
                .IsUnicode(false);

            modelBuilder.Entity<v_Authorization>()
                .Property(e => e.NameUser)
                .IsUnicode(false);

            modelBuilder.Entity<v_Authorization>()
                .Property(e => e.UserInfoID)
                .HasPrecision(35, 0);

            modelBuilder.Entity<v_KaskadControlledPerson>()
                .Property(e => e.Direction)
                .IsUnicode(false);

            modelBuilder.Entity<v_KaskadControlledPerson>()
                .Property(e => e.Family)
                .IsUnicode(false);

            modelBuilder.Entity<v_KaskadControlledPerson>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<v_KaskadControlledPerson>()
                .Property(e => e.Dul)
                .IsUnicode(false);

            modelBuilder.Entity<v_KaskadControlledPerson>()
                .Property(e => e.FlightNumber)
                .IsUnicode(false);

            modelBuilder.Entity<v_KaskadControlledPerson>()
                .Property(e => e.Decision)
                .IsUnicode(false);

            modelBuilder.Entity<v_KaskadFlight>()
                .Property(e => e.Direction)
                .IsUnicode(false);

            modelBuilder.Entity<v_KaskadFlight>()
                .Property(e => e.FlightNumber)
                .IsUnicode(false);

            modelBuilder.Entity<v_ResultsControlAll>()
                .Property(e => e.CabinNumber)
                .IsUnicode(false);

            modelBuilder.Entity<v_ResultsControlCabin>()
                .Property(e => e.CabinNumber)
                .IsUnicode(false);

            modelBuilder.Entity<v_ArmGroup>()
                .Property(e => e.EmployeeFullName)
                .IsUnicode(false);

            modelBuilder.Entity<v_ArmGroup>()
                .Property(e => e.ArmGroupName)
                .IsUnicode(false);

            modelBuilder.Entity<v_EventLog>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<v_EventVideoAttachment>()
                .Property(e => e.FileName)
                .IsUnicode(false);
        }
    }
}
