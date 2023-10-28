#include <iostream>
#include <vector>
#include <string>

class Animal {
public:
    Animal(const std::string& nombre) : nombre_(nombre) {}

    virtual void hacerSonido() const = 0;
    virtual void mostrarInformacion() const {
        std::cout << "Nombre: " << nombre_ << std::endl;
    }

private:
    std::string nombre_;
};

class Mamifero : public Animal {
public:
    Mamifero(const std::string& nombre, int numPatas) : Animal(nombre), numPatas_(numPatas) {}

    void hacerSonido() const override {
        std::cout << "Hace un sonido de mamífero." << std::endl;
    }

    void mostrarInformacion() const override {
        Animal::mostrarInformacion();
        std::cout << "Número de patas: " << numPatas_ << std::endl;
    }

private:
    int numPatas_;
};

class Ave : public Animal {
public:
    Ave(const std::string& nombre, double envergaduraAlas) : Animal(nombre), envergaduraAlas_(envergaduraAlas) {}

    void hacerSonido() const override {
        std::cout << "Hace un sonido de ave." << std::endl;
    }

    void mostrarInformacion() const override {
        Animal::mostrarInformacion();
        std::cout << "Envergadura de alas: " << envergaduraAlas_ << " metros" << std::endl;
    }

private:
    double envergaduraAlas_;
};

class Reptil : public Animal {
public:
    Reptil(const std::string& nombre, bool venenoso) : Animal(nombre), venenoso_(venenoso) {}

    void hacerSonido() const override {
        std::cout << "Hace un sonido de reptil." << std::endl;
    }

    void mostrarInformacion() const override {
        Animal::mostrarInformacion();
        std::cout << "Venenoso: " << (venenoso_ ? "Sí" : "No") << std::endl;
    }

private:
    bool venenoso_;
};

class Recinto {
public:
    Recinto(const std::string& nombre, double area) : nombre_(nombre), area_(area) {}

    virtual double calcularVolumen() const = 0;
    void mostrarInformacion() const {
        std::cout << "Nombre del recinto: " << nombre_ << std::endl;
        std::cout << "Área del recinto: " << area_ << " metros cuadrados" << std::endl;
        std::cout << "Volumen del recinto: " << calcularVolumen() << " metros cúbicos" << std::endl;
    }

private:
    std::string nombre_;
    double area_;
};

class RecintoTerrestre : public Recinto {
public:
    RecintoTerrestre(const std::string& nombre, double area, double altura) : Recinto(nombre, area), altura_(altura) {}

    double calcularVolumen() const override {
        return getArea() * altura_;
    }

private:
    double altura_;
};

class RecintoAereo : public Recinto {
public:
    RecintoAereo(const std::string& nombre, double area, double altura) : Recinto(nombre, area), altura_(altura) {}

    double calcularVolumen() const override {
        return getArea() * altura_;
    }

private:
    double altura_;
};

class RecintoAcuatico : public Recinto {
public:
    RecintoAcuatico(const std::string& nombre, double area, double profundidad) : Recinto(nombre, area), profundidad_(profundidad) {}

    double calcularVolumen() const override {
        return getArea() * profundidad_;
    }

private:
    double profundidad_;
};

int main() {
    Mamifero leon("León", 4);
    Ave aguila("Águila", 2.5);
    Reptil serpiente("Serpiente", true);

    RecintoTerrestre recintoTerrestre("Recinto Terrestre", 500, 3.0);
    RecintoAereo recintoAereo("Recinto Aéreo", 1000, 10.0);
    RecintoAcuatico recintoAcuatico("Recinto Acuático", 750, 5.0);

    std::vector<Animal*> animales = { &leon, &aguila, &serpiente };
    std::vector<Recinto*> recintos = { &recintoTerrestre, &recintoAereo, &recintoAcuatico };

    std::cout << "Información de animales:" << std::endl;
    for (const auto& animal : animales) {
        animal->hacerSonido();
        animal->mostrarInformacion();
        std::cout << "------------------------------" << std::endl;
    }

    std::cout << "Información de recintos:" << std::endl;
    for (const auto& recinto : recintos) {
        recinto->mostrarInformacion();
        std::cout << "------------------------------" << std::endl;
    }

    return 0;
}
