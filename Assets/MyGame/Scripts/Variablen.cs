using UnityEngine;

public enum Himmelsrichtungen
{
    Nord,
    Sued,
    West,
    Ost
}

public class Variablen : MonoBehaviour
{
    Color farbe;
    int anzTueren;
    bool fahren;
    bool hausBauen;
    int anzFenster;

    void Start()
    {
        Debug.Log(
            Himmelsrichtungen.Nord + " " + Himmelsrichtungen.Sued + " " +
            Himmelsrichtungen.West + " " + Himmelsrichtungen.Ost);

        anzTueren = 0;
        anzFenster = 0;
        hausBauen = true;
    }

    void Update()
    {
        {
            if (hausBauen)
            {
                anzTueren = anzTueren + 3;
                anzFenster = anzFenster + 3;
            }

            if (anzTueren <= 15 & anzFenster <= 15)
            {
                hausBauen = true;
            }

            else
            {
                hausBauen = false;
            }
        }
    }
}
