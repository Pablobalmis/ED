/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package tablaenteros;

/**
 * El main del proyecto
 * @author Pablo
 */
public class TablaEnteros {
   private Integer[] tabla;

   TablaEnteros (Integer[] tabla) {
      if (tabla==null || tabla.length==0)
         throw new IllegalArgumentException("No hay elementos");
     this.tabla=tabla;
   }

  /**
   * suma la tabla
   * @return la suma de la tabla
   */
  public int sumaTabla() {
    int suma=0;
    for (int i=0; i<tabla.length; i++)
       suma+=tabla[i];
   return suma;
  }


  /**
   * busca el mayor de los numeros de la tabla
   * @return el mayor de la tabla
   */
  public int mayorTabla() {
    int max=-999;
    for (int i=0; i<tabla.length; i++)
       if (tabla[i]> max)
          max=tabla[i];
   return max;
  }

  /**
   * busca la posicion de un numero 
   * @param n el numero que queremos que busque su posicion
   * @return la posicion del numero que se le pasa
   */
  public int posicionTabla(int n) {
    int suma=0;
    for (int i=0; i<tabla.length; i++)
       if (tabla[i]==n)
          return i;
    throw new java.util.NoSuchElementException("No existe" + n);

  }
}
