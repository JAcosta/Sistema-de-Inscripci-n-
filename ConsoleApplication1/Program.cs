using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Moneda;

namespace ConsoleApplication1 //Juan
{
    class Program
    {
        static string monto_escrito;

        static void Main(string[] args)
        {
            for (int a = 1; a < 1000; a++)
            {
                monto_escrito = Console.ReadLine();
                monto_escrito = cleanit(monto_escrito);
                Console.Write(estructurar(monto_escrito));
            }
            Console.Read();
        }

        protected static string cleanit(string var)
        {

            monto_escrito.Trim();

            if (monto_escrito.Contains(","))
            {
                while (monto_escrito.Contains(","))
                {
                    var = monto_escrito = monto_escrito.Remove(monto_escrito.IndexOf(","), 1);

                }
            }

            if (monto_escrito.Contains("."))
            {
                var = monto_escrito = monto_escrito.Remove(monto_escrito.IndexOf("."));
            }

            return var;

        }

        protected static string estructurar(string var)
        {
            if (var.StartsWith("0"))
            {
                var = var.Remove(0, 1);
            }

            if (var.Length == 1)
            {
                var = unidad(var);
            }
            else if (var.Length == 2)
            {
                var = decena(var);
            }
            else if (var.Length == 3)
            {
                if (var.StartsWith("5") || var.StartsWith("7") || var.StartsWith("9"))
                {
                    var = centena_irr(var);
                }
                else
                {
                    var = centena(var);
                }
            }
            else if (var.Length > 3 && var.Length < 6)
            {
                var = milesima(var);
            }
            else if (var.Length == 6)
            {
                var = cent_Mil(var);
            }
            else if (var.Length > 6)
            {
              var = millonesima(var);
            }


            return var;


        }

        protected static string unidad(string var)
        {

            if (var.StartsWith("0"))
            {

                var = var.Remove(0, 1);

            }

            if (var == "1")
            {
                var = "un";
            }
            else if (var == "2")
            {

                var = "dos";

            }
            else if (var == "3")
            {

                var = "tres";
            }
            else if (var == "4")
            {
                var = "cuatro";

            }
            else if (var == "5")
            {

                var = "cinco";

            }
            else if (var == "6")
            {

                var = "seis";

            }
            else if (var == "7")
            {

                var = "siete";

            }
            else if (var == "8")
            {

                var = "ocho";

            }
            else if (var == "9")
            {

                var = "nueve";

            }

            return var;
        }

