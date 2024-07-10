using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;
using TMPro;            //InputField를 사용하기 위해서 추가함

public class codeInputfield : MonoBehaviour
{
   public TMP_InputField inputField;                            //InputField를 받아올 친구

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))             //스페이스 바를 누를 경우
        {
            Debug.Log("입력된 문자열 : " + GetStringFromInputField(inputField));
        }
    }

    public string GetStringFromInputField(TMP_InputField inputField)
    {
        // inputField가 비어있거나 문자열이 비어있을 경우
        if(inputField == null || inputField.text == null || inputField.text == "")
        {
            //Debug.LogWarning("inputField"가 비어있거나 문자열이 비어있습니다.");
            return null;        //반환값 없음
        }

        return inputField.text;     //inputField 내에 입력된 값을 반환함
    }
}
