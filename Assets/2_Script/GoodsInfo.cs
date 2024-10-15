using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoodsInfo
{
    public string name;
    public int cost;
    public int amount;

    public GoodsInfo()
    {
        name = string.Empty;
        cost = 0;
        amount = 0;
    }

    public GoodsInfo(string name, int cost, int amount)
    {
        this.name = name;
        this.cost = cost;
        this.amount = amount;
    }
}
