using UnityEngine;
using System.Collections;

namespace Item
{
    public class GetItem : MonoBehaviour
    {
        public ItemData itemData;
        public Transform iconHolder;
        public float delay = 5f;
        
        private GameObject icon;
        private void Awake()
        {
            if (itemData != null && itemData.icon != null && iconHolder != null)
            {
                icon = new GameObject("ItemIcon");
                icon.transform.SetParent(iconHolder, false);

                SpriteRenderer sprite = icon.AddComponent<SpriteRenderer>();
                sprite.sprite = itemData.icon;
                sprite.sortingOrder = 10;
                
            }
        }
        private void OnTriggerEnter(Collider other)
        {
            if (itemData != null)
            {
                itemData.effect.Apply(other.gameObject);
                StartCoroutine(Respawn());
            }
        }
        private IEnumerator Respawn()
        {
            GetComponent<Collider>().enabled = false;
            icon.SetActive(false);
            yield return new WaitForSeconds(delay);
            GetComponent<Collider>().enabled = true;
            icon.SetActive(true);
        }
    }
}
