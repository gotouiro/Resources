using System;
using System.IO;
using UnityEngine;

[Serializable]
public class SaveManager
{
    /// <summary>
    /// セーブ
    /// </summary>
    /// <param name="s">セーブするデータ</param>
    public static void Save(SaveData s)
    {
        //セーブデータをJSON化
        string json = JsonUtility.ToJson(s);

        //JSONファイルを発見する(ない場合新規作成)
        StreamWriter w = new StreamWriter(Application.dataPath + "/saveData.json", false);

        //JSONファイルに書き込み、処理を終える
        w.Write(json);
        w.Flush();
        w.Close();
    }

    /// <summary>
    /// ロード
    /// </summary>
    /// <returns>ロードしたデータ</returns>
    public static SaveData Load()
    {
        //ロードするデータ
        SaveData s;

        //JSONデータをロード
        StreamReader r = new StreamReader(Application.dataPath + "/saveData.json");
        string json = r.ReadToEnd();

        //処理を終える
        r.Close();

        //JSONデータをセーブデータ型に変換
        s = JsonUtility.FromJson<SaveData>(json);

        return s;
    }
}