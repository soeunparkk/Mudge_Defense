using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemInfo : MonoBehaviour
{//잡은 물건 정보 값을 가지고 있는 클래스
    public int slotld;      //슬롯 번호 (slot 클래스 생성 후)
    public int itemld;      //아이템 번호


    public void InitDummy(int slotld, int  itemld)
    {//인수로 받은 값을들 Class 쪽에 입력
        this.slotld = slotld;
        this.itemld = itemld;

    }
}
