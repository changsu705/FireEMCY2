using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text[] text;
    public GameObject TextBox;
    public string[] dialogue;

    bool End = false;
    int k;

    //상황에 따른 변수 추가
    private void Start()
    {

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Y))
        {
            TextBox.SetActive(false);
            text[k].text = null;
            End = false;
        }

        //실험
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            int j = 0;
            Typing(j);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            int j = 1;
            Typing(j);
        }
    }

    public void Typing(int j)  //UI의 Text를 나오는 함수실
    {
        if (!End)
        {
            TextBox.SetActive(true);
            StartCoroutine(Typing(dialogue[j], j));
            End = true;
        }

        //상황에 따른 j변수 바꾸기 추가
    }

    IEnumerator Typing(string talk, int j)
    {

        for (int i = 0; i < talk.Length; i++)
        {
            text[j].text += talk[i];
            k = j;

            yield return new WaitForSeconds(0.05f);
        }
    }
}
