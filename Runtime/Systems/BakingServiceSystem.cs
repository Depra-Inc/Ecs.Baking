﻿// SPDX-License-Identifier: Apache-2.0
// © 2023 Nikolay Melnikov <n.melnikov@depra.org>

using Depra.Ecs.Baking.Worlds;
using Depra.Ecs.Systems;
using Depra.Ecs.Worlds;

namespace Depra.Ecs.Baking.Systems
{
	public readonly struct BakingServiceSystem : IPreInitializationSystem, ITerminationSystem
	{
		void IPreInitializationSystem.PreInitialize(World world) =>
			BakingWorld.Initialize(world);

		void ITerminationSystem.Terminate(World world) =>
			BakingWorld.Destroy();
	}
}