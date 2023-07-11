// Copyright Alleyne Technology and all rights reserved

using UnrealBuildTool;
using System.Collections.Generic;

public class GateTarget : TargetRules
{
	public GateTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V2;

		ExtraModuleNames.AddRange( new string[] { "Gate" } );
	}
}
