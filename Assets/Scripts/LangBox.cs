using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
#if UNITY_EDITOR
using UnityEditor;
#endif

[ExecuteAlways] // all the functions here will also be called in the editor, for OnEnable()
public class LangBox : MonoBehaviour
{
    public LangBoxType type;





    // initialize temporary
    void OnEnable()
    {


        // add itself to the manager
        LangBoxManager.allLangBoxes.Add(this);
       
    }





    private void OnDisable() => LangBoxManager.allLangBoxes.Remove(this); // remove itself from the manager


    //gets called everytime a value is changed in the inspector
    private void Update()
    {
       
        TryWriteText();
    }


    public void TryWriteText()
    {
        if (this.type == null)
        {
            return;
        }

        // iterate through list and pick 


        Text tb = this.GetComponent<Text>();
        // get current lang, and fill in value
        tb.text = this.type.Languages.GetValue(this.type.currentLang);
        //Debug.Log(this.type.Languages.GetValue("English"));

    }





}

