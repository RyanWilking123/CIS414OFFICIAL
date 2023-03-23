using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClientAdapter : MonoBehaviour
{
    public InventoryItem item;
    private InventorySystem inventorySystem;
    private IInventorySystem inventorySystemAdaptor;


    // Start is called before the first frame update
    void Start()
    {
        inventorySystem = new InventorySystem();
        inventorySystemAdaptor iSA = new InventorySystemAdaptor();

        iSA.AddItem(item); 
    }

    // Update is called once per frame
    void OnGUI()
    {
        if(GUILayout.Button("Add item (no adaptor)"))
        {
            inventorySystem.AddItem(item);
        }

        if (GUILayout.Button("Add item (with adaptor)"))
        {
            inventorySystemAdaptor.AddItem(item, SaveLocation.Both);
        }
    }
}