        protected static string decena(string var)
        {

            char[] digito = var.ToCharArray();

            if (digito[0].ToString().Equals("0"))
            {
                var = unidad(digito[1].ToString());
            }


            if (var == "10")
            {
                var = "diez";
            }
            else
            {
                if (var == "11")
                {

                    var = "once";

                }
                else
                {

                    if (var == "12")
                    {

                        var = "doce";

                    }
                    else
                    {

                        if (var == "13")
                        {

                            var = "trece";

                        }
                        else
                        {

                            if (var == "14")
                            {

                                var = "catorce";

                            }
                            else
                            {

                                if (var == "15")
                                {

                                    var = "quince";

                                }
                                else
                                {

                                    if (var.StartsWith("1") && Int32.Parse(digito[1].ToString()) > 5)
                                    {

                                        var = "dieci" + unidad(digito[1].ToString());

                                    }
                                    else
                                    {

                                        if (var.StartsWith("2") && Int32.Parse(digito[1].ToString()) > 0)
                                        {

                                            var = "veinti" + unidad(digito[1].ToString());

                                        }
                                        else
                                        {

                                            if (var.StartsWith("3") && Int32.Parse(digito[1].ToString()) > 0)
                                            {

                                                var = "treinta y " + unidad(digito[1].ToString());

                                            }
                                            else
                                            {

                                                if (var.StartsWith("4") && Int32.Parse(digito[1].ToString()) > 0)
                                                {

                                                    var = "cuarenta y " + unidad(digito[1].ToString());

                                                }
                                                else
                                                {

                                                    if (var.StartsWith("5") && Int32.Parse(digito[1].ToString()) > 0)
                                                    {

                                                        var = "cincuenta y " + unidad(digito[1].ToString());

                                                    }
                                                    else
                                                    {

                                                        if (var.StartsWith("6") && Int32.Parse(digito[1].ToString()) > 0)
                                                        {

                                                            var = "sesenta y " + unidad(digito[1].ToString());

                                                        }
                                                        else
                                                        {

                                                            if (var.StartsWith("7") && Int32.Parse(digito[1].ToString()) > 0)
                                                            {

                                                                var = "setenta y " + unidad(digito[1].ToString());

                                                            }
                                                            else
                                                            {

                                                                if (var.StartsWith("8") && Int32.Parse(digito[1].ToString()) > 0)
                                                                {

                                                                    var = "ochenta y " + unidad(digito[1].ToString());

                                                                }
                                                                else
                                                                {

                                                                    if (var.StartsWith("9") && Int32.Parse(digito[1].ToString()) > 0)
                                                                    {

                                                                        var = "noventa y " + unidad(digito[1].ToString());

                                                                    }
                                                                    else
                                                                    {

                                                                        if (var == "20")
                                                                        {

                                                                            var = "veinte";


                                                                        }
                                                                        else
                                                                        {

                                                                            if (var == "30")
                                                                            {


                                                                                var = "treinta";

                                                                            }
                                                                            else
                                                                            {

                                                                                if (var == "40")
                                                                                {

                                                                                    var = "cuarenta";

                                                                                }
                                                                                else
                                                                                {

                                                                                    if (var == "50")
                                                                                    {

                                                                                        var = "cincuenta";

                                                                                    }
                                                                                    else
                                                                                    {

                                                                                        if (var == "60")
                                                                                        {

                                                                                            var = "sesenta";


                                                                                        }
                                                                                        else
                                                                                        {

                                                                                            if (var == "70")
                                                                                            {

                                                                                                var = "setenta";

                                                                                            }
                                                                                            else
                                                                                            {

                                                                                                if (var == "80")
                                                                                                {

                                                                                                    var = "ochenta";

                                                                                                }
                                                                                                else
                                                                                                {

                                                                                                    if (var == "90")

                                                                                                        var = "noventa";

                                                                                                }
                                                                                            }
                                                                                        }
                                                                                    }
                                                                                }
                                                                            }
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            return var;
        }

        protected static string centena(string var)
        {

            char[] digito = var.ToCharArray();

            if (var == "100")
            {
                var = "Cien";
            }else  if (var.StartsWith("1") && Int32.Parse(digito[1].ToString()) == 0 && Int32.Parse(digito[2].ToString()) > 0)
            {

                var = "ciento" + unidad(digito[2].ToString());

            }
            else if (var.StartsWith("1") && Int32.Parse(digito[1].ToString()) > 0)
            {

                var = "ciento" + decena(digito[1].ToString() + digito[2].ToString());

            }
            else if (Int32.Parse(digito[0].ToString()) > 1 || Int32.Parse(digito[0].ToString()) < 5 && Int32.Parse(digito[1].ToString()) >= 1)
            {
                var = unidad(digito[0].ToString()) + " ciento " + decena((digito[1].ToString() + digito[2].ToString()));
            }

            if (var.StartsWith("un"))
            {
                var = var.Remove(0, 2);
                var = var.Trim();
            }
            return var;
        }

        protected static string centena_irr(string var)
        {

            char[] digito = var.ToCharArray();
            if (var.StartsWith("5"))
            {
                var = "Quinientos " + decena(digito[1].ToString() + digito[2].ToString());
            }
            else if (var.StartsWith("7"))
            {
                var = "Setecientos " + decena(digito[1].ToString() + digito[2].ToString());
            }
            else if (var.StartsWith("9"))
            {
                var = "Novecientos " + decena(digito[1].ToString() + digito[2].ToString());
            }


            return var;
        }

        protected static string milesima(string var)
        {
            char[] digito = var.ToCharArray();
            string cant = " Mil ";
            if (var == "1000")
            {
                var = "Mil";
            }
            else if (var.StartsWith("1") && var.Length == 4)
            {
                var = cant + centena(digito[1].ToString() + digito[2].ToString() + digito[3].ToString());
            }
            else if (var.Length == 4 && digito[1].ToString().Equals("5") || digito[1].ToString().Equals("7") || digito[1].ToString().Equals("9"))
            {
                var = unidad(digito[0].ToString()) + cant + estructurar(digito[1].ToString() + digito[2].ToString() + digito[3].ToString());
            }
            else if (var.Length == 5)
            {
                var = estructurar(digito[0].ToString() + digito[1].ToString()) + cant + estructurar(digito[2].ToString() + digito[3].ToString() + digito[4].ToString());

            }
            else
            {
                var = unidad(digito[0].ToString()) + cant + estructurar(digito[1].ToString() + digito[2].ToString() + digito[3].ToString());
            }


            return var;
        }

        protected static string cent_Mil(string var)
        {
            char[] digito = var.ToCharArray();


            var = estructurar(digito[0].ToString() + digito[1].ToString() + digito[2].ToString()) + " Mil " + estructurar(digito[3].ToString() + digito[4].ToString() + digito[5].ToString());
            return var;
        }

        protected static string millonesima(string var)
        {
            char[] digito = var.ToCharArray();

            if (var == "1000000")
            {
                var = "Un Millon";
            }
            else if (var.Length == 7)
            {
                var = estructurar(digito[0].ToString()) + " Millones " + estructurar(digito[1].ToString() + digito[2].ToString() + digito[3].ToString() + digito[4].ToString() + digito[5].ToString() +digito[6].ToString() );

            }
            else if (var.Length >= 8)
            {
                var = estructurar(digito[0].ToString() + digito[1].ToString()) + " Millones " + estructurar(digito[2].ToString() + digito[3].ToString() + digito[4].ToString() + digito[5].ToString() + digito[6].ToString() + digito[7].ToString());

            }
            if (var.Contains(" Mil ") && var.Length == 7)
            {
                //dos_millones_mil
                var = var.Remove(var.LastIndexOf("Mil"), 3);
                
            }
            if (var.Contains("Millones") && var.StartsWith("un"))
            {
                var = var.Remove(var.IndexOf("es"), 2);
            }
            
            return var;

        }
    }
}
