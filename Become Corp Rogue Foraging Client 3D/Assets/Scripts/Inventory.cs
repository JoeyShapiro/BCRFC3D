using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public int width;
    public int height;
    public string Name;

    public Inventory(int x, int y, string n) {
        width = x;
        height = y;
        Name = n;
    }
}
