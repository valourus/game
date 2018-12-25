using components;
using Unity.Entities;
using UnityEngine;

namespace systems.syncSystems
{
	public unsafe class SyncAnimationSpeed : ComponentSystem
	{
		private struct Filter
		{
			public Animator animator;
			public Speed* speed;
		}
		
		protected override void OnUpdate()
		{
			foreach (Filter e in GetEntities<Filter>())
			{
				e.animator.SetFloat("speed", e.speed->speed);	
			}
		}
	}
}