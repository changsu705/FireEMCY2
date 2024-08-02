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

    //��Ȳ�� ���� ���� �߰�
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

        //����
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

    public void Typing(int j)  //UI�� Text�� ������ �Լ���
    {
        if (!End)
        {
            TextBox.SetActive(true);
            StartCoroutine(Typing(dialogue[j], j));
            End = true;
        }

        //��Ȳ�� ���� j���� �ٲٱ� �߰�
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
