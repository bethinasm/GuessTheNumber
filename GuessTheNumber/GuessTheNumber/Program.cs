
using System.Threading.Tasks;
using GuessTheNumber;

Console.WriteLine("Oppgave: Guess the Number");
/*
    OPPGAVE:
    Lag et program hvor brukeren skal gjette et tilfeldig tall mellom 1-100.

    Hver gang brukeren skriver inn et tall vil man få svar fra programmet 
    om man må høyere eller lavere, helt til man gjetter riktig tall. 

    Da skal man få spørsmål om man vil spille på nytt
 */

var Oppgave = new Oppgave();
Oppgave.Run();