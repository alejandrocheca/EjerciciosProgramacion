abstract class FiguraGeometrica {
    public abstract double calcularArea();
    public abstract double calcularPerimetro();
}

class Circulo extends FiguraGeometrica {
    private double radio;

    public Circulo(double radio) {
        this.radio = radio;
    }

    @Override
    public double calcularArea() {
        return Math.PI * radio * radio;
    }

    @Override
    public double calcularPerimetro() {
        return 2 * Math.PI * radio;
    }
}

class Rectangulo extends FiguraGeometrica {
    private double largo;
    private double ancho;

    public Rectangulo(double largo, double ancho) {
        this.largo = largo;
        this.ancho = ancho;
    }

    @Override
    public double calcularArea() {
        return largo * ancho;
    }

    @Override
    public double calcularPerimetro() {
        return 2 * (largo + ancho);
    }
}

class Triangulo extends FiguraGeometrica {
    private double base;
    private double altura;

    public Triangulo(double base, double altura) {
        this.base = base;
        this.altura = altura;
    }

    @Override
    public double calcularArea() {
        return 0.5 * base * altura;
    }

    @Override
    public double calcularPerimetro() {
        // No se puede calcular directamente el perímetro de un triángulo sin más información.
        return -1;
    }
}

public class Main {
    public static void main(String[] args) {
        FiguraGeometrica circulo = new Circulo(5);
        FiguraGeometrica rectangulo = new Rectangulo(4, 7);
        FiguraGeometrica triangulo = new Triangulo(6, 3);

        mostrarInformacionFigura(circulo);
        mostrarInformacionFigura(rectangulo);
        mostrarInformacionFigura(triangulo);
    }

    public static void mostrarInformacionFigura(FiguraGeometrica figura) {
        System.out.println("Área: " + figura.calcularArea());
        System.out.println("Perímetro: " + figura.calcularPerimetro());
        System.out.println("------------------------------");
    }
}