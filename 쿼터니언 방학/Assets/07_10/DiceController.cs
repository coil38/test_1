using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DiceController : MonoBehaviour
{
    public enum Side            // �� ��ü����
    {
        Six,
        Twenty
    }

    public List<Side> dice = new List<Side>();

    public TMP_InputField side_Input;           // ���ü���� �Է��ϴ� InputField
    public TMP_InputField amount_Input;         // � �߰��Ұ��� �Է��ϴ� InputField

    public void AddDice()                       // �ֻ����� �߰��ϴ� �Լ�
    {
        if (!ISInputIsRight())                  // InputField�� �� �ԷµǾ��ִ��� Ȯ���ϰ� �ƴҰ�� �Լ� ����
            return;

        int side = int.Parse(side_Input.text);              // �� ��ü���� �޾ƿ�
        int amount = int.Parse(amount_Input.text);          // �� ������ �޾ƿ�

        if(dice.Count >= 3 || amount + dice.Count > 3)                         // ���� ������ �ִ� �ֻ����� ������ 3�� �̻��̰ų� �߰��ߴ��� 3���� �������
        {
            Debug.LogWarning("3�� �̻� �ֻ����� ���� �� �����ϴ�.");            // ��� �޼��� ���
            return;                             // �Լ� ����
        }

        for(int i = 0; i < amount; i++)             // �߰��ϴ� �� ��ŭ �ݺ�
        {
            if(side == 6)                       // 6��ü�� ���
            {
                dice.Add(Side.Six);
            }
            else                                // 20��ü�� ��� (6, 20 �� �ƴϸ� ������� ������ ����)
            {
                dice.Add(Side.Twenty);
            }
        }

        side_Input.text = string.Empty;             // InputField �ʱ�ȭ
        amount_Input.text = string.Empty;           // InputField �ʱ�ȭ

        ShowMyDice();               // ������ �ִ� �ֻ��� ���
    }

    public void ResetDice()         // �ֻ��� ����Ʈ�� �ʱ�ȭ �ϴ� �Լ�
    {
        dice = new List<Side>();
    }

    public  bool ISInputIsRight()                   // �� ���� �Ǿ��ִ��� Ȯ���ϴ� �Լ�
    {
        int side, amount;

        // int�� ��ȯ�� ���� ���� ���
        if (!int.TryParse(side_Input.text, out side) || !int.TryParse(amount_Input.text, out amount))
        {
            Debug.LogError("���ڸ� �������ּ���");
            return false;       // ���� ��ȯ
        }
        // 6, 20�� �Է����� ���� ���
        if (side != 6 && side != 20)
        {
            Debug.LogError("6 �Ǵ� 20�� �Է����ּ���");
            return false;       // ���� ��ȯ
        }

        return true;        // �߸��Ȱ��� ���� ������ �� ��ȯ
    }

    public void ShowMyDice()                    // ���� ������ �ִ� �ֻ����� ����ϴ� �Լ�
    {
        string text = "";
        int sixSideAmount = 0;
        int twentySideAmount = 0;

        if(dice.Count <= 0)                     // �ֻ����� 0�� ������ ���(���� ���)
        {
            Debug.Log("�ֻ����� �����ϴ�.");    // �ֻ����� ���ٰ� ���
            return;                             // �Լ� ����
        }

        for (int i = 0; i < dice.Count;i++)
        {
            if (dice[i] == Side.Six) 
            {
                text += $"{i + 1}�� �ֻ��� 6��ü \n";
                sixSideAmount++;
            }
            else
            {
                text += $"{i + 1}�� �ֻ��� 20��ü \n";
                twentySideAmount++;
            }
        }

        Debug.Log(text);
        Debug.Log("6��ü : " + sixSideAmount.ToString()); 
        Debug.Log("20��ü : " + twentySideAmount.ToString());
    }


    

}
