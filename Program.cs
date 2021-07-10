using System;
using System.Collections.Generic;
using System.Text;

namespace ejemplo_colecciones
{
    class Program
    {
        static void Main(string[] args)
        {
            char Opcion;
ClaseCamion MiCamion = new ClaseCamion("HFS-521", "Gomez, Jorge", 20000);
Console.Clear();
Console.WriteLine("Ingrese Opcion: \n(A)-Agregar Mercaderia \n(Q)-Quitar Mercaderia \n(L)-Listar Mercaderia \n(S)-Salir \n(B) Buscar caja");
Opcion = char.Parse(Console.ReadKey().KeyChar.ToString().ToUpper());
while (Opcion == 'A' || Opcion == 'Q' || Opcion == 'L' || Opcion == 'B')
{
switch(Opcion)
{
case 'A':
{
Agregar(MiCamion);
break;
}
case 'Q':
{
Quitar(MiCamion);
break;
}
case 'L':
{
Listar(MiCamion);
break;
}
    case 'B':
        {
        Buscar(MiCamion);
        break;
}
}
Console.Clear();
Console.WriteLine("Ingrese Opcion: \n(A)-Agregar Mercaderia \n(Q)-Quitar Mercaderia \n(L)-Listar Mercaderia \n(S)-Salir");
Opcion = char.Parse(Console.ReadKey().KeyChar.ToString().ToUpper());
}
}
        private static void Buscar(ClaseCamion Camion)
        {
        }
        private static void Agregar(ClaseCamion Camion)
{
string Cadena;
string Codigo;
string Contenido;
float Alto;
float Largo;
float Ancho;
float Peso;
string Material;
ClaseCaja NuevaCaja;
Console.Clear();
Console.WriteLine("Codigo: ");
Codigo = Console.ReadLine();
Console.WriteLine("Contenido: ");
Contenido = Console.ReadLine();
Console.WriteLine("Alto en CM: ");
Cadena = Console.ReadLine();
while (float.TryParse(Cadena, out Alto) == false)
{
Console.WriteLine("Alto en CM: ");
Cadena = Console.ReadLine();
}
Console.WriteLine("Largo en CM: ");
Cadena = Console.ReadLine();
while (float.TryParse(Cadena, out Largo) == false)
{
Console.WriteLine("Largo en CM: ");
Cadena = Console.ReadLine();
}
Console.WriteLine("Ancho en CM: ");
Cadena = Console.ReadLine();
while (float.TryParse(Cadena, out Ancho) == false)
{
Console.WriteLine("Ancho en CM: ");
Cadena = Console.ReadLine();
}
Console.WriteLine("Peso en KG: ");
Cadena = Console.ReadLine();
while (float.TryParse(Cadena, out Peso) == false)
{
Console.WriteLine("Peso en KG: ");
Cadena = Console.ReadLine();
}
Console.WriteLine("Material: ");
Material = Console.ReadLine();
NuevaCaja=new ClaseCaja(Codigo,Contenido,Alto,Largo,Ancho,Peso,Material);
if (Camion.AgregarCaja(NuevaCaja))
{
Console.WriteLine("Caja agregada con exito!");
}
else
{
Console.WriteLine("Imposible agregar caja: \nse superaria el peso maximo permitido por el vehiculo.");
}
Console.ReadKey();
}
        private static void Quitar(ClaseCamion Camion)
{
int Posicion;
string Cadena;
Console.Clear();
Console.WriteLine("Posicion de la caja a quitar: ");
Cadena = Console.ReadLine();
while (int.TryParse(Cadena,out Posicion) == false)
{
Console.WriteLine("Posicion de la caja a quitar: ");
Cadena = Console.ReadLine();
}
if (Camion.QuitarCaja(Posicion))
{
Console.WriteLine("Caja quitada con exito!");
}
else
{
Console.WriteLine("Imposible quitar caja: la posicion ingresada no es valida.");
}
Console.ReadKey();
}
private static void Listar(ClaseCamion Camion)
{
int CantCajas;
ClaseCaja CajaRecup;
Console.Clear();
Console.WriteLine("------------------------ LISTADO DE CAJAS CONTENIDAS ------------------------");
Console.WriteLine("PATENTE: {0} CHOFER: {1} MAX. CARGA: {2} LIBRES:{3}",Camion.Patente,Camion.Chofer,Camion.MaxCargaKG,Camion.PesoKGDisponible);
Console.WriteLine("-----------------------------------------------------------------------------");
CantCajas = Camion.CantCajasCargadas;
for (int Posicion = 0; Posicion < CantCajas; Posicion++)
{
Camion.RecuperarDatosCaja(Posicion, out CajaRecup);
Console.WriteLine("Posicion: {0}", Posicion);
Console.WriteLine("Codigo Interno: {0}", CajaRecup.CodigoInterno);
Console.WriteLine("Contenido: {0}", CajaRecup.Contenido);
Console.WriteLine("Peso: {0}", CajaRecup.PesoKG);
Console.WriteLine("Volumen: {0}", CajaRecup.VolumenCM3);
Console.WriteLine("-----------------------------------------------------------------------------");
}
Console.ReadKey();
}
}
        }
    

