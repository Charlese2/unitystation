internal enum MessageTypes : short
{
	//Server messages - 1xxx
	GibMessage = 1000,
	PlayParticleMessage = 1001,
	UpdateChatMessage = 1002,
	UpdateConnectedPlayersMessage = 1003,
	UpdateRoundTimeMessage = 1004,
	UpdateItemSlotMessage = 1005,
	UpdateUIMessage = 1006,
	FollowCameraMessage = 1007,
	ForceJobListUpdateMessage = 1008,
	TransformStateMessage = 1009,
	PlayerDeathMessage = 1010,
	InfoWindowMessage = 1011,
	PlayerMoveMessage = 1012,
	MatrixMoveMessage = 1013,
	ShootMessage = 1014,
	TabUpdateMessage = 1015,
	DoorUpdateMessage = 1016,
	AnnouncementMessage = 1017,
	TileChangesNewClientSync = 1018,
	PlaySoundMessage = 1019,
	ProgressBarMessage = 1020,
	PaperUpdateMessage = 1021,
	StorageObjectSyncMessage = 1022,
	MobMeleeLerpMessage = 1023,
	PlantTrayMessage = 1024, //is temporary Will be replaced by Network sprites Animations
	ElectricalStatsMessage = 1025,
	InformPull = 1026,
	HealthOverallStats = 1027,
	HealthConsciousState = 1028,
	HealthRespiratoryStats = 1029,
	HealthBloodStats = 1030,
	HealthBrainStats = 1031,
	HealthBodyPartStats = 1032,
	TriggerEvent = 1033,
	Suicide = 1034,
	PlayerUprightMessage = 1035,
	ElectricalCableMessage = 1036,
	HealthTemperatureStats = 1037,
	HealthPressureStats = 1038,
	PlayerAppearanceMessage = 1039,
	PlayerCustomisationMessage = 1040,
	BookNetMessage = 1041,
	BookshelfNetMessage = 1042,
	SubBookshelfNetMessage = 1043,
	UpdateCountdownMessage = 1044,
	ObserveInteractableStorage = 1045,
	ServerToClientEvents = 1046,
	SendClientLog = 1047,
	AdminEnableMessage = 1048,
	AdminToolRefreshMessage = 1049,
	AdminBwoinkMessage = 1050,
	PlayAmbientTrack = 1051,
	UpdateHungerStateMessage = 1052,
	SetActionUI = 1053,
	ShowChatBubble = 1054,
	VideoPlayerMessage = 1055,
	ServerTypingMessage = 1056,


	//Client messages - 2xxx
	UpdateHeadsetKeyMessage = 2000,
	InteractMessage = 2001,
	StoreItemMessage = 2002,
	PostToChatMessage = 2003,
	OpenPageValueNetMessage = 2004,
	SimpleInteractMessage = 2005,
	RequestSyncMessage = 2006,
	RequestChangeVariableNetMessage = 2007,
	RequestMoveMessage = 2008,
	RequestShootMessage = 2009,
	TabInteractMessage = 2010,
	UIInteractMessage = 2011,
	RequestTileDeconstructMessage = 2012,
	RequestElectricalStats = 2013,
	RequestHealthStats = 2014,
	DevSpawnMessage = 2015,
	DevCloneMessage = 2016,
	DevDestroyMessage = 2017,
	RequestToViewObjectsAtTile = 2026,
	RequestBookshelfNetMessage = 2027,
	RequestOpenBookIDNetMessage = 2028,
	RequestUncuffMessage = 2029,
	RequestInteraction = 2030,
	RequestSlotTransferMessage = 2031,
	SpawnMessage = 2032,
	DespawnMessage = 2033,
	RequestBuildMessage = 2034,
	RequestAdminPageRefresh = 2035,
	RequestGameModeUpdate = 2036,
	RequestKick = 2037,
	RequestEnableAdmin = 2038,
	RequestRespawn = 2039,
	RequestAdminBwoink = 2040,
	AdminReplyMessage = 2041,
	RequestGameAction = 2042,
	RequestGameActionSO = 2043,
	RequestExamine = 2044,
	ClientTypingMessage = 2045,
	AdminCheckMessages = 2046
}