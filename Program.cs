using MiNET.Utils.Skins;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;
using appEntity1.Modelo;

namespace appEntity1
{
    class Program
    {
        static validar Validacion = new validar();


        static void Main(string[] args)
        {
           
            
            string mantener;
            bool entrada = false;
            int opcionMenu;
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White; Console.SetCursorPosition(15, 2); Console.WriteLine("APP ESTUDIANTE ");
                Console.SetCursorPosition(15, 4); Console.WriteLine("1.Agregar ");
                Console.SetCursorPosition(30, 4); Console.WriteLine("2.Listar");
                Console.SetCursorPosition(45, 4); Console.WriteLine("3.Buscar");
                Console.SetCursorPosition(60, 4); Console.WriteLine("4.Editar");
                Console.SetCursorPosition(75, 4); Console.WriteLine("5.Borrar");
                Console.SetCursorPosition(90, 4); Console.WriteLine("0.Salir");
                Console.ForegroundColor = ConsoleColor.Green; Console.SetCursorPosition(58, 16); Console.WriteLine("BIENVENIDOS");
                Console.ForegroundColor = ConsoleColor.Green; Console.SetCursorPosition(15, 25); Console.WriteLine("CENTRO DE MERCADOS LOGISTICA Y TECNOLOGIAS DE INFORMACION");
                Console.ForegroundColor = ConsoleColor.Green; Console.SetCursorPosition(15, 23); Console.WriteLine("SENA");
                for (int i = 13; i <= 110; i++)
                {
                    Console.SetCursorPosition(i, 1); Console.WriteLine("─");
                    Console.SetCursorPosition(i, 5); Console.WriteLine("─");
                    Console.SetCursorPosition(i, 10); Console.WriteLine("─");
                    Console.SetCursorPosition(i, 26); Console.WriteLine("─");
                }
                for (int i = 1; i <= 4; i++)
                {
                    Console.SetCursorPosition(13, i); Console.WriteLine("│ ");
                    Console.SetCursorPosition(110, i); Console.WriteLine("│ ");


                }
                Console.SetCursorPosition(13, 1); Console.WriteLine("┌  ");
                Console.SetCursorPosition(12, 5); Console.WriteLine(" └ ");
                Console.SetCursorPosition(109, 1); Console.WriteLine(" ┐ ");
                Console.SetCursorPosition(109, 5); Console.WriteLine(" ┘ ");

                for (int i = 10; i <= 25; i++)
                {
                    Console.SetCursorPosition(13, i); Console.WriteLine("│ ");
                    Console.SetCursorPosition(110, i); Console.WriteLine("│ ");
                    Console.SetCursorPosition(13, i); Console.WriteLine("│ ");

                }
                Console.SetCursorPosition(13, 10); Console.WriteLine("┌  ");
                Console.SetCursorPosition(12, 26); Console.WriteLine(" └ ");
                Console.SetCursorPosition(109, 10); Console.WriteLine(" ┐ ");
                Console.SetCursorPosition(109, 26); Console.WriteLine(" ┘ ");

                do
                {

                    Console.ForegroundColor = ConsoleColor.White; Console.SetCursorPosition(70, 2); Console.WriteLine("ESCOJA UNA OPCION [   ] ");
                    Console.SetCursorPosition(89, 2); mantener = Console.ReadLine();
                    if (!validacion.Vacio(mantener))
                        if (validacion.numero(mantener))
                            entrada = true;
                    
                } while (!entrada);

                


                opcionMenu = Convert.ToInt32(mantener);

                switch (opcionMenu)
                {
                    case 1:
                        AgregarEstudiante();
                        break;
                    case 2:
                        ListarEstudiantes();
                        break;
                    case 3:
                        BuscarEstudiante();
                        break;
                    case 4:
                        EditarEstudiante();
                        break;
                    case 5:
                        BorrarEstudiante();
                        break;
                    case 0:
                        Salir();
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red; Console.SetCursorPosition(55, 23); Console.WriteLine("opcion no valida ");
                        Console.ReadLine();
                        break;
                        Console.ForegroundColor = ConsoleColor.Red; Console.SetCursorPosition(50, 23); Console.WriteLine("digite una tecla para continuar");
                        Console.ReadLine();
                        break;
                        Console.ReadKey();
                }

            } while (opcionMenu > 0);



