using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowPLcard : MonoBehaviour
{
    public GameObject cardPrefab;
    public GameObject cardPool;
    public static Card card;

    // Start is called before the first frame update 
    void Start()
    {
    }

    // Update is called once per frame 
    void Update()
    {

    }

    //在cardpool里面生成card 
    public void OnClickOpen()
    {
        //读取角色11的卡 
        List<Card> cardList = CardTools.GetInstance().GetPLcard(11, CardTools.GetInstance().LoadCardData());
        //将每张卡分开
        for (int i = 0; i < cardList[cardList.Count - 1].Id % 10000 / 100; i++)
        {
            List<Card> cardList2 = CardTools.GetInstance().GetNOnumcard(i+1, cardList);
            GameObject newCard = GameObject.Instantiate(cardPrefab, cardPool.transform);
            newCard.GetComponent<CardDisplay>().cardList = cardList2;
        }



    }
}

