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
            if (_instance == null)                                      //인스턴스 오브젝트가 없을 경우
            {
                _instance = FindObjectOfType<T>();                      //클래스 타입을 찾는다
                if (_instance == null)
                {
                    GameObject obj = new GameObject();                  //오브젝트 생성
                    obj.name = typeof(T).Name;                          //이름 설정
                    _instance = obj.AddComponent<T>();                  //생성하고 컨포넌트를 붙인다. (컴포넌트 ADD)
                }
            }
            return _instance;
        }
    }
    private void Awake()
    {
        if (_instance == null)                                        //Instance 가 NULL일때 (인스턴스가 없을경우)
        {
            _instance = this as T;                                   //지금 인스턴스를 Static 에 입력
            DontDestroyOnLoad(gameObject);                           //DontDestroyOnLoad 파괴되지 않은 (게임 오브젝트가 Scene이 전환되고 파괴되지 않음
        }
        else if (_instance != null)
        {
            Destroy(gameObject);                                    //1개로 유지시키기 위해 생성된 객체를 파괴한다. (기존에 인스턴스가 있는 경우 파괴 시킨다.)
        }
    }
}

