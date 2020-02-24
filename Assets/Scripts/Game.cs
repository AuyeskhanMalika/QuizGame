using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
   [SerializeField]
   private GamePanel gamePanel;
   [SerializeField]
   private WinPanel winPanel;
   private int cnt;
   private int countCorrect;
   private bool isGame;
   private IList<Question> list;

    public void Init(IList<Question> listValue)
    {
        list = listValue;
    }

    public void Start()
    {
        cnt = 0;
        countCorrect = 0;
        gamePanel.SetPanelActive(true);
        isGame = true;
        winPanel.SetPanelActive(false);
    }

    private void Update()
    {
        if (isGame)
            {
                gamePanel.SetQuestionText(list[cnt].name_ru);
            }
    }
    public void SetAnswer(bool answer)
    {
            if (answer == list[cnt].right_answer)
            {
                countCorrect++;
            }
            if( cnt == (list.Count - 1))
            {
                isGame = false;
                gamePanel.SetPanelActive(false);
                winPanel.SetPanelActive(true);
            }
            else
            {
                cnt++; 
            }
    }
}
