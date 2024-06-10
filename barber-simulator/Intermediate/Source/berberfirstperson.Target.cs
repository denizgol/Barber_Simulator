using UnrealBuildTool;

public class berberfirstpersonTarget : TargetRules
{
	public berberfirstpersonTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("berberfirstperson");
	}
}
