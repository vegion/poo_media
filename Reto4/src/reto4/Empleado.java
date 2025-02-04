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
public abstract class Empleado {
    private String nombre;
    private String identificacion;

    public Empleado() {
    }

    public Empleado(String nombre, String identificacion) {
        this.nombre = nombre;
        this.identificacion = identificacion;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public String getIdentificacion() {
        return identificacion;
    }

    public void setIdentificacion(String identificacion) {
        this.identificacion = identificacion;
    }
    
    public abstract int turno();
    
    @Override
    public String toString(){
        return "El salario de: "+getNombre()+" con identificacion: "+getIdentificacion();
    }
}
