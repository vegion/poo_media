/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package reto4;

/**
 *
 * @author USUARIO
 */
import java.util.ArrayList;
import javax.swing.JOptionPane;

public class Reto4 {
    static ArrayList<EmpleadoA> empleadosA = new ArrayList <EmpleadoA>();
    static ArrayList<EmpleadoH> empleadosH = new ArrayList <EmpleadoH>(); 
    static ArrayList<EmpleadoC> empleadosC = new ArrayList <EmpleadoC>();
    static ArrayList<EmpleadoBC> empleadosBC = new ArrayList <EmpleadoBC>();

    public static void main(String[] args) {
         
        String opcion;
        
        do{
          
            opcion=JOptionPane.showInputDialog("Nomina empleados\n"+
                                                 "Elija que quiere hacer:\n"+
                                                 "(1) Crear empleados\n"+
                                                 "(2) Mostrar empleados\n"+
                                                 "(3) Salir");
 
            switch(opcion){
                
                case "1": //Crear los distintos tipos de empleados
                    
                    String opcionE;
                    opcionE=JOptionPane.showInputDialog("Elija tipo de empleado: \n" +
                                                                 "(1) Empleado asalariado \n" +
                                                                 "(2) Empleado por horas \n" +
                                                                 "(3) Empleado por comision \n" +
                                                                 "(4) Empleado con salario base y comision");
                    
                    switch (opcionE) {
                        
                        case "1":
                            crearEmpleadoA();
                        break;
                        case "2":
                            crearEmpleadoH();
                        break;
                        case "3":
                            crearEmpleadoC();
                        break;
                        case "4":
                            crearEmpleadoBC();
                        break;
                
                    }
   
                    break;
                    
                    case"2":
                        
                    String opcion1;
                    opcion1=JOptionPane.showInputDialog("Que empleado quiere ver: \n" +
                                                                 "(1) Empleado asalariado \n" +
                                                                 "(2) Empleado por horas \n" +
                                                                 "(3) Empleado por comision \n" +
                                                                 "(4) Empleado con salario base y comision");
                    
                    switch (opcion1) {
                        case "1":
                            mostrarEmpleadoA();
                        break;
                        case "2":
                            mostrarEmpleadoH();
                        break;
                        case "3":
                            mostrarEmpleadoC();
                        break;
                        case "4":
                            mostrarEmpleadoBC();
                        break;
                
            }
   
                        break;
                        case"3":
                            System.exit(0);
                        break;
                           
                
            }
            
        }while(!opcion.equals("3"));
           
        
    }
    
    public static void crearEmpleadoA(){
        EmpleadoA empleadoA = new EmpleadoA();
        
        String nom,id;
        int sueldo;
        
        nom=JOptionPane.showInputDialog("Ingrese el nombre del empleado");
        empleadoA.setNombre(nom);
        id=JOptionPane.showInputDialog("Ingrese la identificacion del empleado");
        empleadoA.setIdentificacion(id);        
        sueldo=Integer.parseInt((JOptionPane.showInputDialog("Introduza el sueldo del empleado")));
        empleadoA.setSalario(sueldo);
        
        empleadosA.add(empleadoA);
        
    }
    
    public static void crearEmpleadoH(){
        EmpleadoH empleadoH = new EmpleadoH();
        String nom, id;
        int horas;
        nom=JOptionPane.showInputDialog("Ingrese el nombre del empleado");
        empleadoH.setNombre(nom);
        id=JOptionPane.showInputDialog("Ingrese la identificacion del empleado");
        empleadoH.setIdentificacion(id);
        horas=Integer.parseInt((JOptionPane.showInputDialog("Introduza el numero de horas trabajadas por el empleado")));   
        empleadoH.setHorasTrabajadas(horas);
        
        empleadosH.add(empleadoH);
    }
    
    public static void crearEmpleadoC(){
        EmpleadoC empleadoC = new EmpleadoC(); 
        String nom, id;
        int ventas;
        nom=JOptionPane.showInputDialog("Ingrese el nombre del empleado");
        empleadoC.setNombre(nom);
        id=JOptionPane.showInputDialog("Ingrese la identificacion del empleado");
        empleadoC.setIdentificacion(id);
        ventas=Integer.parseInt((JOptionPane.showInputDialog("Ingrese el valor de las ventas concretas por el empleado")));
        empleadoC.setTotalVentas(ventas);
        
        empleadosC.add(empleadoC);
    }
    
    public static void crearEmpleadoBC(){
        
        EmpleadoBC empleadoBC = new EmpleadoBC();
        
        String nom, id;
        int sBase,ventas;
        nom=JOptionPane.showInputDialog("Ingrese el nombre del empleado");
        empleadoBC.setNombre(nom);
        id=JOptionPane.showInputDialog("Ingrese la identificacion del empleado");
        empleadoBC.setIdentificacion(id);
        ventas=Integer.parseInt((JOptionPane.showInputDialog("Ingrese el valor de las ventas concretas por el empleado")));
        empleadoBC.setTotalVentas(ventas);
        sBase=Integer.parseInt((JOptionPane.showInputDialog("Ingrese el salario base que tiene el empleado")));
        empleadoBC.setBase(sBase);
        
        empleadosBC.add(empleadoBC);
        
    }
    
    public static void mostrarEmpleadoA(){
        
        
        int y=1;
        
        for (EmpleadoA es: empleadosA){
            JOptionPane.showMessageDialog(null,"Empleado asalariado #"+ y++ +"\n"+
                                          es.toString());
                                            
        }
        
        
    }
    
    public static void mostrarEmpleadoH(){
        
        
        
        int y=1;
        
        for (EmpleadoH eh: empleadosH){
            JOptionPane.showMessageDialog(null,"Empleado por horas # "+ y++ +"\n"+
                                        eh.toString());
            
        }
        
        
    }
    
    public static void mostrarEmpleadoC(){
        
        
        int y=1;
        
        for(EmpleadoC ec: empleadosC){
            JOptionPane.showMessageDialog(null,"Empleado comision # "+ y++ +"\n"+
                                        ec.toString());
            
            
        }
        
    }
    
    public static void mostrarEmpleadoBC(){
        
        
        int y=1;
        for(EmpleadoBC ebs: empleadosBC){
            JOptionPane.showMessageDialog(null,"Empleado base comision # "+ y++ +"\n"+
                                        ebs.toString());
            
        }
    }
        
    }   