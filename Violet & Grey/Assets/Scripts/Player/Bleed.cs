using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// 血条伤害结算测试
/// </summary>
public class Bleed : MonoBehaviour
{
    public GameObject PL;
    public int PLid;
    public void OnMouseDown()
    {
        PL = GameObject.Find(PLid.ToString());
        PL.transform.GetComponent<ShowPLcard>().player.PlHP-=2;
        PL.transform.GetComponent<ShowPLcard>().player.Type = 1;
    }
   
}