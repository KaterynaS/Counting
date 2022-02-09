using TMPro;
using UnityEngine;

public class Baloon
{
    private int numberOnBaloon;
    private Color color;
    private GameObject prefabShape;
    private GameObject spawnPoint;
    private bool isColored;

    //constructor
    public Baloon(int num, Color clr, GameObject shape)
    {
        numberOnBaloon = num;
        color = clr;
        prefabShape = shape;
    }

    public Baloon(int num, Color clr, GameObject prefabShape, GameObject spawnP)
    {
        numberOnBaloon = num;
        color = clr;
        this.prefabShape = prefabShape;
        spawnPoint = spawnP;
    }

    public bool isBaloonColored()
    {
        return isColored;
    }

    public void setBaloonColored()
    {
        isColored = true;
    }


    public GameObject getBaloonGameObj()
    {
        GameObject a = prefabShape;
        TextMeshProUGUI textOnBaloon = prefabShape.GetComponentInChildren<TextMeshProUGUI>();
        string textToSet = numberOnBaloon.ToString();
        textOnBaloon.text = textToSet;

        return a;
    }

    public void setSpawnPoint(GameObject spawnP)
    {
        spawnPoint = spawnP;
    }

    public int getBaloonNumber()
    {
        return numberOnBaloon;
    }

    public Color getBalooncolor()
    {
        return color;
    }

    public GameObject getBaloonShape()
    {
        return prefabShape;
    }

    public GameObject getBaloonspawnPoint()
    {
        return spawnPoint;
    }


}
