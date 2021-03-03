using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_FimDeJogo : MonoBehaviour
{
   public Text message;

    GameManager gm;

    public void Voltar()
    {
    gm.ChangeState(GameManager.GameState.GAME);
    }
   private void OnEnable()
   {
       gm = GameManager.GetInstance();

       if(gm.vidas > 0)
       {
           message.text = "You won!!!";
       }
       else
       {
           message.text = "You lost!!!";
       }
   }
}