using Unity.Entities;
using UnityEngine;

namespace systems
{
	public class CollisionSystem : ComponentSystem
	{
		private struct Filter
		{
			public Collider2D collider;
		}


		protected override void OnUpdate()
		{
			foreach (Filter e in GetEntities<Filter>())
			{
				e.collider.Cast()
			}
		}
	}
}