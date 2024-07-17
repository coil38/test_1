using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DiceController : MonoBehaviour
{
    public enum Side            // 몇 면체인지
    {
        Six,
        Twenty
    }

    public List<Side> dice = new List<Side>();

    public TMP_InputField side_Input;           // 몇면체인지 입력하는 InputField
    public TMP_InputField amount_Input;         // 몇개 추가할건지 입력하는 InputField

    public void AddDice()                       // 주사위를 추가하는 함수
    {
        if (!ISInputIsRight())                  // InputField가 잘 입력되어있는지 확인하고 아닐경우 함수 종료
            return;

        int side = int.Parse(side_Input.text);              // 몇 면체인지 받아옴
        int amount = int.Parse(amount_Input.text);          // 몇 개인지 받아옴

        if(dice.Count >= 3 || amount + dice.Count > 3)                         // 지금 가지고 있는 주사위의 갯수가 3개 이상이거나 추가했더니 3개를 넘을경우
        {
            Debug.LogWarning("3개 이상 주사위를 가질 수 없습니다.");            // 경고 메세지 출력
            return;                             // 함수 종료
        }

        for(int i = 0; i < amount; i++)             // 추가하는 양 만큼 반복
        {
            if(side == 6)                       // 6면체일 경우
            {
                dice.Add(Side.Six);
            }
            else                                // 20면체일 경우 (6, 20 이 아니면 여기까지 오지도 않음)
            {
                dice.Add(Side.Twenty);
            }
        }

        side_Input.text = string.Empty;             // InputField 초기화
        amount_Input.text = string.Empty;           // InputField 초기화

        ShowMyDice();               // 가지고 있는 주사위 출력
    }

    public void ResetDice()         // 주사위 리스트를 초기화 하는 함수
    {
        dice = new List<Side>();
    }

    public  bool ISInputIsRight()                   // 잘 기입 되어있는지 확인하는 함수
    {
        int side, amount;

        // int로 변환이 되지 않을 경우
        if (!int.TryParse(side_Input.text, out side) || !int.TryParse(amount_Input.text, out amount))
        {
            Debug.LogError("숫자만 기입해주세요");
            return false;       // 거짓 반환
        }
        // 6, 20을 입력하지 않은 경우
        if (side != 6 && side != 20)
        {
            Debug.LogError("6 또는 20을 입력해주세요");
            return false;       // 거짓 반환
        }

        return true;        // 잘못된것이 없기 때문에 참 반환
    }

    public void ShowMyDice()                    // 지금 가지고 있는 주사위를 출력하는 함수
    {
        string text = "";
        int sixSideAmount = 0;
        int twentySideAmount = 0;

        if(dice.Count <= 0)                     // 주사위가 0개 이하일 경우(없을 경우)
        {
            Debug.Log("주사위가 없습니다.");    // 주사위가 없다고 출력
            return;                             // 함수 종료
        }

        for (int i = 0; i < dice.Count;i++)
        {
            if (dice[i] == Side.Six) 
            {
                text += $"{i + 1}번 주사위 6면체 \n";
                sixSideAmount++;
            }
            else
            {
                text += $"{i + 1}번 주사위 20면체 \n";
                twentySideAmount++;
            }
        }

        Debug.Log(text);
        Debug.Log("6면체 : " + sixSideAmount.ToString()); 
        Debug.Log("20면체 : " + twentySideAmount.ToString());
    }


    

}