            static void AgregarEstudiante()
            {
                

                var db = new tallersenaContext();
                bool entrada = false;
                Console.Clear();
                Console.SetCursorPosition(52, 13); Console.WriteLine("AGREGAR ESTUDIANTE");
                Console.SetCursorPosition(52, 14); Console.WriteLine("Ingresar Codigo:");
                Console.SetCursorPosition(52, 15); Console.WriteLine("Ingresar Nombre:");
                Console.SetCursorPosition(52, 16); Console.WriteLine("Ingresar Correo:");
                Console.SetCursorPosition(52, 17); Console.WriteLine("Ingresar Nota 1:");
                Console.SetCursorPosition(52, 18); Console.WriteLine("Ingresar Nota 2:");
                Console.SetCursorPosition(52, 19); Console.WriteLine("Ingresar Nota 3:");
                Console.ForegroundColor = ConsoleColor.DarkGray; Console.SetCursorPosition(15, 2); Console.WriteLine("APP ESTUDIANTE ");
                Console.ForegroundColor = ConsoleColor.Green; Console.SetCursorPosition(15, 4); Console.WriteLine("1.Agregar ");
                Console.ForegroundColor = ConsoleColor.DarkGray; Console.SetCursorPosition(30, 4); Console.WriteLine("2.Listar");
                Console.ForegroundColor = ConsoleColor.DarkGray; Console.SetCursorPosition(45, 4); Console.WriteLine("3.Buscar");
                Console.ForegroundColor = ConsoleColor.DarkGray; Console.SetCursorPosition(60, 4); Console.WriteLine("4.Editar");
                Console.ForegroundColor = ConsoleColor.DarkGray; Console.SetCursorPosition(75, 4); Console.WriteLine("5.Borrar");
                Console.ForegroundColor = ConsoleColor.DarkGray; Console.SetCursorPosition(90, 4); Console.WriteLine("0.Salir");
                for (int i = 13; i <= 110; i++)
                {
                    Console.SetCursorPosition(i, 1); Console.WriteLine("─");
                    Console.SetCursorPosition(i, 5); Console.WriteLine("─");
                    Console.SetCursorPosition(i, 10); Console.WriteLine("─");
                    Console.SetCursorPosition(i, 26); Console.WriteLine("─");
                }
                for (int i = 1; i <= 4; i++)
                {
                    Console.SetCursorPosition(13, i); Console.WriteLine("│ ");
                    Console.SetCursorPosition(110, i); Console.WriteLine("│ ");


                }
                Console.SetCursorPosition(13, 1); Console.WriteLine("┌  ");
                Console.SetCursorPosition(12, 5); Console.WriteLine(" └ ");
                Console.SetCursorPosition(109, 1); Console.WriteLine(" ┐ ");
                Console.SetCursorPosition(109, 5); Console.WriteLine(" ┘ ");

                for (int i = 10; i <= 25; i++)
                {
                    Console.SetCursorPosition(13, i); Console.WriteLine("│ ");
                    Console.SetCursorPosition(110, i); Console.WriteLine("│ ");
                    Console.SetCursorPosition(13, i); Console.WriteLine("│ ");

                }
                Console.SetCursorPosition(13, 10); Console.WriteLine("┌  ");
                Console.SetCursorPosition(12, 26); Console.WriteLine(" └ ");
                Console.SetCursorPosition(109, 10); Console.WriteLine(" ┐ ");
                Console.SetCursorPosition(109, 26); Console.WriteLine(" ┘ ");




                

                    Console.SetCursorPosition(68, 14); int cod = int.Parse(Console.ReadLine());


               

                var existe = db.Estudiante.Find(cod);
                if (existe == null)
                {

                    Console.SetCursorPosition(69, 15); string nom = Console.ReadLine();
                     Console.SetCursorPosition(69, 16); string cor = Console.ReadLine();
                    Console.SetCursorPosition(68, 17); double not1 = double.Parse(Console.ReadLine());
                    Console.SetCursorPosition(68, 18); double not2 = double.Parse(Console.ReadLine());
                    Console.SetCursorPosition(68, 19); double not3 = double.Parse(Console.ReadLine());
                    
                    double promedio = (not1 + not2 + not3)/3;

                    Estudiante MyEstudiante = new Estudiante
                    {
                        Codigo = cod,
                        Nombre = nom,
                        Correo = cor,
                        Nota1 = not1,
                        Nota2 = not2,
                        Nota3 =not3,

                    };
                    db.Estudiante.Add(MyEstudiante);
                    db.SaveChanges();
                    Console.SetCursorPosition(52, 23); Console.WriteLine(" EL ESTUDIANTE INGRESO EXITOSAMENTE ");
                    Console.ReadKey();
                }
                else
                {
                    Console.SetCursorPosition(52, 23); Console.WriteLine(" EL CODIGO YA EXISTE");
                    Console.ReadKey();
              
                }
                




            }

