﻿// SPDX-License-Identifier: Apache-2.0
// © 2023 Nikolay Melnikov <n.melnikov@depra.org>

using Depra.Ecs.Worlds;

namespace Depra.Ecs.Baking.Services
{
	internal static class BakingWorld
	{
		public static World World;

		public static void Initialize(World world) => World = world;

		public static void Destroy() => World = null;
	}
}