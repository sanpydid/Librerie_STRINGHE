using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Xml.Linq;

/// <summary>
/// Libreria generale di utility per le stringhe
/// Author: prof
/// Last update: 11 novembre 2022
/// Date start job: 11 novembre 2022
/// Target: sviluppo ai fini puramente didattici.
/// </summary>
public class LibStringhe
{

    /// <summary>
    /// Data una stringa trasformare solo i caratteri maiuscoli presenti in minuscoli. 
    /// </summary>
    /// <param name="str">stringa di input</param>
    /// <returns>stringa di output con minuscole.</returns>
    /// Data una stringa trasformare solo i caratteri minuscoli presenti in maiuscolo. 
    /// </summary>
    /// <param name="str">stringa di input</param>
    /// <returns>stringa di output con maiuscole</returns>
    public static string ToLower(string str)
    {
        int cod_ascii;
        char[] vett_chars = str.ToCharArray();
        for (int i = 0; i < str.Length; i++)
        {
            cod_ascii = (int)str[i];
            if (cod_ascii >= (65) && cod_ascii <= (65 + 26))
                vett_chars[i] = (char)(cod_ascii + 32);
            else
                vett_chars[i] = str[i];
        } // fine for
        return new string(vett_chars);
    } // fine metodo


} // fine classe



