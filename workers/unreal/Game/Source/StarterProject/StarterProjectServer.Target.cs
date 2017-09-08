// Copyright (c) Improbable Worlds Ltd, All Rights Reserved

using UnrealBuildTool;
using System.Collections.Generic;

public class StarterProjectServerTarget : TargetRules
{
	public StarterProjectServerTarget(TargetInfo Target)
	{
		Type = TargetType.Server;
	}

	//
	// TargetRules interface.
	//

	public override void SetupBinaries(
		TargetInfo Target,
		ref List<UEBuildBinaryConfiguration> OutBuildBinaryConfigurations,
		ref List<string> OutExtraModuleNames
		)
	{
		OutExtraModuleNames.AddRange(new [] { "StarterProject" });
	}
}