            static void ListarEstudiantes()
            {
                
                Console.Clear();
                var db = new tallersenaContext();
                var listaEstudiante = db.Estudiante.ToList();
                Console.SetCursorPosition(15, 12); Console.WriteLine("CODIGO\t\tNOMBRE\t\t \tCORREO\t\t \t NOTA1\tNOTA2\tNOTA3");
                
                
                foreach (var MyEstudiante in listaEstudiante)
                {

                   
                    Console.WriteLine($"\t \t {MyEstudiante.Codigo}\t\t {MyEstudiante.Nombre}\t \t {MyEstudiante.Correo}\t {MyEstudiante.Nota1}\t {MyEstudiante.Nota2}\t {MyEstudiante.Nota3}");
                    
                    

                }
                

                Console.ForegroundColor = ConsoleColor.DarkGray; Console.SetCursorPosition(15, 2); Console.WriteLine("APP ESTUDIANTE ");
                Console.ForegroundColor = ConsoleColor.DarkGray; Console.SetCursorPosition(15, 4); Console.WriteLine("1.Agregar ");
                Console.ForegroundColor = ConsoleColor.Green; Console.SetCursorPosition(30, 4); Console.WriteLine("2.Listar");
                Console.ForegroundColor = ConsoleColor.DarkGray; Console.SetCursorPosition(45, 4); Console.WriteLine("3.Buscar");
                Console.ForegroundColor = ConsoleColor.DarkGray; Console.SetCursorPosition(60, 4); Console.WriteLine("4.Editar");
                Console.ForegroundColor = ConsoleColor.DarkGray; Console.SetCursorPosition(75, 4); Console.WriteLine("5.Borrar");
                Console.ForegroundColor = ConsoleColor.DarkGray; Console.SetCursorPosition(90, 4); Console.WriteLine("0.Salir");
                Console.SetCursorPosition(45, 25); Console.WriteLine("EL ENLISTAMIENTO FUE EXITOSO");
                for (int i = 13; i <= 110; i++)
                {
                    Console.SetCursorPosition(i, 1); Console.WriteLine("─");
                    Console.SetCursorPosition(i, 5); Console.WriteLine("─");
                    Console.SetCursorPosition(i, 10); Console.WriteLine("─");
                    Console.SetCursorPosition(i, 26); Console.WriteLine("─");
                }
                for (int i = 1; i <= 4; i++)
                {
                    Console.SetCursorPosition(13, i); Console.WriteLine("│ ");
                    Console.SetCursorPosition(110, i); Console.WriteLine("│ ");


                }
                Console.SetCursorPosition(13, 1); Console.WriteLine("┌  ");
                Console.SetCursorPosition(12, 5); Console.WriteLine(" └ ");
                Console.SetCursorPosition(109, 1); Console.WriteLine(" ┐ ");
                Console.SetCursorPosition(109, 5); Console.WriteLine(" ┘ ");

                for (int i = 10; i <= 25; i++)
                {
                    Console.SetCursorPosition(13, i); Console.WriteLine("│ ");
                    Console.SetCursorPosition(110, i); Console.WriteLine("│ ");
                    Console.SetCursorPosition(13, i); Console.WriteLine("│ ");

                }
                Console.SetCursorPosition(13, 10); Console.WriteLine("┌  ");
                Console.SetCursorPosition(12, 26); Console.WriteLine(" └ ");
                Console.SetCursorPosition(109, 10); Console.WriteLine(" ┐ ");
                Console.SetCursorPosition(109, 26); Console.WriteLine(" ┘ ");
                Console.ReadKey();
                Console.Clear();
                


            }

