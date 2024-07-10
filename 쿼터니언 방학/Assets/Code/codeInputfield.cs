using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;
using TMPro;            //InputField�� ����ϱ� ���ؼ� �߰���

public class codeInputfield : MonoBehaviour
{
   public TMP_InputField inputField;                            //InputField�� �޾ƿ� ģ��

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))             //�����̽� �ٸ� ���� ���
        {
            Debug.Log("�Էµ� ���ڿ� : " + GetStringFromInputField(inputField));
        }
    }

    public string GetStringFromInputField(TMP_InputField inputField)
    {
        // inputField�� ����ְų� ���ڿ��� ������� ���
        if(inputField == null || inputField.text == null || inputField.text == "")
        {
            //Debug.LogWarning("inputField"�� ����ְų� ���ڿ��� ����ֽ��ϴ�.");
            return null;        //��ȯ�� ����
        }

        return inputField.text;     //inputField ���� �Էµ� ���� ��ȯ��
    }
}
