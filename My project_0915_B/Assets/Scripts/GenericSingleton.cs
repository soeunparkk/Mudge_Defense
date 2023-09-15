using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericSingleton<T> : MonoBehaviour where T : Component
{
    private static T _instance;
    public static T Instance
    {
        get
        {
            if (_instance == null)                                      //�ν��Ͻ� ������Ʈ�� ���� ���
            {
                _instance = FindObjectOfType<T>();                      //Ŭ���� Ÿ���� ã�´�
                if (_instance == null)
                {
                    GameObject obj = new GameObject();                  //������Ʈ ����
                    obj.name = typeof(T).Name;                          //�̸� ����
                    _instance = obj.AddComponent<T>();                  //�����ϰ� ������Ʈ�� ���δ�. (������Ʈ ADD)
                }
            }
            return _instance;
        }
    }
    private void Awake()
    {
        if (_instance == null)                                        //Instance �� NULL�϶� (�ν��Ͻ��� �������)
        {
            _instance = this as T;                                   //���� �ν��Ͻ��� Static �� �Է�
            DontDestroyOnLoad(gameObject);                           //DontDestroyOnLoad �ı����� ���� (���� ������Ʈ�� Scene�� ��ȯ�ǰ� �ı����� ����
        }
        else if (_instance != null)
        {
            Destroy(gameObject);                                    //1���� ������Ű�� ���� ������ ��ü�� �ı��Ѵ�. (������ �ν��Ͻ��� �ִ� ��� �ı� ��Ų��.)
        }
    }
}

