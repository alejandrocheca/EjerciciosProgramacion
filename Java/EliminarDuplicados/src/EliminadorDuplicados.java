public class EliminadorDuplicados {

    public static String eliminarDuplicados(String cadena) {
        StringBuilder resultado = new StringBuilder();
        int longitudCadena = cadena.length();

        for (int i = 0; i < longitudCadena; i++) {
            char actual = cadena.charAt(i);
            if (resultado.indexOf(String.valueOf(actual)) == -1) {
                resultado.append(actual);
            }
        }

        return resultado.toString();
    }

    public static void main(String[] args) {
        String cadenaOriginal = "AABBCC";
        String cadenaSinDuplicados = eliminarDuplicados(cadenaOriginal);
        System.out.println(cadenaSinDuplicados);
    }
}
