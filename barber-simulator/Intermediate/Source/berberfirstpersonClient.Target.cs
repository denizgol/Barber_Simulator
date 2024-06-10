using UnrealBuildTool;

public class berberfirstpersonClientTarget : TargetRules
{
	public berberfirstpersonClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("berberfirstperson");
	}
}
