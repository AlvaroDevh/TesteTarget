﻿using System;

namespace Program
{

    public class Exer_01
    {

        static void Main(string[] args)
        {
            int INDICE = 13, SOMA = 0, K = 0;

            while (K < INDICE)
            {
                K = K + 1; SOMA = SOMA + K;
            }

            Console.WriteLine("Soma = " + SOMA) ;
        }   
    }
}