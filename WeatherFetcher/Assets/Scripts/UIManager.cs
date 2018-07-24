using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {

    public static UIManager uiManager;

    public Text countryName;
    public Text countryTemperature;
    public Text countryLatitude, countryLongitude;
    public Text countryCode;
    public Text countrySunrise;
    public Text countrySunset;
    public Text countryWeatherDescription;
    public Text countryHumidity;

    void Awake()
    {
        uiManager = this;
    }
    
}
