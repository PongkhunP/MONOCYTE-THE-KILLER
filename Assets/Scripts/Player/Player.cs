using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour 
{
    public InventoryObject inventory;
    
    public void OnTriggerEnter(Collider other)
    {
        GroundItem item = other.GetComponent<GroundItem>();
        if(item)
        {
            inventory.AddItem(new Item(item.item), 1);
            Destroy(other.gameObject);
        }
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            inventory.Save();
            Debug.Log("Save Item successfully");
        }
        if(Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            inventory.Load();
            Debug.Log("Load Item successfully");
        }
    }

    private void OnApplicationQuit()
    {
        // inventory.Container.Clear();
    }
}
