using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{
    public static Item helm;
    public static List<Inventory> inventories = new List<Inventory>();

    // Start is called before the first frame update
    void Start()
    {
        inventories.Add(new Inventory(1, 4, "Pockets"));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
