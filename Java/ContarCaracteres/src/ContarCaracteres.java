import java.util.HashMap;
import java.util.Map;
import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class ContarCaracteres {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.print("Ingresa un texto: ");
        String texto = scanner.nextLine();

        // Contar la cantidad total de caracteres
        int totalCaracteres = texto.length();

        // Contar la cantidad de signos ortográficos (no letras ni números)
        int signosOrtograficos = contarSignosOrtograficos(texto);

        // Crear un mapa para almacenar la frecuencia de cada letra
        Map<Character, Integer> frecuenciaLetras = new HashMap<>();

        // Iterar a través del texto para contar las letras
        for (char caracter : texto.toCharArray()) {
            if (Character.isLetter(caracter)) {
                char letra = Character.toLowerCase(caracter); // Tratar las letras como minúsculas para evitar distinción entre mayúsculas y minúsculas
                frecuenciaLetras.put(letra, frecuenciaLetras.getOrDefault(letra, 0) + 1);
            }
        }

        // Mostrar resultados
        System.out.println("Cantidad total de caracteres: " + totalCaracteres);
        System.out.println("Cantidad de signos ortográficos: " + signosOrtograficos);

        System.out.println("Frecuencia de letras (en orden alfabético):");
        frecuenciaLetras.entrySet().stream()
                .sorted(Map.Entry.comparingByKey())
                .forEach(entry -> System.out.println(entry.getKey() + ": " + entry.getValue()));
    }

    static int contarSignosOrtograficos(String texto) {
        // Utiliza una expresión regular para contar signos ortográficos
        Pattern pattern = Pattern.compile("\\P{Alnum}");
        Matcher matcher = pattern.matcher(texto);
        int count = 0;
        while (matcher.find()) {
            count++;
        }
        return count;
    }
}
