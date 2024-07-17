using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class DiceRoll : MonoBehaviour
{
    public enum Side        //몇 면체인지
    {
        Six,
        Twenty
    }

    public List<Side> Dice;

    public TMP_InputField side_Input;           // 몇면체인지 입력하는 InputField
    public TMP_InputField amount_Input;         // 몇개 추가할건지 입력하는 InputField


    public void AddDice()
    {
        int side =int.Parse(side_Input.text);
        int amount = int.Parse(amount_Input.text);
        
        

        
    }
}
