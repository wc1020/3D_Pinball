using UnrealBuildTool;

public class pinballTarget : TargetRules
{
	public pinballTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("pinball");
	}
}
