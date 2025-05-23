using Item;
using UnityEngine;

namespace UI
{
    public class InterrectableObject : MonoBehaviour, IInteractable
    {
        [SerializeField] private string name;
        [SerializeField] private string description;
        [SerializeField] private ItemData itemData;
        public string GetName() => itemData != null ? itemData.itemName : name;
        public string GetDescription() => itemData != null ? itemData.description : description;
    }
}
