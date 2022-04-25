using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;



[CreateAssetMenu] // allow creation of the barrel types in your assests
[System.Serializable]
[ExecuteAlways]
public class LangBoxType : ScriptableObject
{

    //id 
    public string id;

    //current language
    public string currentLang = null;

    // Dictionary to store current languages
    public serializableDictionary Languages = new serializableDictionary();
    //public LangBoxType manager;

    private void OnAwake()
    {
        Debug.Log(this.name);
        this.id = this.name;
    }

    public void OnEnable()
    {

        LangBoxType[] gameTexts = Resources.FindObjectsOfTypeAll<LangBoxType>();
        LangBoxType[] gameTextsCopy = (LangBoxType[])gameTexts.Clone();




        for (int i = 0; i < gameTextsCopy.Length; i++)
        {
            if (gameTextsCopy[i].id == "manager")
            {
                Debug.Log("Manager");
                foreach (string lang in gameTexts[i].Languages.keyList)
                {
                    if (!this.Languages.keyList.Contains(lang))
                        this.Languages.AddElement(lang, "n/a");
                }
            }
        }





    }
    // create constructor that takes id

    // public  LangBoxType(){}

    public LangBoxType()
    {

        // add itself to LangboxManager
        //this.id = this.name;
        // initilaize list with current lanuages

        //   LangBoxManager.allLangTypes.Add(this);



    }


}
