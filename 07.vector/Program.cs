﻿using System;

/*
 * AUTOR : Brenda Yasmin Barrios Becerra.
 * OBJETIVO : Determinar de un vector el promedio , cuantos son números 
    mayores al promedio.
 */

namespace _07.vector
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] vector={
                10,20,30,40,50,60,70,80,90,100,
                10,20,30,40,50,60,70,80,90,100,
                10,20,30,40,50,60,70,80,90,100,
                10,20,30,40,50,60,70,80,90,100,
                10,20,30,40,50,60,70,80,90,100,
            };

            
            float promedio=0;



            Console.WriteLine("Calcular el valor de 50 valores constantes! \n");
            Console.WriteLine("Los elementos del arreglo son: \n");
            imprime(vector);
            promedio=prom(vector);
            Console.WriteLine($"El promedio es {promedio}");
            Console.WriteLine($"Mayores que el promedio {mayores(vector,promedio)}");

        }


        static int mayores(int[] v, float p){
            int suma=0;
            for(int i=0;i<v.Length;i++){
                if(v[i]>p) suma++;

            }
            return suma;
        }
        static void imprime(int[] v){
            for(int i=0;i<v.Length;i++){
                Console.Write($"{v[i]} ");

            }
            Console.WriteLine();
        }

        static float prom(int[] v){
            int suma=0;
            for(int i=0;i<v.Length;i++){
               suma+=v[i];

            }
            return suma/v.Length;

        }
    }
}
