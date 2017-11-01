using System;
using System.Collections.Generic;

public enum ShortType
{
    File,
    Edit,
    Assets,
    GameObject,
    Component,
    Window,
    Help,
    Extension
}

public class ShortKeyCode
{
    #region 日常键

    public readonly static string A = "a";
    public readonly static string B = "b";
    public readonly static string C = "c";
    public readonly static string D = "d";
    public readonly static string E = "e";
    public readonly static string F = "f";
    public readonly static string G = "g";
    public readonly static string H = "h";
    public readonly static string I = "i";
    public readonly static string J = "j";
    public readonly static string K = "k";
    public readonly static string L = "l";
    public readonly static string M = "m";
    public readonly static string N = "n";
    public readonly static string O = "o";
    public readonly static string P = "p";
    public readonly static string Q = "q";
    public readonly static string R = "r";
    public readonly static string S = "s";
    public readonly static string T = "t";
    public readonly static string U = "u";
    public readonly static string V = "v";
    public readonly static string W = "w";
    public readonly static string X = "x";
    public readonly static string Y = "y";
    public readonly static string Z = "z";
    public readonly static string Alpha0 = "0";
    public readonly static string Alpha1 = "1";
    public readonly static string Alpha2 = "2";
    public readonly static string Alpha3 = "3";
    public readonly static string Alpha4 = "4";
    public readonly static string Alpha5 = "5";
    public readonly static string Alpha6 = "6";
    public readonly static string Alpha7 = "7";
    public readonly static string Alpha8 = "8";
    public readonly static string Alpha9 = "9";
    public readonly static string Left = "LEFT";
    public readonly static string Right = "RIGHT";
    public readonly static string Up = "UP";
    public readonly static string Down = "DOWN";
    public readonly static string F1 = "F1";
    public readonly static string F2 = "F2";
    public readonly static string F3 = "F3";
    public readonly static string F4 = "F4";
    public readonly static string F5 = "F5";
    public readonly static string F6 = "F6";
    public readonly static string F7 = "F7";
    public readonly static string F8 = "F8";
    public readonly static string F9 = "F9";
    public readonly static string F10 = "F10";
    public readonly static string F11 = "F11";
    public readonly static string F12 = "F12";
    public readonly static string Home = "HOME";
    public readonly static string PageUp = "PGUP";
    public readonly static string PageDown = "PGDN";

    /// <summary>
    /// 空格键
    /// </summary>
    public readonly static string Space = " ";

    /// <summary>
    /// ,
    /// </summary>
    public readonly static string Comma = ",";

    /// <summary>
    /// ,
    /// </summary>
    public readonly static string Period = ".";
    //TODO:其他

    #endregion

    #region 辅助键 

    public readonly static string Shift = "#";

    /// <summary>
    /// Window-->Ctrl Mac-->Option
    /// </summary>
    public readonly static string Control = "&";

    public readonly static string Command = "%";
    public readonly static string NormalKey = "_";

    #endregion
    
    
    public static Dictionary<string,string> popupAIDDict=new Dictionary<string, string>()
    {
        {"",String.Empty},
        {"single",NormalKey},
        {"shift",Shift},
        {"command",Command},
        {"ctrl",Control}
    };

    public static Dictionary<string,string> popupKEYDict =new Dictionary<string, string>()
    {
        {"",String.Empty},
        
        {"A",A},
        {"B",B},
        {"C",C},
        {"D",D},
        {"E",E},
        {"F",F},
        {"G",G},
        {"H",H},
        {"I",I},
        {"J",J},
        {"K",K},
        {"L",L},
        {"M",M},
        {"N",N},
        {"O",O},
        {"P",P},
        {"Q",Q},
        {"R",R},
        {"S",S},
        {"T",T},
        {"U",U},
        {"V",V},
        {"W",W},
        {"X",X},
        {"Y",Y},
        {"Z",Z},
        
        {"Alpha0",Alpha0},
        {"Alpha1",Alpha1},
        {"Alpha2",Alpha2},
        {"Alpha3",Alpha3},
        {"Alpha4",Alpha4},
        {"Alpha5",Alpha5},
        {"Alpha6",Alpha6},
        {"Alpha7",Alpha7},
        {"Alpha8",Alpha8},
        {"Alpha9",Alpha9},
        
        {"Left",Left},
        {"Right",Right},
        {"Up",Up},
        {"Down",Down},
        
        {"F1",F1},
        {"F2",F2},
        {"F3",F3},
        {"F4",F4},
        {"F5",F5},
        {"F6",F6},
        {"F7",F7},
        {"F8",F8},
        {"F9",F9},
        {"F10",F10},
        {"F11",F11},
        {"F12",F12},
        
        {"Home",Home},
        {"PageUp",PageUp},
        {"PageDown",PageDown},
        {"Space",Space},
        {"Comma",Comma},
        {"Period",Period}
    };
}