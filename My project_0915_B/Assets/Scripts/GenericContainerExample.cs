using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericContainerExample : MonoBehaviour
{
    private GenericContainer<int> intContainer;       //컨테이너 선언 (int)
    private GenericContainer<string> stringContainer; //컨테이너 선언 (string)


    void Start()
    {
        intContainer = new GenericContainer<int>(10);      //10칸으로 선언
        stringContainer = new GenericContainer<string>(5);  //5칸으로 선언
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))            //키보드 1을 누르면
        {
            intContainer.Add(Random.Range(0, 100));    //0 - 100 랜던 숫자를 컨테이너에 넣는다.
            DisplayContainerItems(intContainer);       //함수를 통해서 Debug.log에 보여준다.
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))            //키보드 2를 누르면
        {
            string randomString = "Item " + Random.Range(0, 100);       //임의의 문자열을 만들어준다.
            stringContainer.Add(randomString);                         //0 - 100 랜덤(string) 문자열 컨테이너에 넣는다.
            DisplayContainerItems(stringContainer);                     //함수를 통해서 Debug.log에 보여준다.
        }
    }
    //컨테이너에 담긴 값들을 보여주는 함수

    private void DisplayContainerItems<T>(GenericContainer<T> container)
    {
        T[] item = container.GetItems();               //아이템 리스트를 받아온다.
        string temp = "";                              //Debug.Log에 보여질 칸 String
        for (int i = 0; i < item.Length; i++)           //컨테이너의 모든 값을 for문으로 돌면서 //컨테이너를 순환해서 배열값을 문자열로 변환
        {
            if (item[i] != null)                       //값이 NULL 이 아닐경우
            {
                temp += item[i].ToString() + "/";      //제너링 형태값을 string 형식으로 변환
            }
            else
            {
                temp += "Empty / ";                    //비어있으면 NULL일 경우에는 Empty 문자열 표현해준다.
            }
        }
        Debug.Log(temp);
    }
}
