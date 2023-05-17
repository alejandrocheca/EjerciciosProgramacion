import java.util.Arrays;
/*
 * Método de burbuja en Java para ordenar numeros
 *
 * */

public class Burbuja {
    public static void main(String[] args) {
        int numeros[] = {1, 9, 23, 4, 55, 100, 60, 43, 23};
        System.out.println("Antes del método de la burbuja: " + Arrays.toString(numeros));
        burbujaAsc(numeros);
        System.out.println("Orden ascendente: " + Arrays.toString(numeros));
        burbujaDesc(numeros);
        System.out.println("Orden descendente: " + Arrays.toString(numeros));
      
    }

    private static void burbujaAsc(int[] arreglo) {
        for (int x = 0; x < arreglo.length; x++) {
            for (int y = 0; y < arreglo.length - 1; y++) {
                int elementoActual = arreglo[y],
                        elementoSiguiente = arreglo[y + 1];
                if (elementoActual > elementoSiguiente) {
                    arreglo[y] = elementoSiguiente;
                    arreglo[y + 1] = elementoActual;
                }
            }
        }
    }
    private static void burbujaDesc(int[] arreglo) {
        for (int x = 0; x < arreglo.length; x++) {
            for (int y = 0; y < arreglo.length - 1; y++) {
                int elementoActual = arreglo[y],
                        elementoSiguiente = arreglo[y + 1];
                if (elementoActual < elementoSiguiente) {
                    arreglo[y] = elementoSiguiente;
                    arreglo[y + 1] = elementoActual;
                }
            }
        }
    }
}
   