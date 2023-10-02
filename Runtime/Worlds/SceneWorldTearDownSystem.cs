﻿// SPDX-License-Identifier: Apache-2.0
// © 2023 Nikolay Melnikov <n.melnikov@depra.org>

using Depra.Ecs.Systems;

namespace Depra.Ecs.Baking.Runtime.Worlds
{
	public readonly struct SceneWorldTearDownSystem : ITearDownSystem
	{
		void ITearDownSystem.TearDown(IWorldSystems systems) => SceneWorld.Destroy();
	}
}