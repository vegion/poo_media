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
public class EmpleadoC extends Empleado implements SalarioC{
    
    private int totalVentas;
    private final int horasTurno=10;
    

    public EmpleadoC() {
    }

    public EmpleadoC(int totalVentas) {
        this.totalVentas = totalVentas;
        
    }

    public EmpleadoC(int totalVentas, String nombre, String identificacion) {
        super(nombre, identificacion);
        this.totalVentas = totalVentas;
       
    }
      
    
    public int getTotalVentas() {
        return totalVentas;
    }

    public void setTotalVentas(int totalVentas) {
        this.totalVentas = totalVentas;
    }
   
    
    @Override
    public double comision(){
        
        return (PORCENTAJE*totalVentas)/100;
    }
    
    @Override
    public String toString(){
        return "Nombre empleado: "+getNombre()+"\n"+
               "Identificacion: "+getIdentificacion()+"\n"+
               "Total ventas hechas: "+getTotalVentas()+"\n"+
               "Horas diarias: "+horasTurno+"\n"+ 
               "Comision recibida: "+comision();
    }
    
    @Override
    public int turno(){
        
        return horasTurno;
    }
    
}

    
