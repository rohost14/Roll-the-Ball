using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    [Header("List of items sold")]
    [SerializeField] private ShopItem[] shopItem;

    [Header("References")]
    [SerializeField] private Transform shopContainer;
    [SerializeField] private GameObject shopItemPrefab;

    private void Start()
    {
        PopulateShop();
    }

    private void PopulateShop()
    {
        for (int i = 0; i < shopItem.Length; i++)
        {
            ShopItem si = shopItem[i];
            GameObject itemObject = Instantiate(shopItemPrefab, shopContainer);

            // This access the prefab's component, and change it based off your ShopItem structure
            // ShopItem (Image, Button)
            //  - Border (Image)
            //  - Sprite (Image)
            //  - Name (TextMeshProUGUI)

            // Grab button, assign a function to its onclick event
            itemObject.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(si));

            // Change the background color
            itemObject.GetComponent<Image>().color = si.backgroundColor;
            // Change the item's sprite
            itemObject.transform.GetChild(1).GetComponent<Image>().sprite = si.sprite;
            // Change the item's name
            itemObject.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text = si.itemName;
        }
    }

    private void OnButtonClick(ShopItem item)
    {
        Debug.Log(item.name);
    }
}