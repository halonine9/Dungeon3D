using UnityEngine;

namespace Item
{
    public class SprintEffect : ItemEffect
    {
        public float speedUP= 1.5f;
        public float duration = 5f;

        public override void Apply(GameObject target)
        {
            PlayerEffectHandler handler = target.GetComponent<PlayerEffectHandler>();
            if (handler != null)
            {
                handler.ApplySprint(speedUP, duration);
            }
        }
    }
}
