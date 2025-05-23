using UnityEngine;

namespace Item
{
    [CreateAssetMenu(fileName = "NewItem", menuName = "Item")]
    public class ItemData : ScriptableObject
    {
        public string itemName;
        public string description;
        public Sprite icon;
        public ItemEffect effect;
    }
}
