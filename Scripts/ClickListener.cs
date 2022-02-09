using UnityEngine;
using TMPro;

public class ClickListener : MonoBehaviour
{
    GameState gameState;
    // Start is called before the first frame update
    void Start()
    {
        gameState = GameState.GetInstance();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);

            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
            if (hit.collider != null)
            {
                if (hit.collider.gameObject.GetComponent<BalloonManager>() != null)
                {
                    string numberOnBaloon = hit.collider.gameObject.GetComponentInChildren<TextMeshProUGUI>().text;
                    int baloonNum = int.Parse(numberOnBaloon);
                    if (baloonNum == 1)
                    {
                        //color 
                        FindObjectOfType<AudioManager>().PlayYes();
                        hit.collider.gameObject.GetComponent<BalloonManager>().balloonClicked(baloonNum);
                    }
                    else
                    {
                        //check if previous colored, than color
                        if (gameState.isPreviousBaloonColored(baloonNum))
                        {
                            FindObjectOfType<AudioManager>().PlayYes();
                            hit.collider.gameObject.GetComponent<BalloonManager>().balloonClicked(baloonNum);
                        }
                        else
                        {
                            Debug.Log("Color all previous baloons");
                            FindObjectOfType<AudioManager>().PlayNo();
                        }
                    }
                }
            }
        }
    }
}
