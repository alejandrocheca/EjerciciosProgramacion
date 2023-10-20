import java.util.Scanner;

public class TextoDelReves {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.println("Introduce un texto: ");
        String texto = scanner.nextLine();
        
        String textoAlReves = reversoTexto(texto);
        
        System.out.println("Texto al revés: ");
        System.out.println(textoAlReves);
    }
    
    static String reversoTexto(String texto) {
        char[] caracteres = texto.toCharArray();
        int izquierda = 0;
        int derecha = caracteres.length - 1;
        
        while (izquierda < derecha) {
            // Intercambia los caracteres en las posiciones izquierda y derecha
            char temp = caracteres[izquierda];
            caracteres[izquierda] = caracteres[derecha];
            caracteres[derecha] = temp;
            izquierda++;
            derecha--;
        }
        
        return new String(caracteres);
    }
}