/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package tienda;

import java.util.Scanner;

/**
 *
 * @author Usuario
 */
public class Tienda {
    public static int totalPastel = 0;
    public static int totalGaseosa = 0;
    public static int totalPapitas = 0;
    public static int totalPandequeso = 0;
    public static int totalTinto = 0;
    public static int totalPan = 0;
    public static int valorPastel = 1500;
    public static int valorGaseosa = 1000;
    public static int valorPapitas = 800;
    public static int valorPandequeso = 1750;
    public static int valorTinto = 700;
    public static int valorPan = 500;
    public static int pasteles = 0;
    public static int gaseosas = 0;
    public static int papitas = 0;
    public static int pandequesos = 0;
    public static int tintos = 0;
    public static int panes = 0;
    public static int venta = 0;
    public static int total = 0;
    public static char opcion1;
    public static char opcion2;
    public static Scanner dato= new Scanner(System.in);
    public static String nombre, apellido;

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        
        do{
            System.out.printf("\n>>> MENÚ DE OPCIONES <<<");
            System.out.printf("\n1. Venta nueva.");
            System.out.printf("\n2. Ventas por producto.");
            System.out.printf("\n3. Ventas del día.");
            System.out.printf("\n4. Salir.");
            
            do
            {
                System.out.printf("\nIntroduzca opción a realizar (1-4): ");
                opcion1 = dato.next().charAt(0);
            }
            while(opcion1 < '1' || opcion1 > '4');

            System.out.printf("\n");

            switch(opcion1)
            {
                case '1': ventaNueva();
                          break;
                case '2': ventasPorProducto();
                          break;
                case '3': ventasDia();
            }
            
        } while(opcion1 != '4');
        
        
        
    }
    
    private static void ventaNueva()
    {
        total = 0;
        System.out.println("\nIngrese el nombre del cliente: ");
        nombre = dato.next();
        System.out.println("Ingrese el apellido del cliente: ");
        apellido = dato.next();
        
        do{
            System.out.printf("\n>>> PRODUCTOS DISPONIBLES <<<");
            System.out.printf("\n1. Pastel $1.500");
            System.out.printf("\n2. Gaseosa $1.000");
            System.out.printf("\n3. Papitas $800");
            System.out.printf("\n4. Pandequeso $1750");
            System.out.printf("\n5. Tinto $700");
            System.out.printf("\n6. Pan $500");
            System.out.printf("\n7. Finalizar venta.");
            
            do
            {
                System.out.printf("\nIntroduzca el producto a llevar (1-7): ");
                opcion2 = dato.next().charAt(0);
            }
            while(opcion2 < '1' || opcion2 > '7');

            System.out.printf("\n");

            switch(opcion2)
            {
                case '1': System.out.println("\nEl valor del pastel es: $" + valorPastel);
                          System.out.println("\nIngrese la cantidad que lleva: ");
                          pasteles = pasteles + dato.nextInt();
                          break;
                case '2': System.out.println("\nEl valor de la gaseosa es: $" + valorGaseosa);
                          System.out.println("\nIngrese la cantidad que lleva: ");
                          gaseosas = gaseosas + dato.nextInt();
                          break;
                case '3': System.out.println("\nEl valor de las papitas es: $" + valorPapitas);
                          System.out.println("\nIngrese la cantidad que lleva: ");
                          papitas = papitas + dato.nextInt();
                          break;
                case '4': System.out.println("\nEl valor del pandequeso es: $" + valorPandequeso);
                          System.out.println("\nIngrese la cantidad que lleva: ");
                          pandequesos = pandequesos + dato.nextInt();
                          break;
                case '5': System.out.println("\nEl valor del tinto es: $" + valorTinto);
                          System.out.println("\nIngrese la cantidad que lleva: ");
                          tintos = tintos + dato.nextInt();
                          break;
                case '6': System.out.println("\nEl valor del pan es: $" + valorPan);
                          System.out.println("\nIngrese la cantidad que lleva: ");
                          panes = panes + dato.nextInt();
                          break;
                case '7': total = (pasteles * valorPastel) + (gaseosas * valorGaseosa) + (papitas * valorPapitas) + (pandequesos * valorPandequeso) + (tintos * valorTinto) + (panes * valorPan);
                          System.out.println("\nEl total a pagar es: $" + total);
                          totalPastel = totalPastel + pasteles;
                          totalGaseosa = totalGaseosa + gaseosas;
                          totalPapitas = totalPapitas + papitas;
                          totalPandequeso = totalPandequeso + pandequesos;
                          totalTinto = totalTinto + tintos;
                          totalPan = totalPan + panes;
                          pasteles = 0;
                          gaseosas = 0;
                          papitas = 0;
                          pandequesos = 0;
                          tintos = 0;
                          panes = 0;
                          break;
            }            
            
        } while(opcion2 != '7');
        
    }
    
    private static void ventasPorProducto()
    {
        do{
            System.out.printf("\n>>> PRODUCTOS VENDIDOS <<<");
            System.out.printf("\n1. Pastel.");
            System.out.printf("\n2. Gaseosa.");
            System.out.printf("\n3. Papitas.");
            System.out.printf("\n4. Pandequeso.");
            System.out.printf("\n5. Tinto.");
            System.out.printf("\n6. Pan.");
            System.out.printf("\n7. Salir");
            
            do
            {
                System.out.printf("\nIntroduzca el producto a consultar (1-7): ");
                opcion2 = dato.next().charAt(0);
            }
            while(opcion2 < '1' || opcion2 > '7');

            System.out.printf("\n");

            switch(opcion2)
            {
                case '1': System.out.println("\nNombre del producto: Pastel");
                          System.out.println("Valor unitario: $" + valorPastel);
                          System.out.println("Cantidad de producto vendido: " + totalPastel);
                          total = totalPastel * valorPastel;
                          System.out.println("Valor total vendido: $" + total);
                          break;
                case '2': System.out.println("\nNombre del producto: Gaseosa");
                          System.out.println("Valor unitario: $" + valorGaseosa);
                          System.out.println("Cantidad de producto vendido: " + totalGaseosa);
                          total = totalGaseosa * valorGaseosa;
                          System.out.println("Valor total vendido: $" + total);
                          break;
                case '3': System.out.println("\nNombre del producto: Papitas");
                          System.out.println("Valor unitario: $" + valorPapitas);
                          System.out.println("Cantidad de producto vendido: " + totalPapitas);
                          total = totalPapitas * valorPapitas;
                          System.out.println("Valor total vendido: $" + total);
                          break;
                case '4': System.out.println("\nNombre del producto: Pandequeso");
                          System.out.println("Valor unitario: $" + valorPandequeso);
                          System.out.println("Cantidad de producto vendido: " + totalPandequeso);
                          total = totalPandequeso * valorPandequeso;
                          System.out.println("Valor total vendido: $" + total);
                          break;
                case '5': System.out.println("\nNombre del producto: Tinto");
                          System.out.println("Valor unitario: $" + valorTinto);
                          System.out.println("Cantidad de producto vendido: " + totalTinto);
                          total = totalTinto * valorTinto;
                          System.out.println("Valor total vendido: $" + total);
                          break;
                case '6': System.out.println("\nNombre del producto: Pan");
                          System.out.println("Valor unitario: $" + valorPan);
                          System.out.println("Cantidad de producto vendido: " + totalPan);
                          total = totalPan * valorPan;
                          System.out.println("Valor total vendido: $" + total);
                          break;
            }            
            
        } while(opcion2 != '7');
    }
    
    private static void ventasDia()
    {
        int ventaTotal = 0;
        ventaTotal = (totalPastel * valorPastel) + (totalGaseosa * valorGaseosa) + (totalPapitas * valorPapitas) + (totalPandequeso * valorPandequeso) + (totalTinto * valorTinto) + (totalPan * valorPan);
        System.out.println("Ventas de pastel: $" + (totalPastel * valorPastel));
        System.out.println("Ventas de gaseosa: $" + (totalGaseosa * valorGaseosa));
        System.out.println("Ventas de Papitas: $" + (totalPapitas * valorPapitas));
        System.out.println("Ventas de Pandequeso: $" + (totalPandequeso * valorPandequeso));
        System.out.println("Ventas de tinto: $" + (totalTinto * valorTinto));
        System.out.println("Ventas de Pan: $" + (totalPan * valorPan));
        System.out.println("\nVentas totales: $" + ventaTotal);
    }
}
