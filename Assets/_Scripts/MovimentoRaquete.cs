using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoRaquete : MonoBehaviour
{
    [Range(1, 10)]
    public float velocidade;
    GameManager gm;
    // Start is called before the first frame update
    void Start()
    {
        gm = GameManager.GetInstance();
    }

        // Update is called once per frame
    void Update()
    {
    if(Input.GetKeyDown(KeyCode.Escape)) {
            if(gm.gameState == GameManager.GameState.GAME){
                gm.ChangeState(GameManager.GameState.PAUSE);
            }
            else if(gm.gameState == GameManager.GameState.PAUSE){
                gm.ChangeState(GameManager.GameState.GAME);
            }
        }
    if (gm.gameState != GameManager.GameState.GAME) return;

    float inputX = Input.GetAxis("Horizontal");
    transform.position += new Vector3(inputX, 0, 0) * Time.deltaTime * velocidade;  
    }
}
