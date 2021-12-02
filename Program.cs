using System;

namespace Tercer_proyecto
{
    class Program
    {
        static void Main(string[] args)
        {
           string dato =  "";
           double peso = 0.0;
           int actividad = 0;
           int etapa = 0;
           int opcion = 0;

           do{
           
           Console.WriteLine("Bienvenido. Por favor ingrese la etapa de su mascota");
           Console.WriteLine("Opción 1 - Cachorro");
           Console.WriteLine("Opción 2 - Adulto");
           dato = Console.ReadLine();
           etapa = Convert.ToInt32(dato);

           if (etapa == 1){
                Console.WriteLine("Indique el peso de su perro cachorro en KG");
                dato = Console.ReadLine();
                peso = Convert.ToDouble(dato);

                Console.WriteLine("Considera la actividad de su perro como:");
                Console.WriteLine("Opcion 1 - Alta");
                Console.WriteLine("Opcion 2 - Normal");
                Console.WriteLine("Opcion 3 - Baja");
                dato = Console.ReadLine();
                actividad = Convert.ToInt32(dato);

                if(peso == 2){
                switch(actividad){
                    case 1:
                    Console.WriteLine("Su perro miniatura debe comer 55 gramos");
                    break;
                    case 2:
                    Console.WriteLine("Su perro miniatura debe comer 60 gramos");
                    break;
                    case 3:
                    Console.WriteLine("Su perro miniatura debe comer 50 gramos");
                    break;
                }
                }
                 if(peso <= 10 && peso >=5){
                switch(actividad){
                    case 1:
                    Console.WriteLine("Su perro pequeño debe comer entre 95 y 155 gramos");
                    break;
                    case 2:
                    Console.WriteLine("Su perro pequeño debe comer entre 110 y 195 gramos");
                    break;
                    case 3:
                    Console.WriteLine("Su perro pequeño debe comer 110 y 185 gramos");
                    break;
                }
                }
                if(peso == 17){
                switch(actividad){
                    case 1:
                    Console.WriteLine("Su perro mediano debe comer 215 gramos");
                    break;
                    case 2:
                    Console.WriteLine("Su perro mediano debe comer 285 gramos");
                    break;
                    case 3:
                    Console.WriteLine("Su perro mediano debe comer 280 gramos");
                    break;
                }
                }
                if(peso <=90 && peso >=25){
                switch(actividad){
                    case 1:
                    Console.WriteLine("Su perro grande debe comer entre 270 y 580 gramos");
                    break;
                    case 2:
                    Console.WriteLine("Su perro grande debe comer entre 350 y 625 gramos");
                    break;
                    case 3:
                    Console.WriteLine("Su perro grande debe comer  entre 370 y 530 gramos");
                    break;
                
                }
                }
            }   





           else
            {
                Console.WriteLine("Indique el peso de su perro adulto en KG");
                dato = Console.ReadLine();
                peso = Convert.ToDouble(dato);

                Console.WriteLine("Considera la actividad de su perro como:");
                Console.WriteLine("Opcion 1 - Alta");
                Console.WriteLine("Opcion 2 - Normal");
                Console.WriteLine("Opcion 3 - Baja");
                dato = Console.ReadLine();
                actividad = Convert.ToInt32(dato);

                if(peso <= 5 && peso >=2){
                switch(actividad){
                    case 1:
                    Console.WriteLine("Su perro miniatura debe comer entre 60 y 115 gramos");
                    break;
                    case 2:
                    Console.WriteLine("Su perro miniatura debe comer entre 55 y 100 gramos");
                    break;
                    case 3:
                    Console.WriteLine("Su perro miniatura debe comer entre 45 y 85 gramos");
                    break;
                }
                }
                 if(peso <= 10 && peso >=5){
                switch(actividad){
                    case 1:
                    Console.WriteLine("Su perro pequeño debe comer entre 115 y 190 gramos");
                    break;
                    case 2:
                    Console.WriteLine("Su perro pequeño debe comer entre 100 y 170 gramos");
                    break;
                    case 3:
                    Console.WriteLine("Su perro pequeño debe comer 85 y 145 gramos");
                    break;
                }
                }
                if(peso <= 15 && peso >=10){
                switch(actividad){
                    case 1:
                    Console.WriteLine("Su perro mediano debe comer entre 190 y 255 gramos");
                    break;
                    case 2:
                    Console.WriteLine("Su perro mediano debe comer entre 170 y 225 gramos");
                    break;
                    case 3:
                    Console.WriteLine("Su perro mediano debe comer entre 145 y 195 gramos");
                    break;
                }
                }
                if(peso <=25 && peso >=15){
                switch(actividad){
                    case 1:
                    Console.WriteLine("Su perro grande debe comer entre 255 y 380 gramos");
                    break;
                    case 2:
                    Console.WriteLine("Su perro grande debe comer entre 225 y 330 gramos");
                    break;
                    case 3:
                    Console.WriteLine("Su perro grande debe comer  entre 195 y 285 gramos");
                    break;
                }
                }
                if(peso <=40 && peso >=25){
                switch(actividad){
                    case 1:
                    Console.WriteLine("Su perro grande debe comer entre 380 y 535 gramos");
                    break;
                    case 2:
                    Console.WriteLine("Su perro grande debe comer entre 330 y 475 gramos");
                    break;
                    case 3:
                    Console.WriteLine("Su perro grande debe comer  entre 285 y 410 gramos");
                    break;
                }
                }
                if(peso <=55 && peso >=40){
                switch(actividad){
                    case 1:
                    Console.WriteLine("Su perro grande debe comer entre 535 y 680 gramos");
                    break;
                    case 2:
                    Console.WriteLine("Su perro grande debe comer entre 475 y 600 gramos");
                    break;
                    case 3:
                    Console.WriteLine("Su perro grande debe comer  entre 410 y 520 gramos");
                    break;
                }
                }
                if(peso <=70 && peso >=55){
                switch(actividad){
                    case 1:
                    Console.WriteLine("Su perro grande debe comer entre 680 y 820 gramos");
                    break;
                    case 2:
                    Console.WriteLine("Su perro grande debe comer entre 600 y 720 gramos");
                    break;
                    case 3:
                    Console.WriteLine("Su perro grande debe comer entre 520 y 620 gramos");
                    break;
                }
                }
                if(peso <=90 && peso >=70){
                switch(actividad){
                    case 1:
                    Console.WriteLine("Su perro grande debe comer entre 820 y 985 gramos");
                    break;
                    case 2:
                    Console.WriteLine("Su perro grande debe comer entre 720 y 870 gramos");
                    break;
                    case 3:
                    Console.WriteLine("Su perro grande debe comer  entre 620 y 750 gramos");
                    break;
                }
                }
              
                Console.WriteLine("Si desea continuar escriba 1, si desea salir del programa escriba 4");
                dato = Console.ReadLine();
                opcion = Convert.ToInt32(dato);
                
                Console.Clear();
                
               
            }
               
          }while(opcion != 4);     
               
               

               


            


           
           
           
            
        }
    }
}
