using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ItemManager : MonoBehaviour
{
    public static ItemManager Instance;
    List<GoodsInfo> GoodsInfoList;
    public UnityEvent OnChange;

    // Start is called before the first frame update
    void Start()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(this);

        GoodsInfoList = new List<GoodsInfo>();
    }

    public void AddGoods(GoodsInfo item)
    {
        GoodsInfoList.Add(item);
        OnChange.Invoke();
    }

    public void RemoveGoods(GoodsInfo item)
    {
        GoodsInfoList.Remove(item);
        OnChange.Invoke();
    }

    public void RemoveGoods(int index)
    {
        GoodsInfoList.RemoveAt(index);
        OnChange.Invoke();
    }

    public List<GoodsInfo> GetList()
    {
        return GoodsInfoList;
    }
}
