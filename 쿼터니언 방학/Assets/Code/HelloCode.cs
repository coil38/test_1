using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloCode : MonoBehaviour
{
    public int _int;                    //정수 자료형

    public float _fnum;         //실수 자료형

    public bool _bool;          //참, 거짓
        
    public string _string;      //문자열
        
    public char _char;          //문자

    [SerializeField] private int __int;             //[SerializeField] 해당 변수가 인스펙터 창에 뜬다
    [HideInInspector] public float __float;         //[HideInInspector] 해당 변수가 인스펙터 창에 안뜬다

    private void Start()
    {
        /*
        if(_bool == true)       // ==true는 하든 안하든 if(_bool)만 한것이랑 같다. 
        {

        }

        if (!_bool)         // !는 논리 부정 연산자
        {

        }*/

        Rigidbody rb;

        //중요*-----------------------------------------------------------------------------------------------------------------------------
        if (!TryGetComponent<Rigidbody>(out rb))
        {
            rb = gameObject.AddComponent<Rigidbody>();
        }

       //------------------------------------------------------------------------------------------------------------------------------------
    }
}
