using UnityEngine;

namespace UI
{
    public class InterrectableObject : MonoBehaviour, IInteractable
    {
        [SerializeField] private string name;
        [SerializeField] private string description;

        public string GetName() => name;
        public string GetDescription() => description;
    }
}
