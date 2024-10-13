using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoObj : MonoBehaviour
{
    public static InfoObj instance;



    void Start()
    {
        DontDestroyOnLoad(this);
        if (instance == null)
            instance = new InfoObj();
        else
            Destroy(this);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
