﻿// SPDX-License-Identifier: Apache-2.0
// © 2023-2024 Nikolay Melnikov <n.melnikov@depra.org>

using Depra.Ecs.Hybrid.Entities;
using Depra.Ecs.Systems;
using Depra.Ecs.Worlds;

namespace Depra.Ecs.Hybrid.Systems
{
	public readonly struct InitialBakingSystem : IPreInitializationSystem
	{
		void IPreInitializationSystem.PreInitialize(IWorldGroup worlds)
		{
			var entities = InterfaceService.FindOnActiveScene<IAuthoringEntity>();
			foreach (var authoringEntity in entities)
			{
				authoringEntity.CreateBaker().Bake(authoringEntity, worlds.Default);
			}
		}
	}
}