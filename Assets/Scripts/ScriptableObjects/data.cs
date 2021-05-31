using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/Data", order = 1)]
public class data : ScriptableObject
{
    [Header("Game Progress")]
    // data Sets
    public bool basket = false;
    public bool tub = false;
    public bool sofa = false;
    public bool tv = false;
    public bool peppa = false;
    public bool cabinets = false;
    public bool fridge = false;
    public bool tree = false;

    
    [Header("Found Keys")]

    public bool key_Arbeitszimmer = false;
    public bool key_Haustuere = false;

    [Header("Alerts")]
    // Alerts
    public string _basket = "Sausia scheint nicht im Spielzeugkorb zu sein";
    public string _tub = "Hmm auch hier ist er nicht";
    public string _sofa = "Du hast den Schlüssel für das Arbeitszimmer gefunden";
    public string _tv = "Hier läuft nichts interresantes...";
    public string _peppa = "Ach Schorsch du hast doch bestimmt wieder im Garten mit Sausia gespielt";
    public string _cupboard = "Hier ist der Haustürschlüssel versteckt... Jetzt kann ich draußen suchen";
    public string _kuehlschrank = "Keine Spur von Sausia nur das übergebliebene Mittagessen";
    public string _ofen = "Oh es wird heute Abend wohl Lasagne geben";
    public string _tree = "Leider hatt sich Peppa vermutung nicht bestätigt";

    // Lock Notes
   [Header("Lock Alerts")]
    public string lock_arbeitszimmer = "Das Arbeitszimmer ist versperrt. Du musst den Schlüssel dafür finden";
    public string lock_kueche = "Die Haustüre ist zugesperrt";



    

}