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
public class EmpleadoBC extends EmpleadoC implements SalarioC{
    private int base;
    private final int horasTurno=9;

    public EmpleadoBC() {
    }

    public EmpleadoBC(int base) {
        this.base = base;
    }

    public EmpleadoBC(int base, int totalVentas) {
        super(totalVentas);
        this.base = base;
    }

    public EmpleadoBC(int base, int totalVentas, String nombre, String identificacion) {
        super(totalVentas, nombre, identificacion);
        this.base = base;
    }
    public int getBase() {
        return base;
    }

    public void setBase(int base) {
        this.base = base;
    }
    
    @Override
    public double comision(){
        
       return base+((PORCENTAJE*getTotalVentas())/100);
    }
    
    @Override
    public int turno(){
        
        return horasTurno;       
    }
    
    @Override
    public String toString(){
       
       return "Nombre: "+getNombre()+"\n"+
              "Identificacion: "+getIdentificacion()+"\n"+
              "Salario base: "+getBase()+"\n"+
              "Horas diarias: "+horasTurno+" horas"+"\n"+  
              "Salario con la comision: "+comision();
    }
    
}
