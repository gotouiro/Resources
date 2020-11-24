using System;

[Serializable]
public class SaveData
{
    public string name;                 //名前
    public int old;                     //年齢
    public int[] birthday = new int[3]; //生年月日(年, 月, 日)
    public string charactor;            //キャラクター
}