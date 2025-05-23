using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    public class UIRaycast : MonoBehaviour
    {
        public float inspectDistance = 5f;
        public LayerMask layerMask;
        [SerializeField] private Camera playerCamera;

        [SerializeField] private Text nameText;
        [SerializeField] private Text descriptionText;
        [SerializeField] private GameObject uiPanel;

        private RectTransform interactionRect;
        
        private void Awake()
        {
            interactionRect = uiPanel.GetComponent<RectTransform>();
        }
        private void Update()
        {
            Ray ray = new Ray(playerCamera.transform.position, playerCamera.transform.forward);
            if (Physics.Raycast(ray, out RaycastHit hit, inspectDistance, layerMask))
            {
                IInteractable interactable = hit.collider.GetComponent<IInteractable>();
                if (interactable != null)
                {
                    nameText.text = interactable.GetName();
                    descriptionText.text = interactable.GetDescription();
                    uiPanel.SetActive(true);
                    
                    Vector3 screenPoint = playerCamera.WorldToScreenPoint(hit.collider.bounds.center);
                    interactionRect.position = screenPoint;
                    return;
                }
            }
            uiPanel.SetActive(false);
        }
    }
}
