using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;

public class Quest : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI TMPq;
    [SerializeField] string QuestText;
    [SerializeField] BoxCollider BC;
    [SerializeField] PlayerMov PM;
    [SerializeField] GameObject UI;
    [HideInInspector] public bool done = false;
    [SerializeField] GameObject en, dis;
    [SerializeField] GameObject[] toEn;

    public void Done()
    {
        done = true;
        QuestText = "";
        UI.SetActive(false);
        PM.quest = false;
        en.SetActive(true);
        dis.SetActive(false);
    }

    void startQ()
    {
        if (!PM.quest)
        {
            PM.quest = true;
            UI.SetActive(true);
            BC.enabled = false;
            string[] s = {"<br>" };
            List<string> tmpl = QuestText.Split(s,System.StringSplitOptions.None).ToList();
            tmpl.Remove(tmpl.Last());
            QuestText = string.Join("<br>",tmpl);
            TMPq.text = QuestText;
            for(int i=0;i< toEn.Length; i++)
            {
                foreach (MonoBehaviour MB in toEn[i].GetComponents<MonoBehaviour>())
                {
                    MB.enabled = true;
                }
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (PM.enabled){
            TMPq.text = QuestText;
            TMPq.enabled = true;
            PM.usee += startQ;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        TMPq.enabled = false;
        PM.usee -= startQ;
    }
}
