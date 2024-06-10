using UnrealBuildTool;

public class berberfirstpersonServerTarget : TargetRules
{
	public berberfirstpersonServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("berberfirstperson");
	}
}
