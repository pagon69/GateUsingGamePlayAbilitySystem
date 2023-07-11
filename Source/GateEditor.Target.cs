// Copyright Alleyne Technology and all rights reserved

using UnrealBuildTool;
using System.Collections.Generic;

public class GateEditorTarget : TargetRules
{
	public GateEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V2;

		ExtraModuleNames.AddRange( new string[] { "Gate" } );
	}
}
