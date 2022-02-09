using UnityEngine;

public class GameState
{
    private int numberInGame;
    private Baloon[] objectsInGame;

    public GameObject[] baloonsInGame;

    //constructor
    private GameState()
    {
    }

    private static GameState _instance;

    public static GameState GetInstance()
    {
        if (_instance == null)
        {
            _instance = new GameState();

        }
        return _instance;
    }

    public void setGameNumber(int n)
    {
        numberInGame = n;
        objectsInGame = new Baloon[numberInGame];
    }

    public int getGameNumber()
    {
        return numberInGame;
    }

    public void addObjectToArrayToPosition(Baloon obj, int i)
    {
        objectsInGame[i] = obj;
    }

    public Baloon getGameObject(int i)
    {
        return objectsInGame[i];
    }

    public Color getBaloonColor(int i)
    {
        return objectsInGame[i].getBalooncolor();
    }

    public void setBaloonAsColored(int baloonNumber)
    {
        objectsInGame[baloonNumber].setBaloonColored();

        //Debug.Log("GameState, setBaloonAsColored: " + baloonNumber);
    }

    public bool isPreviousBaloonColored(int numberOnBaloon)
    {
        //Debug.Log("GameState, is" + "BaloonColored numberOnBaloon = " + numberOnBaloon);
        bool isColored = objectsInGame[numberOnBaloon-2].isBaloonColored();
        return isColored;
    }

    public bool isLastBaloonColored()
    {
        return objectsInGame[numberInGame - 1].isBaloonColored();
    }

    public string baloonsInfo()
    {
        string a = "";
        for (int i = 0; i < objectsInGame.Length; i++)
        {
            int n = objectsInGame[i].getBaloonNumber();
            bool isBColored = objectsInGame[i].isBaloonColored();
            a =  a + "baloon num: " + n + "      is colored: " + isBColored + "            "; 
        }

        return a;
    }

}