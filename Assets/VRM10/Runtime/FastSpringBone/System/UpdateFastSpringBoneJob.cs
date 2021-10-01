using Unity.Collections;
using Unity.Jobs;
using UniVRM10.FastSpringBones.Blittables;

namespace UniVRM10.FastSpringBones.System
{
    public struct UpdateFastSpringBoneJob : IJobParallelFor
    {
        [ReadOnly] public NativeArray<BlittableSpring> Springs;

        [ReadOnly] public NativeArray<BlittableJoint> Joints;
        [NativeDisableParallelForRestriction] public NativeArray<BlittableTransform> JointTransforms;

        [ReadOnly] public NativeArray<BlittableCollider> Colliders;
        [NativeDisableParallelForRestriction] public NativeArray<BlittableTransform> ColliderTransforms;

        public void Execute(int index)
        {
            var spring = Springs[index];
        }
    }
}