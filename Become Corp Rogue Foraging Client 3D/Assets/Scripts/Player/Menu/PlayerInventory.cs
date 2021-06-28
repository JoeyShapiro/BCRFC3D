using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInventory : MonoBehaviour
{
    // make player stats
    public Button helm;

    // Start is called before the first frame update
    void Start()
    {
        if (PlayerStats.helm != null)
            helm.GetComponent<Text>().text = PlayerStats.helm.Name;

        // right side
        foreach (Inventory inv in PlayerStats.inventories)
        {
            Debug.Log(inv.Name);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
