using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FinalScore : MonoBehaviour
{
    public CheckLOC CheckLOC;
    public connectIV connectIV;
    public BottomConnector BottomConnector;
    public sprayHIT sprayHIT;
    public SwapMats SwapMats;

    private int finalScore;
    private int finalCOUNT = 0;
 
        Dictionary<string, string> debugLogs = new Dictionary<string, string>();
        public TextMeshProUGUI display;

        private void Update()
        {
           if (SwapMats.isdone==true && finalCOUNT ==0)
        {   
            finalScore = CheckLOC.ballScore + connectIV.IVscore + BottomConnector.OXYscore + sprayHIT.NitroScore + SwapMats.scoreNasal;
            Debug.Log(finalScore);
            finalCOUNT = 1;
        }
           
          
        }

        private void OnEnable()
        {
            Application.logMessageReceived += HandleLog;
        }

        private void OnDisable()
        {
            Application.logMessageReceived -= HandleLog;
        }

        void HandleLog(string logString, string stackTrace, LogType type)
        {
            if (type == LogType.Log)
            {
                string[] splitString = logString.Split(char.Parse(":"));
                string debugKey = splitString[0];
                string debugValue = splitString.Length > 1 ? splitString[1] : "";

                if (debugLogs.ContainsKey(debugKey))
                    debugLogs[debugKey] = debugValue;
                else
                    debugLogs.Add(debugKey, debugValue);

            }

            string displayText = "";
            foreach (KeyValuePair<string, string> log in debugLogs)
            {
                if (log.Value == "")
                    displayText += log.Key + "\n";
                else
                    displayText += log.Key + ": " + log.Value + "\n";
            }

            display.text = displayText;
        }
    }

  
       

