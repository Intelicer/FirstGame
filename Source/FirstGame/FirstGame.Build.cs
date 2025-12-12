// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class FirstGame : ModuleRules
{
	public FirstGame(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"FirstGame",
			"FirstGame/Variant_Platforming",
			"FirstGame/Variant_Platforming/Animation",
			"FirstGame/Variant_Combat",
			"FirstGame/Variant_Combat/AI",
			"FirstGame/Variant_Combat/Animation",
			"FirstGame/Variant_Combat/Gameplay",
			"FirstGame/Variant_Combat/Interfaces",
			"FirstGame/Variant_Combat/UI",
			"FirstGame/Variant_SideScrolling",
			"FirstGame/Variant_SideScrolling/AI",
			"FirstGame/Variant_SideScrolling/Gameplay",
			"FirstGame/Variant_SideScrolling/Interfaces",
			"FirstGame/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
