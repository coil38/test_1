using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class DiceRoll : MonoBehaviour
{
    public enum Side        //�� ��ü����
    {
        Six,
        Twenty
    }

    public List<Side> Dice;

    public TMP_InputField side_Input;           // ���ü���� �Է��ϴ� InputField
    public TMP_InputField amount_Input;         // � �߰��Ұ��� �Է��ϴ� InputField


    public void AddDice()
    {
        int side =int.Parse(side_Input.text);
        int amount = int.Parse(amount_Input.text);
        
        

        
    }
}
