using components;
using utils;
using Unity.Entities;
using Unity.Jobs;
using Unity.Transforms;

namespace systems.jobSystems
{
	public class MovementSystem : JobComponentSystem 
	{
		
		private struct MovementJob : IJobProcessComponentData<Position, Speed>
		{
			public float deltaTime;
			
			public void Execute(ref Position position, ref Speed speed)
			{
				position.Value.x += speed.speed * deltaTime;
			}
		}

		protected override JobHandle OnUpdate(JobHandle inputDeps)
		{
			JobHandle job = new MovementJob
			{
				deltaTime = UnityFacade.getDeltaTime(),
			}.Schedule(this, inputDeps);

			return job;
		}
	}
}