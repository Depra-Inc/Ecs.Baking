﻿// SPDX-License-Identifier: Apache-2.0
// © 2023 Nikolay Melnikov <n.melnikov@depra.org>

using Depra.Ecs.Baking.Entities;
using Depra.Ecs.Systems;
using Depra.Ecs.Worlds;
using UnityEngine;

namespace Depra.Ecs.Baking.Systems
{
	public readonly struct InitialBakingSystem : IPreInitializationSystem
	{
		void IPreInitializationSystem.PreInitialize(World world)
		{
			foreach (var authoringEntity in Object.FindObjectsOfType<AuthoringEntity>())
			{
				new AuthoringEntityBaker(authoringEntity).Bake(world);
			}
		}
	}
}