                static void BuscarEstudiante()
                {
                    var db = new tallersenaContext();
                    Console.Clear();
                    Console.SetCursorPosition(47, 13); Console.WriteLine("CODIGO DEL ESTUDIANTE A BUSCAR []");
                    Console.SetCursorPosition(48, 14); Console.WriteLine("Digite el codigo :");
                  Console.ForegroundColor = ConsoleColor.DarkGray; Console.SetCursorPosition(15, 2); Console.WriteLine("APP ESTUDIANTE ");
                  Console.ForegroundColor = ConsoleColor.DarkGray; Console.SetCursorPosition(15, 4); Console.WriteLine("1.Agregar ");
                  Console.ForegroundColor = ConsoleColor.DarkGray; Console.SetCursorPosition(30, 4); Console.WriteLine("2.Listar");
                  Console.ForegroundColor = ConsoleColor.Green; Console.SetCursorPosition(45, 4); Console.WriteLine("3.Buscar");
                  Console.ForegroundColor = ConsoleColor.DarkGray; Console.SetCursorPosition(60, 4); Console.WriteLine("4.Editar");
                  Console.ForegroundColor = ConsoleColor.DarkGray; Console.SetCursorPosition(75, 4); Console.WriteLine("5.Borrar");
                  Console.ForegroundColor = ConsoleColor.DarkGray; Console.SetCursorPosition(90, 4); Console.WriteLine("0.Salir");
                   for (int i = 13; i <= 110; i++)
                   {
                    Console.SetCursorPosition(i, 1); Console.WriteLine("─");
                    Console.SetCursorPosition(i, 5); Console.WriteLine("─");
                    Console.SetCursorPosition(i, 10); Console.WriteLine("─");
                    Console.SetCursorPosition(i, 26); Console.WriteLine("─");
                   }
                   for (int i = 1; i <= 4; i++)
                   {
                    Console.SetCursorPosition(13, i); Console.WriteLine("│ ");
                    Console.SetCursorPosition(110, i); Console.WriteLine("│ ");


                   }
                    Console.SetCursorPosition(13, 1); Console.WriteLine("┌  ");
                    Console.SetCursorPosition(12, 5); Console.WriteLine(" └ ");
                    Console.SetCursorPosition(109, 1); Console.WriteLine(" ┐ ");
                    Console.SetCursorPosition(109, 5); Console.WriteLine(" ┘ ");

                  for (int i = 10; i <= 25; i++)
                  {
                    Console.SetCursorPosition(13, i); Console.WriteLine("│ ");
                    Console.SetCursorPosition(110, i); Console.WriteLine("│ ");
                    Console.SetCursorPosition(13, i); Console.WriteLine("│ ");

                  }
                   Console.SetCursorPosition(13, 10); Console.WriteLine("┌  ");
                   Console.SetCursorPosition(12, 26); Console.WriteLine(" └ ");
                   Console.SetCursorPosition(109, 10); Console.WriteLine(" ┐ ");
                   Console.SetCursorPosition(109, 26); Console.WriteLine(" ┘ ");
                   Console.SetCursorPosition(67, 14); int cod = int.Parse(Console.ReadLine());
                     
                      var existe = db.Estudiante.Find(cod);
                    if (existe != null)
                    {
                        var MyEstudiante = db.Estudiante.FirstOrDefault(e => e.Codigo == cod);
                          Console.SetCursorPosition(35, 17); Console.WriteLine("CODIGO \tNOMBRE \t\tCORREO\t \tNOTA1\tNOTA2\tNOTA3");

                          Console.SetCursorPosition(35, 19); Console.WriteLine($"{MyEstudiante.Codigo}\t{MyEstudiante.Nombre}\t{MyEstudiante.Correo}\t {MyEstudiante.Nota1}\t {MyEstudiante.Nota2}\t {MyEstudiante.Nota3}");


                    Console.SetCursorPosition(45, 25); Console.WriteLine("LA BUSQUEDA DEL ESTUDIANTE FUE EXITOSA ");
                    }
                    else
                    {
                        Console.SetCursorPosition(45, 25); Console.WriteLine("EL CODIGO NO EXITE EN LA BASE DE DATOS");

                        

                    }
                  
                  Console.ReadKey();
                }
                static void EditarEstudiante()
                {
                    var db = new tallersenaContext();
                    Console.Clear();
                    Console.SetCursorPosition(48, 11); Console.WriteLine("EDITAR ESTUDIANTE");
                    Console.SetCursorPosition(47, 12); Console.WriteLine("codigo del estudiante a editar[    ]");
                   Console.ForegroundColor = ConsoleColor.DarkGray; Console.SetCursorPosition(15, 2); Console.WriteLine("APP ESTUDIANTE ");
                   Console.ForegroundColor = ConsoleColor.DarkGray; Console.SetCursorPosition(15, 4); Console.WriteLine("1.Agregar ");
                   Console.ForegroundColor = ConsoleColor.DarkGray; Console.SetCursorPosition(30, 4); Console.WriteLine("2.Listar");
                   Console.ForegroundColor = ConsoleColor.DarkGray; Console.SetCursorPosition(45, 4); Console.WriteLine("3.Buscar");
                   Console.ForegroundColor = ConsoleColor.Green; Console.SetCursorPosition(60, 4); Console.WriteLine("4.Editar");
                   Console.ForegroundColor = ConsoleColor.DarkGray; Console.SetCursorPosition(75, 4); Console.WriteLine("5.Borrar");
                   Console.ForegroundColor = ConsoleColor.DarkGray; Console.SetCursorPosition(90, 4); Console.WriteLine("0.Salir");
                     Console.SetCursorPosition(42, 14); Console.WriteLine(" Codigo:");
                    Console.SetCursorPosition(42, 15); Console.WriteLine(" Nombre:");
                    Console.SetCursorPosition(42, 16); Console.WriteLine(" Correo:");
                    Console.SetCursorPosition(42, 17); Console.WriteLine(" Nota 1:");
                    Console.SetCursorPosition(42, 18); Console.WriteLine(" Nota 2:");
                    Console.SetCursorPosition(42, 19); Console.WriteLine(" Nota 3:");
                  for (int i = 13; i <= 110; i++)
                  {
                    Console.SetCursorPosition(i, 1); Console.WriteLine("─");
                    Console.SetCursorPosition(i, 5); Console.WriteLine("─");
                    Console.SetCursorPosition(i, 10); Console.WriteLine("─");
                    Console.SetCursorPosition(i, 26); Console.WriteLine("─");
                  }
                  for (int i = 1; i <= 4; i++)
                  {
                    Console.SetCursorPosition(13, i); Console.WriteLine("│ ");
                    Console.SetCursorPosition(110, i); Console.WriteLine("│ ");


                  }
                  Console.SetCursorPosition(13, 1); Console.WriteLine("┌  ");
                  Console.SetCursorPosition(12, 5); Console.WriteLine(" └ ");
                  Console.SetCursorPosition(109, 1); Console.WriteLine(" ┐ ");
                  Console.SetCursorPosition(109, 5); Console.WriteLine(" ┘ ");

                  for (int i = 10; i <= 25; i++)
                  {
                    Console.SetCursorPosition(13, i); Console.WriteLine("│ ");
                    Console.SetCursorPosition(110, i); Console.WriteLine("│ ");
                    Console.SetCursorPosition(13, i); Console.WriteLine("│ ");

                  }
                  Console.SetCursorPosition(13, 10); Console.WriteLine("┌  ");
                  Console.SetCursorPosition(12, 26); Console.WriteLine(" └ ");
                  Console.SetCursorPosition(109, 10); Console.WriteLine(" ┐ ");
                  Console.SetCursorPosition(109, 26); Console.WriteLine(" ┘ ");

                Console.SetCursorPosition(78, 12); int cod = int.Parse(Console.ReadLine());

                    
                    var existe = db.Estudiante.Find(cod);
                    if (existe != null)
                    {
                        var myEstudiante = db.Estudiante.FirstOrDefault(e => e.Codigo == cod);
                        Console.SetCursorPosition(52,14 ); Console.WriteLine(myEstudiante.Codigo);
                        Console.SetCursorPosition(52, 15); Console.WriteLine(myEstudiante.Nombre);
                        Console.SetCursorPosition(52, 16); Console.WriteLine(myEstudiante.Correo);
                        Console.SetCursorPosition(52, 17); Console.WriteLine(myEstudiante.Nota1);
                        Console.SetCursorPosition(52, 18); Console.WriteLine(myEstudiante.Nota2);
                        Console.SetCursorPosition(52, 19); Console.WriteLine(myEstudiante.Nota3);


                        Console.SetCursorPosition(84, 15); string nom = Console.ReadLine();
                        Console.SetCursorPosition(84, 16); string cor = Console.ReadLine();
                        Console.SetCursorPosition(84, 17); double not1 = double.Parse(Console.ReadLine());
                        Console.SetCursorPosition(84, 18); double not2 = double.Parse(Console.ReadLine());
                        Console.SetCursorPosition(84, 19); double not3 = double.Parse(Console.ReadLine());

                         Console.SetCursorPosition(81, 15); myEstudiante.Nombre = nom;
                         Console.SetCursorPosition(81, 16); myEstudiante.Correo = cor;
                         Console.SetCursorPosition(81, 17); myEstudiante.Nota1 = not1;
                         Console.SetCursorPosition(81, 18); myEstudiante.Nota2 = not2;
                         Console.SetCursorPosition(81, 19); myEstudiante.Nota3 = not3;
                        db.SaveChanges();


                        Console.SetCursorPosition(45, 25);  Console.WriteLine("LOS DATOS DEL ESTUDIANTE FUERON ACTUALIZADOS  EXITOSAMENTE ");
                    }
                    else
                    {
                        Console.SetCursorPosition(45, 25); Console.WriteLine("EL CODIGO NO EXITE EN LA BASE DE DATOS");

                       

                    }
                   Console.ReadKey();
                }

