using UnrealBuildTool;

public class berberfirstpersonEditorTarget : TargetRules
{
	public berberfirstpersonEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("berberfirstperson");
	}
}
