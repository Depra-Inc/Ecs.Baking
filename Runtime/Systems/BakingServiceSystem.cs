﻿// SPDX-License-Identifier: Apache-2.0
// © 2023 Nikolay Melnikov <n.melnikov@depra.org>

using Depra.Ecs.Baking.Services;
using Depra.Ecs.Systems;

namespace Depra.Ecs.Baking.Systems
{
	public readonly struct BakingServiceSystem : IPreInitializeSystem, ITearDownSystem
	{
		void IPreInitializeSystem.PreInitialize(IWorldSystems systems) =>
			BakingWorld.Initialize(systems.World);

		void ITearDownSystem.TearDown(IWorldSystems systems) =>
			BakingWorld.Destroy();
	}
}