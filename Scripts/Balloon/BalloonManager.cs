using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonManager : MonoBehaviour
{
    private SpriteRenderer sprite;
    GameState gameState;
    GameManager gameManager;
    //takes the number from game manager and paints it on the balloon

    // Start is called before the first frame update
    void Start()
    {
        gameState = GameState.GetInstance();
        gameManager = FindObjectOfType<GameManager>();
    }


    public void balloonClicked(int numberOnBaloon)
    {
        sprite = GetComponent<SpriteRenderer>();

        Color color = gameState.getBaloonColor(numberOnBaloon-1);

        if (color != null)
        {
            sprite.color = color;
            gameState.setBaloonAsColored(numberOnBaloon-1);

            //check if last is colored, if yes - level end
            if (gameState.isLastBaloonColored())
            {
                gameManager.endLevel();
            }
        }
        else sprite.color = new Color(1, 0, 0, 1);

        //string d = gameState.baloonsInfo();
        //Debug.Log(d);
    }

}
