using Project_Analyse_2.Business;
using System;
using static Project_Analyse_2.Business.GestionJustification;

namespace Project_Analyse_2;

internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        (new GestionJustification()).Start();
    }
}