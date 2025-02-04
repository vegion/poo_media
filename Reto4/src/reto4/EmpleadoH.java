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
public class EmpleadoH extends Empleado implements Salario{
    
    
    private int horasTrabajadas;

    public EmpleadoH() {
    }

    public EmpleadoH(int horasTrabajadas) {
        
        this.horasTrabajadas = horasTrabajadas;
    }

    public EmpleadoH(int horasTrabajadas, String nombre, String identificacion) {
        super(nombre, identificacion);
        
        this.horasTrabajadas = horasTrabajadas;
    }

    public int getHorasTrabajadas() {
        return horasTrabajadas;
    }

    public void setHorasTrabajadas(int horasTrabajadas) {
        this.horasTrabajadas = horasTrabajadas;
    }
    
    @Override
    public double salario(){
        return horasTrabajadas*PRECIOHORAS;
    }

    @Override
    public String toString(){
        
        return "Nombre empleado: "+getNombre()+"\n"+
               "Identificacion: "+getIdentificacion()+"\n"+
               "Horas dairias: "+getHorasTrabajadas()+"horas"+"\n"+
               "Salario: "+salario();
    }
    
    @Override
    public int turno(){
        
        return horasTrabajadas;
    }
    
} 