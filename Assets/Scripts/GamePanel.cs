﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GamePanel : MonoBehaviour
{
    [SerializeField]
    private Game game;

    [SerializeField]
    private Text questionText;

    [SerializeField]
    private Button trueBtn, falseBtn;

    private Question question;
    private bool answer;

    private void Start()
    {
   
        trueBtn.onClick.AddListener(OnTrueClick);
        falseBtn.onClick.AddListener(OnFalseClick);
    }

    public void SetPanelActive(bool state)
    {
        gameObject.SetActive(state);
    }

    public void SetQuestionText(string txt)
    {
        questionText.text = txt;
    }

    private void OnTrueClick()
    {
        game.SetAnswer(true);
    }

    private void OnFalseClick()
    {
        game.SetAnswer(false);
    }

    private void OnDestroy()
    {
        trueBtn.onClick.RemoveAllListeners();
        falseBtn.onClick.RemoveAllListeners();
    }
}
