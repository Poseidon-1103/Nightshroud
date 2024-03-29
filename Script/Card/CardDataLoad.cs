using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDataLoad : MonoBehaviour
{
    public List<Card> cardList = new List<Card>();
    
    private void Start()
    {
        SortCard();
    }

    public void SortCard()
    {
        //获得表
        List<Card> sortCardList = CardTools.GetInstance().LoadCardData();
        //排序
        sortCardList.Sort(CardTools.GetInstance().CompareCD);

        Debug.Log("读取:" + sortCardList[0].CardName);
        Debug.Log("读取:" + sortCardList[1].CardName);
        Debug.Log("读取:" + sortCardList[2].CardName);
        Debug.Log("读取:" + sortCardList[3].CardName);
        Debug.Log("读取:" + sortCardList[4].CardName);
    }

    
}
