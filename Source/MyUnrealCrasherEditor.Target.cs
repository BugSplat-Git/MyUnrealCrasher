// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class MyUnrealCrasherEditorTarget : TargetRules
{
	public MyUnrealCrasherEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;

		ExtraModuleNames.AddRange( new string[] { "MyUnrealCrasher" } );
	}
}
