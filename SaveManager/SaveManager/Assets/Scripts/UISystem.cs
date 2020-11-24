using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class UISystem : MonoBehaviour
{
    void Start()
    {
        panel_title.SetActive(true);
        panel_edit.SetActive(false);
        panel_load.SetActive(false);

        //セーブデータがない状態ではロードしないように
        if (!File.Exists(Application.dataPath + "/saveData.json")) title_buttonLoad.GetComponent<Button>().interactable = false;
        else title_buttonLoad.GetComponent<Button>().interactable = true;
    }

    void Update()
    {
        //Panel_title時
        if (panel_title.active)
        {
            if (File.Exists(Application.dataPath + "/saveData.json") && title_buttonLoad.GetComponent<Button>().interactable) title_buttonLoad.GetComponent<Button>().interactable = true;
        }
        //Panel_edit時
        else if(panel_edit.active)
        {
            edit_old_textValue.GetComponent<Text>().text = "" + edit_old_sliderValue.GetComponent<Slider>().value;
        }
    }

    //---public-------------------------------------------------
    /// <summary>
    /// 【ボタン】Button_new<br></br>
    /// 新規作成
    /// </summary>
    public void OnNew()
    {
        panel_title.SetActive(false);
        panel_edit.SetActive(true);

        edit_name_inputFieldValue.GetComponent<InputField>().text = "";
        edit_old_sliderValue.GetComponent<Slider>().value = 0;
        edit_birthday_year_dropdownValue.GetComponent<Dropdown>().value = 0;
        edit_birthday_month_dropdownValue.GetComponent<Dropdown>().value = 0;
        edit_birthday_day_dropdownValue.GetComponent<Dropdown>().value = 0;
        edit_charactor_items[4].GetComponent<Toggle>().isOn = true;
    }

    /// <summary>
    /// 【ボタン】Button_load<br></br>
    /// ロード
    /// </summary>
    public void OnLoad()
    {
        saveData = SaveManager.Load();
        panel_title.SetActive(false);
        panel_load.SetActive(true);

        load_name_textValue.GetComponent<Text>().text = saveData.name;
        load_old_textValue.GetComponent<Text>().text = "" + saveData.old;
        load_birthday_textValue.GetComponent<Text>().text = saveData.birthday[0] + "/" + saveData.birthday[1] + "/" + saveData.birthday[2];
        load_charactor_textValue.GetComponent<Text>().text = saveData.charactor;
    }

    /// <summary>
    /// 【ボタン】Button_back<br></br>
    /// セーブせずに戻る
    /// </summary>
    public void OnBack()
    {
        panel_edit.SetActive(false);
        panel_load.SetActive(false);
        panel_title.SetActive(true);
    }

    /// <summary>
    /// 【ボタン】Button_apply<br></br>
    /// セーブして戻る
    /// </summary>
    public void OnApply()
    {
        saveData.name = edit_name_inputFieldValue.GetComponent<InputField>().text;
        saveData.old = (int)edit_old_sliderValue.GetComponent<Slider>().value;
        saveData.birthday[0] = int.Parse(edit_birthday_year_dropdownValue.GetComponent<Dropdown>().options[edit_birthday_year_dropdownValue.GetComponent<Dropdown>().value].text);
        saveData.birthday[1] = int.Parse(edit_birthday_month_dropdownValue.GetComponent<Dropdown>().options[edit_birthday_month_dropdownValue.GetComponent<Dropdown>().value].text);
        saveData.birthday[2] = int.Parse(edit_birthday_day_dropdownValue.GetComponent<Dropdown>().options[edit_birthday_day_dropdownValue.GetComponent<Dropdown>().value].text);

        if (edit_charactor_items[0].GetComponent<Toggle>().isOn) saveData.charactor = "A";
        else if (edit_charactor_items[1].GetComponent<Toggle>().isOn) saveData.charactor = "B";
        else if (edit_charactor_items[2].GetComponent<Toggle>().isOn) saveData.charactor = "C";
        else if (edit_charactor_items[3].GetComponent<Toggle>().isOn) saveData.charactor = "D";
        else saveData.charactor = "E";

        SaveManager.Save(saveData);
        panel_edit.SetActive(false);
        panel_title.SetActive(true);
    }

    /// <summary>
    /// 【ボタン】Button_edit<br></br>
    /// 編集
    /// </summary>
    public void OnEdit()
    {
        panel_load.SetActive(false);
        panel_edit.SetActive(true);

        edit_name_inputFieldValue.GetComponent<InputField>().text = saveData.name;
        edit_old_sliderValue.GetComponent<Slider>().value = saveData.old;
        
        for(int i = 0; i < edit_birthday_year_dropdownValue.GetComponent<Dropdown>().options.Count; i++)
        {
            if(edit_birthday_year_dropdownValue.GetComponent<Dropdown>().options[i].text == "" + saveData.birthday[0])
            {
                edit_birthday_year_dropdownValue.GetComponent<Dropdown>().value = i;
                break;
            }
        }

        for (int i = 0; i < edit_birthday_month_dropdownValue.GetComponent<Dropdown>().options.Count; i++)
        {
            if (edit_birthday_month_dropdownValue.GetComponent<Dropdown>().options[i].text == "" + saveData.birthday[1])
            {
                edit_birthday_month_dropdownValue.GetComponent<Dropdown>().value = i;
                break;
            }
        }

        for (int i = 0; i < edit_birthday_day_dropdownValue.GetComponent<Dropdown>().options.Count; i++)
        {
            if (edit_birthday_day_dropdownValue.GetComponent<Dropdown>().options[i].text == "" + saveData.birthday[2])
            {
                edit_birthday_day_dropdownValue.GetComponent<Dropdown>().value = i;
                break;
            }
        }

        edit_charactor_items[0].GetComponent<Toggle>().isOn = (saveData.charactor == "A") ? true : false;
        edit_charactor_items[1].GetComponent<Toggle>().isOn = (saveData.charactor == "B") ? true : false;
        edit_charactor_items[2].GetComponent<Toggle>().isOn = (saveData.charactor == "C") ? true : false;
        edit_charactor_items[3].GetComponent<Toggle>().isOn = (saveData.charactor == "D") ? true : false;
        edit_charactor_items[4].GetComponent<Toggle>().isOn = (saveData.charactor == "E") ? true : false;
    }

    //---private------------------------------------------------
    //パネル
    [SerializeField] private GameObject panel_title;
    [SerializeField] private GameObject panel_edit;
    [SerializeField] private GameObject panel_load;

    //Panel_title
    [SerializeField] private GameObject title_buttonLoad;

    //Panel_edit
    [SerializeField] private GameObject edit_name_inputFieldValue;
    [SerializeField] private GameObject edit_old_sliderValue;
    [SerializeField] private GameObject edit_old_textValue;
    [SerializeField] private GameObject edit_birthday_year_dropdownValue;
    [SerializeField] private GameObject edit_birthday_month_dropdownValue;
    [SerializeField] private GameObject edit_birthday_day_dropdownValue;
    [SerializeField] private List<GameObject> edit_charactor_items;

    //Panel_load
    [SerializeField] private GameObject load_name_textValue;
    [SerializeField] private GameObject load_old_textValue;
    [SerializeField] private GameObject load_birthday_textValue;
    [SerializeField] private GameObject load_charactor_textValue;

    //その他
    private SaveData saveData = new SaveData();
}