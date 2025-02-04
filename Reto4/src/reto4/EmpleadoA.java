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
public class EmpleadoA extends Empleado implements Salario{
    
    private int salario;
    private final int horasTurno=8;

    public EmpleadoA() {
    }

    public EmpleadoA(int salario) {
        this.salario = salario;
    }

    public EmpleadoA(int salario, String nombre, String identificacion) {
        super(nombre, identificacion);
        this.salario = salario;
    }   
    
    public int getSalario() {
        return salario;
    }

    public void setSalario(int salario) {
        this.salario = salario;
    }
    
    @Override
    public int turno(){
        
        return horasTurno;
    }
    
    @Override
    public double salario(){
        
        return this.salario=salario;
    }
    
    @Override
    public String toString(){
        
        return "Nombre empleado: "+getNombre()+"\n"+
               "Identificacion: "+getIdentificacion()+"\n"+
               "Horas diarias: "+horasTurno+" horas"+"\n"+
               "Salario: "+getSalario();
        
    }
    
    
}
