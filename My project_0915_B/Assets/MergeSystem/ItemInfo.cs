using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemInfo : MonoBehaviour
{//���� ���� ���� ���� ������ �ִ� Ŭ����
    public int slotld;      //���� ��ȣ (slot Ŭ���� ���� ��)
    public int itemld;      //������ ��ȣ


    public void InitDummy(int slotld, int  itemld)
    {//�μ��� ���� ������ Class �ʿ� �Է�
        this.slotld = slotld;
        this.itemld = itemld;

    }
}
