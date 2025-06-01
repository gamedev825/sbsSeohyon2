using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelegateExample : MonoBehaviour
{
    // 1. 델리게이트 선언
    public delegate void MyDelegate(string message);

    // 2. 델리게이트가 참조할 메소드
    void PrintMessage(string message)
    {
        Debug.Log("PrintMessage : " + message);
    }

    void LogMessage(string message)
    {
        Debug.Log("LogMessage : " + message);
    }

    void WarningMessage(string message)
    {
        Debug.Log("WarningMessage : " + message);
    }

    void DangerMessage(string message)
    {
        Debug.Log("위험 : " + message);
    }
    void Start()
    {
        //3. 델리게이트 인스턴스 생성
        MyDelegate myDelegate = null;

        //4. 메서드 추가
        myDelegate += PrintMessage;
        myDelegate += LogMessage;
        myDelegate += WarningMessage;
        myDelegate += DangerMessage;

        //5. 델리게이트를 사용하여 메서드 호출
        myDelegate(" 델리게이트 정상 작동 ");

        // 6.메서드 제거 후 호출
        myDelegate -= DangerMessage;
        myDelegate -= WarningMessage;
        myDelegate -= LogMessage;

        myDelegate(" PrintMessage 만남았네");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
