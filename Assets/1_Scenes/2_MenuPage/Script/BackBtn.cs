using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BackBtn : MonoBehaviour
{
    public void OnButtonPress()
    {
        Debug.Log("Ȩ�۵�");
        //InfoObj.instance���� ���� ��ٱ��� ���� ����
        SceneManager.LoadScene("IntroPage");
    }
}
