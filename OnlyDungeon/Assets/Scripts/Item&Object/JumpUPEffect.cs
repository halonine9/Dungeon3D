using UnityEngine;

namespace Item
{
    [CreateAssetMenu(menuName = "Effects/JumpUP")]
    public class JumpUPEffect : ItemEffect
    {
        public float jumpfower = 1.5f;
        public float duration = 5f;

        public override void Apply(GameObject target)
        {
            PlayerEffectHandler handler = target.GetComponent<PlayerEffectHandler>();
            if (handler != null)
            {
                handler.ApplyJumpUP(jumpfower, duration);
            }
        }
    }
}
