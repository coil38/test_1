using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloCode : MonoBehaviour
{
    public int _int;                    //���� �ڷ���

    public float _fnum;         //�Ǽ� �ڷ���

    public bool _bool;          //��, ����
        
    public string _string;      //���ڿ�
        
    public char _char;          //����

    [SerializeField] private int __int;             //[SerializeField] �ش� ������ �ν����� â�� ���
    [HideInInspector] public float __float;         //[HideInInspector] �ش� ������ �ν����� â�� �ȶ��

    private void Start()
    {
        /*
        if(_bool == true)       // ==true�� �ϵ� ���ϵ� if(_bool)�� �Ѱ��̶� ����. 
        {

        }

        if (!_bool)         // !�� �� ���� ������
        {

        }*/

        Rigidbody rb;

        //�߿�*-----------------------------------------------------------------------------------------------------------------------------
        if (!TryGetComponent<Rigidbody>(out rb))
        {
            rb = gameObject.AddComponent<Rigidbody>();
        }

       //------------------------------------------------------------------------------------------------------------------------------------
    }
}
