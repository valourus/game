using System;
using Unity.Entities;
using UnityEngine;

namespace components
{
    [Serializable]
    public struct Speed : IComponentData
    {
        public float speed;
    }
    
    [Serializable]
    public class SpeedComponent : ComponentDataWrapper<Speed>
    {
        
    }
}