                static void BorrarEstudiante()
                {
                    var db = new tallersenaContext();
                    Console.Clear();
                    Console.SetCursorPosition(52, 11); Console.WriteLine("BORRAR ESTUDIANTE");
                    Console.SetCursorPosition(43, 12); Console.WriteLine("Digite el codigo del estudiante a borrar[    ]");
                  Console.ForegroundColor = ConsoleColor.DarkGray; Console.SetCursorPosition(15, 2); Console.WriteLine("APP ESTUDIANTE ");
                  Console.ForegroundColor = ConsoleColor.DarkGray; Console.SetCursorPosition(15, 4); Console.WriteLine("1.Agregar ");
                   Console.ForegroundColor = ConsoleColor.DarkGray; Console.SetCursorPosition(30, 4); Console.WriteLine("2.Listar");
                   Console.ForegroundColor = ConsoleColor.DarkGray; Console.SetCursorPosition(45, 4); Console.WriteLine("3.Buscar");
                   Console.ForegroundColor = ConsoleColor.DarkGray; Console.SetCursorPosition(60, 4); Console.WriteLine("4.Editar");
                   Console.ForegroundColor = ConsoleColor.Green; Console.SetCursorPosition(75, 4); Console.WriteLine("5.Borrar");
                   Console.ForegroundColor = ConsoleColor.DarkGray; Console.SetCursorPosition(90, 4); Console.WriteLine("0.Salir");

                for (int i = 13; i <= 110; i++)
                  {
                    Console.SetCursorPosition(i, 1); Console.WriteLine("─");
                    Console.SetCursorPosition(i, 5); Console.WriteLine("─");
                    Console.SetCursorPosition(i, 10); Console.WriteLine("─");
                    Console.SetCursorPosition(i, 26); Console.WriteLine("─");
                  }
                  for (int i = 1; i <= 4; i++)
                  {
                    Console.SetCursorPosition(13, i); Console.WriteLine("│ ");
                    Console.SetCursorPosition(110, i); Console.WriteLine("│ ");


                  }
                  Console.SetCursorPosition(13, 1); Console.WriteLine("┌  ");
                   Console.SetCursorPosition(12, 5); Console.WriteLine(" └ ");
                   Console.SetCursorPosition(109, 1); Console.WriteLine(" ┐ ");
                   Console.SetCursorPosition(109, 5); Console.WriteLine(" ┘ ");

                   for (int i = 10; i <= 25; i++)
                   {
                    Console.SetCursorPosition(13, i); Console.WriteLine("│ ");
                    Console.SetCursorPosition(110, i); Console.WriteLine("│ ");
                    Console.SetCursorPosition(13, i); Console.WriteLine("│ ");

                   }
                   Console.SetCursorPosition(13, 10); Console.WriteLine("┌  ");
                   Console.SetCursorPosition(12, 26); Console.WriteLine(" └ ");
                   Console.SetCursorPosition(109, 10); Console.WriteLine(" ┐ ");
                   Console.SetCursorPosition(109, 26); Console.WriteLine(" ┘ ");

                   Console.SetCursorPosition(84, 12); int cod = int.Parse(Console.ReadLine());
                    var existe = db.Estudiante.Find(cod);
                    if (existe != null)
                    {
                        var MyEstudiante = db.Estudiante.FirstOrDefault(e => e.Codigo == cod);
                       Console.SetCursorPosition(30, 17); Console.WriteLine("CODIGO  \tNOMBRE  \t\tCORREO\t \t  \tNOTA1 NOTA2 NOTA3");

                       Console.SetCursorPosition(30, 19); Console.WriteLine($"{MyEstudiante.Codigo}\t{MyEstudiante.Nombre}\t{MyEstudiante.Correo} {MyEstudiante.Nota1}   {MyEstudiante.Nota2}   {MyEstudiante.Nota3}");
                        string confirmar = "n";
                         Console.SetCursorPosition(28, 22); Console.WriteLine($"esta seguro que desea borrar el estudiante{MyEstudiante.Nombre} s/n");
                         Console.SetCursorPosition(94, 22); confirmar = Console.ReadLine();

                        if (confirmar == "s")
                        {
                            db.Estudiante.Remove(MyEstudiante);
                            db.SaveChanges();

                            Console.SetCursorPosition(45, 25); Console.WriteLine(" EL ESTUDIANTE FUE BORRADO EXITOSAMENTE ");
                        }
                        else
                        {
                            Console.SetCursorPosition(45, 25); Console.WriteLine("SE CANCELO LA ELIMINACION DEL ESTUDIANTE");
                        }

                    }
                    else
                    {
                        Console.SetCursorPosition(45, 25); Console.WriteLine("EL ESTUDIANTE NO EXITE EN LA BASE DE DATOS");

                        

                    }
                    Console.ReadKey();
                }
            static void Salir() 
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkGray; Console.SetCursorPosition(15, 2); Console.WriteLine("APP ESTUDIANTE ");
                Console.ForegroundColor = ConsoleColor.DarkGray; Console.SetCursorPosition(15, 4); Console.WriteLine("1.Agregar ");
                Console.ForegroundColor = ConsoleColor.DarkGray; Console.SetCursorPosition(30, 4); Console.WriteLine("2.Listar");
                Console.ForegroundColor = ConsoleColor.DarkGray; Console.SetCursorPosition(45, 4); Console.WriteLine("3.Buscar");
                Console.ForegroundColor = ConsoleColor.DarkGray; Console.SetCursorPosition(60, 4); Console.WriteLine("4.Editar");
                Console.ForegroundColor = ConsoleColor.DarkGray; Console.SetCursorPosition(75, 4); Console.WriteLine("5.Borrar");
                Console.ForegroundColor = ConsoleColor.Green; Console.SetCursorPosition(90, 4); Console.WriteLine("0.Salir");
                Console.ForegroundColor = ConsoleColor.DarkGray; Console.SetCursorPosition(50, 16); Console.WriteLine("GRACIAS POR USAR EL PROGRAMA");
                Console.ForegroundColor = ConsoleColor.DarkGray; Console.SetCursorPosition(15, 25); Console.WriteLine("PRESIONE CUALQUIER TECLA PARA SALIR");
                for (int i = 13; i <= 110; i++)
                {
                    Console.SetCursorPosition(i, 1); Console.WriteLine("─");
                    Console.SetCursorPosition(i, 5); Console.WriteLine("─");
                    Console.SetCursorPosition(i, 10); Console.WriteLine("─");
                    Console.SetCursorPosition(i, 26); Console.WriteLine("─");
                }
                for (int i = 1; i <= 4; i++)
                {
                    Console.SetCursorPosition(13, i); Console.WriteLine("│ ");
                    Console.SetCursorPosition(110, i); Console.WriteLine("│ ");


                }
                Console.SetCursorPosition(13, 1); Console.WriteLine("┌  ");
                Console.SetCursorPosition(12, 5); Console.WriteLine(" └ ");
                Console.SetCursorPosition(109, 1); Console.WriteLine(" ┐ ");
                Console.SetCursorPosition(109, 5); Console.WriteLine(" ┘ ");

                for (int i = 10; i <= 25; i++)
                {
                    Console.SetCursorPosition(13, i); Console.WriteLine("│ ");
                    Console.SetCursorPosition(110, i); Console.WriteLine("│ ");
                    Console.SetCursorPosition(13, i); Console.WriteLine("│ ");

                }
                Console.SetCursorPosition(13, 10); Console.WriteLine("┌  ");
                Console.SetCursorPosition(12, 26); Console.WriteLine(" └ ");
                Console.SetCursorPosition(109, 10); Console.WriteLine(" ┐ ");
                Console.SetCursorPosition(109, 26); Console.WriteLine(" ┘ ");







            }






























            
        }
}   }