using UnityEngine;

namespace Item
{
    public abstract class ItemEffect : ScriptableObject
    {
        public abstract void Apply(GameObject target);
    }
}
