using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Inventory Item Data")]
public class InventoryItemData : MonoBehaviour
{
    public string id;
    public string displayName;
    public Sprite icon;
    public GameObject prefab;
    public InventoryItemData data { get; private set; }

    public class InventoryItem
    {

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
