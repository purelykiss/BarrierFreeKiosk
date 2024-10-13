using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BackBtn : MonoBehaviour, ISelectHandler
{
    public void OnSelect(BaseEventData eventData)
    {
        OnButtonPress();
        Debug.Log("invoke");
    }

    public void OnButtonPress()
    {
        //InfoObj.instance에서 현제 장바구니 정보 삭제
        SceneManager.LoadScene("IntroPage");
    }
}
