﻿using Unity.Mathematics;
using static Jolt.Bindings;

namespace Jolt
{
    [GenerateHandle("JPH_BoxShape"), GenerateBindings("JPH_BoxShape", "JPH_ConvexShape", "JPH_Shape")]
    public readonly partial struct BoxShape
    {
        [OverrideBinding("JPH_BoxShape_Create")]
        public static BoxShape Create(float3 halfExtent, float convexRadius = PhysicsSettings.DefaultConvexRadius)
        {
            return new BoxShape(JPH_BoxShape_Create(halfExtent, convexRadius));
        }
    }
}
