using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelegateExample : MonoBehaviour
{
    // 1. ��������Ʈ ����
    public delegate void MyDelegate(string message);

    // 2. ��������Ʈ�� ������ �޼ҵ�
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
        Debug.Log("���� : " + message);
    }
    void Start()
    {
        //3. ��������Ʈ �ν��Ͻ� ����
        MyDelegate myDelegate = null;

        //4. �޼��� �߰�
        myDelegate += PrintMessage;
        myDelegate += LogMessage;
        myDelegate += WarningMessage;
        myDelegate += DangerMessage;

        //5. ��������Ʈ�� ����Ͽ� �޼��� ȣ��
        myDelegate(" ��������Ʈ ���� �۵� ");

        // 6.�޼��� ���� �� ȣ��
        myDelegate -= DangerMessage;
        myDelegate -= WarningMessage;
        myDelegate -= LogMessage;

        myDelegate(" PrintMessage �����ҳ�");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
