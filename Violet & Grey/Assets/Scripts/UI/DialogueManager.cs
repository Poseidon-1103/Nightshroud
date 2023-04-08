using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DialogueManager : MonoBehaviour
{
    /// <summary>
    /// 对话文本文件
    /// </summary>
    public TextAsset dialogueDateFile;
    /// <summary>
    /// 角色立绘
    /// </summary>
    public SpriteRenderer characterLeft;
    public SpriteRenderer characterRight;
    //角色立绘列表
    public List<Sprite> sprites = new List<Sprite>();

    /// <summary>
    /// 角色名字对应立绘的字典
    /// </summary>
    Dictionary<string, Sprite> imageDic = new Dictionary<string, Sprite>();

    //保存当前的对话索引值
    public int dialogueIndex;
    //读取到的对话文本，按行分割
    public string[] dialogueRows;
    private void Awake()
    {
        imageDic["弗尔米奥"] = sprites[0];
        imageDic["卡斯"] = sprites[1];
        ReadText(dialogueDateFile);
    }

    //角色名字文本
    public TMP_Text nameText;
    //对话内容文本
    public TMP_Text dialogueText;
    
    private void Start()
    {
        // ShowDialogueRow();
    }
 
    private void Update()
    {
        
    }

    //更新文本
    public void UpdateText(string name, string text)
    {
        nameText.text = name;
        dialogueText.text = text;
    }

    //更新立绘
    public void UpdateImage(string name, string position)
    {
        if (position == "左")
        {
            characterLeft.sprite = imageDic[name];
            characterRight.sprite = null;
        }
        else if (position == "右")
        {
            characterRight.sprite = imageDic[name];
            characterLeft.sprite = null;
        }
    }

    public void ReadText(TextAsset textAsset)
    {
        dialogueRows = textAsset.text.Split('\n');
    }

    public void ShowDialogueRow()
    {
        foreach (var row in dialogueRows)
        {
            string[] cells = row.Split(',');
            if (cells[0] == "#" && int.Parse(cells[1]) == dialogueIndex)
            {
                UpdateText(cells[2],cells[4]);
                UpdateImage(cells[2],cells[3]);
                dialogueIndex = int.Parse(cells[5]);
                break;
            }
            // else if (dialogueIndex == -1)
            // {
            //     UIManager.GetInstance().HidePanel("CharacterSpeakPanel");
            // }
            // else if (cells[0] == "&" && int.Parse(cells[1]) == dialogueIndex)
            // {
            //     
            // }
            
        }
    }
}