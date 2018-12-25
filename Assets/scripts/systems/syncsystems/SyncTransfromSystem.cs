using Unity.Entities;
using Unity.Transforms;
using UnityEngine;

namespace systems.syncSystems
{
	public unsafe class SyncTransfromSystem : ComponentSystem
	{
		private struct Filter
		{
			public Transform transform;
			public Position* position;
		}
		
		protected override void OnUpdate()
		{
			foreach (Filter e in GetEntities<Filter>())
			{
				e.transform.position = e.position->Value;
			}
		}
	}
}